using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHotelBLL;
using MyHotelModel.DataBaseModel;
using Sunny.UI;

namespace MyHotel
{
    public partial class FrmGuestInfo : Form
    {
        public FrmGuestInfo()
        {
            InitializeComponent();
        }

        //交易号
        private string tradeNo = string.Empty;

        //未结账 根据时间查询
        private void btInquire_Click(object sender, EventArgs e)
        {
            try
            {
                //禁止添加多余的列
                dgvGuestList_1.AutoGenerateColumns = false;

                //将数据转换成DataTable，绑定到dgv上
                DataTable dt = GuestManager.GetGuestRecord(dpStartTime.Value, dpEndTime.Value).ToDataTable();
                dgvGuestList_1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
        }

        private void btAck_Click(object sender, EventArgs e)
        {
            GettradeNo();
            if (dgvGuestList_1.SelectedRows.Count == 0)
            {
                return;
            }
            int guestId = Convert.ToInt32(dgvGuestList_1.CurrentRow.Cells["colGuestId"].Value);
            GuestRecord gr = GuestManager.GetOneGuest(guestId);
            //总价
            gr.total_money = Convert.ToDecimal(txtTotalMoney.Text);
            gr.leave_date = DateTime.Now;
            gr.reside_id = 2;
            gr.trade_no = tradeNo;
            try
            {
                bool flag = GuestManager.UpdateState(gr);
                if (flag)
                {
                    if (MessageBox.Show("退房成功!是否打印发票?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //打印发票
                        //Print();
                        MessageBox.Show("打印成功!");
                    }
                    //刷新
                    btInquire_Click(null, null);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
        }

        private void dgvGuestList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //房款
            decimal money = 0;
            //订金
            decimal deposit = 0;
            //消费
            decimal price = 0;
            if (dgvGuestList_1.SelectedRows.Count == 0)
            {
                return;
            }
            int roomId = Convert.ToInt32(dgvGuestList_1.CurrentRow.Cells["colRoomId"].Value);
            DateTime resideDate = Convert.ToDateTime(dgvGuestList_1.CurrentRow.Cells["colResideDate"].Value);

            //查询餐饮消费金额
            price = Convert.ToDecimal(dgvGuestList_1.CurrentRow.Cells["colDishPrice"].Value);
            txtTrade.Text = price.ToString();
            //查询房款
            try
            {
                money = GuestManager.PayMoney(roomId, resideDate);
                txtTotalMoney.Text = money.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
            //订金
            deposit = Convert.ToDecimal(dgvGuestList_1.CurrentRow.Cells["colDeposit"].Value);
            this.txtDeposit.Text = deposit.ToString();
            //应付
            this.txtPay.Text = (money + price - deposit).ToString();
        }
        /// <summary>
        /// 生成交易号
        /// </summary>
        /// <returns></returns>
        private void GettradeNo()
        {
            Random random = new Random();
            tradeNo = random.Next().ToString();
        }
        //已结账
        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //禁止添加多余的列
                dgvGuestList__2.AutoGenerateColumns = false;

                //将数据转换成DataTable，绑定到dgv上
                DataTable dt = GuestManager.GetGuestRecord(txtGuestName.Text).ToDataTable();
                dgvGuestList__2.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
        }
    }
}

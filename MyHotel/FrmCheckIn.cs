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

namespace MyHotel
{
    public partial class FrmCheckIn : Form
    {
        public FrmCheckIn()
        {
            InitializeComponent();
        }

        private void FrmCheckIn_Load(object sender, EventArgs e)
        {
            //获取当前系统时间
            dpRegTime.Text = DateTime.Now.ToString("yyyy-MM-dd");

            //绑定 未入住房间号 下选框
            try
            {
                cobRoNum.DisplayMember = "description";
                cobRoNum.ValueMember = "room_id";
                List<Room> r = RoomManager.GetFreeRoom();

                cobRoNum.DataSource = r;
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
            //非空验证
            if (string.IsNullOrEmpty(txtCashPlg.Text.Trim()) || string.IsNullOrEmpty(txtCustNa.Text.Trim()) || string.IsNullOrEmpty(txtIdNum.Text.Trim()) || string.IsNullOrEmpty(txtTel.Text.Trim()))
            {
                MessageBox.Show("请完善顾客信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GuestRecord gr = new GuestRecord() {
                guest_name = txtCustNa.Text,
                identity_id = txtIdNum.Text,
                phone = txtTel.Text,
                reside_date = Convert.ToDateTime(dpRegTime.Text),
                gender = cobGender.Text,
                room_id = Convert.ToInt32(cobRoNum.SelectedValue),
                deposit = Convert.ToInt32(txtCashPlg.Text)
            };
            try
            {
                if (GuestManager.AddGuestRecord(gr))
                {
                    MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btCanc_Click(null, null);
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

        private void btCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

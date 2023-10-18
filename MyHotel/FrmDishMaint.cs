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
using MyHotelModel.CommonModel;
using MyHotelModel.DataBaseModel;
using Sunny.UI;

namespace MyHotel
{
    public partial class FrmDishMaint : Form
    {
        public FrmDishMaint()
        {
            InitializeComponent();
        }
        //默认新增状态
        private EnumState state = EnumState.ADD;
        //DataGridView初始化
        private void LoadData()
        {
            try
            {
                DataTable dt = DishManager.GetDishList(txtName_1.Text.Trim()).ToDataTable();
                dgvDishList.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知异常：" + ex.Message);
            }
        }

        private void FrmCatereMaint_Load(object sender, EventArgs e)
        {
            LoadData();

            btAck.Enabled = false;
            tsbCancel.Enabled = false;
            txtName_2.Enabled = false;
            txtPrice.Enabled = false;
            txtUnit.Enabled = false;
        }
        //增
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            state = EnumState.ADD;

            tsbAdd.Enabled = true;
            tsbDelete.Enabled = false;
            tsbUpdate.Enabled = false;
            tsbCancel.Enabled = true;

            txtName_2.Enabled = true;
            txtPrice.Enabled = true;
            txtUnit.Enabled = true;

            btAck.Enabled = true;
        }
        //改
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            state = EnumState.UPDATE;

            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = false;
            tsbAdd.Enabled = false;
            tsbCancel.Enabled = true;

            txtName_2.Enabled = true;
            txtPrice.Enabled = true;
            txtUnit.Enabled = true;

            btAck.Enabled = true;
        }
        //删
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(dgvDishList.CurrentRow.Cells["colDishId"].Value);
            string str = string.Format("是否删除ID为 {0} 的数据？", selectId);
            if (MessageBox.Show(str, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                bool ret = DishManager.DeleteDish(new DishList { dish_id = selectId });
                if (ret)
                    MessageBox.Show("数据删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("数据删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //刷新数据
                LoadData();
                return;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("未知异常：" + ex.Message);
            }
            return;
        }
        //取消
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            tsbAdd.Enabled = true;
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;

            txtName_2.Enabled = false;
            txtPrice.Enabled = false;
            txtUnit.Enabled = false;

            btAck.Enabled = false;

            txtName_2.Clear();
            txtPrice.Clear();
            txtUnit.Clear();
        }
        //退出
        private void tsbQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //查
        private void btQuery_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //确认
        private void btAck_Click(object sender, EventArgs e)
        {
            //非空验证
            if (string.IsNullOrEmpty(txtName_2.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtUnit.Text))
            {
                MessageBox.Show("请完善房间类型信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //新增
            if (state == EnumState.ADD)
            {
                try
                {
                    bool ret = DishManager.AddDish(new DishList { dish_name = txtName_2.Text.Trim(), price = Convert.ToInt32(txtPrice.Text), unit = txtUnit.Text });
                    if (ret)
                        MessageBox.Show("数据添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("数据添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //刷新数据
                    LoadData();
                    return;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("数据库异常：" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("未知异常：" + ex.Message);
                }
                return;
            }
            //修改
            if (state == EnumState.UPDATE)
            {
                int selectId = Convert.ToInt32(dgvDishList.CurrentRow.Cells["colDishId"].Value);
                string str = string.Format("是否修改ID为 {0} 的数据", selectId);
                if (MessageBox.Show(str, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                try
                {
                    bool ret = DishManager.UpdateDish(new DishList { dish_id =selectId, dish_name = txtName_2.Text, price = Convert.ToInt32(txtPrice.Text), unit = txtUnit.Text });
                    if (ret)
                        MessageBox.Show("数据修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("数据修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //刷新数据
                    LoadData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("数据库异常：" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("未知异常：" + ex.Message);
                }
                return;
            }
        }

        private void dgvDishList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(state == EnumState.UPDATE)
            {
                txtName_2.Text = dgvDishList.CurrentRow.Cells["colDishName"].Value.ToString();
                txtPrice.Text = dgvDishList.CurrentRow.Cells["colPrice"].Value.ToString();
                txtUnit.Text = dgvDishList.CurrentRow.Cells["colUnit"].Value.ToString();
            }
        }
    }
}

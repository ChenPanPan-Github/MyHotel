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
using Sunny.UI;

namespace MyHotel
{
    public partial class FrmTypeMgmt : Form
    {
        public FrmTypeMgmt()
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
                DataTable dt = TypeManager.GetAllRoomType(txtTypeName.Text.Trim()).ToDataTable();
                dgvTypeList.DataSource = dt;
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

        //Frm界面
        private void FrmTypeMgmt_Load(object sender, EventArgs e)
        {
            LoadData();

            btAck.Enabled = false;
            tsbCancel.Enabled = false;
            txtTypeName_2.Enabled = false;
            txtPrice.Enabled = false;
        }


        //查询
        private void btQuery_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //确认
        private void btAck_Click(object sender, EventArgs e)
        {
            //非空验证
            if (string.IsNullOrEmpty(txtTypeName_2.Text.Trim()) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("请完善房间类型信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //新增
            if(state == EnumState.ADD)
            {
                try
                {
                    bool ret = TypeManager.AddRoomType(new RoomType(txtTypeName_2.Text.Trim(), Convert.ToDecimal(txtPrice.Text)));
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
                int row = Convert.ToInt32(dgvTypeList.CurrentRow.Cells["colTypeId"].Value);
                string str = string.Format("是否修改第{0}行数据", row);
                if (MessageBox.Show(str, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                try
                {
                    bool ret = TypeManager.UpdateRoomType(new RoomType(row, txtTypeName_2.Text.Trim(), Convert.ToDecimal(txtPrice.Text)));
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
        //删除
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(dgvTypeList.CurrentRow.Cells["colTypeId"].Value);
            string selectTypeName = dgvTypeList.CurrentRow.Cells["colTypeName"].Value.ToString();
            decimal selectPrice = Convert.ToDecimal(dgvTypeList.CurrentRow.Cells["colPrice"].Value);
            string str = string.Format("是否删除第{0}行数据，类型名称为{1}，价格为{2}", selectId, selectTypeName, selectPrice);
            if (MessageBox.Show(str, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                bool ret = TypeManager.DeleteRoomType(new RoomType(selectId, selectTypeName, Convert.ToDecimal(selectPrice)));
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
        //新增
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            state = EnumState.ADD;
            btAck.Enabled = true;
            tsbCancel.Enabled = true;
            txtTypeName_2.Enabled = true;
            txtPrice.Enabled = true;
            tsbDelete.Enabled = false;
            tsbUpdate.Enabled = false;
        }
        //修改
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            state = EnumState.UPDATE;
            btAck.Enabled = true;
            tsbCancel.Enabled = true;
            txtTypeName_2.Enabled = false;
            txtPrice.Enabled = false;
            tsbDelete.Enabled = false;
            tsbAdd.Enabled = false;
        }

        //取消
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            state = EnumState.ADD;
            btAck.Enabled = false;
            tsbCancel.Enabled = false;
            tsbUpdate.Enabled = true;
            tsbDelete.Enabled = true;
            tsbAdd.Enabled = true;
            txtTypeName_2.Enabled = false;
            txtPrice.Enabled = false;
            txtPrice.Clear();
            txtTypeName_2.Clear();
        }
        //退出
        private void tsbQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //dgv行单击修改
        private void dgvTypeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (state == EnumState.UPDATE)
            {
                txtTypeName_2.Text = dgvTypeList.CurrentRow.Cells["colTypeName"].Value.ToString();
                txtPrice.Text = dgvTypeList.CurrentRow.Cells["colPrice"].Value.ToString();
                txtTypeName_2.Enabled = true;
                txtPrice.Enabled = true;
            }
        }
    }
}

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
    public partial class FrmRoomMgmt : Form
    {
        public FrmRoomMgmt()
        {
            InitializeComponent();
        }

        //默认新增状态
        private EnumState state = EnumState.ADD;

        /// <summary>
        /// DataGridView初始化
        /// </summary>
        private void LoadData()
        {
            try
            {
                //禁止添加多余的列
                dgvRoomList.AutoGenerateColumns = false;
                //将数据转换成DataTable，绑定到dgv上
                DataTable dt = RoomManager.GetAllRoom(txtRmNm.Text.Trim()).ToDataTable();
                dgvRoomList.DataSource = dt;
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

        private void LoadDropbox()
        {
            //绑定 房间类型 下选框
            try
            {
                cobRmTy.DisplayMember = "type_name";
                cobRmTy.ValueMember = "id";

                List<RoomType> r = TypeManager.GetAllRoomType("");
                r.Insert(0, new RoomType(0, "请选择", 0));
                cobRmTy.DataSource = r;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }

            //绑定 房间状态 下选框
            try
            {
                cobRmSta.DisplayMember = "roomstate_name";
                cobRmSta.ValueMember = "roomstate_id";

                List<RoomState> r = RoomStateManager.GetAllRoomState();
                r.Insert(0, new RoomState { roomstate_id = -1, roomstate_name = "请选择" });
                cobRmSta.DataSource = r;
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
        //FrmLoad事件
        private void FrmRoomMgmt_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDropbox();
            txtDesc.Enabled = false;
            txtNumOfbed.Enabled = false;
            cobRmSta.Enabled = false;
            cobRmTy.Enabled = false;
            tsbCancel.Enabled = false;
            btAck.Enabled = false;
        }
        //查询
        private void btQuery_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        //新增
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            state = EnumState.ADD;
            tsbUpdate.Enabled = false;
            tsbDelete.Enabled = false;

            txtDesc.Enabled = true;
            txtNumOfbed.Enabled = true;
            cobRmSta.Enabled = true;
            cobRmTy.Enabled = true;
            tsbCancel.Enabled = true;
            btAck.Enabled = true;

        }
        //修改
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            state = EnumState.UPDATE;
            tsbAdd.Enabled = false;
            tsbDelete.Enabled = false;

            txtDesc.Enabled = true;
            txtNumOfbed.Enabled = true;
            cobRmSta.Enabled = true;
            cobRmTy.Enabled = true;
            tsbCancel.Enabled = true;
            btAck.Enabled = true;

            LoadDropbox();

        }
        //删除
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            int selectId = Convert.ToInt32(dgvRoomList.CurrentRow.Cells["colRoomId"].Value);
            string str = string.Format("是否删除房间号为 {0} 的数据？", selectId);
            if (MessageBox.Show(str, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                bool ret = RoomManager.DeleteRoom(new Room() { room_id = selectId });
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
            state = EnumState.ADD;

            tsbAdd.Enabled = true;
            tsbDelete.Enabled = true;
            tsbUpdate.Enabled = true;

            txtDesc.Enabled = false;
            txtNumOfbed.Enabled = false;
            cobRmSta.Enabled = false;
            cobRmTy.Enabled = false;
            tsbCancel.Enabled = false;
            btAck.Enabled = false;

            txtDesc.Clear();
            txtNumOfbed.Clear();
            cobRmSta.Clear();
            cobRmTy.Clear();
        }
        //退出
        private void tsbQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //确认
        private void btAck_Click(object sender, EventArgs e)
        {
            //非空验证
            if (string.IsNullOrEmpty(txtNumOfbed.Text) || string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("请完善房间类型信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //下拉框验证
            int stateId = Convert.ToInt32(cobRmSta.SelectedValue);
            int typeId = Convert.ToInt32(cobRmTy.SelectedValue);
            if(stateId == -1 || typeId == -1)
            {
                MessageBox.Show("请完善房间类型信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //新增
            if (state == EnumState.ADD)
            {
                try
                {
                    bool ret = RoomManager.AddRoom(new Room() {
                        bed_num = Convert.ToInt32(txtNumOfbed.Text),
                        description = txtDesc.Text,
                        roomstate_id = stateId,
                        roomtype_id = typeId
                    });
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
                int row = Convert.ToInt32(dgvRoomList.CurrentRow.Cells["colRoomId"].Value);
                string str = string.Format("是否修改房间号为 {0} 的数据", row);
                if (MessageBox.Show(str, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                try
                {
                    bool ret = RoomManager.UpdateRoom(new Room {
                        room_id = Convert.ToInt32(dgvRoomList.CurrentRow.Cells["colRoomId"].Value),
                        bed_num = Convert.ToInt32(txtNumOfbed.Text),
                        description = txtDesc.Text,
                        roomstate_id = stateId,
                        roomtype_id = typeId
                    });
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

        private void dgvRoomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (state == EnumState.UPDATE)
            {
                //FrmRoomMgmt_Load(null, null);
                txtDesc.Text = dgvRoomList.CurrentRow.Cells["colRoomDescribe"].Value.ToString();
                txtNumOfbed.Text = dgvRoomList.CurrentRow.Cells["colNumOfBed"].Value.ToString();

                cobRmSta.SelectedIndex = cobRmSta.FindString(dgvRoomList.CurrentRow.Cells["colRoomStatue"].Value.ToString());
                cobRmTy.SelectedIndex = cobRmTy.FindString(dgvRoomList.CurrentRow.Cells["colRoomType"].Value.ToString());
            }
        }
    }
}

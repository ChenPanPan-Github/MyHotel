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
using MyHotelModel;
using MyHotelModel.CommonModel;
using MyHotelModel.DataBaseModel;
using Sunny.UI;

namespace MyHotel
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
        }

        //总金额
        private decimal money = 0;
        //房间号
        private int roomId = 0;

        #region 工具栏
        //类型管理
        private void tsbTypeMgmt_Click(object sender, EventArgs e)
        {
            FrmTypeMgmt frmTypeMgmt = new FrmTypeMgmt();
            frmTypeMgmt.ShowDialog();
            //刷新
            FrmMain_Load(null, null);
        }
        //房间管理
        private void tsbRoomMgmt_Click(object sender, EventArgs e)
        {
            FrmRoomMgmt frmRoomMgmt = new FrmRoomMgmt();
            frmRoomMgmt.ShowDialog();
            //刷新
            FrmMain_Load(null, null);
        }
        //餐饮维护
        private void tsbCatereMaint_Click(object sender, EventArgs e)
        {
            FrmDishMaint frmCatereMaint = new FrmDishMaint();
            frmCatereMaint.ShowDialog();
            //刷新
            FrmMain_Load(null, null);
        }
        //收入统计
        private void tsbInStat_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.ShowDialog();
        }
        //入住统计
        private void tsbCheckIn_Click(object sender, EventArgs e)
        {
            FrmCheckIn frmCheckIn = new FrmCheckIn();
            frmCheckIn.ShowDialog();
            //刷新
            FrmMain_Load(null, null);
        }
        //顾客查询
        private void tsbCustInq_Click(object sender, EventArgs e)
        {
            FrmGuestInfo frmGuestInfo = new FrmGuestInfo();
            frmGuestInfo.ShowDialog();
            //刷新
            FrmMain_Load(null, null);
        }
        //锁定
        private void tsbLock_Click(object sender, EventArgs e)
        {
            FrmLock frmLock = new FrmLock();
            frmLock.ShowDialog();
        }
        //×退出
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //按钮退出
        private void tsbQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 加载
        //时间
        private void timer_Tick(object sender, EventArgs e)
        {
            tsTime.Text = DateTime.Now.ToString();
            string str = "一二三四五六天".Substring((int)DateTime.Now.DayOfWeek, 1);
            tsDayOfWeek.Text = string.Format("星期{0}", str);
        }
        //main界面加载
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //状态栏初始化
            timer_Tick(null, null);
            tsLoginId.Text = User.LoginId;

            //绑定TreeView
            tvTreeList.Nodes.Clear();
            TreeNode root = new TreeNode("全部");
            try
            {
                List<RoomType> roomType = TypeManager.GetAllRoomType("");
                foreach (RoomType var in roomType)
                {
                    TreeNode node = new TreeNode();
                    node.Text = var.type_name;
                    node.Tag = var.id;
                    root.Nodes.Add(node);
                }
                this.tvTreeList.Nodes.Add(root);
                this.tvTreeList.ExpandAll();
                //显示所有房间状态
                this.lvList.Items.Clear();
                List<RoomExpand> room = RoomManager.GetAllRoom("");
                Method(room);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其它异常：" + ex.Message);
            }
            //房间统计
            RoomCount("全部", 0);
        }
        #endregion
        /// <summary>
        /// 图片显示房间当前状态
        /// </summary>
        /// <param name="room"></param>
        private void Method(List<RoomExpand> room)
        {
            foreach (Room var in room)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = var.room_id.ToString();
                if (var.roomstate_id == 1)
                {
                    lvi.ImageIndex = 1;
                }
                else if (var.roomstate_id == 2)
                {
                    lvi.ImageIndex = 0;
                }
                else
                {
                    lvi.ImageIndex = 2;
                }
                this.lvList.Items.Add(lvi);
            }
        }
        /// <summary>
        /// 房间统计
        /// </summary>
        private void RoomCount(string name, int typeId)
        {
            try
            {
                //类型
                this.txttype.Text = name;
                //总数
                double count = RoomManager.GetRoomCount(typeId);
                this.txtCount.Text = count.ToString();
                //入住
                double comin = RoomManager.GetRoomStateCount(typeId, 1);
                this.txtIn.Text = comin.ToString();
                //空闲
                double free = RoomManager.GetRoomStateCount(typeId, 2);
                this.txtFree.Text = free.ToString();
                //维修
                double bad = RoomManager.GetRoomStateCount(typeId, 3);
                this.txtBad.Text = bad.ToString();
                //入住率 入住/(总数-维修)
                this.txtlv.Text = (comin / (count - bad)).ToString();
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

        private void tvTreeList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.lvList.Items.Clear();
            if (this.tvTreeList.SelectedNode.Level == 0)
            {
                //显示所有房间状态
                List<RoomExpand> room = RoomManager.GetAllRoom("");
                Method(room);
            }
            try
            {
                //显示当前类型房间状态
                List<RoomExpand> room = RoomManager.GetRoomStateByType(Convert.ToInt32(this.tvTreeList.SelectedNode.Tag));
                Method(room);
                //统计当前类型房间信息
                RoomCount(this.tvTreeList.SelectedNode.Text, Convert.ToInt32(this.tvTreeList.SelectedNode.Tag));
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
        private Point pointView = new Point(0, 0);//位置
        //鼠标少扫过lvList时发生提示
        private void lvList_MouseMove(object sender, MouseEventArgs e)
        {
            //指定位置的项
            ListViewItem lvi = this.lvList.GetItemAt(e.X + 20, e.Y + 20);

            if (lvi != null)
            {
                if (pointView.X != e.X + 20 || pointView.Y != e.Y + 20)//防止闪烁
                {
                    //根据房间号查询信息
                    try
                    {
                        List<RoomExpand> rb = RoomManager.GetAllRoom(lvi.Text);
                        //设置toolTip
                        toolTip.Show(("房间号：" + rb[0].room_id + "\n床位数：" + rb[0].bed_num + "\n状态：" + rb[0].roomstate_name + "\n类型：" + rb[0].roomtype_name + "\n描述：" + rb[0].description), lvList, new Point(e.X + 5, e.Y + 5), 2000);
                        pointView.X = e.X + 20;
                        pointView.Y = e.Y + 20;
                        toolTip.Active = true;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    toolTip.Hide(lvList);
                    pointView = new Point(e.X + 20, e.Y + 20);
                }
            }
        }

        private void lvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvDishList.DataSource = null;
            if (this.lvList.SelectedItems.Count == 0)
            {
                this.btAck.Enabled = false;
                this.dgvDishList.Enabled = false;
                this.txtList.Enabled = false;
                this.txtList.Text = string.Empty;
                return;
            }
            if (this.lvList.SelectedItems[0].ImageIndex == 1)
            {
                //记录房间号
                this.roomId = Convert.ToInt32(this.lvList.SelectedItems[0].Text);
                //获取点餐信息
                try
                {
                    //禁止添加多余的列
                    dgvDishList.AutoGenerateColumns = false;
                    //将数据转换成DataTable，绑定到dgv上
                    DataTable dt = DishManager.GetDishList("").ToDataTable();
                    dgvDishList.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("数据库异常：" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("其它异常：" + ex.Message);
                }
                this.btAck.Enabled = true;
                this.dgvDishList.Enabled = true;
                this.txtList.Enabled = true;
            }
            else
            {
                this.btAck.Enabled = false;
                this.dgvDishList.Enabled = false;
                this.txtList.Text = string.Empty;
            }
        }

        private void dgvDishList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvDishList.Rows[e.RowIndex].IsNewRow)
            {
                if (e.ColumnIndex == 5)
                {
                    money = 0;
                    StringBuilder sb = new StringBuilder();
                    foreach (DataGridViewRow row in dgvDishList.Rows)
                    {
                        DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["colChoose"];
                        //选中状态
                        bool flag = Convert.ToBoolean(cell.Value);
                        if (flag)
                        {
                            //份数
                            int num = Convert.ToInt32(row.Cells["colNumber"].Value);
                            //单价
                            decimal price = Convert.ToDecimal(row.Cells["colPrice"].Value);
                            if (num != 0)
                            {
                                sb.AppendLine(row.Cells["colDishName"].Value.ToString() + " " + num.ToString() + row.Cells["colUnit"].Value.ToString() + " ￥" + price * num);
                                money += Convert.ToDecimal(row.Cells["colPrice"].Value) * num;
                                this.txtList.Text = sb.ToString();
                            }

                        }
                    }
                    sb.AppendLine("- - - - - - - - - - - - - - - -");
                    sb.AppendLine("总计：￥" + money);
                    this.txtList.Text = sb.ToString();
                    //设置TextBox焦点总在最后
                    this.txtList.Focus();
                    this.txtList.Select(this.txtList.TextLength, 0);
                    this.txtList.ScrollToCaret();
                }
            }
        }

        private void dgvDishList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDishList.IsCurrentCellDirty)
            {
                dgvDishList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btAck_Click(object sender, EventArgs e)
        {
            try
            {
                bool ret = GuestManager.UpdatePrice(roomId, money);
                if(ret == false)
                    MessageBox.Show("点餐失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("点餐成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

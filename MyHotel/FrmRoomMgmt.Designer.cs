
namespace MyHotel
{
    partial class FrmRoomMgmt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomMgmt));
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.dgvRoomList = new Sunny.UI.UIDataGridView();
            this.colRoomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomStatue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumOfBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.cobRmSta = new Sunny.UI.UIComboBox();
            this.cobRmTy = new Sunny.UI.UIComboBox();
            this.txtDesc = new Sunny.UI.UITextBox();
            this.btAck = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtNumOfbed = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.btQuery = new Sunny.UI.UIButton();
            this.txtRmNm = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuit = new System.Windows.Forms.ToolStripButton();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.dgvRoomList);
            this.uiPanel1.Controls.Add(this.uiGroupBox2);
            this.uiPanel1.Controls.Add(this.uiGroupBox1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 25);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.SystemColors.ActiveCaption;
            this.uiPanel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPanel1.Size = new System.Drawing.Size(637, 554);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 5;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRoomList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvRoomList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvRoomList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvRoomList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoomList.ColumnHeadersHeight = 32;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomId,
            this.colRoomType,
            this.colRoomStatue,
            this.colNumOfBed,
            this.colRoomDescribe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoomList.EnableHeadersVisualStyles = false;
            this.dgvRoomList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvRoomList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.dgvRoomList.Location = new System.Drawing.Point(17, 102);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoomList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRoomList.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgvRoomList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoomList.RowTemplate.Height = 23;
            this.dgvRoomList.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvRoomList.SelectedIndex = -1;
            this.dgvRoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomList.Size = new System.Drawing.Size(607, 267);
            this.dgvRoomList.Style = Sunny.UI.UIStyle.Custom;
            this.dgvRoomList.TabIndex = 2;
            this.dgvRoomList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomList_CellClick);
            // 
            // colRoomId
            // 
            this.colRoomId.DataPropertyName = "room_id";
            this.colRoomId.HeaderText = "房间号";
            this.colRoomId.Name = "colRoomId";
            this.colRoomId.ReadOnly = true;
            // 
            // colRoomType
            // 
            this.colRoomType.DataPropertyName = "roomtype_name";
            this.colRoomType.HeaderText = "房价类型";
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            // 
            // colRoomStatue
            // 
            this.colRoomStatue.DataPropertyName = "roomstate_name";
            this.colRoomStatue.HeaderText = "房间状态";
            this.colRoomStatue.Name = "colRoomStatue";
            this.colRoomStatue.ReadOnly = true;
            // 
            // colNumOfBed
            // 
            this.colNumOfBed.DataPropertyName = "bed_num";
            this.colNumOfBed.HeaderText = "床位数";
            this.colNumOfBed.Name = "colNumOfBed";
            this.colNumOfBed.ReadOnly = true;
            // 
            // colRoomDescribe
            // 
            this.colRoomDescribe.DataPropertyName = "description";
            this.colRoomDescribe.HeaderText = "房间描述";
            this.colRoomDescribe.Name = "colRoomDescribe";
            this.colRoomDescribe.ReadOnly = true;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.Controls.Add(this.cobRmSta);
            this.uiGroupBox2.Controls.Add(this.cobRmTy);
            this.uiGroupBox2.Controls.Add(this.txtDesc);
            this.uiGroupBox2.Controls.Add(this.btAck);
            this.uiGroupBox2.Controls.Add(this.uiLabel4);
            this.uiGroupBox2.Controls.Add(this.uiLabel5);
            this.uiGroupBox2.Controls.Add(this.uiLabel3);
            this.uiGroupBox2.Controls.Add(this.txtNumOfbed);
            this.uiGroupBox2.Controls.Add(this.uiLabel2);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox2.Location = new System.Drawing.Point(17, 377);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(10, 32, 10, 32);
            this.uiGroupBox2.RectSize = 2;
            this.uiGroupBox2.Size = new System.Drawing.Size(607, 162);
            this.uiGroupBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox2.TabIndex = 3;
            this.uiGroupBox2.Text = "房间类型信息";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // cobRmSta
            // 
            this.cobRmSta.DataSource = null;
            this.cobRmSta.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cobRmSta.FillColor = System.Drawing.Color.White;
            this.cobRmSta.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cobRmSta.Location = new System.Drawing.Point(417, 44);
            this.cobRmSta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobRmSta.MinimumSize = new System.Drawing.Size(63, 0);
            this.cobRmSta.Name = "cobRmSta";
            this.cobRmSta.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cobRmSta.Size = new System.Drawing.Size(160, 28);
            this.cobRmSta.Style = Sunny.UI.UIStyle.Custom;
            this.cobRmSta.TabIndex = 14;
            this.cobRmSta.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cobRmSta.Watermark = "";
            // 
            // cobRmTy
            // 
            this.cobRmTy.DataSource = null;
            this.cobRmTy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cobRmTy.FillColor = System.Drawing.Color.White;
            this.cobRmTy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cobRmTy.Location = new System.Drawing.Point(134, 44);
            this.cobRmTy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobRmTy.MinimumSize = new System.Drawing.Size(63, 0);
            this.cobRmTy.Name = "cobRmTy";
            this.cobRmTy.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cobRmTy.Size = new System.Drawing.Size(148, 28);
            this.cobRmTy.Style = Sunny.UI.UIStyle.Custom;
            this.cobRmTy.TabIndex = 13;
            this.cobRmTy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cobRmTy.Watermark = "";
            // 
            // txtDesc
            // 
            this.txtDesc.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDesc.Location = new System.Drawing.Point(134, 84);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesc.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Padding = new System.Windows.Forms.Padding(5);
            this.txtDesc.Radius = 8;
            this.txtDesc.ShowText = false;
            this.txtDesc.Size = new System.Drawing.Size(148, 29);
            this.txtDesc.Style = Sunny.UI.UIStyle.Custom;
            this.txtDesc.TabIndex = 12;
            this.txtDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDesc.Watermark = "";
            // 
            // btAck
            // 
            this.btAck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAck.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAck.Location = new System.Drawing.Point(501, 121);
            this.btAck.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAck.Name = "btAck";
            this.btAck.Size = new System.Drawing.Size(76, 29);
            this.btAck.Style = Sunny.UI.UIStyle.Custom;
            this.btAck.TabIndex = 11;
            this.btAck.Text = "确认";
            this.btAck.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAck.Click += new System.EventHandler(this.btAck_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(325, 44);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(91, 28);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.Text = "房间状态：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(29, 44);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(98, 28);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "房间类型：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(29, 84);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(105, 28);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "房间描述：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumOfbed
            // 
            this.txtNumOfbed.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtNumOfbed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumOfbed.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumOfbed.Location = new System.Drawing.Point(417, 84);
            this.txtNumOfbed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumOfbed.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtNumOfbed.Name = "txtNumOfbed";
            this.txtNumOfbed.Padding = new System.Windows.Forms.Padding(5);
            this.txtNumOfbed.Radius = 8;
            this.txtNumOfbed.ShowText = false;
            this.txtNumOfbed.Size = new System.Drawing.Size(160, 29);
            this.txtNumOfbed.Style = Sunny.UI.UIStyle.Custom;
            this.txtNumOfbed.TabIndex = 2;
            this.txtNumOfbed.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNumOfbed.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(325, 84);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(74, 28);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 0;
            this.uiLabel2.Text = "床位数：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.btQuery);
            this.uiGroupBox1.Controls.Add(this.txtRmNm);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(17, 5);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(10, 32, 10, 32);
            this.uiGroupBox1.RectSize = 2;
            this.uiGroupBox1.Size = new System.Drawing.Size(607, 89);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btQuery
            // 
            this.btQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuery.Location = new System.Drawing.Point(447, 40);
            this.btQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(76, 29);
            this.btQuery.Style = Sunny.UI.UIStyle.Custom;
            this.btQuery.TabIndex = 3;
            this.btQuery.Text = "查询";
            this.btQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // txtRmNm
            // 
            this.txtRmNm.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtRmNm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRmNm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRmNm.Location = new System.Drawing.Point(164, 41);
            this.txtRmNm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRmNm.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRmNm.Name = "txtRmNm";
            this.txtRmNm.Padding = new System.Windows.Forms.Padding(5);
            this.txtRmNm.Radius = 8;
            this.txtRmNm.ShowText = false;
            this.txtRmNm.Size = new System.Drawing.Size(232, 29);
            this.txtRmNm.Style = Sunny.UI.UIStyle.Custom;
            this.txtRmNm.TabIndex = 2;
            this.txtRmNm.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRmNm.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(72, 41);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 28);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "房间号：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbUpdate,
            this.tsbDelete,
            this.tsbCancel,
            this.tsbQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(637, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(68, 22);
            this.tsbAdd.Text = "新增(A)";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(69, 22);
            this.tsbUpdate.Text = "修改(U)";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(69, 22);
            this.tsbDelete.Text = "删除(D)";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(68, 22);
            this.tsbCancel.Text = "取消(C)";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbQuit
            // 
            this.tsbQuit.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuit.Image")));
            this.tsbQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuit.Name = "tsbQuit";
            this.tsbQuit.Size = new System.Drawing.Size(67, 22);
            this.tsbQuit.Text = "退出(E)";
            this.tsbQuit.Click += new System.EventHandler(this.tsbQuit_Click);
            // 
            // FrmRoomMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 579);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoomMgmt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间管理";
            this.Load += new System.EventHandler(this.FrmRoomMgmt_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtNumOfbed;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDataGridView dgvRoomList;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton btQuery;
        private Sunny.UI.UITextBox txtRmNm;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuit;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton btAck;
        private Sunny.UI.UITextBox txtDesc;
        private Sunny.UI.UIComboBox cobRmTy;
        private Sunny.UI.UIComboBox cobRmSta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomStatue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumOfBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomDescribe;
    }
}
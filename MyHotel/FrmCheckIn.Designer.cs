
namespace MyHotel
{
    partial class FrmCheckIn
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cobRoNum = new Sunny.UI.UIComboBox();
            this.dpRegTime = new Sunny.UI.UIDatetimePicker();
            this.btCanc = new Sunny.UI.UIButton();
            this.cobGender = new Sunny.UI.UIComboBox();
            this.btAck = new Sunny.UI.UIButton();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtCashPlg = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtTel = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtIdNum = new Sunny.UI.UITextBox();
            this.txtCustNa = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiGroupBox1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.cobRoNum);
            this.uiGroupBox1.Controls.Add(this.dpRegTime);
            this.uiGroupBox1.Controls.Add(this.btCanc);
            this.uiGroupBox1.Controls.Add(this.cobGender);
            this.uiGroupBox1.Controls.Add(this.btAck);
            this.uiGroupBox1.Controls.Add(this.uiLabel10);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.txtCashPlg);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.txtTel);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Controls.Add(this.txtIdNum);
            this.uiGroupBox1.Controls.Add(this.txtCustNa);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 14);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(605, 266);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "登记客服信息";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cobRoNum
            // 
            this.cobRoNum.DataSource = null;
            this.cobRoNum.FillColor = System.Drawing.Color.White;
            this.cobRoNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cobRoNum.Location = new System.Drawing.Point(461, 100);
            this.cobRoNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobRoNum.MinimumSize = new System.Drawing.Size(63, 0);
            this.cobRoNum.Name = "cobRoNum";
            this.cobRoNum.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cobRoNum.Size = new System.Drawing.Size(110, 29);
            this.cobRoNum.TabIndex = 15;
            this.cobRoNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cobRoNum.Watermark = "";
            // 
            // dpRegTime
            // 
            this.dpRegTime.DateFormat = "yyyy-MM-dd";
            this.dpRegTime.FillColor = System.Drawing.Color.White;
            this.dpRegTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpRegTime.Location = new System.Drawing.Point(137, 205);
            this.dpRegTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpRegTime.MaxLength = 10;
            this.dpRegTime.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpRegTime.Name = "dpRegTime";
            this.dpRegTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpRegTime.Size = new System.Drawing.Size(191, 29);
            this.dpRegTime.SymbolDropDown = 61555;
            this.dpRegTime.SymbolNormal = 61555;
            this.dpRegTime.TabIndex = 14;
            this.dpRegTime.Text = "2023-09-24";
            this.dpRegTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpRegTime.Value = new System.DateTime(2023, 9, 24, 10, 1, 21, 246);
            this.dpRegTime.Watermark = "";
            // 
            // btCanc
            // 
            this.btCanc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCanc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCanc.Location = new System.Drawing.Point(504, 205);
            this.btCanc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btCanc.Name = "btCanc";
            this.btCanc.Size = new System.Drawing.Size(67, 29);
            this.btCanc.TabIndex = 13;
            this.btCanc.Text = "取消";
            this.btCanc.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCanc.Click += new System.EventHandler(this.btCanc_Click);
            // 
            // cobGender
            // 
            this.cobGender.DataSource = null;
            this.cobGender.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cobGender.DropDownWidth = 110;
            this.cobGender.FillColor = System.Drawing.Color.White;
            this.cobGender.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cobGender.Items.AddRange(new object[] {
            "女",
            "男"});
            this.cobGender.Location = new System.Drawing.Point(461, 52);
            this.cobGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cobGender.MinimumSize = new System.Drawing.Size(63, 0);
            this.cobGender.Name = "cobGender";
            this.cobGender.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cobGender.Size = new System.Drawing.Size(110, 29);
            this.cobGender.TabIndex = 12;
            this.cobGender.Text = "男";
            this.cobGender.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cobGender.Watermark = "";
            // 
            // btAck
            // 
            this.btAck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAck.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAck.Location = new System.Drawing.Point(396, 205);
            this.btAck.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAck.Name = "btAck";
            this.btAck.Size = new System.Drawing.Size(67, 29);
            this.btAck.TabIndex = 11;
            this.btAck.Text = "确认";
            this.btAck.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAck.Click += new System.EventHandler(this.btAck_Click);
            // 
            // uiLabel10
            // 
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.Location = new System.Drawing.Point(30, 205);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 29);
            this.uiLabel10.TabIndex = 9;
            this.uiLabel10.Text = "入住时间：";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(392, 148);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(62, 29);
            this.uiLabel5.TabIndex = 7;
            this.uiLabel5.Text = "押金：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(392, 100);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(62, 29);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "房间：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCashPlg
            // 
            this.txtCashPlg.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtCashPlg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashPlg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCashPlg.Location = new System.Drawing.Point(461, 148);
            this.txtCashPlg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCashPlg.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCashPlg.Name = "txtCashPlg";
            this.txtCashPlg.Padding = new System.Windows.Forms.Padding(5);
            this.txtCashPlg.ShowText = false;
            this.txtCashPlg.Size = new System.Drawing.Size(110, 29);
            this.txtCashPlg.TabIndex = 6;
            this.txtCashPlg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCashPlg.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(392, 52);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(62, 29);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "性别：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(30, 148);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 29);
            this.uiLabel6.TabIndex = 5;
            this.uiLabel6.Text = "联系电话：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTel
            // 
            this.txtTel.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTel.Location = new System.Drawing.Point(137, 148);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTel.Name = "txtTel";
            this.txtTel.Padding = new System.Windows.Forms.Padding(5);
            this.txtTel.ShowText = false;
            this.txtTel.Size = new System.Drawing.Size(191, 29);
            this.txtTel.TabIndex = 4;
            this.txtTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTel.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(30, 100);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 29);
            this.uiLabel4.TabIndex = 5;
            this.uiLabel4.Text = "身份证号：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(30, 52);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 29);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "客户姓名：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdNum
            // 
            this.txtIdNum.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtIdNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdNum.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIdNum.Location = new System.Drawing.Point(137, 100);
            this.txtIdNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdNum.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.Padding = new System.Windows.Forms.Padding(5);
            this.txtIdNum.ShowText = false;
            this.txtIdNum.Size = new System.Drawing.Size(191, 29);
            this.txtIdNum.TabIndex = 4;
            this.txtIdNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtIdNum.Watermark = "";
            // 
            // txtCustNa
            // 
            this.txtCustNa.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtCustNa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustNa.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustNa.Location = new System.Drawing.Point(137, 52);
            this.txtCustNa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustNa.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtCustNa.Name = "txtCustNa";
            this.txtCustNa.Padding = new System.Windows.Forms.Padding(5);
            this.txtCustNa.ShowText = false;
            this.txtCustNa.Size = new System.Drawing.Size(191, 29);
            this.txtCustNa.TabIndex = 0;
            this.txtCustNa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtCustNa.Watermark = "";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiGroupBox1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(631, 295);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 295);
            this.Controls.Add(this.uiPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入住登记";
            this.Load += new System.EventHandler(this.FrmCheckIn_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btAck;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtCashPlg;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtTel;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtIdNum;
        private Sunny.UI.UITextBox txtCustNa;
        private Sunny.UI.UIComboBox cobGender;
        private Sunny.UI.UIButton btCanc;
        private Sunny.UI.UIDatetimePicker dpRegTime;
        private Sunny.UI.UIComboBox cobRoNum;
    }
}
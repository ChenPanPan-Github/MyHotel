
namespace MyHotel
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.txtLoginId = new Sunny.UI.UITextBox();
            this.txtPwd = new Sunny.UI.UITextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbLogin.Location = new System.Drawing.Point(517, 345);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(175, 26);
            this.pbLogin.TabIndex = 2;
            this.pbLogin.TabStop = false;
            this.pbLogin.Click += new System.EventHandler(this.pbLogin_Click);
            // 
            // txtLoginId
            // 
            this.txtLoginId.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtLoginId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginId.Location = new System.Drawing.Point(517, 254);
            this.txtLoginId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoginId.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Padding = new System.Windows.Forms.Padding(5);
            this.txtLoginId.ShowText = false;
            this.txtLoginId.Size = new System.Drawing.Size(175, 26);
            this.txtLoginId.TabIndex = 3;
            this.txtLoginId.Text = "pan";
            this.txtLoginId.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLoginId.Watermark = "";
            this.txtLoginId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoginId_KeyDown);
            // 
            // txtPwd
            // 
            this.txtPwd.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.DoubleValue = 123D;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPwd.IntValue = 123;
            this.txtPwd.Location = new System.Drawing.Point(517, 302);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.ShowText = false;
            this.txtPwd.Size = new System.Drawing.Size(175, 26);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.Text = "123";
            this.txtPwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPwd.Watermark = "";
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip.ToolTipTitle = "提示：";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyHotel.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 469);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.pbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogin;
        private Sunny.UI.UITextBox txtLoginId;
        private Sunny.UI.UITextBox txtPwd;
        private System.Windows.Forms.ToolTip toolTip;
    }
}


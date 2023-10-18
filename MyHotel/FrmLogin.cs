using MyHotelBLL;
using MyHotelModel;
using Sunny.UI;
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

namespace MyHotel
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        private void Login()
        {
            if (string.IsNullOrEmpty(this.txtLoginId.Text.Trim()))
            {
                toolTip.Show("请输入用户名！", txtLoginId, 1000);
                txtLoginId.Focus();
                return;
            }
            if(string.IsNullOrEmpty(this.txtPwd.Text))
            {
                toolTip.Show("请输入密码！", txtPwd, 1000);
                txtPwd.Focus();
                return;
            }
            try
            {
                bool IsTarget = AdminManager.CheckIdPwd(new Admin(txtLoginId.Text.Trim(), txtPwd.Text));
                if (IsTarget == false)
                {
                    MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                User.LoginId = txtLoginId.Text;
                User.PassWord = txtPwd.Text;
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("数据库异常：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("其他异常：" + ex.Message);
            }

        }
        /// <summary>
        /// 登录按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        /// <summary>
        /// 回车登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) pbLogin_Click(null, null);
        }
        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) pbLogin_Click(null, null);
        }

    }
}

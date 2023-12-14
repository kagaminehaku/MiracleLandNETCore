using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MiracleLandNETFW
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string userpwd = login_password.Text;
            ////BUSLogin bLogin = new BUSLogin();
            ////int id = bLogin.checkValidLogin(username, userpwd);
            int id = 0;
            if (id != -1)
            {
                MessageBox.Show("Đăng nhập thành công!\nChào mừng " + username + "!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}

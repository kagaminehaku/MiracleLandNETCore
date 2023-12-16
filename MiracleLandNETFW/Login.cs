using BUS;
using DTO;
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
            BUSLogin bLogin = new BUSLogin();

            user_account user = bLogin.checkValidLogin(username, userpwd);

            if (user.type == "admin")
            {
                AdminBehavior(user);
            }
            if (user.type == "Normal")
            {
                CustomerBehavior(user);
            }
            else
            {
                MessageBox.Show("Invail username or password.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void AdminBehavior(user_account user)
        {
            MessageBox.Show($"Welcome {user.username}!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MiracleLandAdminUI miracleLandAdminUI = new MiracleLandAdminUI(user);
            miracleLandAdminUI.FormClosed += (s, args) => this.Show();
            miracleLandAdminUI.Show();
            this.Hide();
        }

        private void CustomerBehavior(user_account user)
        {
            MessageBox.Show($"Welcome {user.username}!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

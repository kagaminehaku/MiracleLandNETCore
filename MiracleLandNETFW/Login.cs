using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Load += Login_Load;
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            await Task.Delay(1);
            GuestBehavior(null);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string userpwd = login_password.Text;
            var bLogin = new BUSLogin();

            user_account user = bLogin.checkValidLogin(username, userpwd);

            ResetLoginData();
            if (user == null)
            {
                MessageBox.Show("Invail username or password.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (user.type == "admin")
            {
                AdminBehavior(user);
            }
            else if (user.type == "Normal")
            {
                CustomerBehavior(user);
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
            var miracleLandAdminUI = new MiracleLandAdminUI(user);
            miracleLandAdminUI.FormClosed += (s, args) => this.Show();
            miracleLandAdminUI.Show();
            this.Hide();
        }

        private void CustomerBehavior(user_account user)
        {
            MessageBox.Show($"Welcome {user.username}!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var miracleLandMainUI = new MiracleLandMainUI(user);
            miracleLandMainUI.FormClosed += (s, args) => this.Show();
            miracleLandMainUI.Show();
            this.Hide();
        }

        private void GuestBehavior(user_account user)
        {
            var miracleLandMainUI = new MiracleLandMainUI(null);
            miracleLandMainUI.FormClosed += (s, args) => this.Show();
            miracleLandMainUI.Show();
            this.Hide();
        }


        private void ResetLoginData()
        {
            login_username.Clear();
            login_password.Clear();
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            GuestBehavior(null);
        }
    }
}

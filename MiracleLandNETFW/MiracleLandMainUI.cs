using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiracleLandNETFW
{
    public partial class MiracleLandMainUI : Form
    {
        private user_account loggedInUser;
        private string setting;
        public MiracleLandMainUI(user_account user)
        {
            InitializeComponent();
            loggedInUser = user;
            if (loggedInUser == null)
            {
                setting = "guess";
            }
            if (loggedInUser != null)
            {
                setting = "logged";
            }

        }

        private void mainui_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.FormClosed += (s, args) => this.Show();
            login.Show();
            this.Hide();     
        }
    }
}

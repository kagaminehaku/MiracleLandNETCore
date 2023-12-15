using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MiracleLandNETFW
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(register_username.Text) || String.IsNullOrEmpty(register_password.Text) || String.IsNullOrEmpty(register_password2.Text)||String.IsNullOrEmpty(register_email.Text)||String.IsNullOrEmpty(register_address.Text)||String.IsNullOrEmpty(register_phone.Text))
            {
                MessageBox.Show("Please fill all empty field.");
            }
        }
    }
}

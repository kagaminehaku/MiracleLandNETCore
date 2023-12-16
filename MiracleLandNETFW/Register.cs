using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            RegisterBehavior();
        }

        private void RegisterBehavior()
        {
            if (String.IsNullOrEmpty(register_username.Text) || String.IsNullOrEmpty(register_password.Text) || String.IsNullOrEmpty(register_password2.Text) || String.IsNullOrEmpty(register_email.Text) || String.IsNullOrEmpty(register_address.Text) || String.IsNullOrEmpty(register_phone.Text))
            {
                MessageBox.Show("Please fill all empty fields.");
                return;
            }

            if (register_password.Text != register_password2.Text)
            {
                MessageBox.Show("Password does not match.");
                return;
            }
            string username = register_username.Text;
            string password = register_password.Text;
            string type = "Normal";
            string email = register_email.Text;
            string address = register_address.Text;
            string phone = register_phone.Text;

            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            BUSuser_account busUserAccount = new BUSuser_account();
            string result = busUserAccount.RegisterUser(username, password, type, email, phone, address);
            if (result == username)
            {
                MessageBox.Show("Registration successful.");
            }
            else if (result == "Duplicate")
            {
                MessageBox.Show("Username is already taken.");
            }
            else
            {
                MessageBox.Show("An Unexpected Error Occurred.");
            }
        }
    }
}

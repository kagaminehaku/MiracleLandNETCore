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
using System.Windows.Forms;

namespace MiracleLandNETFW
{
    public partial class MiracleLandAdminUI : Form
    {
        private user_account session;
        public MiracleLandAdminUI(user_account user)
        {
            InitializeComponent();
            session = user;
            LoadDataToDGV();
            ControlBox = false;
        }

        private void LoadDataToDGV()
        {
            DGV1.Rows.Clear();
            var busproduct = new BUSproduct();
            List<product> products = busproduct.GetAllProduct();
            foreach (product product in products)
            {
                DGV1.Rows.Add(product.pid, product.pname, product.pprice, product.pquantity, product.pinfo);
            }
        }

        private void admin_add_Click(object sender, EventArgs e)
        {
            var addNewProduct = new AddNewProduct();
            addNewProduct.FormClosed += (s, args) => this.Show();
            addNewProduct.FormClosed += (s, args) => LoadDataToDGV();
            addNewProduct.Show();
            this.Hide();
        }

        private void admin_logout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            session = null;
            this.Close();
        }

        private void ShowDataReset()
        {
            LoadDataToDGV();
            admin_pid.Clear();
            pname.Clear();
            pprice.Clear();
            pquantity.Clear();
            pinfo.Clear();
            pictureBox1.ImageLocation = null;
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DGV1.SelectedRows[0].Cells["Id"].Value;
            var busproduct = new BUSproduct();
            var product = busproduct.GetProduct(id);
            admin_pid.Text = product.pid.ToString();
            pname.Text = product.pname;
            pprice.Text = product.pprice.ToString();
            pquantity.Text = product.pquantity.ToString();
            pinfo.Text = product.pinfo;
            pictureBox1.ImageLocation = product.pimg;
        }

        private void admin_delete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(admin_pid.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            else if (int.TryParse(admin_pid.Text, out int productid))
            {
                var busproduct = new BUSproduct();
                string imagepath = pictureBox1.ImageLocation;
                if (busproduct.RemoveProduct(productid,imagepath))
                {
                    MessageBox.Show("Product delete sucessfully");
                    ShowDataReset();
                    return;
                }
            }
        }

        private void admin_edit_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(admin_pid.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            else if (int.TryParse(admin_pid.Text, out int productid))
            {
                var editproduct = new EditProduct(productid);
                editproduct.FormClosed += (s, args) => this.Show();
                editproduct.FormClosed += (s, args) => LoadDataToDGV();
                editproduct.Show();
                this.Hide();
            }
        }

        private void change_password_Click(object sender, EventArgs e)
        {
            if (n_password.Text != cn_password.Text || String.IsNullOrEmpty(n_password.Text) || String.IsNullOrEmpty(cn_password.Text))
            {
                MessageBox.Show("Please fill all field");
                return;
            }
            var bususeraccount = new BUSuser_account();
            if (bususeraccount.IsPasswordVaild(n_password.Text) == false)
            {
                MessageBox.Show("New password invaild,it must contain more than 8 characters");
                return;
            }
            var buslogin = new BUSLogin();
            var allowchangepwd = (buslogin.checkValidLogin(session.username.ToString(), current_password.Text));
            if ( allowchangepwd !=null )
            {
                var bus2useraccount = new BUSuser_account();
                if(bus2useraccount.UpdatePassword(session.username.ToString(), n_password.Text))
                {
                    MessageBox.Show("Password has been changed,session timeout.");
                    session = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An Unexpected Error Occurred.");
                    return;
                }
            }
            else if (allowchangepwd == null)
            {
                MessageBox.Show("Old password invaild !");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            foreach (DataGridViewRow row in DGV1.Rows)
            {
                string studentName = row.Cells["name"].Value.ToString();
                if (studentName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}

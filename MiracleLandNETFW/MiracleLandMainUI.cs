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
using System.Net.NetworkInformation;
using System.Windows.Controls;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace MiracleLandNETFW
{
    public partial class MiracleLandMainUI : Form
    {
        private user_account session;
        public MiracleLandMainUI(user_account user)
        {
            InitializeComponent();
            session = user;
            LoadDataToDGV();
            if (session == null)
            {
                InitForGuess();
            }
            else if (session != null)
            {
                InitForSession(); 
            }

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

        private void InitForGuess()
        {
            mainui_login.Enabled = false;
            mainui_login.Text = "Current user: Guest ";
            tabControl1.TabPages["tabPage2"].Enabled = false;
            tabControl1.TabPages["tabPage3"].Enabled = false;
        }

        private void InitForSession()
        {
            mainui_login.Enabled = false;
            mainui_login.Text = "Current user: " +session.username;
        }

        private void mainui_login_Click(object sender, EventArgs e)
        {
            this.Close();     
        }

        private void user_shopcart_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                MessageBox.Show("Login to use this function.");
                return;
            }
            tabControl1.SelectedTab = tabPage2;
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

        private void button5_Click(object sender, EventArgs e)
        {
            session = null;
            this.Close();
        }

        private void user_add_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                MessageBox.Show("Login to use this function.");
                return;
            }
            else if (String.IsNullOrEmpty(user_pid.Text))
            {
                MessageBox.Show("Please choose a product to buy.");
                return;
            }
            else if (session != null)
            {
                int productId = int.Parse(user_pid.Text);
                string productName = user_pname.Text;
                int productPrice = int.Parse(user_pprice.Text);
                int productQuantityAvailable = int.Parse(user_pquantity.Text);
                string pinfo = user_pinfo.Text;

                DataGridViewRow existingRow = FindProductInCart(productId);

                if (existingRow == null)
                {
                    int quantityToAdd = AskForQuantity(productQuantityAvailable);

                    if (quantityToAdd > 0)
                    {
                        DGV2.Rows.Add(productId, productName, productPrice, quantityToAdd, pinfo);
                    }
                }
                else
                {
                    int currentQuantityInCart = Convert.ToInt32(existingRow.Cells["quantity2"].Value);
                    int quantityToAdd = AskForQuantity(productQuantityAvailable);
                    if (quantityToAdd > 0)
                    {
                        existingRow.Cells["quantity2"].Value = currentQuantityInCart + quantityToAdd;
                    }
                }
            }
        }

        private DataGridViewRow FindProductInCart(int productId)
        {
            foreach (DataGridViewRow row in DGV2.Rows)
            {
                int cartProductId = Convert.ToInt32(row.Cells["id2"].Value);
                if (cartProductId == productId)
                {
                    return row;
                }
            }

            return null;
        }

        private int FindProductQuantityInList(int cartProductId)
        {
            foreach (DataGridViewRow row in DGV1.Rows)
            {
                int ProductId = Convert.ToInt32(row.Cells["Id"].Value);
                int Quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                if (ProductId == cartProductId)
                {
                    return Quantity;
                }
            }

            return 0;
        }

        public static int AskForQuantity(int maxQuantity)
        {
            int qty = 0;
            using (var inputForm = new AskQuantity(maxQuantity))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    qty = inputForm.Qty;
                }
            }
            return qty;
        }


        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = (int)DGV2.SelectedRows[0].Cells["id2"].Value;
            var busproduct = new BUSproduct();
            var product = busproduct.GetProduct(id);
            cart_id.Text = product.pid.ToString();
            cart_name.Text = product.pname;
            cart_price.Text = product.pprice.ToString();
            cart_quantity.Text = DGV2.SelectedRows[0].Cells["quantity2"].Value.ToString();
            cart_info.Text = product.pinfo;
            pictureBox2.ImageLocation = product.pimg;

        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DGV1.SelectedRows[0].Cells["Id"].Value;
            var busproduct = new BUSproduct();
            var product = busproduct.GetProduct(id);
            user_pid.Text = product.pid.ToString();
            user_pname.Text = product.pname;
            user_pprice.Text = product.pprice.ToString();
            user_pquantity.Text = product.pquantity.ToString();
            user_pinfo.Text = product.pinfo;
            pictureBox1.ImageLocation = product.pimg;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text.Trim();
            foreach (DataGridViewRow row in DGV2.Rows)
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
            if (allowchangepwd != null)
            {
                var bus2useraccount = new BUSuser_account();
                if (bus2useraccount.UpdatePassword(session.username.ToString(), n_password.Text))
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGV2.SelectedRows.Count > 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            int id = (int)DGV2.SelectedRows[0].Cells["id2"].Value;
            int productQuantityAvailable = FindProductQuantityInList(id);
            int quantityToAdd = AskForQuantity(productQuantityAvailable);
            DGV2.SelectedRows[0].Cells["quantity2"].Value=quantityToAdd;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DGV2.SelectedRows.Count > 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            int selectedIndex = DGV2.SelectedRows[0].Index;
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected product?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DGV2.Rows.RemoveAt(selectedIndex);
            }
        }

        private void CartClear()
        {
            cart_id.Clear();
            cart_name.Clear();  
            cart_price.Clear(); 
            cart_quantity.Clear();
            cart_info.Clear();
            pictureBox2.ImageLocation = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

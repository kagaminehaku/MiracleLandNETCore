using BUS;
using DTOCore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiracleLandNETFW
{
    public partial class MiracleLandMainUI : Form
    {
        private UserAccount session;
        public MiracleLandMainUI(UserAccount user)
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
                LoadDataToDGV2();
            }

        }

        private void LoadDataToDGV()
        {
            DGV1.Rows.Clear();
            var busproduct = new BUSproduct();
            List<Product> products = busproduct.GetAllProduct();
            foreach (Product product in products)
            {
                DGV1.Rows.Add(product.Pid, product.Pname, product.Pprice, product.Pquantity, product.Pinfo);
            }
        }

        private void LoadDataToDGV2()
        {
            int cartid = 1;
            DGV2.Rows.Clear();
            var busshopping_cart = new BUSshopping_cart();
            List<ShoppingCart> items = busshopping_cart.GetAllItemInUserCart(session.Id);
            foreach (ShoppingCart item in items)
            {
                var busproduct = new BUSproduct();
                Product product = busproduct.GetProduct(item.Pid);
                int cartprice = product.Pprice * item.Pquantity;
                DGV2.Rows.Add(cartid, product.Pname, cartprice, item.Pquantity, product.Pinfo);
                cartid++;
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
            mainui_login.Text = "Current user: " + session.Username;
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
                int uid = session.Id;
                int productId = int.Parse(user_pid.Text);
                int productQuantityAvailable = int.Parse(user_pquantity.Text);
                if (true)
                {
                    int quantityToAdd = AskForQuantity(productQuantityAvailable);

                    if (quantityToAdd > 0)
                    {
                        var buscart = new BUSshopping_cart();
                        buscart.AddItemToCart(uid, productId, quantityToAdd);
                    }
                }
            }
            LoadDataToDGV2();
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

            string itemname = (string)DGV2.SelectedRows[0].Cells["name2"].Value;
            var busproduct = new BUSproduct();
            var product = busproduct.GetProductByName(itemname);
            cart_id.Text = product.Pid.ToString();
            cart_name.Text = product.Pname;
            cart_price.Text = product.Pprice.ToString();
            cart_quantity.Text = DGV2.SelectedRows[0].Cells["quantity2"].Value.ToString();
            cart_info.Text = product.Pinfo;
            pictureBox2.ImageLocation = product.Pimg;

        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DGV1.SelectedRows[0].Cells["Id"].Value;
            var busproduct = new BUSproduct();
            var product = busproduct.GetProduct(id);
            user_pid.Text = product.Pid.ToString();
            user_pname.Text = product.Pname;
            user_pprice.Text = product.Pprice.ToString();
            user_pquantity.Text = product.Pquantity.ToString();
            user_pinfo.Text = product.Pinfo;
            pictureBox1.ImageLocation = product.Pimg;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox3.Text.Trim();
            foreach (DataGridViewRow row in DGV2.Rows)
            {
                string studentName = row.Cells["name2"].Value.ToString();
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
            var allowchangepwd = (buslogin.checkValidLogin(session.Username.ToString(), current_password.Text));
            if (allowchangepwd != null)
            {
                var bus2useraccount = new BUSuser_account();
                if (bus2useraccount.UpdatePassword(session.Username.ToString(), n_password.Text))
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
            if (String.IsNullOrEmpty(cart_name.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            var busproduct = new BUSproduct();
            var product = busproduct.GetProductByName(cart_name.Text);
            int newqty = AskForQuantity(product.Pquantity);
            var cart = new BUSshopping_cart();
            cart.EditItemQtyInCart(session.Id, product.Pid, newqty);
            LoadDataToDGV2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cart_name.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected product?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var busproduct = new BUSproduct();
                var product = busproduct.GetProductByName(cart_name.Text);
                var cart = new BUSshopping_cart();
                cart.DeleteCartItem(session.Id, product.Pid);
                CartClear();
                LoadDataToDGV2();
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
            DGV2.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long total = 0;
            if (DGV2.RowCount == 0)
            {
                MessageBox.Show("Please add something to cart");
                return;
            }
            foreach (DataGridViewRow row in DGV2.Rows)
            {
                if (row.Cells["price2"].Value != null && row.Cells["quantity2"].Value != null)
                {
                    if (int.TryParse(row.Cells["price2"].Value.ToString(), out int price) &&
                        int.TryParse(row.Cells["quantity2"].Value.ToString(), out int quantity))
                    {
                        total += price * quantity;
                    }
                }
            }
            var busorders = new BUSorders();
            string oid = busorders.AddNewOrders(session.Id, total);
            foreach (DataGridViewRow row in DGV2.Rows)
            {
                if (int.TryParse(row.Cells["id2"].Value.ToString(), out int pid) &&
                        int.TryParse(row.Cells["quantity2"].Value.ToString(), out int quantity))
                {
                    var busproduct = new BUSproduct();
                    busproduct.UpdateProductQuantity(pid, quantity);
                    var busorderdetail = new BUSorderdetail();
                    bool isok = busorderdetail.AddNewOrderDetail(int.Parse(oid), pid, quantity);
                    if (isok == false)
                    {
                        MessageBox.Show("Something wrong");
                    }
                }
            }
            MessageBox.Show("Thank you for your order! Please pay " + total + "VND when your package arrives.");
            CartClear();
            LoadDataToDGV();
        }

        private void DGV2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void DGV2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void DGV2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            long total = 0;
            if (DGV2 == null)
            {
                return;
            }
            foreach (DataGridViewRow row in DGV2.Rows)
            {
                if (row.Cells["price2"].Value != null && row.Cells["quantity2"].Value != null)
                {
                    if (int.TryParse(row.Cells["price2"].Value.ToString(), out int price) &&
                        int.TryParse(row.Cells["quantity2"].Value.ToString(), out int quantity))
                    {
                        total += price * quantity;
                    }
                }
            }
            button3.Text = "💵 Total: " + total.ToString();
        }
    }
}

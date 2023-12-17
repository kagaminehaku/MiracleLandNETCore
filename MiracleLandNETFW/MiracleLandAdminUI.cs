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
        private user_account loggedInUser;
        public MiracleLandAdminUI(user_account user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadDataToDGV();
            ControlBox = false;
        }

        private void LoadDataToDGV()
        {
            DGV1.Rows.Clear();
            BUSproduct busproduct = new BUSproduct();
            List<product> products = busproduct.GetAllProduct();
            foreach (product product in products)
            {
                DGV1.Rows.Add(product.pid, product.pname, product.pprice, product.pquantity, product.pinfo);
            }
        }

        private void admin_add_Click(object sender, EventArgs e)
        {
            AddNewProduct addNewProduct = new AddNewProduct();
            addNewProduct.FormClosed += (s, args) => this.Show();
            addNewProduct.FormClosed += (s, args) => LoadDataToDGV();
            addNewProduct.Show();
            this.Hide();
        }

        private void admin_logout_Click(object sender, EventArgs e)
        {
            loggedInUser = null;
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
    }
}

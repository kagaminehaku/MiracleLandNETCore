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
        }

        private void LoadDataToDGV()
        {
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
            
        }

        private void DGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("LMAO");
        }
    }
}

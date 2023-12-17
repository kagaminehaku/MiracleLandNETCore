using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiracleLandNETFW
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void NewImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;

                    string currentDirectory = Environment.CurrentDirectory;

                    string imagesFolderPath = Path.Combine(currentDirectory, "Images");
                    if (!Directory.Exists(imagesFolderPath))
                    {
                        Directory.CreateDirectory(imagesFolderPath);
                    }

                    string destinationPath = Path.Combine(imagesFolderPath, Path.GetFileName(selectedImagePath));
                    File.Copy(selectedImagePath, destinationPath, true);

                    pictureBox1.ImageLocation = destinationPath;
                }
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            AddProductLogic();
        }

        private void AddProductLogic()
        {
            
            string imagePath = pictureBox1.ImageLocation;
            if (imagePath == null || imagePath.Length > 1024)
            {
                MessageBox.Show("Image path invaild.");
                return;
            }
            else if (String.IsNullOrEmpty(add_name.Text) || add_price == null || add_quantity == null || String.IsNullOrEmpty(add_info.Text))
            {
                MessageBox.Show("Please fill all field.");
                return;
            }
            var busproduct = new BUSproduct();
            if (int.TryParse(add_price.Text, out int price) && int.TryParse(add_quantity.Text, out int quantity))
            {
                string productname = busproduct.AddNewProduct(add_name.Text, price, quantity, add_info.Text, imagePath);
                if (productname == add_name.Text)
                {
                    MessageBox.Show($"{productname}" + "Added", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (productname != add_name.Text)
                {
                    MessageBox.Show("An Unexpected Error Occurred.");
                    return;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NewImage();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        private void add_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
    }
}

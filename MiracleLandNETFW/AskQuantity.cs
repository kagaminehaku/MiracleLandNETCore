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
    public partial class AskQuantity : Form
    {
        public int Qty { get; private set; }
        private int maxvalue;
        public AskQuantity(int max)
        {
            InitializeComponent();
            maxvalue = max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            else if (int.Parse(textBox1.Text) == 0 || int.Parse(textBox1.Text) > maxvalue)
            {
                MessageBox.Show("Please type a vaild quantity.");
                return;
            }
            Qty = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }
    }
}

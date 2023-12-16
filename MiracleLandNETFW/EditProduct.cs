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
    public partial class EditProduct : Form
    {
        private int eid;
        public EditProduct(int id)
        {
            eid = id;
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        }
    }
}

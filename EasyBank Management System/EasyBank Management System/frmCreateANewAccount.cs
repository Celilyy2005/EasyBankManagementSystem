using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank_Management_System
{
    public partial class frmCreateANewAccount : Form
    {
        public frmCreateANewAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.Show();
            this.Hide();
        }
    }
}

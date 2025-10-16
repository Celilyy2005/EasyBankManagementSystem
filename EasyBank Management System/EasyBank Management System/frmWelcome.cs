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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Show();
        }

        private void btnCreateANewAccount_Click(object sender, EventArgs e)
        {
            frmCreateANewAccount formCreateAnewAccount = new frmCreateANewAccount();
            this.Hide();
            formCreateAnewAccount.ShowDialog();
            this.Show();
        }

        private void btnActivateAccount_Click(object sender, EventArgs e)
        {
            frmActivateAccount formActivateAccount = new frmActivateAccount();
            this.Hide();
            formActivateAccount.ShowDialog();
            this.Show();
        }
    }
}

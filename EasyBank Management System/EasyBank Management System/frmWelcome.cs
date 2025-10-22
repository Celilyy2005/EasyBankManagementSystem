using System;
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
            // Pass the Welcome form itself to Step1
            frmCreateANewAccountStep1 step1Form = new frmCreateANewAccountStep1(this);
            step1Form.Show();
            this.Hide();
        }

        private void btnActivateAccount_Click(object sender, EventArgs e)
        {
            frmActivateAccount formActivateAccount = new frmActivateAccount();
            this.Hide();
            formActivateAccount.ShowDialog();
            this.Show();
        }

        private void lnkContactUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmContactUs formContactUs = new frmContactUs();
            formContactUs.Show();
            this.Hide();
        }
    }
}

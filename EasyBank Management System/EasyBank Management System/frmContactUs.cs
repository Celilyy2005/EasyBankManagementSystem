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
    public partial class frmContactUs : Form
    {
        public frmContactUs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmContactUs_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome formWelcome = new frmWelcome();
            this.Hide(); // hide current form
            formWelcome.ShowDialog();
            this.Show();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string message = txtMessage.Text.Trim();
            if(fullName == "" || email=="" || message == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error");
                return;
            }
        }
    }
}

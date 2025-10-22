using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;


namespace EasyBank_Management_System
{
    public partial class frmCreateANewAccountStep3 : Form
    {
        private frmCreateANewAccountStep2 step2Form;

        private string _email;
        private string _phoneNumber;
        private string _nationalIdOrCIF;
        

        public frmCreateANewAccountStep3(frmCreateANewAccountStep2 previousForm, string email, string phoneNumber, string nationalIdOrCIF)
        {
            InitializeComponent();

            this.step2Form = previousForm;
       
            _email = email;
            _phoneNumber = phoneNumber;
            _nationalIdOrCIF = nationalIdOrCIF;


        }
        public void SetPreviousData(string username, string password, string confirmPass)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtConfirmPassword.Text = confirmPass;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            step2Form.SetPreviousData(_email, _phoneNumber, _nationalIdOrCIF);
            step2Form.Show();
            this.Hide();
        }

        private void frmCreateANewAccountStep3_Load(object sender, EventArgs e)
        {
            // You can put form initialization code here if needed.
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            // Validations
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPass)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkAgree.Checked)
            {
                MessageBox.Show("You must accept the terms and conditions.", "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            frmDashboard formDashboard = new frmDashboard();
            formDashboard.Show();
            this.Hide();
        }
    }
}
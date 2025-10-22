using System;
using System.Windows.Forms;

namespace EasyBank_Management_System
{
    public partial class frmCreateANewAccountStep1 : Form
    {
        private Form _welcomeForm;

        public frmCreateANewAccountStep1(Form welcomeForm)
        {
            InitializeComponent();
            _welcomeForm = welcomeForm;

      
        }

        public void SetPreviousData(string firstName, string lastName, string gender, DateTime dob)
        {
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;

            if (gender == "Male") rdoMale.Checked = true;
            else if (gender == "Female") rdoFemale.Checked = true;

            dtpDateOfBirth.Value = dob;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _welcomeForm.Show();
            this.Hide();
        }
        private void frmCreateANewAccountStep1_Load(object sender, EventArgs e)
        {
            // You can put form initialization code here if needed.
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string gender = rdoMale.Checked ? "Male" : rdoFemale.Checked ? "Female" : "";
            DateTime dob = dtpDateOfBirth.Value;

            // Validations
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please fill in all name fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dob.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid Date of Birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int age = DateTime.Now.Year - dob.Year;
            if (dob > DateTime.Now.AddYears(-age)) age--;
            if (age <= 18)
            {
                MessageBox.Show("You must be at least 18 years old to create an account.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Move to Step2
            frmCreateANewAccountStep2 step2Form = new frmCreateANewAccountStep2(this, firstName, lastName, gender, dob);
            step2Form.Show();
            this.Hide();
        }
    }
}

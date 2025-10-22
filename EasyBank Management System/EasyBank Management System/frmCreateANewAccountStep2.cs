using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Text;

namespace EasyBank_Management_System
{
    public partial class frmCreateANewAccountStep2 : Form
    {
      

        private frmCreateANewAccountStep1 _step1CreateAccountForm;
        private frmCreateANewAccountStep2 step2Form;
        // private Form _step1;
        //  public frmCreateANewAccountStep2(Form step1CreateAccountForm)
        //{
        //InitializeComponent();
        //  _step1 = step1CreateAccountForm;


        //}
        private string _firstName;
        private string _lastName;
        private string _gender;
        private DateTime _dob;

         
        public void SetPreviousData(string email, string phoneNumber, string nationalIDOrCIF)
        {
            txtEmail.Text = email ;
            txtPhoneNumber.Text = phoneNumber;
            txtNationalIdOrCIF.Text = nationalIDOrCIF;
        }
        public frmCreateANewAccountStep2(frmCreateANewAccountStep1 step1CreateAccountForm, string firstName, string lastName, string gender, DateTime dob)
        {
            InitializeComponent();
            _step1CreateAccountForm = step1CreateAccountForm;
            _firstName = firstName;
            _lastName = lastName;
            _gender = gender;
            _dob = dob;
        }
        private void frmCreateANewAccountStep2_Load(object sender, EventArgs e)
        {
            // You can put form initialization code here if needed.
        }  


        private void btnBack_Click(object sender, EventArgs e)
        {
            _step1CreateAccountForm.SetPreviousData(_firstName, _lastName, _gender, _dob);
            _step1CreateAccountForm.Show();
            this.Hide();
        }
    

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-z0-9._]+@(gmail\.com|yahoo\.com|outlook\.com)$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }

           
            
                
               
            
        }

       
        private void btnNext_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string nationalIDOrCIF = txtNationalIdOrCIF.Text.Trim();

            if(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(nationalIDOrCIF))
            {
                MessageBox.Show("please fill in all required fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email must end with @gmail.com, @yahoo.com, or @outlook.com! and MUST BE LOWERCASE", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            if(!Regex.IsMatch(phoneNumber, @"^\d{9,11}$"))
            {
                MessageBox.Show("Please enter a valid phone number (9-11 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(nationalIDOrCIF, @"^\d{8,15}$"))
            {
                MessageBox.Show("Please enter a valid National ID (8-15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Move to CreateAccountStepp3 
            frmCreateANewAccountStep3 step3Form = new frmCreateANewAccountStep3(this,email, phoneNumber,nationalIDOrCIF);
            step3Form.Show();
            this.Hide();

        }
    }
}

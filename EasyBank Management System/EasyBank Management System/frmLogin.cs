using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace EasyBank_Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcome formWelcome = new frmWelcome();
            formWelcome.Show(); // show form when back

            //Hide Login Form before back to Welcome
            this.Hide(); // or this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string input = txtUsernameOrEmail.Text.Trim();
            string pin = txtPIN.Text.Trim();

            // Step 1: Check checkbox for Terms and Conditions
            if (!chkAgree.Checked)
            {
                MessageBox.Show("You must accept the Terms and Conditions before continuing.",
                    "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 2: Basic validation
            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(pin))
            {
                MessageBox.Show("Please enter both username/email and PIN.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnector.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "SELECT UserId, Username, Email, PasswordHash, PasswordSalt, IsActive FROM Users " +
                        "WHERE Username=@Input OR Email=@Input", conn);
                    cmd.Parameters.AddWithValue("@Input", input);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        byte[] hash = (byte[])reader["PasswordHash"];
                        byte[] salt = (byte[])reader["PasswordSalt"];
                        bool isActive = Convert.ToBoolean(reader["IsActive"]);

                        if (!isActive)
                        {
                            MessageBox.Show("Your account is not activated. Please activate before logging in.",
                                "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            reader.Close();
                            return;
                        }

                        if (VerifyPassword(pin, hash, salt))
                        {
                            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmDashboard dashboard = new frmDashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid PIN. Please try again.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found. Please check your username or email.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        // 🧩 Verify password using hashing
        private bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, storedSalt, 10000))
            {
                byte[] newKey = deriveBytes.GetBytes(storedHash.Length);
                return StructuralComparisons.StructuralEqualityComparer.Equals(newKey, storedHash);
            }
        }

        // 🟦 Go to Register form
        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        // 🟧 Go to Forgot Password form
        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLoginCreateNewPassword forgot = new frmLoginCreateNewPassword();
            forgot.Show();
            this.Hide();
        }
    }
}
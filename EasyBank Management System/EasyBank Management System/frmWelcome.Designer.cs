namespace EasyBank_Management_System
{
    partial class frmWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateANewAccount = new System.Windows.Forms.Button();
            this.btnActivateAccount = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to EasyBank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(596, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label2.Size = new System.Drawing.Size(314, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "The first commerical bank in Cambodia";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(581, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(310, 49);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateANewAccount
            // 
            this.btnCreateANewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateANewAccount.Location = new System.Drawing.Point(583, 227);
            this.btnCreateANewAccount.Name = "btnCreateANewAccount";
            this.btnCreateANewAccount.Size = new System.Drawing.Size(310, 49);
            this.btnCreateANewAccount.TabIndex = 4;
            this.btnCreateANewAccount.Text = "Create a new account";
            this.btnCreateANewAccount.UseVisualStyleBackColor = true;
            this.btnCreateANewAccount.Click += new System.EventHandler(this.btnCreateANewAccount_Click);
            // 
            // btnActivateAccount
            // 
            this.btnActivateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateAccount.Location = new System.Drawing.Point(583, 301);
            this.btnActivateAccount.Name = "btnActivateAccount";
            this.btnActivateAccount.Size = new System.Drawing.Size(310, 49);
            this.btnActivateAccount.TabIndex = 5;
            this.btnActivateAccount.Text = "Activate account";
            this.btnActivateAccount.UseVisualStyleBackColor = true;
            this.btnActivateAccount.Click += new System.EventHandler(this.btnActivateAccount_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(583, 370);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel2.Location = new System.Drawing.Point(819, 370);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 17);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Contact Us";
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 459);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnActivateAccount);
            this.Controls.Add(this.btnCreateANewAccount);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to EasyBank";
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateANewAccount;
        private System.Windows.Forms.Button btnActivateAccount;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
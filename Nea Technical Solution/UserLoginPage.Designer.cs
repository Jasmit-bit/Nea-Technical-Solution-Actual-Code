namespace Nea_Technical_Solution
{
    partial class UserLoginPage
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
            this.Login = new System.Windows.Forms.Button();
            this.CreateAccount = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(879, 238);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(187, 91);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // CreateAccount
            // 
            this.CreateAccount.Location = new System.Drawing.Point(879, 443);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(187, 91);
            this.CreateAccount.TabIndex = 1;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.UseVisualStyleBackColor = true;
            this.CreateAccount.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 907);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 58);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(671, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please login or register to proceed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1813, 878);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.Login);
            this.Name = "UserLoginPage";
            this.Text = "UserLoginPage";
            this.Load += new System.EventHandler(this.UserLoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
    }
}
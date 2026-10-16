namespace Nea_Technical_Solution
{
    partial class SignInPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.GroupBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserIDBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.UnstarPassword = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(919, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.UnstarPassword);
            this.Box.Controls.Add(this.PasswordBox);
            this.Box.Controls.Add(this.UserIDBox);
            this.Box.Controls.Add(this.label5);
            this.Box.Controls.Add(this.label2);
            this.Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box.Location = new System.Drawing.Point(691, 230);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(543, 352);
            this.Box.TabIndex = 1;
            this.Box.TabStop = false;
            this.Box.Text = "Log In Below";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(276, 234);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(148, 31);
            this.PasswordBox.TabIndex = 7;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // UserIDBox
            // 
            this.UserIDBox.Location = new System.Drawing.Point(276, 113);
            this.UserIDBox.Name = "UserIDBox";
            this.UserIDBox.Size = new System.Drawing.Size(148, 31);
            this.UserIDBox.TabIndex = 6;
            this.UserIDBox.TextChanged += new System.EventHandler(this.UserIDBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserID";
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Lavender;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(930, 635);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(121, 57);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "Log In";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // UnstarPassword
            // 
            this.UnstarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UnstarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnstarPassword.Location = new System.Drawing.Point(276, 280);
            this.UnstarPassword.Name = "UnstarPassword";
            this.UnstarPassword.Size = new System.Drawing.Size(148, 40);
            this.UnstarPassword.TabIndex = 3;
            this.UnstarPassword.Text = "Show Password";
            this.UnstarPassword.UseVisualStyleBackColor = false;
            this.UnstarPassword.Click += new System.EventHandler(this.UnstarPassword_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 921);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 38);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SignInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.label1);
            this.Name = "SignInPage";
            this.Text = "SignInPage";
            this.Load += new System.EventHandler(this.SignInPage_Load);
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserIDBox;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button UnstarPassword;
        private System.Windows.Forms.Button ExitButton;
    }
}
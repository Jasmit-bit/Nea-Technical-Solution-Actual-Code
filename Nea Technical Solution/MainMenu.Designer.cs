namespace Nea_Technical_Solution
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Tutorial = new System.Windows.Forms.Button();
            this.PastPaper = new System.Windows.Forms.Button();
            this.TestingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Further Maths Algorithm Assister";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Exit.Location = new System.Drawing.Point(3, 505);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(189, 67);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit Program";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Tutorial
            // 
            this.Tutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Tutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tutorial.Location = new System.Drawing.Point(604, 170);
            this.Tutorial.Name = "Tutorial";
            this.Tutorial.Size = new System.Drawing.Size(197, 85);
            this.Tutorial.TabIndex = 8;
            this.Tutorial.Text = "View Tutorials";
            this.Tutorial.UseVisualStyleBackColor = false;
            this.Tutorial.Click += new System.EventHandler(this.Tutorial_Click);
            // 
            // PastPaper
            // 
            this.PastPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PastPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastPaper.Location = new System.Drawing.Point(604, 320);
            this.PastPaper.Name = "PastPaper";
            this.PastPaper.Size = new System.Drawing.Size(197, 90);
            this.PastPaper.TabIndex = 9;
            this.PastPaper.Text = "Practice Past Paper Questions";
            this.PastPaper.UseVisualStyleBackColor = false;
            this.PastPaper.Click += new System.EventHandler(this.PastPaper_Click);
            // 
            // TestingButton
            // 
            this.TestingButton.BackColor = System.Drawing.Color.Transparent;
            this.TestingButton.Location = new System.Drawing.Point(3, 12);
            this.TestingButton.Name = "TestingButton";
            this.TestingButton.Size = new System.Drawing.Size(97, 30);
            this.TestingButton.TabIndex = 10;
            this.TestingButton.Text = "Testing\r\n \r\n             \r\n";
            this.TestingButton.UseVisualStyleBackColor = false;
            this.TestingButton.Click += new System.EventHandler(this.TestingButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1365, 629);
            this.Controls.Add(this.TestingButton);
            this.Controls.Add(this.PastPaper);
            this.Controls.Add(this.Tutorial);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Tutorial;
        private System.Windows.Forms.Button PastPaper;
        private System.Windows.Forms.Button TestingButton;
    }
}


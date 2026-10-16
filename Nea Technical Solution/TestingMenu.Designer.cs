namespace Nea_Technical_Solution
{
    partial class TestingMenu
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
            this.Vector1Box = new System.Windows.Forms.TextBox();
            this.Vector2Box = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TestPrimsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vector1Box
            // 
            this.Vector1Box.Location = new System.Drawing.Point(837, 198);
            this.Vector1Box.Multiline = true;
            this.Vector1Box.Name = "Vector1Box";
            this.Vector1Box.Size = new System.Drawing.Size(280, 59);
            this.Vector1Box.TabIndex = 0;
            // 
            // Vector2Box
            // 
            this.Vector2Box.Location = new System.Drawing.Point(837, 336);
            this.Vector2Box.Multiline = true;
            this.Vector2Box.Name = "Vector2Box";
            this.Vector2Box.Size = new System.Drawing.Size(280, 59);
            this.Vector2Box.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(903, 522);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(167, 43);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your first vector, separate each dimension by a comma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your second vector, separate each dimension by a comma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(830, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dot Product Calculator";
            // 
            // TestPrimsButton
            // 
            this.TestPrimsButton.Location = new System.Drawing.Point(45, 33);
            this.TestPrimsButton.Name = "TestPrimsButton";
            this.TestPrimsButton.Size = new System.Drawing.Size(147, 60);
            this.TestPrimsButton.TabIndex = 6;
            this.TestPrimsButton.Text = "Test Prims Algorithm";
            this.TestPrimsButton.UseVisualStyleBackColor = true;
            this.TestPrimsButton.Click += new System.EventHandler(this.TestPrimsButton_Click);
            // 
            // TestingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.TestPrimsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.Vector2Box);
            this.Controls.Add(this.Vector1Box);
            this.Name = "TestingMenu";
            this.Text = "TestingMenu";
            this.Load += new System.EventHandler(this.TestingMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Vector1Box;
        private System.Windows.Forms.TextBox Vector2Box;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TestPrimsButton;
    }
}
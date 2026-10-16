namespace Nea_Technical_Solution
{
    partial class GraphForRecommendedQuestion
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
            this.BoxToDrawIn = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxToDrawIn
            // 
            this.BoxToDrawIn.Location = new System.Drawing.Point(37, 66);
            this.BoxToDrawIn.Name = "BoxToDrawIn";
            this.BoxToDrawIn.Size = new System.Drawing.Size(1853, 784);
            this.BoxToDrawIn.TabIndex = 0;
            this.BoxToDrawIn.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxToDrawIn_Paint_1);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReturnButton.Location = new System.Drawing.Point(1606, 867);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(190, 67);
            this.ReturnButton.TabIndex = 13;
            this.ReturnButton.Text = "Return To Questions page";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Exit.Location = new System.Drawing.Point(25, 867);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 67);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GraphForRecommendedQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BoxToDrawIn);
            this.Name = "GraphForRecommendedQuestion";
            this.Text = "GraphForRecommendedQuestion";
            this.Load += new System.EventHandler(this.GraphForRecommendedQuestion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BoxToDrawIn;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button Exit;
    }
}
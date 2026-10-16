namespace Nea_Technical_Solution
{
    partial class GraphForRecommendedQuestions
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
            this.SuspendLayout();
            // 
            // BoxToDrawIn
            // 
            this.BoxToDrawIn.AutoScroll = true;
            this.BoxToDrawIn.Location = new System.Drawing.Point(12, 83);
            this.BoxToDrawIn.Name = "BoxToDrawIn";
            this.BoxToDrawIn.Size = new System.Drawing.Size(1853, 784);
            this.BoxToDrawIn.TabIndex = 11;
            this.BoxToDrawIn.Visible = false;
            this.BoxToDrawIn.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxToDrawIn_Paint);
            // 
            // GraphForRecommendedQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.BoxToDrawIn);
            this.Name = "GraphForRecommendedQuestions";
            this.Text = "GraphForRecommendedQuestions";
            this.Load += new System.EventHandler(this.GraphForRecommendedQuestions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BoxToDrawIn;
    }
}
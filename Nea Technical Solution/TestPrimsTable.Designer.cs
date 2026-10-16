namespace Nea_Technical_Solution
{
    partial class TestPrimsTable
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
            this.AdjacencyMatrix = new System.Windows.Forms.DataGridView();
            this.ShwAnsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // AdjacencyMatrix
            // 
            this.AdjacencyMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjacencyMatrix.Location = new System.Drawing.Point(60, 79);
            this.AdjacencyMatrix.Name = "AdjacencyMatrix";
            this.AdjacencyMatrix.Size = new System.Drawing.Size(1689, 789);
            this.AdjacencyMatrix.TabIndex = 10;
            this.AdjacencyMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdjacencyMatrix_CellContentClick);
            // 
            // ShwAnsButton
            // 
            this.ShwAnsButton.Location = new System.Drawing.Point(22, 21);
            this.ShwAnsButton.Name = "ShwAnsButton";
            this.ShwAnsButton.Size = new System.Drawing.Size(123, 39);
            this.ShwAnsButton.TabIndex = 11;
            this.ShwAnsButton.Text = "Show Answer";
            this.ShwAnsButton.UseVisualStyleBackColor = true;
            this.ShwAnsButton.Click += new System.EventHandler(this.ShwAnsButton_Click);
            // 
            // TestPrimsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.ShwAnsButton);
            this.Controls.Add(this.AdjacencyMatrix);
            this.Name = "TestPrimsTable";
            this.Text = "TestPrimsTable";
            this.Load += new System.EventHandler(this.TestPrimsTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdjacencyMatrix;
        private System.Windows.Forms.Button ShwAnsButton;
    }
}
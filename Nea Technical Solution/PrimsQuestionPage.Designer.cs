namespace Nea_Technical_Solution
{
    partial class PrimsQuestionPage
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
            this.ShowQstButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // AdjacencyMatrix
            // 
            this.AdjacencyMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjacencyMatrix.Location = new System.Drawing.Point(107, 74);
            this.AdjacencyMatrix.Name = "AdjacencyMatrix";
            this.AdjacencyMatrix.Size = new System.Drawing.Size(1689, 789);
            this.AdjacencyMatrix.TabIndex = 9;
            this.AdjacencyMatrix.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdjacencyMatrix_CellContentClick);
            // 
            // ShowQstButton
            // 
            this.ShowQstButton.Location = new System.Drawing.Point(12, 12);
            this.ShowQstButton.Name = "ShowQstButton";
            this.ShowQstButton.Size = new System.Drawing.Size(110, 56);
            this.ShowQstButton.TabIndex = 10;
            this.ShowQstButton.Text = "Show Question";
            this.ShowQstButton.UseVisualStyleBackColor = true;
            this.ShowQstButton.Click += new System.EventHandler(this.ShowQstButton_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Exit.Location = new System.Drawing.Point(12, 869);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 67);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainMenu.Location = new System.Drawing.Point(1606, 869);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(190, 67);
            this.MainMenu.TabIndex = 13;
            this.MainMenu.Text = "Return To Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // PrimsQuestionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowQstButton);
            this.Controls.Add(this.AdjacencyMatrix);
            this.Name = "PrimsQuestionPage";
            this.Text = "PrimsQuestionPage";
            this.Load += new System.EventHandler(this.PrimsQuestionPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdjacencyMatrix;
        private System.Windows.Forms.Button ShowQstButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MainMenu;
    }
}
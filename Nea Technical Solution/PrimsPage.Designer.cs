namespace Nea_Technical_Solution
{
    partial class PrimsPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.AdjacencyMatrix = new System.Windows.Forms.DataGridView();
            this.RunPrims = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(775, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prim\'s Algorithm from table";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(3, 925);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(170, 64);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit Program";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(1738, 925);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(168, 64);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "Return to Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // AdjacencyMatrix
            // 
            this.AdjacencyMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjacencyMatrix.Location = new System.Drawing.Point(3, 103);
            this.AdjacencyMatrix.Name = "AdjacencyMatrix";
            this.AdjacencyMatrix.Size = new System.Drawing.Size(1903, 816);
            this.AdjacencyMatrix.TabIndex = 8;
            // 
            // RunPrims
            // 
            this.RunPrims.BackColor = System.Drawing.Color.Black;
            this.RunPrims.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunPrims.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RunPrims.Location = new System.Drawing.Point(12, 23);
            this.RunPrims.Name = "RunPrims";
            this.RunPrims.Size = new System.Drawing.Size(192, 74);
            this.RunPrims.TabIndex = 9;
            this.RunPrims.Text = "Run Algorithm";
            this.RunPrims.UseVisualStyleBackColor = false;
            this.RunPrims.Click += new System.EventHandler(this.RunPrims_Click);
            // 
            // PrimsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1918, 1015);
            this.Controls.Add(this.RunPrims);
            this.Controls.Add(this.AdjacencyMatrix);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Name = "PrimsPage";
            this.Text = "PrimsPage";
            this.Load += new System.EventHandler(this.PrimsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdjacencyMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.DataGridView AdjacencyMatrix;
        private System.Windows.Forms.Button RunPrims;
    }
}
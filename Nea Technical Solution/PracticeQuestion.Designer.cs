namespace Nea_Technical_Solution
{
    partial class PracticeQuestion
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
            this.Exit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Djikstra = new System.Windows.Forms.Button();
            this.Prims = new System.Windows.Forms.Button();
            this.Kruskal = new System.Windows.Forms.Button();
            this.Recommend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit.Location = new System.Drawing.Point(12, 645);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(161, 64);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit Program";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.DeepPink;
            this.MainMenu.Location = new System.Drawing.Point(1141, 645);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(161, 64);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "Return to Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1143, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Algorithm Which you want to practice questions for :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Djikstra
            // 
            this.Djikstra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Djikstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Djikstra.Location = new System.Drawing.Point(529, 191);
            this.Djikstra.Name = "Djikstra";
            this.Djikstra.Size = new System.Drawing.Size(231, 66);
            this.Djikstra.TabIndex = 5;
            this.Djikstra.Text = "Djikstra\'s Algorithm";
            this.Djikstra.UseVisualStyleBackColor = false;
            this.Djikstra.Click += new System.EventHandler(this.Djikstra_Click);
            // 
            // Prims
            // 
            this.Prims.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Prims.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prims.Location = new System.Drawing.Point(529, 322);
            this.Prims.Name = "Prims";
            this.Prims.Size = new System.Drawing.Size(231, 69);
            this.Prims.TabIndex = 6;
            this.Prims.Text = "Prim\'s Algorithm (table)";
            this.Prims.UseVisualStyleBackColor = false;
            this.Prims.Click += new System.EventHandler(this.Prims_Click);
            // 
            // Kruskal
            // 
            this.Kruskal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kruskal.Location = new System.Drawing.Point(529, 454);
            this.Kruskal.Name = "Kruskal";
            this.Kruskal.Size = new System.Drawing.Size(231, 69);
            this.Kruskal.TabIndex = 7;
            this.Kruskal.Text = "Kruskal\'s Algorithm";
            this.Kruskal.UseVisualStyleBackColor = false;
            this.Kruskal.Click += new System.EventHandler(this.Kruskal_Click);
            // 
            // Recommend
            // 
            this.Recommend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Recommend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recommend.Location = new System.Drawing.Point(529, 629);
            this.Recommend.Name = "Recommend";
            this.Recommend.Size = new System.Drawing.Size(231, 69);
            this.Recommend.TabIndex = 8;
            this.Recommend.Text = "Recommend Me A Question ";
            this.Recommend.UseVisualStyleBackColor = false;
            this.Recommend.Click += new System.EventHandler(this.Recommend_Click);
            // 
            // PracticeQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1314, 721);
            this.Controls.Add(this.Recommend);
            this.Controls.Add(this.Kruskal);
            this.Controls.Add(this.Prims);
            this.Controls.Add(this.Djikstra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Exit);
            this.Name = "PracticeQuestion";
            this.Text = "PracticeQuestion";
            this.Load += new System.EventHandler(this.PracticeQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Djikstra;
        private System.Windows.Forms.Button Prims;
        private System.Windows.Forms.Button Kruskal;
        private System.Windows.Forms.Button Recommend;
    }
}
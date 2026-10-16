namespace Nea_Technical_Solution
{
    partial class TutorialsPage
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
            this.Prims = new System.Windows.Forms.Button();
            this.Kruskal = new System.Windows.Forms.Button();
            this.Djikstra = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a tutorial";
            // 
            // Prims
            // 
            this.Prims.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Prims.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prims.Location = new System.Drawing.Point(654, 270);
            this.Prims.Name = "Prims";
            this.Prims.Size = new System.Drawing.Size(231, 69);
            this.Prims.TabIndex = 2;
            this.Prims.Text = "Prim\'s Algorithm (table)";
            this.Prims.UseVisualStyleBackColor = false;
            this.Prims.Click += new System.EventHandler(this.Prims_Click);
            // 
            // Kruskal
            // 
            this.Kruskal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kruskal.Location = new System.Drawing.Point(654, 410);
            this.Kruskal.Name = "Kruskal";
            this.Kruskal.Size = new System.Drawing.Size(231, 69);
            this.Kruskal.TabIndex = 3;
            this.Kruskal.Text = "Kruskal\'s Algorithm";
            this.Kruskal.UseVisualStyleBackColor = false;
            this.Kruskal.Click += new System.EventHandler(this.Kruskal_Click);
            // 
            // Djikstra
            // 
            this.Djikstra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Djikstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Djikstra.Location = new System.Drawing.Point(654, 140);
            this.Djikstra.Name = "Djikstra";
            this.Djikstra.Size = new System.Drawing.Size(231, 66);
            this.Djikstra.TabIndex = 4;
            this.Djikstra.Text = "Djikstra\'s Algorithm";
            this.Djikstra.UseVisualStyleBackColor = false;
            this.Djikstra.Click += new System.EventHandler(this.Djikstra_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Exit.Location = new System.Drawing.Point(12, 601);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 67);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainMenu.Location = new System.Drawing.Point(1345, 601);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(190, 67);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "Return To Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // TutorialsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1547, 680);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Djikstra);
            this.Controls.Add(this.Kruskal);
            this.Controls.Add(this.Prims);
            this.Controls.Add(this.label1);
            this.Name = "TutorialsPage";
            this.Text = "Tutorials";
            this.Load += new System.EventHandler(this.TutorialsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Prims;
        private System.Windows.Forms.Button Kruskal;
        private System.Windows.Forms.Button Djikstra;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MainMenu;
    }
}
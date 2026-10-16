namespace Nea_Technical_Solution
{
    partial class DjikstrasPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.BoxToDrawIn = new System.Windows.Forms.Panel();
            this.FindPath = new System.Windows.Forms.Button();
            this.GenerateNewGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Exit.Location = new System.Drawing.Point(12, 907);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 67);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(794, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Djikstra\'s Algorithm";
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainMenu.Location = new System.Drawing.Point(1654, 907);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(190, 67);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Return To Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // BoxToDrawIn
            // 
            this.BoxToDrawIn.AutoScroll = true;
            this.BoxToDrawIn.Location = new System.Drawing.Point(27, 99);
            this.BoxToDrawIn.Name = "BoxToDrawIn";
            this.BoxToDrawIn.Size = new System.Drawing.Size(1853, 784);
            this.BoxToDrawIn.TabIndex = 5;
            this.BoxToDrawIn.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxToDrawIn_Paint);
            // 
            // FindPath
            // 
            this.FindPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FindPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindPath.Location = new System.Drawing.Point(46, 12);
            this.FindPath.Name = "FindPath";
            this.FindPath.Size = new System.Drawing.Size(179, 70);
            this.FindPath.TabIndex = 0;
            this.FindPath.Text = "Find Shortest Path";
            this.FindPath.UseVisualStyleBackColor = false;
            this.FindPath.Click += new System.EventHandler(this.FindPath_Click);
            // 
            // GenerateNewGraph
            // 
            this.GenerateNewGraph.BackColor = System.Drawing.Color.MediumAquamarine;
            this.GenerateNewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateNewGraph.Location = new System.Drawing.Point(1554, 19);
            this.GenerateNewGraph.Name = "GenerateNewGraph";
            this.GenerateNewGraph.Size = new System.Drawing.Size(229, 74);
            this.GenerateNewGraph.TabIndex = 6;
            this.GenerateNewGraph.Text = "Generate New Graph";
            this.GenerateNewGraph.UseVisualStyleBackColor = false;
            this.GenerateNewGraph.Click += new System.EventHandler(this.GenerateNewGraph_Click);
            // 
            // DjikstrasPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.GenerateNewGraph);
            this.Controls.Add(this.FindPath);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BoxToDrawIn);
            this.Name = "DjikstrasPage";
            this.Text = "Djisktra\'s Page";
            this.Load += new System.EventHandler(this.DjikstrasPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Panel BoxToDrawIn;
        private System.Windows.Forms.Button FindPath;
        private System.Windows.Forms.Button GenerateNewGraph;
    }
}
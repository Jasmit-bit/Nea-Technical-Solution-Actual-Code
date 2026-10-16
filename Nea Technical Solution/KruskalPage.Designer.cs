namespace Nea_Technical_Solution
{
    partial class KruskalPage
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
            this.BoxToDrawIn = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.NewGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(21, 930);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(170, 64);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit Program";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(1733, 930);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(168, 64);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "Return to Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(760, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kruskal\'s Algorithm";
            // 
            // BoxToDrawIn
            // 
            this.BoxToDrawIn.AutoScroll = true;
            this.BoxToDrawIn.Location = new System.Drawing.Point(30, 111);
            this.BoxToDrawIn.Name = "BoxToDrawIn";
            this.BoxToDrawIn.Size = new System.Drawing.Size(1853, 784);
            this.BoxToDrawIn.TabIndex = 6;
            this.BoxToDrawIn.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxToDrawIn_Paint);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(40, 22);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(201, 83);
            this.Start.TabIndex = 7;
            this.Start.Text = "Run Kruskal\'s Algorithm";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // NewGraph
            // 
            this.NewGraph.Location = new System.Drawing.Point(1577, 22);
            this.NewGraph.Name = "NewGraph";
            this.NewGraph.Size = new System.Drawing.Size(201, 83);
            this.NewGraph.TabIndex = 8;
            this.NewGraph.Text = "Generate New Graph";
            this.NewGraph.UseVisualStyleBackColor = true;
            this.NewGraph.Click += new System.EventHandler(this.NewGraph_Click);
            // 
            // KruskalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1913, 1006);
            this.Controls.Add(this.NewGraph);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.BoxToDrawIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Exit);
            this.Name = "KruskalPage";
            this.Text = "KruskalPage";
            this.Load += new System.EventHandler(this.KruskalPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BoxToDrawIn;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button NewGraph;
    }
}
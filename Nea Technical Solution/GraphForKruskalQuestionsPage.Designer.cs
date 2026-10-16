namespace Nea_Technical_Solution
{
    partial class GraphForKruskalQuestionsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForKruskalQuestionsPage));
            this.BoxToDrawIn = new System.Windows.Forms.Panel();
            this.ShowQstButton = new System.Windows.Forms.Button();
            this.ReDrawGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxToDrawIn
            // 
            this.BoxToDrawIn.AutoScroll = true;
            this.BoxToDrawIn.Location = new System.Drawing.Point(22, 157);
            this.BoxToDrawIn.Name = "BoxToDrawIn";
            this.BoxToDrawIn.Size = new System.Drawing.Size(1853, 784);
            this.BoxToDrawIn.TabIndex = 7;
            this.BoxToDrawIn.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxToDrawIn_Paint);
            // 
            // ShowQstButton
            // 
            this.ShowQstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ShowQstButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowQstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowQstButton.Location = new System.Drawing.Point(49, 36);
            this.ShowQstButton.Name = "ShowQstButton";
            this.ShowQstButton.Size = new System.Drawing.Size(184, 69);
            this.ShowQstButton.TabIndex = 8;
            this.ShowQstButton.Text = "Show The Questions";
            this.ShowQstButton.UseVisualStyleBackColor = false;
            this.ShowQstButton.Click += new System.EventHandler(this.ShowQstButton_Click);
            // 
            // ReDrawGraph
            // 
            this.ReDrawGraph.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReDrawGraph.Location = new System.Drawing.Point(1624, 36);
            this.ReDrawGraph.Name = "ReDrawGraph";
            this.ReDrawGraph.Size = new System.Drawing.Size(178, 60);
            this.ReDrawGraph.TabIndex = 9;
            this.ReDrawGraph.Text = "Make a new graph";
            this.ReDrawGraph.UseVisualStyleBackColor = false;
            this.ReDrawGraph.Click += new System.EventHandler(this.ReDrawGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(703, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Practice Kruskal\'s Algorithm!";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Exit.Location = new System.Drawing.Point(0, 947);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(190, 67);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainMenu.Location = new System.Drawing.Point(1711, 947);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(190, 67);
            this.MainMenu.TabIndex = 12;
            this.MainMenu.Text = "Return To Main Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // GraphForKruskalQuestionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1913, 1006);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReDrawGraph);
            this.Controls.Add(this.ShowQstButton);
            this.Controls.Add(this.BoxToDrawIn);
            this.Name = "GraphForKruskalQuestionsPage";
            this.Text = "KruskalQuestionsPage";
            this.Load += new System.EventHandler(this.KruskalQuestionsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BoxToDrawIn;
        private System.Windows.Forms.Button ShowQstButton;
        private System.Windows.Forms.Button ReDrawGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button MainMenu;
    }
}
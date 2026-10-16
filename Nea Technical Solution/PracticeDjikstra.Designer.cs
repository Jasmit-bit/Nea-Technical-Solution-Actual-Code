namespace Nea_Technical_Solution
{
    partial class PracticeDjikstra
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ViewGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxToDrawIn = new System.Windows.Forms.Panel();
            this.ReDraw = new System.Windows.Forms.Button();
            this.ShowQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.DeepPink;
            this.MainMenu.Location = new System.Drawing.Point(1755, 918);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(161, 64);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Return to Menu";
            this.MainMenu.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Exit.Location = new System.Drawing.Point(12, 918);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(189, 67);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit Program";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ViewGraph
            // 
            this.ViewGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ViewGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ViewGraph.Location = new System.Drawing.Point(1746, 12);
            this.ViewGraph.Name = "ViewGraph";
            this.ViewGraph.Size = new System.Drawing.Size(189, 67);
            this.ViewGraph.TabIndex = 8;
            this.ViewGraph.Text = "View Graph";
            this.ViewGraph.UseVisualStyleBackColor = false;
            this.ViewGraph.Click += new System.EventHandler(this.ViewGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Practice Djikstras";
            // 
            // BoxToDrawIn
            // 
            this.BoxToDrawIn.AutoScroll = true;
            this.BoxToDrawIn.Location = new System.Drawing.Point(-22, 81);
            this.BoxToDrawIn.Name = "BoxToDrawIn";
            this.BoxToDrawIn.Size = new System.Drawing.Size(1853, 784);
            this.BoxToDrawIn.TabIndex = 10;
            this.BoxToDrawIn.Visible = false;
            this.BoxToDrawIn.Paint += new System.Windows.Forms.PaintEventHandler(this.BoxToDrawIn_Paint);
            // 
            // ReDraw
            // 
            this.ReDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReDraw.Location = new System.Drawing.Point(6, 12);
            this.ReDraw.Name = "ReDraw";
            this.ReDraw.Size = new System.Drawing.Size(218, 63);
            this.ReDraw.TabIndex = 11;
            this.ReDraw.Text = "If the weights overlaps/you find it complicated press here to redraw";
            this.ReDraw.UseVisualStyleBackColor = true;
            this.ReDraw.Click += new System.EventHandler(this.ReDraw_Click);
            // 
            // ShowQuestions
            // 
            this.ShowQuestions.Location = new System.Drawing.Point(840, 880);
            this.ShowQuestions.Name = "ShowQuestions";
            this.ShowQuestions.Size = new System.Drawing.Size(154, 54);
            this.ShowQuestions.TabIndex = 13;
            this.ShowQuestions.Text = "Show Questions";
            this.ShowQuestions.UseVisualStyleBackColor = true;
            this.ShowQuestions.Click += new System.EventHandler(this.ShowQuestions_Click);
            // 
            // PracticeDjikstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1808, 946);
            this.Controls.Add(this.ShowQuestions);
            this.Controls.Add(this.ReDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewGraph);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.BoxToDrawIn);
            this.Name = "PracticeDjikstra";
            this.Text = "PracticeDjikstra";
            this.Load += new System.EventHandler(this.PracticeDjikstra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ViewGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BoxToDrawIn;
        private System.Windows.Forms.Button ReDraw;
        private System.Windows.Forms.Button ShowQuestions;
    }
}
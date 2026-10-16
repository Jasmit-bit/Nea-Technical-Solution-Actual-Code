using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class PracticeQuestion : Form
    {
        public PracticeQuestion()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.menu.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Djikstra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.DjikstraQuestions.Show();
            
        }

        private void Recommend_Click(object sender, EventArgs e)
        {
            Forms.RecQs.Show();
            this.Hide();
        }

        private void PracticeQuestion_Load(object sender, EventArgs e)
        {

        }

        private void Prims_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Prims.Show();
        }

        private void Kruskal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.KruskalsQuestionsGraph.Show();  
        }
    }
}

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
    public partial class TutorialsPage : Form
    {
        public TutorialsPage()
        {
            InitializeComponent();
        }

       

        private void Kruskal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph.InitialiseGraph();
            Forms.kruskal.Show();
        }

        private void Prims_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.prims.Show();
        }

        private void Djikstra_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph.InitialiseGraph();
            Forms.djikstra.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.menu.Show();
        }

        private void TutorialsPage_Load(object sender, EventArgs e)
        {

        }
    }
}

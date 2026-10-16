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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        

        

        

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PastPaper_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.recommendeQuestion.Show();
        }

        private void Tutorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.tutorials.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void TestingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.TestingMenu.Show();
        }
    }
}

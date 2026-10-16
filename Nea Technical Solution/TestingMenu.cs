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
    public partial class TestingMenu : Form
    {
        public TestingMenu()
        {
            InitializeComponent();
        }

        private void TestingMenu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int x1Dimension = int.Parse(Vector1Box.Text.Split(',')[0]);
            int y1Dimension = int.Parse(Vector1Box.Text.Split(',')[1]);
            int z1Dimension = int.Parse(Vector1Box.Text.Split(',')[2]);
            int x2Dimension = int.Parse(Vector2Box.Text.Split(',')[0]);
            int y2Dimension = int.Parse(Vector2Box.Text.Split(',')[1]);
            int z2Dimension = int.Parse(Vector2Box.Text.Split(',')[2]);

            int dotProduct = (x1Dimension*x2Dimension)+(y1Dimension*y2Dimension)+(z1Dimension*z2Dimension);
            MessageBox.Show("The dot product is " + dotProduct);

        }

        private void TestPrimsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.TestingPrims.Show();
        }
    }
}

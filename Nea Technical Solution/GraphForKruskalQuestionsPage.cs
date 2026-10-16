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
    public partial class GraphForKruskalQuestionsPage : Form
    {
        public GraphForKruskalQuestionsPage()
        {
            InitializeComponent();
        }
        private struct CoOrdinate// structure which holds the locations on where to show the node on screen
        {
            public int Xcoordinate, Ycoordinate;
        }
        private CoOrdinate[] MakeLocations()
        {
            CoOrdinate[] coOrdinates = new CoOrdinate[7];
            coOrdinates[0].Xcoordinate = 600;
            coOrdinates[0].Ycoordinate = 0;

            coOrdinates[1].Xcoordinate = 1000;
            coOrdinates[1].Ycoordinate = 0;

            coOrdinates[2].Xcoordinate = 200;
            coOrdinates[2].Ycoordinate = 300;

            coOrdinates[3].Xcoordinate = 1400;
            coOrdinates[3].Ycoordinate = 300;


            coOrdinates[4].Xcoordinate = 600;
            coOrdinates[4].Ycoordinate = 600;


            coOrdinates[5].Xcoordinate = 1000;
            coOrdinates[5].Ycoordinate = 600;


            coOrdinates[6].Xcoordinate = 800;
            coOrdinates[6].Ycoordinate = 425;

            return coOrdinates;




        }

        private void BoxToDrawIn_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            Pen PentoDrawCircles = new Pen(Color.Black);
            Brush BrushToColourCircle = new SolidBrush(Color.Black);

            int NumberOfNodesInGraph = Graph.NodesInGraph.Count;

            int Diameter = 100;// Diameter of the nodes
            CoOrdinate[] coordinates = MakeLocations(); // retrieves a set of location of nodes that follow a similar approach to further maths questions

            for (int i = 0; i < NumberOfNodesInGraph; i++)
            {
                g.DrawEllipse(PentoDrawCircles, coordinates[i].Xcoordinate, coordinates[i].Ycoordinate, Diameter, Diameter); // draws the node by retrieving at the retrieved location
                Graph.NodesInGraph[i].XCoOrdinate = coordinates[i].Xcoordinate; // stores the x value at which the node is drawn at  
                Graph.NodesInGraph[i].YCoOrdinate = coordinates[i].Ycoordinate; // does the same for the y axis 
                g.FillEllipse(BrushToColourCircle, coordinates[i].Xcoordinate, coordinates[i].Ycoordinate, Diameter, Diameter); // colours it in 
                g.DrawString(Graph.NodesInGraph[i].name, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.White, (float)(coordinates[i].Xcoordinate + 15), (float)(coordinates[i].Ycoordinate + 40));
                // enters the name inside the circle 

            }
           
                foreach (Arc arc in Graph.ArcsInGraph)
                {
                    Node node1 = arc.nodesConnected[0]; // getting both the nodes so that I can access the coordinates where they are stored
                    Node node2 = arc.nodesConnected[1];
                    g.DrawLine(PentoDrawCircles, new Point(node1.XCoOrdinate + 50, node1.YCoOrdinate + 70), new Point(node2.XCoOrdinate + 50, node2.YCoOrdinate + 70));
                    int midpointX = (node1.XCoOrdinate + node2.XCoOrdinate) / 2; // I work out the midpoint between each node so that I can work out where to place the name of the arc
                    int midpointY = (node1.YCoOrdinate + node2.YCoOrdinate) / 2;
                    int XAdjustmentValue = 33;// I have made these so that I can adjust the location of where the names go if there are any collisons
                    int YAdjustmentValue = 53;
                    g.DrawString(arc.Weight.ToString(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.Purple, new Point(midpointX + XAdjustmentValue, midpointY + YAdjustmentValue));
                }
            
            




        }

        private void KruskalQuestionsPage_Load(object sender, EventArgs e)
        {
        }

        private void ShowQstButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.KruskalQuestionsPage.Show();
            
        }

        private void ReDrawGraph_Click(object sender, EventArgs e)
        {
            Graph.InitialiseGraph();
            BoxToDrawIn.Refresh();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.recommendeQuestion.Show();
        }
    }
}

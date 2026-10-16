using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class DjikstrasPage : Form
    {

        private ComboBox startNode = null;
        private ComboBox endNode = null;
        private bool RunDjikstras;
        private bool repeat = false;
        private GroupBox CurrentGroupbox = null;
        public DjikstrasPage()
        {
            InitializeComponent();
            RunDjikstras = false;
        }

        private void DjikstrasPage_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;

            MakeNewGraph();
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
        private void MakeNewGraph()
        {
            Graph.InitialiseGraph();

        }

        private void FindShortestPath(Node StartingNode, Node FinishNode) // calls the function which applies djikstra's algorithm

        {
           Graph.FindShortestPath(StartingNode, FinishNode);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            RunDjikstras = false;
            Forms.menu.Show();
            
        }

        private void BoxToDrawIn_Paint(object sender, PaintEventArgs e) // resposnible for drawing the graph 
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
            int totalWeight = 0;
            bool firstArc = true;
            if (RunDjikstras == true) 
            {
                foreach (Arc arc in Djikstra.orderOfArcs)
                {
                    totalWeight += arc.Weight;
                    Node node1 = arc.nodesConnected[0]; // getting both the nodes so that I can access the coordinates where they are stored
                    Node node2 = arc.nodesConnected[1];
                    if (firstArc == true)
                    {
                        MessageBox.Show($"The smallest arc from the starting node is the one connecting {node1.name} and {node2.name} as it has the weight of {arc.Weight},  please press ok when  you have caught up to continue ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // stops doing anything until student has caught up
                        firstArc = false;
                    }
                    else
                    {
                    MessageBox.Show($"The next smallest arc distance that doesn't create a cycle is the one connecting {node1.name} and {node2.name} as it has the weight of {arc.Weight}, please press ok when  you have caught up to continue ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); // stops doing anything until student has caught up

                    }

                    
                    g.DrawLine(PentoDrawCircles, new Point(node1.XCoOrdinate + 50, node1.YCoOrdinate + 70), new Point(node2.XCoOrdinate + 50, node2.YCoOrdinate + 70));
                    int midpointX = (node1.XCoOrdinate + node2.XCoOrdinate) /2; // I work out the midpoint between each node so that I can work out where to place the name of the arc
                    int midpointY = (node1.YCoOrdinate + node2.YCoOrdinate) /2;
                    int XAdjustmentValue = 85;// I have made these so that I can adjust the location of where the names go if there are any collisons
                    int YAdjustmentValue = 80;
                    g.DrawString(arc.Weight.ToString(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.Purple, new Point(midpointX+ XAdjustmentValue, midpointY + YAdjustmentValue));
                    System.Threading.Thread.Sleep(1200);

                }
                MessageBox.Show($"We have now reached the finish node and this is our complete graph, if we add up the weight of each arc we are left with {totalWeight} miles - the shortest distance to get from our start node to our finish node"); // conclusion for the  
                MessageBox.Show("If you want to have a go by yourself without the help of the tutorial click find shortest path and click return to graph", "Tip",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Djikstra.Clear(); // by doing this the user can return to the main menu and when they return they will be presented with the original graph not the shortest distance one
            }
            else
            {
                foreach (Arc arc in Graph.ArcsInGraph)
                {
                    Node node1 = arc.nodesConnected[0]; // getting both the nodes so that I can access the coordinates where they are stored
                    Node node2 = arc.nodesConnected[1];
                    g.DrawLine(PentoDrawCircles, new Point(node1.XCoOrdinate + 50, node1.YCoOrdinate + 70), new Point(node2.XCoOrdinate +50 , node2.YCoOrdinate + 70));
                    int midpointX = (node1.XCoOrdinate + node2.XCoOrdinate) / 2; // I work out the midpoint between each node so that I can work out where to place the name of the arc
                    int midpointY = (node1.YCoOrdinate + node2.YCoOrdinate) / 2;
                    int XAdjustmentValue = 33;// I have made these so that I can adjust the location of where the names go if there are any collisons
                    int YAdjustmentValue = 53;
                    g.DrawString(arc.Weight.ToString(), new Font(Font.FontFamily, Font.Size, FontStyle.Bold), Brushes.Purple, new Point(midpointX + XAdjustmentValue, midpointY + YAdjustmentValue));
                }
            }

        }
        public void PickStartAndPickEnd()
        {
            Button ViewGraph = new Button { Text = "Return To Graph", Height = 60, Width = 200, BackColor = Color.Red , ForeColor = Color.AliceBlue , Location = new Point(35,800)};
            this.Controls.Add(ViewGraph);
            ViewGraph.Click += ViewGraph_Click;
            FindPath.Visible = false; //hiding these buttons as I dont want user to accidentaly change their graph
            GenerateNewGraph.Visible = false;

            GroupBox SelectionMenu = new GroupBox(); // Creates a box to contain the text and drop down menu

            SelectionMenu.Name = "Selection Menu";
            SelectionMenu.BackColor = Color.White;
            SelectionMenu.Font = new Font(SelectionMenu.Font.FontFamily, 14, SelectionMenu.Font.Style);
            SelectionMenu.Text = "Pick Start and End Nodes";
            
            SelectionMenu.Location = new Point(750, 400);

            

            SelectionMenu.Height = 200;
            SelectionMenu.Width = 400;
            this.Controls.Add(SelectionMenu);
            BoxToDrawIn.Visible = false;// Have to hide the box to draw in as it would cover the selection menu 


            Label pickFirstNode = new Label { Text = "Start Node", Location = new Point(10, 40) };
            SelectionMenu.Controls.Add(pickFirstNode);


            ComboBox StartNodes = new ComboBox { Location = new Point(150, 40), Height = 10, Width = 170 };

            


            foreach (Node node in Graph.NodesInGraph)
            {
                StartNodes.Items.Add(node.name);
            }


            SelectionMenu.Controls.Add(StartNodes);


            ComboBox ListOfEndNode = new ComboBox { Location = new Point(150, 140), Height = 10, Width = 170 };



            foreach (Node node in Graph.NodesInGraph)
            {
                ListOfEndNode.Items.Add(node.name);
            }
            SelectionMenu.Controls.Add(ListOfEndNode);


            Label PickLastNode = new Label() { Text = "Finish Node", Location = new Point(10, 140) };
            SelectionMenu.Controls.Add(PickLastNode);
            // menu text finishes here

            Button Confirm = new Button { Text = "Confirm", Location = new Point(867, 700), BackColor = Color.White, Height = 60, Width = 200 };
            this.Controls.Add(Confirm);
            Confirm.Click += Confirm_Click;
            startNode = StartNodes; // assigns the values chosen in the combo box
            endNode = ListOfEndNode;
            CurrentGroupbox = SelectionMenu;
        }

        private void ViewGraph_Click(object sender, EventArgs e)
        {
            CurrentGroupbox.Hide();
            BoxToDrawIn.Show();
            GenerateNewGraph.Visible = true;
            FindPath.Visible = true;
        }

        private void Confirm_Click(object sender, EventArgs e) // what to do when the user clicks the confirm button after selecting the start and finish node
        {
            if (startNode.SelectedItem == null || endNode.SelectedItem == null)
            {
                MessageBox.Show("You didnt fill this out properly!");

            }
            else
            {
                CurrentGroupbox.Hide();
                Node BeginningNode = Graph.ConvertNameToNode(startNode.SelectedItem.ToString());
                Node FinishNode = Graph.ConvertNameToNode(endNode.SelectedItem.ToString());
                MessageBox.Show("Finding Shortest path between " + BeginningNode.name + " and " + FinishNode.name);
                FindShortestPath(BeginningNode, FinishNode);
                GenerateNewGraph.Visible = true;
                FindPath.Visible = true;
                BoxToDrawIn.Visible = true;
                RunDjikstras = true;
                BoxToDrawIn.Refresh();
                RunDjikstras = false;

            }


        }

        private void FindPath_Click(object sender, EventArgs e)
        {
            PickStartAndPickEnd();

        }

        private void GenerateNewGraph_Click(object sender, EventArgs e)
        {
           
            MakeNewGraph();
            BoxToDrawIn.Refresh();
            repeat = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

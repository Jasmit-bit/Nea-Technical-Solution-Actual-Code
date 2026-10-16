using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class PrimsPage : Form
    {
        const int NumOfNodes = 10; // I used a constant here, so if needed can change the complexity and size of graph
        int[,] ArcWeights = new int[NumOfNodes, NumOfNodes];

        public PrimsPage()
        {
            InitializeComponent();
            
            WindowState = FormWindowState.Maximized;
        }

        private void PrimsPage_Load(object sender, EventArgs e)
        {
            GenerateGraph();
            MessageBox.Show("Adjust the table to your liking you can change the sizes of the texts on the side");
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void GenerateGraph() // draws the adjacency matrix
        {



            Random rnd = new Random();

            for (int rows = 0; rows < NumOfNodes; rows++)
            {
                for (int columns = 0; columns < NumOfNodes; columns++)
                {
                    int arcWeight = 0;
                    if (rows == columns)
                    {
                        arcWeight = -1;// no arcs going to the same node so using -1 to represent this
                    }
                    else
                    {
                        arcWeight = rnd.Next(1, 101);
                    }
                    ArcWeights[rows, columns] = arcWeight;// makes sure graph is symmetrical 
                    ArcWeights[columns, rows] = arcWeight;
                }
            } // this creates a 2d array and populates it

            AdjacencyMatrix.RowCount = NumOfNodes;
            AdjacencyMatrix.ColumnCount = NumOfNodes;

            for (int rows = 0; rows < NumOfNodes; rows++)
            {
                for (int columns = 0; columns < NumOfNodes; columns++)
                {
                    AdjacencyMatrix.Rows[rows].Cells[columns].Value = ArcWeights[rows, columns];
                }
            }
            // this nested loop is populating the grid which is used to display the 2D array 

            for (int row = 0; row < NumOfNodes; row++)
            {
                for (int column = 0; column < NumOfNodes; column++)
                {
                    AdjacencyMatrix.Rows[row].Height = 85;
                    AdjacencyMatrix.Columns[column].Width = 180;
                }
            } // changing the sizes of the cells so that it looks good

            AddNamesOfCities(rnd);
            AdjacencyMatrix.ReadOnly = true;// you cant change the weights in the cells during run time if its read only so I made it read only
        }

        private void AddNamesOfCities(Random rnd) // Adds the names of cities along the top and side
        {
            List<string> NamesOfCities = new List<string>();
            string filename = "NameOfCities.txt";// add an error catching if the file doesnt exist
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string CityName = sr.ReadLine();
                    NamesOfCities.Add(CityName);
                }
            }
            for (int i = NamesOfCities.Count - 1; i > 0; i--) // just like words with aqa I am shuffling the way the cities are read so we have a new and different city name each time
            {
                int j = rnd.Next(0, i + 1);
                string temp = NamesOfCities[i];
                NamesOfCities[i] = NamesOfCities[j];
                NamesOfCities[j] = temp;
            }
            for (int i = 0; i < AdjacencyMatrix.RowCount; i++)
            {
                AdjacencyMatrix.Rows[i].HeaderCell.Value = NamesOfCities[i];
                AdjacencyMatrix.Columns[i].HeaderText = NamesOfCities[i];
            }

        }

        public struct CoordinateOfUsedWeights
        {
            public int x;
            public int y;
        }

        private bool ChecKIfCoOrdinateUsed(int xCoOrdinate, int YCordinate, List<CoordinateOfUsedWeights> CoOrdinates)
        {
            foreach(CoordinateOfUsedWeights cord in  CoOrdinates)
            {
                if (cord.x == xCoOrdinate && cord.y == YCordinate)
                {
                    return true;
                }
            }
            return false;
        } // this function checks if a weight has already been used preventing a loop from happening


        private void RunPrims_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We want to make sure that we dont create a loop when we first start out so we are immediately going to make sure we don't use the first row we can do this by making the weights -1", "Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int x = 0; x < 10; x++) // we want to make sure that we dont use the first row to prevent loops so I immediately set weights as -1
            {
                AdjacencyMatrix.Rows[0].Cells[x].Style.BackColor = Color.Magenta;
                AdjacencyMatrix.Rows[0].Cells[x].Value = -1;
            } // making sure there are no cycles

            


            int xValue = 0;// row
            int yValue = 0;// column 
            List<int> RowsToLookDownIn = new List<int>();
            List<CoordinateOfUsedWeights> listOfCoOrdinates = new List<CoordinateOfUsedWeights>();
            RowsToLookDownIn.Add(0);// we want to start in the first column so I add its index
            MessageBox.Show("We are going to start by looking down in " + AdjacencyMatrix.Rows[0].HeaderCell.Value);

            while (RowsToLookDownIn.Count < AdjacencyMatrix.Rows.Count)  // this loop applies the tabular form of prims algorithm, and finishes when all Nodes have been visited
            {
                
                int smallestValue = int.MaxValue;
                
                foreach (int x in RowsToLookDownIn)
                {
                    for (int y = 0; y < AdjacencyMatrix.RowCount; y++)
                    {
                        if (ArcWeights[x, y] > 0)
                        {
                            if (ChecKIfCoOrdinateUsed(x, y, listOfCoOrdinates) == false)
                            {
                                int weight = ArcWeights[x, y];


                                if (weight < smallestValue)
                                {
                                    smallestValue = weight;
                                    xValue = x;
                                    yValue = y;
                                }
                            }
                        }
                    }
                }
                    MessageBox.Show("The smallest weight we have in our current set of nodes being considered is " + smallestValue + " and it connects to " + AdjacencyMatrix.Rows[yValue].HeaderCell.Value);
                MessageBox.Show("To make sure that we don't loop around we are going to set all the other value to be negligible ( -1 Value)");
                if (!RowsToLookDownIn.Contains(yValue))
                {
                    MessageBox.Show("Because the smallest value we have selected was connecting to " + AdjacencyMatrix.Rows[yValue].HeaderCell.Value + " we are going to add that column into weights we are going to consider london");
                    RowsToLookDownIn.Add(yValue);
                }
                
                CoordinateOfUsedWeights newPoint = new CoordinateOfUsedWeights();
                newPoint.x = xValue;
                newPoint.y = yValue;
                listOfCoOrdinates.Add(newPoint); 
               
                
                for (int x = 0; x < NumOfNodes; x++)
                {
                    if (x == xValue && (int)AdjacencyMatrix.Rows[yValue].Cells[x].Value != -1)
                    {
                        AdjacencyMatrix.Rows[yValue].Cells[x].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        if (AdjacencyMatrix.Rows[yValue].Cells[x].Style.BackColor != Color.Red)
                        {
                            AdjacencyMatrix.Rows[yValue].Cells[x].Value = -1;

                            AdjacencyMatrix.Rows[yValue].Cells[x].Style.BackColor = Color.Yellow;
                        }

                        
                    }
                }
                AdjacencyMatrix.Invalidate();
                
            }
            
            
            
            int TotalWeight = 0;
            for (int y = 0; y < NumOfNodes; y++)
            {
                for (int x = 0; x < NumOfNodes; x++)
                {
                    if ((int)AdjacencyMatrix.Rows[x].Cells[y].Value != -1)
                    {
                        AdjacencyMatrix.Rows[x].Cells[y].Style.BackColor = Color.Green;
                        TotalWeight += (int)AdjacencyMatrix.Rows[x].Cells[y].Value;
                    }
                    else
                    {
                        AdjacencyMatrix.Rows[x].Cells[y].Style.BackColor = Color.Black;


                    }
                }
            } // at the end I want to only display weights which were used for this reason the weights used become green and not used become black
            MessageBox.Show("The green boxes indicate the arcs we have to take in order to end up with a minimum spanning tree, Our total weight of the minimum spanning tree is " + TotalWeight + "miles");






        }




    }
}


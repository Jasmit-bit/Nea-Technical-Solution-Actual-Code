using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class TestPrimsTable : Form
    {
        int NumOfNodes = 5;
        int[,] ArcWeights = new int[5, 5];

        public TestPrimsTable()
        {
            InitializeComponent();
        }

        private async void ShwAnsButton_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < NumOfNodes; x++) // we want to make sure that we dont use the first row to prevent loops so I immediately set weights as -1
            {
                AdjacencyMatrix.Rows[0].Cells[x].Style.BackColor = Color.Magenta;
                AdjacencyMatrix.Rows[0].Cells[x].Value = -1;
            }

            int xValue = 0;// row
            int yValue = 0;// column 
            List<int> RowsToLookDownIn = new List<int>();
            List<CoordinateOfUsedWeights> list = new List<CoordinateOfUsedWeights>();
            RowsToLookDownIn.Add(0);// we want to start in the first column so I add its index
            while (RowsToLookDownIn.Count < AdjacencyMatrix.Rows.Count)
            {

                int smallestValue = int.MaxValue;
                List<int> weights = new List<int>();
                foreach (int x in RowsToLookDownIn)
                {
                    for (int y = 0; y < AdjacencyMatrix.RowCount; y++)
                    {
                        if (ArcWeights[x, y] > 0)
                        {


                            if (ChecKIfCoOrdinateUsed(x, y, list) == false)
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
                if (!RowsToLookDownIn.Contains(yValue))
                {
                    RowsToLookDownIn.Add(yValue);
                }

                CoordinateOfUsedWeights newPoint = new CoordinateOfUsedWeights();
                newPoint.x = xValue;
                newPoint.y = yValue;
                list.Add(newPoint);
                for (int x = 0; x < NumOfNodes; x++)
                {
                    if (x == xValue && (int)AdjacencyMatrix.Rows[yValue].Cells[x].Value != -1)
                    {
                        AdjacencyMatrix.Rows[yValue].Cells[x].Style.BackColor = Color.Red;
                        await Task.Delay(10);
                    }
                    else
                    {
                        if (AdjacencyMatrix.Rows[yValue].Cells[x].Style.BackColor != Color.Red)
                        {
                            AdjacencyMatrix.Rows[yValue].Cells[x].Value = -1;

                            AdjacencyMatrix.Rows[yValue].Cells[x].Style.BackColor = Color.Yellow;
                            await Task.Delay(10);
                        }


                    }
                }
                AdjacencyMatrix.Invalidate();

            } // this loop applies the algorithm, and finishes when all Nodes have been visited
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
            MessageBox.Show("The answer is " + TotalWeight);

        }
        private void GenerateGraph()
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
            foreach (CoordinateOfUsedWeights cord in CoOrdinates)
            {
                if (cord.x == xCoOrdinate && cord.y == YCordinate)
                {
                    return true;
                }
            }
            return false;
        } // this function checks if a weight has already been used preventing a loop from happening
        private void TestPrimsTable_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            GenerateGraph();
        }

        private void AdjacencyMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

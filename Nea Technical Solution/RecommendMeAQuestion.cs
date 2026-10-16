using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class RecommendMeAQuestion : Form
    {
        private Node startNode;
        private Node endNode;

        List<Question> questions = new List<Question>();
        List<GroupBox> QuestionBoxes = new List<GroupBox>();

        const int NumOfNodes = 7; // I used a constant here, so if needed can change the complexity and size of the adjacency matrix
        int[,] ArcWeights = new int[NumOfNodes, NumOfNodes];
        GroupBox ConfidenceBox;
        TextBox AnswerBox;
        double userfeedback;
        private string currentQuestionNumber;
        string currentOutcome;
        Question currentQuestion;
        int currentIndex = 0;
        public RecommendMeAQuestion()
        {
            InitializeComponent();
        }

        public List<Question> QuestionsInOrder;
        private void WorkOutDotProductForEveryQuestion(List<Question> EveryQuestion)
        {
            double userDjikstraDimension = User.DjikstraDimension;
            double userKruskalDimension = User.KruskalDimension;
            double userPrimDimension = User.PrimDimension;

            foreach (Question question in EveryQuestion)
            {
                double dotProduct = 0;
                dotProduct += userDjikstraDimension * question.DjikstraDimension;
                dotProduct += userKruskalDimension * question.KruskalDimension;
                dotProduct += userPrimDimension * question.PrimDimension;
                question.dotProductWithUserVector = dotProduct;
            }
            EveryQuestion.Sort((q1, q2) => q1.dotProductWithUserVector.CompareTo(q2.dotProductWithUserVector)); // sorts the questions in ascending order relating to the dot product between the user and the question
            questions = new List<Question>(EveryQuestion); // the question should be in an order in which they are sorted by the lowest dot product coming first so least similar so we should get questions the user vector is least familiar with
        }
        private void CreateAList() // create a list of all the questin 
        {
            Question questions = new Question();
            List<Question> ListOfQuestions = new List<Question>(questions.GenerateEveryQuestion());
            WorkOutDotProductForEveryQuestion(ListOfQuestions);
            
            foreach (Question question in ListOfQuestions)
            {
                if (question.Answer == "Dynamic")
                {
                    AddDynamicAnswers(question);
                }
            }
            MakeUI();
        } 
        private void RecommendMeAQuestion_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CreateAList();
            AdjacencyMatrix.Visible = false;

        }
        private void MakeUI() // makes the question boxes with the question text and the mark buttons
        {
            if (questions[currentIndex].id == 3)// this question invlolves an adjacency matrix so populate a adjacency matrix in the background
            {
                GenerateGraph();
            }
            GroupBox QuestionBox = new GroupBox();
            QuestionBox.Text = "Question" + (currentIndex + 1);
            QuestionBox.Location = new Point(700, 410);
            QuestionBox.Width = 520;
            QuestionBox.Height = 350;
            QuestionBoxes.Add(QuestionBox);
            if (questions[currentIndex].id == 5)
            {
                CurrentQuestionInfo.mstToBeShown = true;
            }

            Label questiontxt = new Label
            {
                Text = questions[currentIndex].QuestionText,
                Size = new Size(500, 80),
                Font = new Font("Arial", 16),
                Location = new Point(15, 15)
            };

            QuestionBoxes[currentIndex].Controls.Add(questiontxt);

            // Just a word directing what to put in the answe box
            Label AnswerTxt = new Label
            {
                Text = "Please enter your answer",
                Size = new Size(300, 80),
                Font = new Font("Arial", 16),
                Location = new Point(15, questiontxt.Bottom + 200)
            };
            QuestionBoxes[currentIndex].Controls.Add(AnswerTxt);

            TextBox AnswerBox = new TextBox
            {
                Name = "AnswerBox",
                Location = new Point(350, questiontxt.Bottom + 200),
                Size = new Size(150, 100),

            }; // box in which the user enters their answer
            QuestionBoxes[currentIndex].Controls.Add(AnswerBox);
            if (questions[currentIndex].id != 1)
            {
                Button ReturnButton = new Button()
                {
                    Name = "ViewGraph",
                    Text = "View Graph",
                    Location = new Point(350, 200),
                    Size = new Size(150, 50)
                };
                ReturnButton.Click += ReturnButton_Click;
                QuestionBoxes[currentIndex].Controls.Add(ReturnButton);
            }


            Button CheckButton = new Button()
            {
                Name = "CheckButton",
                Text = "Click to check if answer is correct",
                Location = new Point(50, 200),
                Size = new Size(150, 50)

            };
            CheckButton.Click += CheckButton_Click;
            QuestionBoxes[currentIndex].Controls.Add(CheckButton);
            this.Controls.Add(QuestionBoxes[currentIndex]);

        }
        private void ReturnButton_Click(object sender, EventArgs e)// goes to the form where the graph is visible or show the adjacency matrix
        {
            if (questions[currentIndex].id == 3)
            {
                QuestionBoxes[currentIndex].Hide();
                AdjacencyMatrix.Visible = true;
            }
            else
            {
                Forms.GraphForRecommendedQuestions.Show();
            }


        }

        private int FindShortestPath(Node StartingNode, Node FinishNode)

        {

            return Graph.FindShortestPath(StartingNode, FinishNode);


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

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string userAnswer = ((TextBox)QuestionBoxes[currentIndex].Controls["AnswerBox"]).Text; // retrieves the answer provided by the yser

            if (questions[currentIndex].id == 3)
            {
                for (int x = 0; x < NumOfNodes; x++) // we want to make sure that we dont use the first row to prevent loops so I immediately set weights as -1
                {
                    AdjacencyMatrix.Rows[0].Cells[x].Style.BackColor = Color.Magenta;
                    AdjacencyMatrix.Rows[0].Cells[x].Value = -1;
                } // making sure there are no cycles
                currentQuestionNumber = questions[currentIndex].id.ToString();
                currentQuestion = questions[currentIndex];



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

                questions[currentIndex].Answer = TotalWeight.ToString();
            }
            string correctAnswer = questions[currentIndex].Answer;
            string outcome = "";
            if (userAnswer == correctAnswer)
            {
                MessageBox.Show("That's correct");
                outcome = "correct";
            }
            else
            {
                MessageBox.Show("That's incorrect");
                outcome = "false";
            }
            currentOutcome = outcome;
            QuestionBoxes[currentIndex].Hide();

            CreateUserFeedBackBox();
            currentQuestionNumber = questions[currentIndex].id.ToString();
            currentQuestion = questions[currentIndex];
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int feedbackvalueenteredInAnswerBox = int.Parse(AnswerBox.Text);
                if (feedbackvalueenteredInAnswerBox < 1 || feedbackvalueenteredInAnswerBox > 10)
                {
                    throw new ArgumentOutOfRangeException();
                }
                userfeedback = (double.Parse(AnswerBox.Text)) / 10;
                ConfidenceBox.Hide();
                MakeARecord(currentQuestionNumber, currentOutcome, userfeedback);
                MakeNextQuestion();
            }
            catch (FormatException)
            {
                MessageBox.Show("Your input was not a valid number please enter a number");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Your Number was not in the range please enter a valid number");
            }

        }
        // The submit button for the confidence box
        private void AddDynamicAnswers(Question question)
        {
            switch (question.id)
            {
                case 6:
                    {
                        Random rnd = new Random();
                        startNode = Graph.NodesInGraph[rnd.Next(0, Graph.NodesInGraph.Count)];
                        do
                        { endNode = Graph.NodesInGraph[rnd.Next(0, Graph.NodesInGraph.Count)]; } while (endNode == startNode);// we cant have the same node in this scenario
                        question.Answer = FindShortestPath(startNode, endNode).ToString();
                        string modifiedQuestionText = question.QuestionText.Replace("{node1}", startNode.name);
                        modifiedQuestionText = modifiedQuestionText.Replace("{node2}", endNode.name);
                        question.QuestionText = modifiedQuestionText;
                        break;
                    }
                case 5:
                    {
                        Random rnd = new Random();
                        KruskalAlgorithm kruskal = new KruskalAlgorithm();
                        kruskal.RunAlgorithm();
                        Graph.ArcsInGraph = new List<Arc>(kruskal.arcSelected);
                        startNode = Graph.NodesInGraph[rnd.Next(0, Graph.NodesInGraph.Count)];
                        do
                        { endNode = Graph.NodesInGraph[rnd.Next(0, Graph.NodesInGraph.Count)]; } while (endNode == startNode);// we cant have the same node in this scenario
                        string modifiedQuestionText = question.QuestionText.Replace("{node1}", startNode.name);
                        modifiedQuestionText = modifiedQuestionText.Replace("{node2}", endNode.name);
                        question.Answer = FindShortestPath(startNode, endNode).ToString();
                        question.QuestionText = modifiedQuestionText;
                        break;
                    }
                case 4:
                    {
                        KruskalAlgorithm kruskAlgorithm = new KruskalAlgorithm(); // I am going to apply the algorithm here so that I can 
                        kruskAlgorithm.RunAlgorithm();
                        int sum = 0;
                        foreach (Arc arc in kruskAlgorithm.arcSelected) // applied the algorithm and totalled up the weight of the graph
                        {
                            sum += arc.Weight;
                        }

                        question.Answer = sum.ToString();
                        break;
                    }

            }
        }

        private void MakeNextQuestion()
        {
            currentIndex++;// increment for the next question
            Graph.InitialiseGraph();// make a new graph for the question
            try
            {
                AddDynamicAnswers(questions[currentIndex]);
                MakeUI();
                QuestionBoxes[currentIndex].Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You have completed all the questions in this section please exit and try for some other algorithm");
            }

        }
        private void CreateUserFeedBackBox()
        {
            ConfidenceBox = new GroupBox()
            {
                Text = "Feedback",
                Location = new Point(700, 20),
                Width = 520,
                Height = 350

            };
            Label AskingTheUserForConfidence = new Label // text for asking the user for their feedback
            {
                Text = "How confident do you feel on a scale of 1- 10?",
                Width = 520,
                Height = 80,
                Font = new Font("Arial", 16),
                Location = new Point(15, 15)
            };

            AnswerBox = new TextBox
            {
                Name = "AnswerBox",
                Location = new Point(AskingTheUserForConfidence.Bottom + 40, AskingTheUserForConfidence.Bottom + 40),
                Size = new Size(150, 100),

            }; // box in which the user enters their answer

            Button EnterButton = new Button()
            {
                Name = "ConfirmButton",
                Text = "Enter",

                Location = new Point(50, 250),
                Width = 80,
                Height = 20

            };
            EnterButton.Click += EnterButton_Click;


            ConfidenceBox.Controls.Add(AskingTheUserForConfidence);
            ConfidenceBox.Controls.Add(AnswerBox);
            ConfidenceBox.Controls.Add(EnterButton);
            this.Controls.Add(ConfidenceBox);

        }
        private string CalculateUserKnowledgeVector()
        {

            double QuestionKruskalDimension = currentQuestion.KruskalDimension;
            double QuestionPrimDimension = currentQuestion.PrimDimension;
            double QuestionDjikstraDimension = currentQuestion.DjikstraDimension;


            int feedbackValue = 0;
            if (currentOutcome == "correct") // the score for the answer the user provided
            {
                feedbackValue = 1;
            }
            else
            {
                feedbackValue = -1;
            }

            double updatedUserVectorForKruskal = User.KruskalDimension + (feedbackValue * userfeedback * QuestionKruskalDimension);
            double updatedUserVectorForPrim = User.PrimDimension + (feedbackValue * userfeedback * QuestionPrimDimension);
            double updatedUserVectorForDjikstra = User.DjikstraDimension + (feedbackValue * userfeedback * QuestionDjikstraDimension);
            string updatedKnowledgeVector = $"{updatedUserVectorForKruskal},{updatedUserVectorForPrim},{updatedUserVectorForDjikstra}";


            return updatedKnowledgeVector;



        }
        private void MakeARecord(string questionId, string outcome, double confidenceLevel)
        {
            string ConnectionString = "Data Source=Questions.db;Version=3;New=True;Compress=True;";
            string newUserKnowledgeVector = CalculateUserKnowledgeVector();

            using (SQLiteConnection sqlite_conn = new SQLiteConnection(ConnectionString))
            {
                sqlite_conn.Open();

                string Command = "INSERT INTO UserPerformance (UserID, QuestionID, Correct, ConfidenceLevel, KnowledgeVector, TimeStamp) VALUES (@UserID, @QuestionID, @Correct, @ConfidenceLevel, @KnowledgeVector, @TimeStamp)";
                using (SQLiteCommand cmd = new SQLiteCommand(Command, sqlite_conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", User.userID);
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);
                    cmd.Parameters.AddWithValue("@Correct", outcome);
                    cmd.Parameters.AddWithValue("@ConfidenceLevel", confidenceLevel);
                    cmd.Parameters.AddWithValue("@KnowledgeVector", newUserKnowledgeVector);
                    cmd.Parameters.AddWithValue("@TimeStamp", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                sqlite_conn.Close();
            }
            User.UpdateVector(newUserKnowledgeVector);
            User.UpdateDatabase(newUserKnowledgeVector);
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
            try
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
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("The file was not found. Please check the file is still there in the debug folder and try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading node names");
            }

        }

        private void ShowQstButton_Click(object sender, EventArgs e) // goes back to showing the question and hides the adjacency matrix 
        {
            AdjacencyMatrix.Visible = false;
            QuestionBoxes[currentIndex].Visible = true;
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

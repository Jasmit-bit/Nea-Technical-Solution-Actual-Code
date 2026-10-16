using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;


namespace Nea_Technical_Solution
{
    public partial class DjikstraQuestionsPage : Form
    {
        private Node startNode;
        private Node endNode;

        List<Question> questions = new List<Question>();
        List<GroupBox> QuestionBoxes = new List<GroupBox>();

        GroupBox ConfidenceBox;
        TextBox AnswerBox;
        double userfeedback;
        private string currentQuestionNumber;
        string currentOutcome;
        Question currentQuestion;

        int currentIndex = 0;
        private int FindShortestPath(Node StartingNode, Node FinishNode)

        {

            return Graph.FindShortestPath(StartingNode, FinishNode);


        }
        public DjikstraQuestionsPage()
        {
            InitializeComponent();
        }

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
                        //MessageBox.Show(question.QuestionText);
                        MessageBox.Show(question.Answer);
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


            }
        }

        private void GenerateQuestionsBasedOnGraph()
        {
            DjikstraQuestions djikstraQuestions = new DjikstraQuestions();
            questions = new List<Question>(djikstraQuestions.GenerateQuestions("Djikstra"));// creates a list of questions from the sql table

            if (questions[currentIndex].Answer == "Dynamic")
            {
                AddDynamicAnswers(questions[currentIndex]);
            }


        }
        private void MakeUI() // responsible for making the question box show up with the question text and the answer boxes
        {
            GroupBox QuestionBox = new GroupBox();
            QuestionBox.Text = "Question" + currentIndex + 1;
            QuestionBox.Location = new Point(700, 410);
            QuestionBox.Width = 520;
            QuestionBox.Height = 350;
            QuestionBoxes.Add(QuestionBox);

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

            Button ReturnButton = new Button()
            {
                Name = "ViewGraph",
                Text = "ViewGraph",
                Location = new Point(350, 200),
                Size = new Size(150, 50)
            };
            ReturnButton.Click += ReturnButton_Click;
            QuestionBoxes[currentIndex].Controls.Add(ReturnButton);
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
            MessageBox.Show(questions[currentIndex].Answer);
        }
        private void DjikstraQuestionsPage_Load(object sender, EventArgs e) // sets of things to do as soon as the page is opened up
        {
            WindowState = FormWindowState.Maximized;
            Graph.InitialiseGraph();
            GenerateQuestionsBasedOnGraph();
            MakeUI();

        }
        private void ReturnButton_Click(object sender, EventArgs e)// goes back to the form where the graph is visible
        {
            this.Hide();
            Forms.PracticeD.Show();
            Forms.PracticeD.Refresh();
        }


        private void CheckButton_Click(object sender, EventArgs e) // what to do when the user clicks the check button for their input answer
        {
            Button clickedButton = (Button)sender;

            string userAnswer = ((TextBox)QuestionBoxes[currentIndex].Controls["AnswerBox"]).Text; // retrieves the answer provided by the yser
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

        private void EnterButton_Click(object sender, EventArgs e) // what to do when the user enters their confidence level
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
                Size = new Size(500, 80),
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
        private void MakeARecord(string questionId, string outcome, double confidenceLevel) // make a record in the database with the otcome of what the user answer did
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

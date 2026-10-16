using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class KruskalQuestionsPage : Form
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
        public KruskalQuestionsPage()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;    
        }

        private void AddDynamicAnswers(Question question)
        {
            switch (question.id)
            {
                case 4:
                    {
                        KruskalAlgorithm kruskAlgorithm = new KruskalAlgorithm(); // I am going to apply the algorithm here so that I can 
                        kruskAlgorithm.RunAlgorithm();
                        int sum = 0;
                        foreach(Arc arc in kruskAlgorithm.arcSelected) // applied the algorithm and totalled up the weight of the graph
                        {
                            sum += arc.Weight;
                        }

                        question.Answer = sum.ToString();

                        break;
                    }
                


            }
        }
        private void MakeQuestion()
        {
           KruskalsQuestions kQs = new KruskalsQuestions();
           questions = new List<Question>(kQs.GenerateQuestions("Kruskal"));
            foreach (Question question in questions)
            {
                if (question.Answer == "Dynamic")
                {
                    AddDynamicAnswers(question); // this checks for the questions which are classed as Kruskals algorithm but have dynamic answers which differ at run time as the graph is dynamically created
                }

            }
        }
        private void MakeUI() // makes the question box and all the other buttons needed in the question box
        {
            GroupBox QuestionBox = new GroupBox();
            QuestionBox.Text = "Question" + (currentIndex+1);
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
            
        }
        private void KruskalQuestionsPage_Load(object sender, EventArgs e)
        {
            MakeQuestion();
            MakeUI();
        }
        private void ReturnButton_Click(object sender, EventArgs e)// goes back to the form where the graph is visible
        {
            this.Hide();
            Forms.KruskalsQuestionsGraph.Show();
            
        }
        private void CheckButton_Click(object sender, EventArgs e)
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
        private void MakeARecord(string questionId, string outcome, double confidenceLevel) // makes a record in the database with the outcome of the answer
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
    }
}

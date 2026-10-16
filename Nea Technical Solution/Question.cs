using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public class Question
    {
        public int id;
        public string AlgorithmType;
        public string Difficulty;
        public string QuestionText;
        public string Options;
        public string Answer;
        public double DjikstraDimension;
        public double PrimDimension;
        public double KruskalDimension;
        public double dotProductWithUserVector;
        public virtual List<Question> GenerateQuestions(string AlgorithmType)
        {
            List<Question> questionSet = new List<Question>();
            string ConnectionString = "Data Source=Questions.db;Version=3;New=True;Compress=True;";
            using (SQLiteConnection sqlite_conn = new SQLiteConnection(ConnectionString))
            {
                sqlite_conn.Open();
                string Command = $"SELECT * FROM Questions WHERE AlgorithmType = '{AlgorithmType}'";
                using (SQLiteCommand instruction = new SQLiteCommand(Command, sqlite_conn))
                {

                    using (SQLiteDataReader reader = instruction.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Question question = new Question();
                            question.id = int.Parse(reader["QuestionID"].ToString());
                            question.QuestionText = reader["QuestionText"].ToString();
                            question.AlgorithmType = reader["AlgorithmType"].ToString();
                            question.Answer = reader["Answer"].ToString();

                            string preprocessedVectors = reader["Vector"].ToString();

                            question.KruskalDimension = double.Parse(preprocessedVectors.Split(',')[0]);
                            question.PrimDimension = double.Parse(preprocessedVectors.Split(',')[1]);
                            question.DjikstraDimension = double.Parse(preprocessedVectors.Split(',')[2]);

                            questionSet.Add(question);
                        }

                    }
                }
                sqlite_conn.Close();

            }
            return questionSet;
        }
        public List<Question> GenerateEveryQuestion()
        {
            List<Question> AllQuestions = new List<Question>();
            string ConnectionString = "Data Source=Questions.db;Version=3;New=True;Compress=True;";
            using (SQLiteConnection sqlite_conn = new SQLiteConnection(ConnectionString))
            {
                sqlite_conn.Open();
                string Command = "SELECT * FROM Questions";
                using (SQLiteCommand instruction = new SQLiteCommand(Command, sqlite_conn))
                {

                    using (SQLiteDataReader reader = instruction.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Question question = new Question();
                            question.id = int.Parse(reader["QuestionID"].ToString());
                            question.QuestionText = reader["QuestionText"].ToString();
                            question.AlgorithmType = reader["AlgorithmType"].ToString();
                            question.Answer = reader["Answer"].ToString();

                            string preprocessedVectors = reader["Vector"].ToString();

                            question.KruskalDimension = double.Parse(preprocessedVectors.Split(',')[0]);
                            question.PrimDimension = double.Parse(preprocessedVectors.Split(',')[1]);
                            question.DjikstraDimension = double.Parse(preprocessedVectors.Split(',')[2]);

                            AllQuestions.Add(question);
                        }

                    }
                }
                sqlite_conn.Close();

            }
            return AllQuestions;
        }

        
    }
    // the below classes are used to only return question respective to the class name
    public class DjikstraQuestions : Question
    {
        
        public override List<Question> GenerateQuestions(string AlgorithmType)
        {
            string algorithmType = "Djikstra";
           return base.GenerateQuestions(algorithmType);
        }
    } 

    public class PrimsQuestions : Question
    {
        public override List<Question> GenerateQuestions(string AlgorithmType)
        {
            string algorithmType = "Prim";
            return base.GenerateQuestions(algorithmType);
        }
    }

    public class KruskalsQuestions : Question
    {
        public override List<Question> GenerateQuestions(string AlgorithmType)
        {
            string algorithmType = "Kruskal";
            return base.GenerateQuestions(algorithmType);
        }   
    }

}

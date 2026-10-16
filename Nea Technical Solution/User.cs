using System.Data.SQLite;

namespace Nea_Technical_Solution
{

    public static class User
    {
        public static string userID;
        public static string Name;
        public static double DjikstraDimension;
        public static double PrimDimension;
        public static double KruskalDimension;

        static public void UpdateVector(string PreProcessedUserVector)
        {
            KruskalDimension = double.Parse(PreProcessedUserVector.Split(',')[0]);
            PrimDimension = double.Parse(PreProcessedUserVector.Split(',')[1]);
            DjikstraDimension = double.Parse(PreProcessedUserVector.Split(',')[2]);


        }
        static public void UpdateDatabase(string knowledgeVector) // updates the database with the new user knowledge vector after the answer the question
        {
            string ConnectionString = "Data Source=Questions.db;Version=3;New=True;Compress=True;";


            using (SQLiteConnection sqlite_conn = new SQLiteConnection(ConnectionString))
            {
                sqlite_conn.Open();


                string Command = "UPDATE Users SET KnowledgeVector = @KnowledgeVector WHERE UserID = @userID";

                using (SQLiteCommand cmd = new SQLiteCommand(Command, sqlite_conn))
                {

                    cmd.Parameters.AddWithValue("@KnowledgeVector", knowledgeVector);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    cmd.ExecuteNonQuery();
                }


                sqlite_conn.Close();

            }
        }


    }
}

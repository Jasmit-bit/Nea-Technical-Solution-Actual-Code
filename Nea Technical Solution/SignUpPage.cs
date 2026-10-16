using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserIDBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool InformationComplete()
        {
            if (UserIDBox.Text == string.Empty || PassWordBox.Text == string.Empty || NameBox.Text == string.Empty || SurnameBox.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void CreateUser()
        {
            string ConnectionString = "Data Source=Questions.db;Version=3;New=True;Compress=True;";


            using (SQLiteConnection sqlite_conn = new SQLiteConnection(ConnectionString))
            {
                sqlite_conn.Open();


                string Command = "INSERT INTO Users (UserID, Password, Name, Surname,KnowledgeVector) VALUES (@username, @password, @name, @surname, @knowledgeVector)";
                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(Command, sqlite_conn))
                    {
                        cmd.Parameters.AddWithValue("@username", UserIDBox.Text); // I have gone for this approach to prevent Database Injection
                        cmd.Parameters.AddWithValue("@password", PassWordBox.Text);
                        cmd.Parameters.AddWithValue("@name", NameBox.Text);
                        cmd.Parameters.AddWithValue("@surname", SurnameBox.Text);
                        cmd.Parameters.AddWithValue("@knowledgeVector", "0.1,0.1,0.1"); // The default user vector
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("User with the same userID Already Exists please create another");
                }

                sqlite_conn.Close();

            }
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (InformationComplete() == false) // checks if all the info asked for is completed
            {
                MessageBox.Show("Please fill in all the info");
            }
            else
            {
                CreateUser();

            }
            MessageBox.Show("Sucesfully created log in");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.signIn.Show();
        }
    }
}


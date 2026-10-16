using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
            UnstarPassword.MouseDown += UnstarPassword_MouseDown;
            UnstarPassword.MouseUp += UnstarPassword_MouseUp;
        }
        public bool unstar = false;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(oblject sender, EventArgs e) //stars the passwords so no one else can read it 
        {
            if (unstar == false)
            {
                PasswordBox.PasswordChar = '*';
            }
            
            
        }
        private void UnstarPassword_Click(object sender, EventArgs e)
        {

        }

        private void UnstarPassword_MouseDown(object sender, MouseEventArgs e)  // when the user holds the button down they can see their password but when they dont it stars 
        {
            unstar = true;
            PasswordBox.PasswordChar = '\0';  
        }

        private void UnstarPassword_MouseUp(object sender, MouseEventArgs e)
        {
            unstar = false;
            PasswordBox.PasswordChar = '*'; 
        }
        private bool CheckIfUserExists() // checks if the user exists and retrieves the information relating to it
        {
            string ConnectionString = "Data Source=Questions.db;Version=3;New=True;Compress=True;";


            using (SQLiteConnection sqlite_conn = new SQLiteConnection(ConnectionString))
            {

                sqlite_conn.Open();
                string Command = "SELECT * FROM Users WHERE UserID = @username AND Password = @password ";
                using (SQLiteCommand instruction = new SQLiteCommand(Command, sqlite_conn))
                {
                    instruction.Parameters.AddWithValue("@username", UserIDBox.Text);
                    instruction.Parameters.AddWithValue("@password", PasswordBox.Text);


                    using (SQLiteDataReader reader = instruction.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                User.userID = reader["UserID"].ToString();
                                User.Name = reader["Name"].ToString();
                                
                                string PreProcessedUserVector = reader["KnowledgeVector"].ToString();

                                
                                sqlite_conn.Close();
                                User.UpdateVector(PreProcessedUserVector);
                                return true;
                            }
                            else
                            {

                                sqlite_conn.Close();
                                return false;
                            }
                        }

                    }
                }
                return false;

            }
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (CheckIfUserExists() == true)
            {
                MessageBox.Show($"Welcome Back {User.Name}");

                this.Hide();
                Forms.menu.Show();

            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void SignInPage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

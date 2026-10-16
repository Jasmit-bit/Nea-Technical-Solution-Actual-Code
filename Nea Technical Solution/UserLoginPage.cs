using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Nea_Technical_Solution
{
    public partial class UserLoginPage : Form
    {
        public UserLoginPage()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.signIn.Show();
            
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.signUp.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserLoginPage_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

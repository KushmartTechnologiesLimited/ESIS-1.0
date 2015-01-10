using ESIS.Base_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESIS.Dashboard
{
    public partial class LogIn : Form
    {
        public string UserName {get; set;}
        public string Password { get; set;}
        InputValidator validator = new InputValidator();
        Connector database = new Connector();
        public LogIn()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Password = validator.CalculateMD5Hash(passwordText.Text);
            if(database.logIn(UserName,Password))
            {
                database.UserName = UserName;
                Dashboards dashboard = new Dashboards();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
                
            }
            userNameText.Text = "";
            passwordText.Text = "";
        }

        private void userNameText_TextChanged(object sender, EventArgs e)
        {
            if (validator.alphaNumericCheck(userNameText.Text))
            { UserName = userNameText.Text; }
            return;
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            if (validator.alphaNumericCheck(passwordText.Text))
            {
                Password=validator.CalculateMD5Hash(passwordText.Text);
                
            }
            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ESIS.Base_classes;
using ESIS.Dashboard;

namespace ESIS.Registration
{
    public partial class StudentDetails : Form
    {
        private DataSet students = new DataSet();
        Connector studentDetails = new Connector();
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            students = studentDetails.studentDetails("select * from students,guardiandetails where students.registrationnumber=guardiandetails.registrationnumber");
            studentDetailsGrid.DataSource = students.Tables[0];
            string user = studentDetails.UserName;
            userNameLabel.Text = user;
            savingLabel.Text = "";

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent register = new RegisterStudent();
            //this.Hide();
            register.Show();
            //this.Close();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboards dashboard = new Dashboards();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable changes = ((DataTable)studentDetailsGrid.DataSource).GetChanges();
            if (studentDetails.saveStudentDetails(changes))
                ((DataTable)studentDetailsGrid.DataSource).AcceptChanges();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentDetailsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void streamComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

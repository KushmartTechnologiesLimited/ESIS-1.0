using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESIS.Base_classes;
using ESIS.Registration;
using ESIS.Finances;
using ESIS.Config;
namespace ESIS.Dashboard
{
    public partial class Dashboards : Form
    {
        Connector database = new Connector();
        public Dashboards()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            string user = database.UserName;
            toolStripStatusLabel1.Text = "User is : "  + user;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent register = new RegisterStudent();
            //this.Hide();
            register.Show();
            //this.Close();
        }

        private void studentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordTransaction receipt = new RecordTransaction();
            // this.Hide();
            receipt.ShowDialog();
            //this.Close();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails details = new StudentDetails();
            this.Hide();
            details.ShowDialog();
            this.Close();
        }

        private void reportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PaymentDetails ledger = new PaymentDetails();
             this.Hide();
            ledger.ShowDialog();
            this.Close();
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentHistory ledger = new PaymentHistory();
            //this.Hide();
            ledger.ShowDialog();
            //this.Close();
        }

        private void frontDeskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main desk = new main();
            this.Hide();
            desk.ShowDialog();
            this.Close();
        }

        private void configurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sMSServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addFeesItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesItem a = new FeesItem();
            
            a.ShowDialog();
        }

        private void billStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillStudents student = new BillStudents();
            this.Hide();
           student.ShowDialog();
           this.Show();
        }
    }
}

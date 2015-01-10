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
using ESIS.Dashboard;

namespace ESIS.Finances
{
    public partial class PaymentDetails : Form
    {
        Connector database = new Connector();
        private DataSet students = new DataSet();
        public PaymentDetails()
        {
            InitializeComponent();
            List<string>[] items = database.Select("select name from feesstructure");
            for(int i = 0; i < items[0].Count; i++)
            {
                feesItemComboBox.Items.Add(items[0][i]);          
            }
           
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }
        private void PaymentDetails_Load(object sender, EventArgs e)
        {
            students = database.studentDetails("select distinct studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber order by dateentered desc");
            feeDataGrid.DataSource = students.Tables[0];
            string user = database.UserName;
            userNameLabel.Text = user;
            
        }

        private void recordNewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecordTransaction receipt = new RecordTransaction();
           // this.Hide();
            receipt.ShowDialog();
            //this.Close();
        }

        private void admNoTextBox_TextChanged(object sender, EventArgs e)
        {
            
            string admNo = admNoTextBox.Text;
            if (admNo != "")
            {
                students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and students.registrationnumber = '" + admNo + "'");
                feeDataGrid.DataSource = students.Tables[0];
            }
            
            
            
        }

        private void feesItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = feesItemComboBox.Text;
            if (item != "")
            {
                students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By' from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and transactionhistory.PaymentFor= '" + item + "'");
                feeDataGrid.DataSource = students.Tables[0];
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            string date1 = dateTimePicker1.Text;

            students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and datepaid='" + date1 + "'");
                feeDataGrid.DataSource = students.Tables[0];
            
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date2 = dateTimePicker2.Text;
            string date1=dateTimePicker1.Text;
            
            
             if ( date1 != null && date2 != null)
            {
                students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and datepaid >= " + date1 + " and datepaid <= " + date2);
                feeDataGrid.DataSource = students.Tables[0];
            }
            else
            {
                students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and datepaid = " + date2);
                feeDataGrid.DataSource = students.Tables[0];
            }
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           
            admNoTextBox.Text = "";
            feesItemComboBox.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber group by name order by 'date entered' desc ");
            feeDataGrid.DataSource = students.Tables[0];
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboards back = new Dashboards();
            this.Hide();
            back.ShowDialog();
            this.Close();
            
        }
    }
}

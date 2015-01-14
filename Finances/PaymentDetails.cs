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
using System.Reflection;

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
            feeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
       
            //for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
            //{
            //    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
            //feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //for (int i = 0; i < feeDataGrid.Columns.Count; i++)
            //{
            //    int colw = feeDataGrid.Columns[i].Width;
            //    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    feeDataGrid.Columns[i].Width = colw;
            //}
           
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
                for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
                {
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < feeDataGrid.Columns.Count; i++)
                {
                    int colw = feeDataGrid.Columns[i].Width;
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    feeDataGrid.Columns[i].Width = colw;
                }
            }
            
            
            
        }

        private void feesItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = feesItemComboBox.Text;
            if (item != "")
            {
                students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By' from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and transactionhistory.PaymentFor= '" + item + "'");
                feeDataGrid.DataSource = students.Tables[0];
                for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
                {
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < feeDataGrid.Columns.Count; i++)
                {
                    int colw = feeDataGrid.Columns[i].Width;
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    feeDataGrid.Columns[i].Width = colw;
                }
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            string date1 = dateTimePicker1.Text;

            students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and datepaid='" + date1 + "'");
                feeDataGrid.DataSource = students.Tables[0];
                for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
                {
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < feeDataGrid.Columns.Count; i++)
                {
                    int colw = feeDataGrid.Columns[i].Width;
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    feeDataGrid.Columns[i].Width = colw;
                }
            
            
            
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
                for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
                {
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < feeDataGrid.Columns.Count; i++)
                {
                    int colw = feeDataGrid.Columns[i].Width;
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    feeDataGrid.Columns[i].Width = colw;
                }
            }
            else
            {
                students = database.studentDetails("select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber and datepaid = " + date2);
                feeDataGrid.DataSource = students.Tables[0];
                for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
                {
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < feeDataGrid.Columns.Count; i++)
                {
                    int colw = feeDataGrid.Columns[i].Width;
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    feeDataGrid.Columns[i].Width = colw;
                }
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
            for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
            {
                feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < feeDataGrid.Columns.Count; i++)
            {
                int colw = feeDataGrid.Columns[i].Width;
                feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                feeDataGrid.Columns[i].Width = colw;
            }
            
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboards back = new Dashboards();
            this.Hide();
            back.ShowDialog();
            this.Close();
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string query = "select studentsname as Name, paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By'  from students,transactionhistory where students.registrationnumber=transactionhistory.registrationnumber";
            string admNo; string item;
            if (admNoCheckBox.Checked)
            {
                admNo=admNoTextBox.Text;
                if (admNo != "")
                {
                    query += " and students.registrationnumber = '" + admNo + "'";
                }
                else
                    query = "";
            
            }
             if (itemCheckBox.Checked && query!="")
            {
                item = feesItemComboBox.Text;
                if (item != "")
                {
                    query +=  " and transactionhistory.PaymentFor= '" + item + "'";

                }
                else
                    query = "";

            }
           if (fromDateCheckBox.Checked && query != "")
            {
                string date1 = dateTimePicker1.Text;
                if (date1 != "")
                {
                    query += " and datepaid='" + date1 + "'";
                    
            
                }
                else
                    query = "";
            }
           if (toDateCheckbox.Checked && query != "")
            {
                string date2 = dateTimePicker2.Text;
                string date1 = dateTimePicker1.Text;


                if (date1 != null && date2 != null)
                {
                    query +=" and datepaid >= " + date1 + " and datepaid <= " + date2;
                    
                }
                else
                {
                    query += " and datepaid = " + date2;
                  
                }
           
            }
            if (query != "")
            {
                students = database.studentDetails(query);
                feeDataGrid.DataSource = students.Tables[0];
                for (int i = 0; i < feeDataGrid.Columns.Count - 1; i++)
                {
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                feeDataGrid.Columns[feeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < feeDataGrid.Columns.Count; i++)
                {
                    int colw = feeDataGrid.Columns[i].Width;
                    feeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    feeDataGrid.Columns[i].Width = colw;
                }
            }
            else
            { MessageBox.Show("All fields selected are not filled"); }
        }

        private void feeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feeDataGrid_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void feeDataGrid_DataSourceChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}

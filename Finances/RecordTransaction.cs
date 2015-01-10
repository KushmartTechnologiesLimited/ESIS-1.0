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

namespace ESIS.Finances
{
    public partial class RecordTransaction : Form
    {
        Connector fees = new Connector();
        InputValidator validator = new InputValidator();
        string user;
        
        public RecordTransaction()
        {
           
            InitializeComponent();
            user = fees.UserName;
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void classTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void admissionButton_Click(object sender, EventArgs e)
        {
            string admNo = admNoText.Text;
            if (validator.alphaNumericCheck(admNo))
            {
                List<string>[] details = fees.feesDetails("select studentsName,surname,AcademicLevel,balance from transactionhistory,students where transactionhistory.registrationnumber=students.registrationnumber and students.registrationnumber= '" + admNo + "'order by dateStamp desc");
                if (details != null)
                {
                    
                    
                        nameTextBox.Text = details[0][0] + " " + details[1][0];
                        classTextBox.Text = details[2][0];
                        balanceTextBox.Text = details[3][0];
                        
                    
                    

                }
                else
                {
                    admNoText.Text = "";
                }
            }
            else
            {
                admNoText.Text = "";
            }
            return;
        }

        private void RecordTransaction_Load(object sender, EventArgs e)
        {
            DataSet items = fees.studentDetails("select name,amount from feesstructure");
            paymentComboBox.DataSource = items.Tables[0];
            paymentComboBox.ValueMember = "amount";
            paymentComboBox.DisplayMember = "name";
            displayListBox.Items.Add("Payment For".PadRight(55).PadLeft(10) + "Amount");
        }

        private void admNoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            if (validator.alphaCheck(nameText.Text))
            {
                DataSet items = fees.studentDetails("select studentsname from students where surname='" + nameText.Text + "'");
                if (items.Tables[0].Rows.Count != 0)
                {
                    namecomboBox.DataSource = items.Tables[0];
                    namecomboBox.DisplayMember = "StudentsName";
                }
                else
                {
                    MessageBox.Show("No student by such a name was found!");
                    nameText.Text = "";
                }
                    
            }
            else
                nameText.Text = "";
        }

        private void namecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            string surname = nameText.Text;
            string name = namecomboBox.Text;
            List<string>[] detail = fees.feesDetails("select studentsName,surname,AcademicLevel,balance from transactionhistory,students where transactionhistory.registrationnumber=students.registrationnumber and students.surname= '" + surname + "'" + " and students.studentsname= '" + name + "' order by datestamp desc");
            if (detail != null) 
            {
                nameTextBox.Text = detail[0][0] + " " + detail[1][0];
                classTextBox.Text = detail[2][0];
                balanceTextBox.Text = detail[3][0];
                

            }
        }

        private void paymentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(balanceTextBox.Text == ""))
            {
                var amount = (int)paymentComboBox.SelectedValue;
                var item = (string)paymentComboBox.Text;
                int balance = int.Parse(balanceTextBox.Text);

                displayListBox.Items.Add(item.PadRight(60).PadLeft(10) + amount);
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
            }
            catch (Exception)
            {

                return;
            }
        }

        private void paidTextBox_TextChanged(object sender, EventArgs e)
        {
            int balance = int.Parse(balanceTextBox.Text);
            if (validator.numericCheck(paidTextBox.Text))
            {
                int amount = int.Parse(paidTextBox.Text);
                balance = balance - amount;
                balanceTextBox.Text = balance + "";
            }
            else
            {
                paidTextBox.Text = "";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string paymentMethod="";
            string details="";
            if (validator.alphaNumericCheck(detailsTextBox.Text))
            {
                details = detailsTextBox.Text;
            }
            string admno = admNoText.Text;
            string date = datePicker.Text;
            int amount = int.Parse(paidTextBox.Text);
            int balance = int.Parse(balanceTextBox.Text);
            var item = (string)paymentComboBox.Text;
            if (mpesaCheckBox.Checked)
            { paymentMethod = "Mpesa"; }
            if (bankSlipCheckBox.Checked)
            { paymentMethod = "Bank Slip"; }
            string query = "insert into transactionhistory (RegistrationNumber,AmountPaid,paymentFor,paymentMethod,methodDetails,datePaid,balance,transactedBy) values('" + admno + "','" + amount + "','" + item + "','" + paymentMethod + "','" + details + "','" + date + "','" + balance + "','" + user + "')";
            if (fees.Insert(query))
            {
                RecordTransaction transaction = new RecordTransaction();
                this.Hide();
                transaction.ShowDialog();
                this.Close();
            }
        
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}

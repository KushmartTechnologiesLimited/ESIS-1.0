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
    public partial class PaymentHistory : Form
    {
        InputValidator validator = new InputValidator();
        Connector history = new Connector();

        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (validator.alphaNumericCheck(textBox1.Text))
                {
                    DataSet items = history.studentDetails("select studentsname from students where surname='" + textBox1.Text + "'");
                    if (items.Tables[0].Rows.Count != 0)
                    {
                        nameComboBox.DataSource = items.Tables[0];
                        nameComboBox.DisplayMember = "StudentsName";
                    }
                    else
                    {
                        MessageBox.Show("No student by such a name was found!");
                        textBox1.Text = "";
                    }
                }
            }
            else
                nameRadioButton.Checked = false;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
                    }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (validator.alphaNumericCheck(textBox1.Text))
                {
                    DataSet detail = history.studentDetails("select paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By' from transactionhistory,students where transactionhistory.registrationnumber=students.registrationnumber and students.registrationnumber= '" + textBox1.Text + "' order by datestamp desc");
                    if (detail.Tables[0].Rows.Count != 0)
                    {
                        dataGridView.DataSource = detail.Tables[0];
                        textBox1.Text = "";
                        admNoRadioButton.Checked = false;
                        nameRadioButton.Checked = false;
                        admNoRadioButton.Visible = true;
                        nameRadioButton.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("No student by such an AdmNo was found!");
                    }
                }
                else
                {

                    textBox1.Text = "";
                }
                
            }
            else
            {
                admNoRadioButton.Checked = false;
            }
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text;
            string name = nameComboBox.Text;
            DataSet detail = history.studentDetails("select paymentFor as 'Payment For' , paymentMethod as 'Payment Method',methoddetails as 'Payment Method Details', AmountPaid as 'Amount paid' ,Balance, datepaid as 'Date Paid', datestamp as 'Date Entered' , transactedBy as 'Processed By' from transactionhistory,students where transactionhistory.registrationnumber=students.registrationnumber and students.surname= '" + surname + "'" + " and students.studentsname= '" + name + "' order by datestamp desc");
            dataGridView.DataSource = detail.Tables[0];
            textBox1.Text = "";
            admNoRadioButton.Checked = false;
            nameRadioButton.Checked = false;
            admNoRadioButton.Visible = true;
            nameRadioButton.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            admNoRadioButton.Checked = false;
            nameRadioButton.Checked = false;
            admNoRadioButton.Visible = true;
            nameRadioButton.Visible = true;
        }
    }
}

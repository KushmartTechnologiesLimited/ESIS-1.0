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

namespace ESIS.Config
{
    public partial class BillStudents : Form
    {
        Connector fees=new Connector();
        DataSet items=new DataSet();
        List<Tuple<string, string>> item= new List<Tuple<string, string>>() ;
        List<Tuple<string, string>> classStream=new List<Tuple<string, string>>() ;
        public BillStudents()
        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              
                int selected = itemListBox.SelectedIndex;
                foreach (var list in item)
                {


                    // for List<Tuple<string, string>>
                    var value1 = list.Item1;
                    var value2 = list.Item2;
                    string temp = value1.PadRight(90).PadLeft(10) + value2;
                   // MessageBox.Show(temp);
                    
                    if (temp == (string)itemListBox.Items[selected])
                    {
                        item.RemoveAll(p => p.Item1 == value1);
                        itemListBox.Items.RemoveAt(itemListBox.SelectedIndex);
                        
                    }
                    
                }
                itemListBox.Items.RemoveAt(itemListBox.SelectedIndex);
            }
            catch (Exception)
            {

                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int selected = classListBox.SelectedIndex;
                foreach (var list in item)
                {


                    // for List<Tuple<string, string>>
                    var value1 = list.Item1;
                    var value2 = list.Item2;
                    string temp = value1.PadRight(90).PadLeft(10) + value2;
                   // MessageBox.Show(temp);
                    
                    if (temp == (string)classListBox.Items[selected])
                    {
                        classStream.RemoveAll(p => p.Item1 == value1);
                        classListBox.Items.RemoveAt(itemListBox.SelectedIndex);
                        
                    }
                    
                
                }
                classListBox.Items.RemoveAt(classListBox.SelectedIndex);
            }
            catch (Exception)
            {

                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BillStudents_Load(object sender, EventArgs e)
        {
           items=fees.studentDetails("select name, amount from feesstructure");
           if (items.Tables[0].Rows.Count != 0)
           {
               feeItemComboBox.DataSource = items.Tables[0];
               feeItemComboBox.DisplayMember = "name";
               feeItemComboBox.ValueMember = "amount";
           }
           items = fees.studentDetails("select name,code from typeclass");
           if (items.Tables[0].Rows.Count != 0)
           {
               classComboBox.DataSource = items.Tables[0];
               classComboBox.DisplayMember = "name";
               classComboBox.ValueMember = "code";
               
           }
           items = fees.studentDetails("select name from stream");
           if (items.Tables[0].Rows.Count != 0)
           {
               streamComboBox.DataSource = items.Tables[0];
               streamComboBox.DisplayMember = "name";
               
           }
           classListBox.Items.Add("Class Name".PadRight(50) + "Stream");
           itemListBox.Items.Add("Class Name".PadRight(85).PadLeft(10) + "Amount");
        }

        private void feeItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void feeItemButton_Click(object sender, EventArgs e)
        {
            string name;
            var amount = (int)feeItemComboBox.SelectedValue;
            string stringAmount = amount + "";
            name = feeItemComboBox.Text;            
            item.Add(Tuple.Create(name, stringAmount));
            itemListBox.Items.Add(name.PadRight(90).PadLeft(10) + amount);
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            string className;
            string stream;
            className = classComboBox.Text;
            stream = streamComboBox.Text;
            classStream.Add(Tuple.Create(className, stream));
            if (className == "All" && stream == "All")
            { 
                
                classStream=null;
                classStream = new List<Tuple<string, string>>();
                classStream.Add(Tuple.Create(className, stream));
                classListBox.Items.Clear();
                classListBox.Items.Add(className.PadRight(50) + stream);
            
            }
            else
            classListBox.Items.Add(className.PadRight(55) + stream);
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            if (fees.billStudents(classStream, item))
            { }
            else
            {
                MessageBox.Show("The Billing process was not successful. Please try again.");
                BillStudents students = new BillStudents();
                this.Hide();
                students.ShowDialog();
                this.Close();
            }
          
           
        }
    }
}

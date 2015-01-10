using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESIS.appointment;
using MySql.Data.MySqlClient;  //Its for MySQL.
namespace ESIS
{
    public partial class appoint_create : Form
    {
        public appoint_create()
        {
            InitializeComponent();
        }

        private void appointment_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date1.Format = DateTimePickerFormat.Custom;
            date1.CustomFormat = "yyyy/MM/dd";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            timepicker.Format = DateTimePickerFormat.Custom;
           // timepicker.Format = DateTimePickerFormat.Time;
            timepicker.CustomFormat="HH:mm";
            timepicker.ShowUpDown=true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
    try
   {
            //This is my connection string i have assigned the database file address path
            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "insert into schoolfees.appointment(appointmentno,staffID,appointmentdate,personname,purpose,contactnumber,time) values('"+this.appointno.Text+"','" +this.staff.Text+ "','" +this.date1.Text+ "','" +this.Appointee.Text+ "','"+this.purpose.Text+"','" +this.contact.Text+ "','" +this.timepicker.Text+ "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            MessageBox.Show("Save Data");
            while (MyReader2.Read())
            {                   
            }
            MyConn2.Close();
          
          
        }
        catch (Exception ex)
        { 
            MessageBox.Show(ex.Message);
      }

   /* appoint_create form = new appoint_create();
    this.Close();
    form.Show(); 
    */
    this.Close();
    appoint_create ac = new appoint_create();
    ac.Show();

}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifybtn_Click(object sender, EventArgs e)
        {

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            appointdash ad = new appointdash();
            ad.Show();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
                    try
                    {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root";
                    string Query = "delete from schoolfees.appointment where appointno='" + this.appointno.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                    }

        private void appointno_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        }
        }





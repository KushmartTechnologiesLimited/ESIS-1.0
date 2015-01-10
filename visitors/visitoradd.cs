using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ESIS.visitors
{
    public partial class visitoradd : Form
    {
        public visitoradd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void purpose_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
          try   {
            //This is my connection string i have assigned the database file address path
            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "insert into schoolfees.visitorpass(visitorname,visitorcardnumber,address,contactnumber,numberofvisitors,visitpurpose,meetingwith,visitdate,intime,outtime,comments) values('"+this.name.Text+"','" +this.card.Text+ "','" +this.addrs.Text+ "','" +this.cont.Text+"','"+this.nume.Text+ "','"+this.purpose.Text+"','" +this.person.Text+ "','" +this.date.Text+"','" + this.intime.Text+"','" +this.outtime.Text+"','" +this.comments.Text+"');";
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
          
          
        }        catch (Exception ex)
        { 
            MessageBox.Show(ex.Message);
      }

   /* appoint_create form = new appoint_create();
   
    form.Show(); 
    */
          this.Close();
          visitoradd va = new visitoradd();
          va.Show();

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            visitor v = new visitor();
            v.Show();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

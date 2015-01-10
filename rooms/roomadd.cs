using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESIS.rooms;
using MySql.Data.MySqlClient;

namespace ESIS.rooms
{
    public partial class roomadd : Form
    {
        public roomadd()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
 try
   {
            //This is my connection string i have assigned the database file address path
            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "insert into schoolfees.rooms(room_name,room_code,type_id) values('"+this.rmname.Text+"','" +this.rmcode.Text+ "','" +this.rmtype.Text+ "');";
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
    roomadd ra = new roomadd();
    ra.Show();


        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            roomdash ad = new roomdash();
            ad.Show();
        }
    }
}

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
using ESIS;

namespace ESIS.visitors
{
    public partial class visitor : Form
    {
        public visitor()
        {
            InitializeComponent();
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //Display query
                string Query = "select * from schoolfees.visitorpass;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);


                // MyConn2.Open﴾﴿;
                //For offline connection we weill use MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                datagrid1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.
                // MyConn2.Close﴾﴿;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
          //  visitor v = new visitor();
            
        }

        private void visitor_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            visitoradd va = new visitoradd();
            va.Show();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable changes = ((DataTable)datagrid1.DataSource).GetChanges();
            
                ((DataTable)datagrid1.DataSource).AcceptChanges();
           

        }
    }
}

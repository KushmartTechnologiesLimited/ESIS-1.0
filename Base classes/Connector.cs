using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//Add MySql Library
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;



namespace ESIS.Base_classes
{
    class Connector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private static string userName;
        private MySqlDataAdapter mySqlDataAdapter;

        //Constructor
        public Connector()
        {
            Initialize();
        }
        public string UserName
        {
            get{return userName;}
            set{userName=value;}
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "school details";
            uid = "school";
            password = "incorrect";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public bool Insert(string query)
        {
            bool success = false;
            string cs = @"server=localhost;userid=school;
            password=incorrect;database='school details'";
            MySqlConnection conn = null;
            MySqlTransaction tr = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                tr = conn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = tr;

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                

                tr.Commit();
                MessageBox.Show("Success!");
                success = true;
            }
            catch (MySqlException ex)
            {
                try
                {
                    tr.Rollback();

                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show("Error: {0}", ex1.ToString());
                }

                MessageBox.Show("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return success;
        }
        public List<string>[] feesDetails(string query)
        {
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            //list = null;

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.Read())
                {
                    list = null;
                    MessageBox.Show("Student by that admission number not found!");
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
                else
                {
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                    if (this.OpenConnection() == true)
                    {
                        cmd = new MySqlCommand(query, connection);
                        //Create a data reader and Execute the command
                        dataReader = cmd.ExecuteReader();
                        //Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["StudentsName"] + "");
                            list[1].Add(dataReader["surname"] + "");
                            list[2].Add(dataReader["academicLevel"] + "");
                            list[3].Add(dataReader["balance"] + "");
                            
                        }
                    }
                    

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                }
            }//end inner else
            else
            {
                MessageBox.Show("Could not retrieve the required data");
                list = null;
            }
                //return list to be displayed
                return list;
            
        }
        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public bool logIn(string user, string password)
        {
            UserName = user;
            string query = "select username, password from users where username=(@Name) and password=(@Password)";
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = query;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@Name", user);
                cmd.Parameters.AddWithValue("@Password", password);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                if (dataReader == null)
                {
                    MessageBox.Show("Incorrect username or passowrd");
                    return false;

                }
                else
                {
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["username"] + "");
                        list[1].Add(dataReader["password"] + "");



                    }

                }
                dataReader.Close();
                this.CloseConnection();
                for (int i = 0; i < list[0].Count; i++)
                {
                    if (list[0][i].Equals(user) && list[1][i].Equals(password))
                    { return true; }
                }

                MessageBox.Show("Incorrect username or password");

                return false;

                //close Data Reader

                //int answer=cmd.ExecuteNonQuery();
                //this.CloseConnection();
                //if (answer == 0)
                //{
                //    MessageBox.Show("Invalid user or password");
                //    return false;
                //}
                //else if (answer == 1)
                //{ return true; }

            }
            else
            {
                MessageBox.Show("Cannot connect to the database");
            }
            return false;
        }

        //Select statement
        public List<string>[] Select(string query)
        {
            //string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["name"] + "");
                    
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar()+"");
                
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }
        public DataSet studentDetails(string query)
        {
            DataSet DS = new DataSet();
            //DataGrid students= new DataGrid();
            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                mySqlDataAdapter.Fill(DS);
                //students.DataSource = DS.Tables[0];

                //close connection
                this.CloseConnection();
            }
            return DS;
        }
        public bool saveStudentDetails( DataTable changes)
        {
            bool status = false;
            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                status = true;
            }
            return status;
        }
        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);

                
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }
        public bool billStudents(List<Tuple<string,string>> classStream,List<Tuple<string,string>> item)
        {
            bool result = false;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            bool all = false;
            string query = "insert into transactionhistory (registrationnumber,amountpaid,paymentfor,paymentmethod,datepaid,transactedby) ";
            List<string> classes = new List<string>();
            List<string> streams = new List<string>();
            foreach (var a in classStream)
            {
                if (a.Item1 == "All" && a.Item2 == "All")
                {
                    all = true;
                    break;
                }
                classes.Add(a.Item1);
                streams.Add(a.Item2);
            }
            string cs = @"server=localhost;userid=school;
            password=incorrect;database='school details'";
            MySqlConnection conn = null;
            MySqlTransaction tr = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                tr = conn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = tr;
                
                foreach (var list in item)
                {
                    query = "insert into transactionhistory (registrationnumber,amountpaid,paymentfor,paymentmethod,datepaid,transactedby) ";
                    var value1 = list.Item1;
                    var value2 = list.Item2;
                    if (all)
                    {

                        query += "SELECT registrationNumber, '-" + value2 + "','" + value1 + "','" + "Billing','" + date + "','" + userName + "' FROM students WHERE status = 1";
                        //Create and call a method
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show(query);

                    }
                    else
                    {
                        for (int counter = 0; counter < classes.Count; counter++)
                        {
                            query = "insert into transactionhistory (registrationnumber,amountpaid,paymentfor,paymentmethod,datepaid,transactedby) ";
                            query += "SELECT registrationNumber, '-" + value2 + "','" + value1 + "','" + "Billing','" + date + "','" + userName + "' FROM students WHERE status = 1 and academicLevel='"+classes[counter]+ "' and stream ='" + streams[counter] + "'";
                            //Create and call a method
                            cmd.CommandText = query;
                            cmd.ExecuteNonQuery();
                            //MessageBox.Show(query);
                        }
 
                    }
                    
                    
                    
                }

                


                tr.Commit();
                MessageBox.Show("Success!");
                
            }
            catch (MySqlException ex)
            {
                try
                {
                    tr.Rollback();

                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show( ex1.ToString());
                }

                MessageBox.Show( ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            
            return result;
        
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                
                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}



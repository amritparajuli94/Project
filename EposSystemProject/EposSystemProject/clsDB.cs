using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EposSystemProject
{

    // clsOledb
    // this class can connect to diffrent databases, we only need to change the data source in connection string
    class clsDB
    {
        // DBConnection makes a connection to database 
        // It return a connection whenever we call it

        public  SqlConnection DBConnection()
        {

           // string strconnection = ConfigurationManager.ConnectionStrings["SaxonCharity.Properties.Settings.SaxonDBConnectionString"].ToString();
            SqlConnection DBConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\EposSystemDatabase.mdf;Integrated Security=True");
            return DBConnection;
        }
        
        // DBExecute is for doing actions such as INSERT, UPDATE, DELETE and CREATE on tables in Database
        // it gets the command in CommandString and it doesn not return any data.

        //public void DBExecute(String CommandString)
        //{
        //    try
        //    {
        //    SqlConnection command = new SqlConnection(); 
        //    command.CommandType = CommandType.Text;
        //    command.CommandText = CommandString;
        //    command.Connection = DBConnection();
        //    command.Connection.Open();
        //    command.ExecuteNonQuery();
        //    command.Connection.Close();
        //    }
        //    catch(Exception er)
        //    {
        //        MessageBox.Show("Errorr Ocured In Command Execution : " + er.Message);
        //    }
        //}

        // SelectCommand is for SELECT command
        // it gets SELECT command from SelectString and return a DataSet with results

        public DataSet SelectCommand(String SelectString)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter dataadapter = new SqlDataAdapter(SelectString, DBConnection());
                dataadapter.Fill(ds);
                dataadapter.Dispose();
            }
            catch (Exception er)
            {
                MessageBox.Show("Errorr Ocured in Selecting Command : " + er.Message);
            }
            return ds;
        }

        // it gets table name and field name and it will return a number
        // i design this function to generate new code for my records such as request number
        // it return the biigest number in the choosen column and then sum it up by 1 and return a new code.

        public int CodeGenerator(String TableName, String FieldName)
        {
            int code;
            DataSet ds;
            ds=SelectCommand("SELECT MAX("+ FieldName +") AS MaxNum FROM " + TableName);
            try
            {
                code = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]) + 1;
            }
            catch
            {
                code = 1;
            }
            return code;
        }
    }
}

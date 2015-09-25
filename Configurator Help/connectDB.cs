using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Configurator_Help
{
    class connectDB
    {
        public static OleDbConnection GetConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            try
            {
                String connectionString = @"Provider=Microsoft.JET.OlEDB.4.0;"
               + "Data Source=\fpdarpsDB.mdb";
                conn = new OleDbConnection(connectionString);
                conn.Open();
            }
            catch
            {
               //MessageBox.Show("The database cannot be accessed!");
               //return conn;
            }
            return conn;
        }
    }
}

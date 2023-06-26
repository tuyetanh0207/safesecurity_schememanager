using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAO_HotelManagement
{
    public class DataProvider
    {
        public string username;
        public string password;
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
            private set { instance = value; }
        }

        private DataProvider() { }

        public void setUserPass(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.connectStr = connectStr + this.username + ";Password =" + this.password;
        }
        public string getUsername() { return this.username; }
        public string getconnecStr() { return this.connectStr; }

        // connect string for the rest
        private string connectStr = "Data Source=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST = LocalHost)(Port=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl1))); User ID=";
       
        // connect string tuyetanh for docker
        //private string connectStr = "Data Source = " + "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 15212)))(CONNECT_DATA = (SERVICE_NAME = XE)))" + ";User Id = ";
        public DataSet ExecuteQuery1(string query)
        {
            DataSet dataset = new DataSet();
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataset);
                connection.Close();
            }
            return dataset;
        }
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }

            return dataTable;
        }
        public int ExecuteNonQuery(string query)
        {
            int result = 0;
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result;
        }
        public string ExecuteScalar(string query)
        {
            string result = "";
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                result = command.ExecuteScalar().ToString();
                connection.Close();
            }
            return result;
        }
        public DataTable ExecuteProc(string query)
        {
            DataTable dataTable = new DataTable();
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
        public int ExecuteNonQueryProc(string query)
        {
            int result = 0;
            using (OracleConnection connection = new OracleConnection(connectStr))
            {
                connection.Open();
                OracleCommand command = new OracleCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                result = command.ExecuteNonQuery();
                connection.Close();
            }
            return result;
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace GH_Web_Application.Models
{
    public static class DbAccess
    {
        const string CONNECTION_STRING = "User Id= sys;Password=Password;" + "DATA SOURCE=localhost:1521/XE;DBA Privilege=SYSDBA";


        public static OracleConnection Connection = new OracleConnection(CONNECTION_STRING);
        public static OracleCommand Command { get; set; }

        //Execute statement that return Data Table
        public static DataTable ExecuteQuery(string query,params object [] parameter)
        {
            DataTable data = new DataTable();

            Connection.Open();
            Command = new OracleCommand(query, Connection);
            if(parameter != null)
            {
                int i = 0;
                string[] listPara = query.Split(' ');
                foreach (string item in listPara)
                {
                    if (item.Contains(':'))
                    {
                        Command.Parameters.Add(item, parameter[i]);
                        i++;
                    }
                }

            }
            OracleDataAdapter adapter = new OracleDataAdapter(Command);
            adapter.Fill(data);
            Connection.Close();          

            return data;
        }

        //Execute statement not return Data Table
        public static int ExecuteNonQuery(string query,params object[] parameter)
        {
            int data = 0;

            Connection.Open();
            Command = new OracleCommand(query, Connection);
            if (parameter != null)
            {
                int i = 0;
                string[] listPara = query.Split(' ');
                foreach (string item in listPara)
                {
                    if (item.Contains(':'))
                    {
                        Command.Parameters.Add(item, parameter[i]);
                        i++;
                    }
                }
            }
            data = Command.ExecuteNonQuery();
            Connection.Close();

            return data;
        }
        public static int ExecuteStoredProcedured(string query,params object[] parameter)
        {
            Command.CommandType = CommandType.StoredProcedure;
            ExecuteNonQuery(query, parameter);
            return 0;
        }

    }
}

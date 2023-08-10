using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UltraGamesStoreNoSteamNONONO
{
    public class SQLBase
    {
        string ConnectionString;
        SqlConnection connection;

        public SQLBase(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void OpenConnection()
        {
            connection = new SqlConnection(ConnectionString);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void NoResultQuery(string query, params Tuple<string, object>[] list)
        {

            SqlCommand command = Query(query, list);
            command.ExecuteNonQuery();
        }

        private SqlCommand Query( string query, Tuple<string, object>[] list)
        {
            SqlCommand command = new SqlCommand(query, connection);
            foreach (var item in list)
            {
                command.Parameters.AddWithValue(item.Item1, item.Item2);
            }
            return command;
        }

        public DataSet DataQuery(string query, params Tuple<string, object>[] list)
        {
            SqlCommand command = Query( query, list);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data= new DataSet();
            adapter.Fill(data);
            return data;
        }
    }
}

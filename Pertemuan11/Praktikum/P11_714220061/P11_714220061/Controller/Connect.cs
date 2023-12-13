using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_714220061
{
    internal class Connect
    {
        string connectionstring = "Server=localhost;Database=ulbi;Uid=root;Pwd=;";
        MySqlConnection con;

        public void OpenConnection()
        {
            con = new MySqlConnection(connectionstring);
            con.Open();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }
    }
}

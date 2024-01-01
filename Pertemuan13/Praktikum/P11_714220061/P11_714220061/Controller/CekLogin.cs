using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_714220061.Controller
{
    class CekLogin
    {
        Connect connect = new Connect();

        public bool cek_login(string username, string password)
        {
            try
            {
                connect.OpenConnection();
                MySqlDataReader reader = connect.reader("SELECT * FROM t_user WHERE username='" + username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    connect.CloseConnection();
                    return true;
                }
                else
                {
                    connect.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}

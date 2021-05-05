using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Villiers
{
    class Database
    {
        private static string connectBDD = "server=localhost; user id = root; database=villiers";

        public static string connectString
        {
            get
            {
                return connectBDD;
            }
        }

        public static MySqlConnection openConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectBDD);
            conn.Open();
            return conn;
        }
    }
}

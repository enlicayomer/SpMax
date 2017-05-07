using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SportMax.com.omerenlicay.db
{
    class DBConnectionManager
    {


        static MySqlConnection connection;

        public static MySqlConnection getConnection()
        {
            connection = new MySqlConnection("server=127.0.0.1;uid=root;pwd=root;database=sportmax;");

            return connection;
        }
    }
}

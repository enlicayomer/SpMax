using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SportMax.com.omerenlicay.db;
namespace SportMax.com.omerenlicay.dao
{
    class UserDAO
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader dataReader;
        private static String LOGIN_QUERY = "SELECT * FROM user WHERE userName=@kulad AND userPassword=@pass";
        
        public Boolean loginDelegate(String kulad, String pass)
        {
            Boolean isStatus = false;
            try
            {
                
                using (connection = DBConnectionManager.getConnection())
                {
                    connection.Open();
                    using (command = new MySqlCommand(LOGIN_QUERY, connection));
                    command.Parameters.AddWithValue("kulad", kulad);
                    command.Parameters.AddWithValue("pass", pass);
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            isStatus = true;
                            
                        }
                    }
                    connection.Close();
                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: "+ex);
            }

            return isStatus;
        }

    }
}

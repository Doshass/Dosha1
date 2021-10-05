using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosha1
{
    class Doss
    {
        public static DataTable Select(string sql)
        {
            MySqlConnectionStringBuilder my = new MySqlConnectionStringBuilder();
            my.Server = "192.168.201.12";
            my.Port = 3306;
            my.UserID = "ISP232_VorobyevaDA";
            my.Database = "ISP232_VorobyevaDA_magazin";
            my.CharacterSet = "utf8";
            my.Password = "270304";

            MySqlConnection connection = new MySqlConnection(my.ConnectionString);
            MySqlCommand command = new MySqlCommand(sql, connection);
            DataTable table = new DataTable();

            connection.Open();
            table.Load(command.ExecuteReader());
            connection.Close();
            return table;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosha1
{
    public class Klient
    {
        public int Idklient;
        public string klient_login;
        public string klient_pass;
        public string klient_name;
        public UInt64 klient_phone;

        public Klient(DataRow row)
        {
            Idklient = Convert.ToInt32(row["Idklient"]);
            klient_login = Convert.ToString(row["klient_login"]);
            klient_pass = Convert.ToString(row["klient_pass"]);
            klient_name = Convert.ToString(row["klient_name"]);
            klient_phone = Convert.ToUInt64(row["klient_phone"]);
        }
        public Klient() { }
        public static List <Klient> Select ()
        {
            List<Klient> klients = new List<Klient>();
            foreach (DataRow row in Doss.Select("Select * from klient").Rows)
            {
                klients.Add(new Klient(row));
            }
            return klients;


        }
        public static void Add(string login, string pass, string name, UInt64 phone) {
            Doss.Select("INSERT INTO `klient` (`klient_login`, `klient_pass`, `klient_name`, `klient_phone`)" +
                " VALUES ('" + login + "', '" + pass + "', '"+name+"', '"+phone+"');");
        }
        //UPDATE `klient` SET `klient_login` = '3', `klient_pass` = '3', `klient_name` = '4', `klient_phone` = '3' WHERE (`idklient` = '7');
        public void change (string login, string pass, string name, UInt64 phone)
        {
            Doss.Select("UPDATE `klient` SET `klient_login` = '"+login+"', `klient_pass` = '"+pass+"', " +
                "`klient_name` = '"+name+"', `klient_phone` = '"+phone+"' WHERE(`idklient` = '"+Idklient+"');");
        }
    }
    public void Delete ()
    
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.classes
{
    internal class ConnectionClass
    {
        static string connStr = "server = localhost; database = user2; user = root; password = qwerty";
        static public MySqlCommand cmd;
        static public MySqlDataAdapter adapter;
        static MySqlConnection conn;
        static public DataTable user;

        static public bool Open()
        {
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                adapter = new MySqlDataAdapter(cmd);
                return true;
            }
            catch
            {
                MessageClass.Error("Ошибка подключения к БД!");
                return false;
            }
        }
    }
}

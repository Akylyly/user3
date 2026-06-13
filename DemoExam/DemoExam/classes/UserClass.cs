using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.classes
{
    internal class UserClass
    {
        static public DataTable Auth(string login, string pass)
        {
            ConnectionClass.cmd.CommandText = $@"select * from user where login = '{login}' and pass = '{pass}'";
            DataTable dt = new DataTable();
            ConnectionClass.adapter.Fill(dt);
            return dt;
        }
        static public DataTable Get()
        {
            ConnectionClass.cmd.CommandText = $@"select * from user";
            DataTable dt = new DataTable();
            ConnectionClass.adapter.Fill(dt);
            return dt;
        }
    }
}

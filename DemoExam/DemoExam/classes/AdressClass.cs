using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.classes
{
    internal class AdressClass
    {

        static public DataTable Get()
        {
            ConnectionClass.cmd.CommandText = $@"select * from adress";
            DataTable dt = new DataTable();
            ConnectionClass.adapter.Fill(dt);
            return dt;
        }

    }
}

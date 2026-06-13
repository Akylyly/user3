using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.classes
{
    internal class CategoryClass
    {
        static public DataTable Get()
        {
            ConnectionClass.cmd.CommandText = $@"select * from category";
            DataTable dt = new DataTable();
            ConnectionClass.adapter.Fill(dt);
            return dt;
        }
    }
}

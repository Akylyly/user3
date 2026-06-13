using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam.classes
{
    internal class MessageClass
    {
        static public void Info(string msg)
        {
            MessageBox.Show(msg, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static public void Error(string msg)
        {
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static public bool Question(string msg)
        {
            return MessageBox.Show(msg, "Уведомление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
        }
    }
}

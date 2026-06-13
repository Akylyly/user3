using DemoExam.classes;
using DemoExam.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!ConnectionClass.Open())
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageClass.Error("Вы заполнили не все поля!");
                return;
            }
            ConnectionClass.user = UserClass.Auth(textBox1.Text, textBox2.Text);
            if(ConnectionClass.user.Rows.Count == 0)
            {
                MessageClass.Error("Такого пользователя не существует! Проверьте данные!");
                return;
            }
            new MainForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MainForm().ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

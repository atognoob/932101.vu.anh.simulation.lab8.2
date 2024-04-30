using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8._2
{
    public partial class Form1 : Form
    {
        List<double> p = new List<double> { 0.1, 0.3, 0.5, 0.8, 1 };
        List<string> answer = new List<string>
        {
            "Cтрашная идея, бросай!",
            "Не стоит, ты сильно хочешь риска?",
            "Почему нет?",
            "Вот шанс перед тобой, иначе его жалеешь",
            "Да, 3000 раз ДА",
        };
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "На пару сегодня?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            double q = rdn.NextDouble();
            int i = 0;
            while (i < 5)
            {
                if(q < p[i])
                {
                    label1.Text = answer[i];
                    break;
                }
                i++;
            }
        }
    }
}

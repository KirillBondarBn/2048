using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // Очищение richTextBox1
            // for имеет три параметра
            // 1. Начальное значение счетчика цикла
            // 2. Условие
            // 3. Увеличение счетчика цикла
            for (int i = 0; i < 10; i++)
            {
                richTextBox1.Text += "i=" + i.ToString() + "\n";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // Очищение richTextBox1
            // while имеет 1 параметр
            // Начальное значение счетчика цикла задается ДО ЦИКЛА
            // 1. Условие
            int i = 5;
            while (i < 20)
            {
                richTextBox1.Text += "i=" + i.ToString() + "\n";
                i += 2;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // Очищение richTextBox1
            int left = Convert.ToInt32(textBox1.Text),
                right = Convert.ToInt32(textBox2.Text),
                summa = 0;
            for (int i = left; i < right; i++)
            {
                if (i%2 == 0) // Если число делится на 2 без остатка, то оно четное
                {
                    richTextBox1.Text += "i=" + i.ToString() + "\n";
                    summa += i;

                }
            }
            MessageBox.Show(Convert.ToString(summa));// или summa.ToString()
        }
    }
}

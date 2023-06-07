using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.IO;

namespace Diagrams
{
    public partial class Form2 : Form //форма круговой диаграммы
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int err = 0;
            if (textBox1.Text.Length == 0)
            {
                textBox1.BackColor = Color.Red;
                err = 1;
            }
            else if (!checkText(textBox1.Text)) { textBox1.ForeColor = Color.Red; err = 1; }
            if(err==0)
            chart1.Series[0].Points.Add(Convert.ToDouble(textBox1.Text));
            else MessageBox.Show("Ошибка ввода данных", "Внимание!");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Проверка, позволяющая вводить в текстбокс только цифры, запятые, минусы и бэкспейс
        {
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
        private bool checkText(string text) //Проверяет, вбиваемые данные на соответствование верным данным для безошибочной работы.
        {
            bool check=true;
            int counter = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    if ((int)text[i] == 44)
                    {
                        check = false;
                    }
                }
                
                if ((int)text[i] == 44)
                {
                    counter++;
                }
            }
            if (counter > 1) check = false;
            return check;
        }

        private void столбчатаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(); // где Form3 название формы гистограммы
            frm3.Show();
        }

        private void кусочнолинейнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(); // где Form1 название формы гистограммы
            frm1.Show();
        }

        private void добавитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e) //работа с файлом
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Title = "Добавить из файла";
            opendialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(opendialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(file, Encoding.UTF8);
                List<string> str = new List<string>();
                while (!read.EndOfStream)
                {
                    str.Add(read.ReadLine());
                }
                Regex num_double = new Regex(@"-?\d+(,\d+)?");
                List<double> Xcoords = new List<double>();
                for (int i = 0; i < str.Count; i++)
                {
                    if (str[i].Length != 0)
                    {
                        if (str[i][0] == 'X' || str[i][0] == 'x')
                        {
                            if (str[i][1] == '=' || str[i][1] == ':')
                            {
                                foreach (Match x in num_double.Matches(str[i]))
                                {
                                    Xcoords.Add(double.Parse(x.Value));
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < Xcoords.Count; i++)
                {
                    chart1.Series[0].Points.Add(Xcoords[i]);
                }
                read.Close();
                file.Close();
            }
        }
    }
}

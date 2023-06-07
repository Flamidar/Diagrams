using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Diagrams
{
    public partial class Form1 : Form //форма кусочно-линейной диаграммы
    {
        public Form1()
        {
            InitializeComponent();
        }



        

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                this.chart1.Series[0].Points.Clear();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int err = 0;
            if (textBox_X.Text.Length == 0)
            {
                textBox_X.BackColor = Color.Red;
                err = 1;
            }
            else if (!checkText(textBox_X.Text)) { textBox_X.ForeColor = Color.Red; err = 1; }
            if (textBox_Y.Text.Length == 0)
            {
                textBox_Y.BackColor = Color.Red;
                err = 1;
            }
            else if (!checkText(textBox_Y.Text)) { textBox_Y.ForeColor = Color.Red; err = 1; }
            if (err == 0)
                chart1.Series[0].Points.AddXY(Convert.ToDouble(textBox_X.Text), Convert.ToDouble(textBox_Y.Text));
            else MessageBox.Show("Ошибка ввода данных", "Внимание!");
        }

        private void textBox_X_KeyPress(object sender, KeyPressEventArgs e) //Проверка, позволяющая вводить в текстбокс только цифры, запятые, минусы и бэкспейс
        {
            textBox_X.ForeColor = Color.Black;
            textBox_X.BackColor = Color.White;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }
        private bool checkText(string text) //Проверяет, вбиваемые данные на соответствование верным данным для безошибочной работы.
        {
            bool check = true;
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    if ((int)text[i] == 44)
                    {
                        check = false;
                    }
                }
                else if ((int)text[i] == 45)
                {
                    check = false;
                }
                if ((int)text[i] == 44)
                {
                    counter++;
                    if (i == 1)
                    {
                        if ((int)text[0] == 45) check = false;
                    }
                }
            }
            if (counter > 1) check = false;
            return check;
        }

        private void textBox_Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox_Y.ForeColor = Color.Black;
            textBox_Y.BackColor = Color.White;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void столбчатаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(); //где Form3 - название формы круговой диаграммы
            frm3.Show();
        }

        private void круговаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(); //где Form2 - название формы круговой диаграммы
            frm2.Show();
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
                List<double> Ycoords = new List<double>();
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
                        if (str[i][0] == 'Y' || str[i][0] == 'y')
                        {
                            if (str[i][1] == '=' || str[i][1] == ':')
                            {
                                foreach (Match y in num_double.Matches(str[i]))
                                {
                                    Ycoords.Add(double.Parse(y.Value));
                                }
                            }
                        }
                    }
                }
                if (Xcoords.Count == Ycoords.Count)
                {
                    for (int i = 0; i < Xcoords.Count; i++)
                    {
                        chart1.Series[0].Points.AddXY(Xcoords[i], Ycoords[i]);
                    }
                }
                else MessageBox.Show("Количество считанных координат Y не соответствует количеству считанных координат Х", "Ошибка");
                read.Close();
                file.Close();
            }
        }
    }
}

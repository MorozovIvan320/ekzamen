using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ekz
{
    public partial class Form1 : Form
    {
        string curFile;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Html files(*.html)|*.html|All files(*.*)|*.*";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            openFileDialog1.ShowDialog();
            string[] repSplit = openFileDialog1.FileName.Split('\\');
            curFile = repSplit[repSplit.Length - 1];
            webBrowser1.Navigate(openFileDialog1.FileName);

            if (curFile == "var1.html" || curFile == "var2.html")
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                MessageBox.Show(
                 "Для данного файла не предусмотрено решение.",
                 "Ошибка",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button3);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                  "Программу разработал:\n Студент группы ПКуспк-320\n Морозов Иван Валерьевич.\n Вариант 4",
                  "О программе",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.None,
                  MessageBoxDefaultButton.Button3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 formRez = new Form2();
                double x = Convert.ToDouble(textBox1.Text), y = Convert.ToDouble(textBox2.Text);
                if (curFile == "var1.html")
                {
                    if (y <= 4 && y >= -4 && x >= -5 && x <= 5 && ((x >= 1 && y <= -2 * x + 6) || (y <= 0 && y <= (-x - 35) / 10) || (x <= 1 && y <= (7 * x + 17) / 6)))
                    {
                        if (y < 4 && y > -4 && x > -5 && x <= 5 && ((x >= 1 && y < -2 * x + 6) || (y <= 0 && y < (-x - 35) / 10) || (x <= 1 && y < (7 * x + 17) / 6)))
                        {
                            formRez.Show();
                            formRez.resultSet("Точка находится внутри фигуры");
                        }
                        else
                        {
                            formRez.Show();
                            formRez.resultSet("Точка находится на границе фигуры");
                        }
                    }
                    else
                    {
                        formRez.Show();
                        formRez.resultSet("Точка находится вне фигуры");
                    }
                }

                else if (curFile == "var2.html")
                {
                    if (x < 2 && y > 0.5 && y < 2 || x < 2 && 2 > y && y > 0.5)
                    {
                        formRez.Show();
                        formRez.resultSet("Точка находится внутри фигуры");
                    }
                    else if (x == 2 && y <= 2 || x == 1.5 && y == 1.5)
                    {
                        formRez.Show();
                        formRez.resultSet("Точка находится на границе фигуры");

                    }
                    else
                    {
                        formRez.Show();
                        formRez.resultSet("Точка находится вне фигуры");
                    }
                }
                else
                {
                    MessageBox.Show(
                     "Для данного файла не предусмотрено решение.",
                     "Ошибка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button3);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(
                 $"Похоже вы ввели не число. {exp}",
                 "Ошибка",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button3);
            }
        }
    }
}

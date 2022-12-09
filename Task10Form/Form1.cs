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

namespace Task10Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double a; private double b; private double h; private double f(double x)
        {
            try
            {
                if (x == -2) throw new Exception();
                else return 3 / Math.Abs(Math.Pow(x, 3) + 8);
            }
            catch
            {
                throw;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (start_TextBox.Text == "" || finish_TextBox.Text == "" || H_TextBox.Text== "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                res_TextBox.Text = "";
                try
                {
                    a = double.Parse(start_TextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!"); return;
                }
                try
                {
                    b = double.Parse(finish_TextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!"); return;
                }
                if (a > b)
                {
                    MessageBox.Show("Начальная точка диапазона не может быть больше конечной точки");
                    return;
                }
                try
                {
                    h = double.Parse(H_TextBox.Text);
                    if (h == 0)
                    {
                        MessageBox.Show("Шаг не может быть равен 0"); return;
                    }
                    else if (h < 0)
                    {
                        MessageBox.Show("Шаг не может быть меньше 0"); return;

                    }
                }
                catch
                {
                    Console.Write("Некорректный ввод!");
                }
                for (double i = a; i <= b; i += h)
                {
                    try
                    { res_TextBox.Text += "y(" + Math.Round(i, 2) + ") = " + Math.Round(f(i), 2) + "\n"; }
                    catch
                    {
                        res_TextBox.Text += "y(" + Math.Round(i, 2) + ") = Не определен "+ "\n";
                    }

                }

            }
        }
    }
} 

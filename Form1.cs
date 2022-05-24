using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graf
{
    public partial class Form1 : Form
    {
        double a=0, b=0, h=0, x=0, y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            chart1.Series[0].Points.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b' && l != 45)
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            bool f = true;
            try
            {

                a = Convert.ToDouble(textBox2.Text);
                b = Convert.ToDouble(textBox3.Text);
                h = Convert.ToDouble(textBox4.Text);
                label4.Text = x.ToString();
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Введенные значения не верны");
                f = false;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Введенные значения слишком большие");
                f = false;
            }
            int t = listBox1.SelectedIndex;
            if (a > b)
            {

                MessageBox.Show("Начало отсчета больше его конца");
             }
            else
            {
                if (f)
                {
                    chart1.Visible = true;
                    x = a;
                    if (listBox1.SelectedIndex == 0)
                    {
                        while (x <= b)
                        {
                            y = Math.Cos(x);
                            chart1.Series[0].Points.AddXY(x, y);
                            x += h;

                        }
                    }
                    if (listBox1.SelectedIndex == 1)
                    {
                        while (x <= b)
                        {
                            y = Math.Sin(x);
                            chart1.Series[0].Points.AddXY(x, y);
                            x += h;

                        }
                    }
                    if (listBox1.SelectedIndex == 2)
                    {
                        while (x <= b)
                        {
                            y = Math.Exp(x);
                            chart1.Series[0].Points.AddXY(x, y);
                            x += h;

                        }
                    }
                    if (listBox1.SelectedIndex == 3)
                    {
                        while (x <= b)
                        {
                            y = Math.Pow(x, 2);
                            chart1.Series[0].Points.AddXY(x, y);
                            x += h;

                        }
                    }

                }
            }

           
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < '0' || l > '9') && l != '\b' && l != 44 )
            {
                e.Handled = true;
            }
        }
    }
}

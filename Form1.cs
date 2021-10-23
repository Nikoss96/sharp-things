using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int l = 0;
        string[] story = new string[50];
        public static double sum(double a, double b) => (a + b);
        public static double minus(double a, double b) => (a-b);
        public static double delit(double a, double b) => (a / b);
        public static double umn(double a, double b) => (a*b);
        public static double stepen(double a, double b) => Math.Pow(a,b);
        public static double koren(double a, double b) => Math.Pow(a, 1/b);

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text) ) ) ;
            string itog = textBox1.Text + "+" + textBox2.Text + "=" + textBox3.Text;
            story[l] = itog;
            l++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(minus(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            string itog = textBox1.Text + "-" + textBox2.Text + "=" + textBox3.Text;
            story[l] = itog;
            l++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(umn(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            string itog = textBox1.Text + "*" + textBox2.Text + "=" + textBox3.Text;
            story[l] = itog;
            l++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(delit(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            string itog = textBox1.Text + "/" + textBox2.Text + "=" + textBox3.Text;
            story[l] = itog;
            l++;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(stepen(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            string itog = textBox1.Text + "^" + textBox2.Text + "=" + textBox3.Text;
            story[l] = itog;
            l++;
        } 
        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(koren(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            string itog = textBox1.Text + "^(1/" + textBox2.Text + ")=" + textBox3.Text;
            story[l] = itog;
            l++;
        }  
        private void button7_Click(object sender, EventArgs e)
        {
            if (l >= 2)
            {
                textBox4.Text = story[l - 2];
            }
            else
            {
                textBox4.Text = "Его нет";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
         private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
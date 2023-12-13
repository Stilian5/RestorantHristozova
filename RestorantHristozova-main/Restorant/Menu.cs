using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restorant
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double a = double.Parse(textBox6.Text);
            double b = double.Parse(textBox5.Text);
            double c = double.Parse(textBox4.Text);
            if (textBox6.Text != " ")
            {
                double aa = a * 16.60;
                sum += aa;
            }
            if (textBox5.Text != " ")
            {
                double bb = b * 10.50;
                sum += bb;
            }
            if (textBox4.Text != " ")
            {
                double cc = c * 12.30;
                sum += cc;
            }

            double d = double.Parse(textBox3.Text);
            double d1 = double.Parse(textBox2.Text);
            double d2 = double.Parse(textBox1.Text);

            if (textBox3.Text != "")
            {
                double aa = d * 18.70;
                sum += aa;
            }
            if (textBox2.Text != "")
            {
                double bb = d1 * 13.30;
                sum += bb;
            }
            if (textBox1.Text != "")
            {
                double cc = d2 * 17.20;
                sum += cc;
            }

            double f = double.Parse(textBox9.Text);
            double f1 = double.Parse(textBox8.Text);
            double f2 = double.Parse(textBox7.Text);

            if (textBox9.Text != "")
            {
                double aa = f * 18.40;
                sum += aa;
            }
            if (textBox8.Text != "")
            {
                double bb = f1 * 17.30;
                sum += bb;
            }
            if (textBox7.Text != "")
            {
                double cc = f2 * 20.80;
                sum += cc;
            }

            double g = double.Parse(textBox12.Text);
            double g1 = double.Parse(textBox11.Text);
            double g2 = double.Parse(textBox10.Text);

            if (textBox12.Text != "")
            {
                double aa = g * 3.20;
                sum += aa;
            }
            if (textBox11.Text != "")
            {
                double bb = g1 * 3.20;
                sum += bb;
            }
            if (textBox10.Text != "")
            {
                double cc = g2 * 3.20;
                sum += cc;
            }

            double h = double.Parse(textBox15.Text);
            double h1 = double.Parse(textBox14.Text);
            double h2 = double.Parse(textBox13.Text);

            if (textBox15.Text != "")
            {
                double aa = h * 6.60;
                sum += aa;
            }
            if (textBox14.Text != "")
            {
                double bb = h1 * 6.60;
                sum += bb;
            }
            if (textBox13.Text != "")
            {
                double cc = h2 * 5.30;
                sum += cc;
            }

            MessageBox.Show("Вашата сметка е :" + sum);



        }
    }
}

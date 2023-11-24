using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Restorant
{
    public partial class Form2 : Form
    {
        const int Cezar = 16;
        const int Mlechna = 10;
        const int Ruska = 12;
        const int PileOriz = 18;
        const int Musaka = 13;
        const int SvinskaPurjola = 17;
        const int Brauni = 18;
        const int ChiizKeik = 17;
        const int Tiramisu = 20;
        const int Whiskey = 6;
        const int Vodka = 6;
        const int Menta = 4;
        const int Cola = 3;
        const int Fanta = 3;
        const int Sprite = 2;
        const int Coffe = 3;
        const int Choco = 3;
        const int Tea = 2;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salati1.Show();
            osnovno1.Hide();
            desert1.Hide();
            alkohol1.Hide();
            bezalkoholno1.Hide();
            topliNapitki1.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            salati1.Hide();
            osnovno1.Hide();
            desert1.Hide();
            alkohol1.Hide();
            bezalkoholno1.Hide();
            topliNapitki1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salati1.Hide();
            osnovno1.Show();
            desert1.Hide();
            alkohol1.Hide();
            bezalkoholno1.Hide();
            topliNapitki1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salati1.Hide();
            osnovno1.Hide();
            desert1.Show();
            alkohol1.Hide();
            bezalkoholno1.Hide();
            topliNapitki1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            salati1.Hide();
            osnovno1.Hide();
            desert1.Hide();
            alkohol1.Show();
            bezalkoholno1.Hide();
            topliNapitki1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            salati1.Hide();
            osnovno1.Hide();
            desert1.Hide();
            alkohol1.Hide();
            bezalkoholno1.Show();
            topliNapitki1.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            salati1.Hide();
            osnovno1.Hide();
            desert1.Hide();
            alkohol1.Hide();
            bezalkoholno1.Hide();
            topliNapitki1.Show();
        }

        private void topliNapitki1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

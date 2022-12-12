using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        Random rndm = new Random();
        int[] rnd = new int[6];
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGamble_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int f = 0; f < 6; f++)
                {
                    rnd[i] = rndm.Next(0, 100);
                    if (rnd[i] == rnd[f]) i -= 1;
                }
            }

            label1.Text = Convert.ToString(rnd[0]);
            label2.Text = Convert.ToString(rnd[1]);
            label3.Text = Convert.ToString(rnd[2]);
            label4.Text = Convert.ToString(rnd[3]);
            label5.Text = Convert.ToString(rnd[4]);
            label6.Text = Convert.ToString(rnd[5]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

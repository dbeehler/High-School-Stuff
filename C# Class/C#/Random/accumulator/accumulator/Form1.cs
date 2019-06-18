using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accumulator
{
    public partial class Form1 : Form
    {
        int score = 0, secret = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            label1.Text = "Score: " + score;
            secret = rand.Next(1, 3);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (secret == 1)
            {
                score += 1;
                label1.Text = "Score: " + score;
                secret = rand.Next(1, 3);
            }
            else
            {
                MessageBox.Show("you wrong fool");
                score -= 1;
                label1.Text = "Score: " + score;
                secret = rand.Next(1, 3);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (secret == 2)
            {
                score += 1;
                label1.Text = "Score: " + score;
                secret = rand.Next(1, 3);
            }
            else
            {
                MessageBox.Show("you wrong fool");
                score -= 1;
                label1.Text = "Score: " + score;
                secret = rand.Next(1, 3);
            }
        }
    }
}

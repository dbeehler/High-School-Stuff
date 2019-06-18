using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testKek
{
    public partial class Form1 : Form
    {
        int guess, secret;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtNumInput.Text != "")
            {
                guess = Convert.ToInt32(txtNumInput.Text);
            }
            else
            {
                MessageBox.Show("Error, Please Enter a Number");
            }
            if (guess < secret)
            {
                MessageBox.Show("You dumb, you shouldn't guess that low");
            }
            else if (guess == secret){
                MessageBox.Show("Good job you win!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("You are really trying to hard. Guess lower. Dummy.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToParent();
            secret = rand.Next(1, 10);
        }
    }
}

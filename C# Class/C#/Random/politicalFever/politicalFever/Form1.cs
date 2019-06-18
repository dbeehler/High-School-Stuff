using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace politicalFever
{
    public partial class Form1 : Form
    {
        double percentCan1, percentCan2, percentCan3;
        double votesCan1, votesCan2, votesCan3, totalVotes;
        const double TOTAL_PERCENT = 1;
        bool fifty = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            fifty = false;
            percentCan1 = 0;
            percentCan2 = 0;
            percentCan3 = 0;
            votesCan1 = 0;
            votesCan2 = 0;
            votesCan3 = 0;
            totalVotes = 0;

            percentCan1 = Convert.ToDouble(txtCan1.Text);
            percentCan2 = Convert.ToDouble(txtCan2.Text);
            percentCan3 = TOTAL_PERCENT - (percentCan1 + percentCan2);
            totalVotes = Convert.ToInt32(txtTotalVote.Text);

            fiftyPercent();
            fifteenPercent();

            votesCan1 = Convert.ToInt32(totalVotes * percentCan1);
            votesCan2 = Convert.ToInt32(totalVotes * percentCan2);
            votesCan3 = Convert.ToInt32(totalVotes * percentCan3);


            lblCan3.Text = percentCan3.ToString();
            lblFinalCan1.Text = votesCan1.ToString();
            lblFinalCan2.Text = votesCan2.ToString();
            lblFinalCan3.Text = votesCan3.ToString();
        }

        private void fiftyPercent()
        {
            if (percentCan1 > .5)
            {
                MessageBox.Show("Candidate 1 got more than 50%, he wins all!");
                percentCan1 = 1;
                percentCan2 = 0;
                percentCan3 = 0;
                fifty = true;
            }
            else if (percentCan2 > .5)
            {
                MessageBox.Show("Candidate 2 got more than 50%, he wins all!");
                percentCan1 = 0;
                percentCan2 = 1;
                percentCan3 = 0;
                fifty = true;
            }
            else if (percentCan3 > .5)
            {
                MessageBox.Show("Candidate 3 got more than 50%, he wins all!");
                percentCan1 = 0;
                percentCan2 = 0;
                percentCan1 = 1;
                fifty = true;
            }
        }

        private void fifteenPercent()
        {
            if (fifty == false)
            {
                if (percentCan1 < .15)
                {
                    MessageBox.Show("Candidate 1 is non viable, his percentage will be spread evenly");
                    percentCan2 += percentCan1 / 2;
                    percentCan3 += percentCan1 / 2;
                    percentCan1 = 0;
                }
                else if (percentCan2 < .15)
                {
                    MessageBox.Show("Candidate 2 is non viable, his percentage will be spread evenly");
                    percentCan1 += percentCan2 / 2;
                    percentCan3 += percentCan2 / 2;
                    percentCan2 = 0;
                }
                else if (percentCan3 < .15)
                {
                    MessageBox.Show("Candidate 3 is non viable, his percentage will be spread evenly");
                    percentCan1 += percentCan3 / 2;
                    percentCan2 += percentCan3 / 2;
                    percentCan3 = 0;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}

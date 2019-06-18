using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace romanNumeralFinder
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnCalcualte_Click(object sender, EventArgs e)
        {
            int total = 0;
            string numeral = txtNumeral.Text;
            numeral = numeral.ToUpper();

            for (int i = 0; i < numeral.Length; i++)
            {
                char currentNumeral = numeral[i];
                char lastNumeral;
                if (i == 0)
                {
                    lastNumeral = currentNumeral;
                }
                else
                {
                    lastNumeral = numeral[i - 1];
                }

                if (lastNumeral == 'I' && currentNumeral == 'V')
                {
                    total -= 2;
                }
                else if (lastNumeral == 'I' && currentNumeral == 'X')
                {
                    total -= 2;
                }
                else if (lastNumeral == 'I' && currentNumeral == 'L')
                {
                    total -= 2;
                }
                else if (lastNumeral == 'I' && currentNumeral == 'C')
                {
                    total -= 2;
                }

                if (currentNumeral == 'I')
                {
                    total += 1;
                }
                else if (currentNumeral == 'V')
                {
                    total += 5;
                }
                else if (currentNumeral == 'X'){
                    total += 10;
                }
                else if (currentNumeral == 'L')
                {
                    total += 50;
                }
                else if (currentNumeral == 'C')
                {
                    total += 100;
                }
                else
                {
                    MessageBox.Show("Please Enter a Roman Numeral smaller than 100 (C). Applicable Characters are: I, V, X, L, C");
                    total = 0;
                    break;
                }
            }
            txtNumeral.Text = string.Empty;
            lblNumber.Text = total.ToString();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}

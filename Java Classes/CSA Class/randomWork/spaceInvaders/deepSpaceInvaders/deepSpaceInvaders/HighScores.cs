using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deepSpaceInvaders
{
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            int lineCount = System.IO.File.ReadLines(@"C:\Users\Public\scores.txt").Count();
            string name = System.IO.File.ReadAllText(@"C:\Users\Public\scores.txt");
            this.CenterToScreen();
            for(int x = 0; x < lineCount; x++)
            {
            }
        }

    }
}

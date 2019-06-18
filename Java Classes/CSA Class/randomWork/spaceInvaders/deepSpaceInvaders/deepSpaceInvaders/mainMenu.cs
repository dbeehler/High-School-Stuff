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
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            level open = new level();
            open.ShowDialog();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            HighScores ope = new HighScores();
            ope.ShowDialog();
        }
    }
}

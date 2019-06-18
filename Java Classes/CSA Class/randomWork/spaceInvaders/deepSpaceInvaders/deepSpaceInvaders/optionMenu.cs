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
    public partial class optionMenu : Form
    {
        public string username = "";
        private static List<Form> openForms = new List<Form>();
        public optionMenu()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            username = usrName.Text;
            System.IO.File.AppendAllText(@"C:\Users\Public\scores.txt", username + "," + level.score + "," + Environment.NewLine);
            foreach (Form f in openForms)
            {
                if (f.Name != "mainMenu")
                    f.Close();
            }
            Close();
        }

        private void optionMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            blinkText();
        }

        private void blinkText()
        {
            if(lblName.Visible == true)
                lblName.Visible = false;
            else if(lblName.Visible == false)
                lblName.Visible = true;
        }
    }
}
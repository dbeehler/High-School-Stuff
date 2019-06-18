using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProgramTesting{

    public partial class Form1 : Form{
        int number1, number2, final;

        public Form1(){
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            final = number1 + number2;
            txtNumber1.Text = final.ToString();
            txtNumber2.Text = "";
        }

    }
}

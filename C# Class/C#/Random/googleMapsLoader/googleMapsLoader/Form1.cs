using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace googleMapsLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZipCode.Text;

            StringBuilder searchQuery = new StringBuilder();
            searchQuery.Append("www.Google.com/maps/place/");
            if (street != string.Empty)
            {
                searchQuery.Append(street + "," + "+");
            }
            if (city != string.Empty)
            {
                searchQuery.Append(city + "," + "+");
            }
            if (state != string.Empty)
            {
                searchQuery.Append(state + "," + "+");
            }
            if (zip != string.Empty)
            {
                searchQuery.Append(zip + "," + "+");
            }

            mainWebBrowser.Navigate(searchQuery.ToString());
        }
    }
}

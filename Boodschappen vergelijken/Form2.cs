using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boodschappen_vergelijken
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            cbplus.AutoCheck = true;
            cbjumbo.AutoCheck = true;
            cbah.AutoCheck = true;
            cbvomar.AutoCheck = true;
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }






        // checkboxen moet boolens opslaan 
        // if checkbox is check bool is true 
        bool pluschecked, dekachecked, vomarchecked, ahchecked, jumbochecked;
        private void cbplus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbplus.Checked){pluschecked = true;}
            else{pluschecked = false;}
        }

        private void cbdeka_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdeka.Checked){dekachecked = true;}
            else{dekachecked = false;}
        }

        private void cbvomar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbvomar.Checked){vomarchecked = true;}
            else{vomarchecked = false;}
        }

        private void cbjumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbjumbo.Checked){jumbochecked = true;}
            else{jumbochecked = false;}
        }

        private void cbah_CheckedChanged(object sender, EventArgs e)
        {
            if (cbah.Checked){ahchecked = true;}
            else{ahchecked = false;}
        }






        // textbox leeghalen en in listboxproductlijst stoppen
        // ook in array stoppen
        private void btntoevoegen_Click(object sender, EventArgs e)
        {
            listboxproductlijst.Items.Add(textboxtoevoegen);
            if (textboxtoevoegen.Text == "")
            {
                MessageBox.Show("vul aub een product in ");
            }
        }







        // de voorbenoemde array moeten worden gequeried met de database 
        // info wordt uit db gehaald en met deze knop worden de sums op desc gezet in listboxwinkel
        // de array wordt een voor een gequeried en gekeken bij welke hij goedkoper is en dat wordt aan listboxproductindividu toegevoegd
        private void vergelijkbtn_Click(object sender, EventArgs e)
        {
            if (listboxproductlijst.Text == "")
            {
                MessageBox.Show("vul aub een product in ");
            }

        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Boodschappen_vergelijken
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // zet de buttons op aan
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
        int intID=0;
        bool pluschecked, dekachecked, vomarchecked, ahchecked, jumbochecked;
        
        private void cbplus_CheckedChanged(object sender, EventArgs e)
        {   //checked of de buttons aan of uit staan
            if (cbplus.Checked)
            {
                pluschecked = true;
                intID++;
            // doet een het winkel ID + of - 1 zodat 
            }
            else
            {   pluschecked = false;
                intID--;            
            }
        }

        private void cbdeka_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdeka.Checked)
            {
                dekachecked = true;
                intID++;
            }
            else
            {
                dekachecked = false;
                intID--;
            }
        }

        private void cbvomar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbvomar.Checked)
            {
                vomarchecked = true;
                intID++;
            }
            else
            {
                vomarchecked = false;
                intID--;
            }
        }

        private void cbjumbo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbjumbo.Checked){
                jumbochecked = true;
                intID++;
            }
            else
            {
                jumbochecked = false;
                intID--;
            }
        }

        private void cbah_CheckedChanged(object sender, EventArgs e)
        {
            if (cbah.Checked)
            {
                ahchecked = true;
                intID++;
            }
            else
            {
                ahchecked = false;
                intID--;
            }
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
            if (intID == 5)
            {
                string query = "SELECT * FROM `winkel` ";
            }
            
            if (listboxproductlijst.Text == "")
            {
                //MessageBox.Show("vul aub een product in ");
                MessageBox.Show(intID.ToString());
            }


     

        }



    }
}

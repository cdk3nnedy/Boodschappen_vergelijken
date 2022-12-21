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
using MySql.Data.MySqlClient;

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
        // checkboxen moet bool  opslaan 
        // if checkbox is check bool is true 
        int intID=0;
        bool pluschecked, dekachecked, vomarchecked, ahchecked, jumbochecked;
        public void GetDataFromMySQL()
        {
            string server = "localhost";
            string database = "boodschappenvergelijken";
            string username = "root";
            string password = "";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" +
                "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            // Execute a query and retrieve the results
            string query = "SELECT * FROM product";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();

            // Loop through the rows in the data reader and add them to the ListBox control
            while (reader.Read())
            {
                string productName = reader["naam"].ToString();
                listboxproductlijst.Items.Add(productName);
            }
            reader.Close();
            conn.Close();
        }

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
            if (cbjumbo.Checked)
            {
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


        private void listboxproductlijst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        // de voorbenoemde array moeten worden gequeried met de database 
        // info wordt uit db gehaald en met deze knop worden de sums op desc gezet in listboxwinkel
        // de array wordt een voor een gequeried en gekeken bij welke hij goedkoper is en dat wordt aan listboxproductindividu toegevoegd
        private void vergelijkbtn_Click_1(object sender, EventArgs e)
        {
            if (intID == 0)
            {
                MessageBox.Show("Selecteer één(of meerdere) winkel(s)");
            }
            if (intID == 5)
            {


                //MySqlDataReader reader = command.ExecuteReader();
            }

            if (listboxproductlijst.Text == "")
            {
                MessageBox.Show("vul aub een product in ");
               
            }
        }

        // textbox leeghalen en in listboxproductlijst stoppen
        // ook in array stoppen
        private void btntoevoegen_Click_1(object sender, EventArgs e)
        {
            GetDataFromMySQL();
            string textProduct = textboxtoevoegen.Text;
            listboxproductindividu.Items.Add(textboxtoevoegen.ToString());

            if (textboxtoevoegen.Text == "")
            {
                MessageBox.Show("vul aub een product in ");
            }
        }







    }
}

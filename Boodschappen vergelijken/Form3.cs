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
    public partial class Form3 : Form
    {
        int Foutlogin = 0;
        public Form3()
        {
            InitializeComponent();
     
        }
 
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void InitializeMyControl()
        {
          
           
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string strUsername = txtUsername.Text;
            string strWachtwoord = txtWachtwoord.Text;
    
            if (strUsername == "admin" && strWachtwoord == "admin")
            {
                MessageBox.Show("u bent succesvol ingelogd!");
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
            else if (strUsername!="admin"&&strWachtwoord!="admin"){
                MessageBox.Show("gegevens waren incorrect probeer opnieuw ");
            }
             if (Foutlogin == 3)   {
                
                MessageBox.Show("u heeft al 3 keer verkeerde gegevens ingevuld u gaat terug naar het hoofdscherm");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                Foutlogin = 0;
            }
        }
        

    }
}

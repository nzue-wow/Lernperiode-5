using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswortManager
{
    public partial class EingabePasswort : Form
    {
        public EingabePasswort()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1Website.TextAlign = HorizontalAlignment.Center;
            textBox2Passwort.TextAlign = HorizontalAlignment.Center;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            
            string website = textBox1Website.Text;
            string passwort = textBox2Passwort.Text;

            if (!string.IsNullOrWhiteSpace(website) && !string.IsNullOrWhiteSpace(passwort))
            {
                Form1.passwortListe.Add((website, passwort));  // Speichern in Liste
                MessageBox.Show("Passwort gespeichert!");
                this.Close();  
            }
            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");  // Fehler wenn Felder leer sind
            }
        }

    }
}




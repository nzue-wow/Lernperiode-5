using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;  
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace PasswortManager
{
    

    public partial class Form1 : Form
    {
        

        public static List<(string Website, string Passwort)> passwortListe = new List<(string, string)>();

        

        public Form1()
        { InitializeComponent();

           
            this.StartPosition = FormStartPosition.CenterScreen; // Fenster zentriert starten
            LoadPasswords();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.SavePasswords();  // Passwörter beim Schließen speichern
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EingabePasswort().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new SavedPasswords().ShowDialog();
        }

        // Methode zum Speichern der Passwörter
        public static void SavePasswords()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "passwords.json");  // Speicherort

                
                

                
                
                MessageBox.Show("Passwörter wurden gespeichert!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern: {ex.Message}");
            }
        }

        // Methode zum Laden der Passwörter
        public static void LoadPasswords()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "passwords.json");

                if (File.Exists(filePath))
                {
                   
                    string json = File.ReadAllText(filePath);

                    
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden: {ex.Message}");
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.Sqlite; // für SqliteConnection
using SQLitePCL;             // für Batteries_V2.Init()


namespace PasswortManager
{
    public partial class EingabePasswort : Form
    {


        public EingabePasswort()
        {
            Batteries_V2.Init(); // <- initialisiert die SQLite-Engine

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
                string connectionString = "Data Source=\"C:\\Users\\nenaz\\source\\repos\\PasswortManager\\SQL_PasswortmanagerDB.db\"";

                using (SqliteConnection connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    SqliteCommand insertCommand = new SqliteCommand("INSERT INTO SavedPasswords (WebseitenName, Passwort) VALUES (@WebseitenName, @Passwort)", connection);

                    insertCommand.Parameters.AddWithValue("@WebseitenName", website);
                    insertCommand.Parameters.AddWithValue("@Passwort", passwort);

                    insertCommand.ExecuteNonQuery();  // <-- Wichtig: Führe den Befehl aus
                }

                Form1.passwortListe.Add((website, passwort));
                MessageBox.Show("Passwort gespeichert!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
            }
        }
    }

}



//private void BtnSave_Click(object sender, EventArgs e)

//{

//    string connectionString = "Server=KAITO\\KAITO;Database=ChessGameDB;Trusted_Connection=True;";

//    using (SqlConnection connection = new SqlConnection(connectionString))

//    {

//        connection.Open();

//        // Bestehende Daten löschen

//        SqlCommand deleteCommand = new SqlCommand("DELETE FROM ChessBoardState", connection);

//        deleteCommand.ExecuteNonQuery();

//        // Alle Buttons von A1 bis H8 durchgehen

//        for (char col = 'A'; col <= 'H'; col++)

//        {

//            for (int row = 1; row <= 8; row++)

//            {

//                string feldname = $"btn{col}{row}";

//                Control[] controls = this.Controls.Find(feldname, true);

//                if (controls.Length > 0 && controls[0] is Button button)

//                {

//                    string inhalt = button.Tag?.ToString() ?? "";


//                    SqlCommand insertCommand = new SqlCommand("INSERT INTO ChessBoardState (Feld, Inhalt) VALUES (@Feld, @Inhalt)", connection);

//                    insertCommand.Parameters.AddWithValue("@Feld", $"{col}{row}");

//                    insertCommand.Parameters.AddWithValue("@Inhalt", inhalt);

//                    insertCommand.ExecuteNonQuery();

//                }

//            }

//        }

//        MessageBox.Show("Spielstand erfolgreich gespeichert.");

//    }

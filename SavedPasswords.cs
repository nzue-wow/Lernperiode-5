using Microsoft.Data.Sqlite;
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
    public partial class SavedPasswords : Form
    {
        public SavedPasswords()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadPasswords();
            buttonDelete.Click += ButtonDelete_Click;
        }



        private void LoadPasswords()
        {
            listBoxPasswords.Items.Clear();

            string connectionString = "Data Source=\"C:\\Users\\nenaz\\source\\repos\\PasswortManager\\SQL_PasswortmanagerDB.db\"";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT WebseitenName, Passwort FROM SavedPasswords";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string website = reader.GetString(0);
                        string passwort = reader.GetString(1);

                        listBoxPasswords.Items.Add($"{website}: {passwort}");
                    }
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPasswords.SelectedItem != null)
            {
                int selectedIndex = listBoxPasswords.SelectedIndex;
                Form1.passwortListe.RemoveAt(selectedIndex);
                listBoxPasswords.Items.RemoveAt(selectedIndex);
                MessageBox.Show("Passwort gelöscht!");
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie ein Passwort zum Löschen aus.");
            }
        }

        private void ButtonSuche_Click(object sender, EventArgs e)
        {
            string suchbegriff = textBoxSuche.Text.Trim().ToLower();

            listBoxPasswords.Items.Clear();

            string connectionString = "Data Source=\"C:\\Users\\nenaz\\source\\repos\\PasswortManager\\SQL_PasswortmanagerDB.db\"";

            using (var connection = new Microsoft.Data.Sqlite.SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT WebseitenName, Passwort FROM SavedPasswords WHERE LOWER(WebseitenName) LIKE @suchbegriff";
                command.Parameters.AddWithValue("@suchbegriff", "%" + suchbegriff + "%");

                using (var reader = command.ExecuteReader())
                {
                    bool gefunden = false;
                    while (reader.Read())
                    {
                        string website = reader.GetString(0);
                        string passwort = reader.GetString(1);

                        listBoxPasswords.Items.Add($"{website}: {passwort}");
                        gefunden = true;
                    }

                    if (!gefunden)
                    {
                        listBoxPasswords.Items.Add("Keine Einträge gefunden.");
                    }
                }
            }
        }

        private void SavedPasswords_Load(object sender, EventArgs e)
        {

        }
    }
}


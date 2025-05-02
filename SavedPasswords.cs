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
            if (listBoxPasswords == null)
            {
                MessageBox.Show("Fehler: listBoxPasswords existiert nicht!");
                return;
            }

            

            foreach (var entry in Form1.passwortListe)
            {
                listBoxPasswords.Items.Add($"{entry.Website}: {entry.Passwort}");
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

        private void SavedPasswords_Load(object sender, EventArgs e)
        {

        }
    }
}


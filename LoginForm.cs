using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace PasswortManager
{
    public partial class LoginForm : Form
    {
        private string korrektesPasswort = "1234";  // Passwort 

        public LoginForm()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            textBoxPasswort.TextAlign = HorizontalAlignment.Center;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPasswort.Text == korrektesPasswort)
            {
                this.Hide();
                Form1 hauptfenster = new Form1();
                hauptfenster.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Falsches Passwort!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPasswort_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


namespace PasswortManager
{
    partial class SavedPasswords
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPasswords;  // <--- NEU HINZUGEFÜGT

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listBoxPasswords = new System.Windows.Forms.ListBox();
            buttonDelete = new System.Windows.Forms.Button();
            textBoxSuche = new System.Windows.Forms.TextBox();
            buttonSuche = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // listBoxPasswords
            // 
            listBoxPasswords.FormattingEnabled = true;
            listBoxPasswords.ItemHeight = 32;
            listBoxPasswords.Location = new System.Drawing.Point(22, 26);
            listBoxPasswords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBoxPasswords.Name = "listBoxPasswords";
            listBoxPasswords.Size = new System.Drawing.Size(1225, 644);
            listBoxPasswords.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new System.Drawing.Point(1131, 795);
            buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(116, 59);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxSuche
            // 
            textBoxSuche.Location = new System.Drawing.Point(12, 692);
            textBoxSuche.Name = "textBoxSuche";
            textBoxSuche.Size = new System.Drawing.Size(331, 39);
            textBoxSuche.TabIndex = 2;
            // 
            // buttonSuche
            // 
            buttonSuche.Location = new System.Drawing.Point(349, 692);
            buttonSuche.Name = "buttonSuche";
            buttonSuche.Size = new System.Drawing.Size(173, 42);
            buttonSuche.TabIndex = 3;
            buttonSuche.Text = "Suchen";
            buttonSuche.UseVisualStyleBackColor = true;
            buttonSuche.Click += ButtonSuche_Click;
            // 
            // SavedPasswords
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LavenderBlush;
            ClientSize = new System.Drawing.Size(1272, 869);
            Controls.Add(buttonSuche);
            Controls.Add(textBoxSuche);
            Controls.Add(buttonDelete);
            Controls.Add(listBoxPasswords);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SavedPasswords";
            Text = "Gespeicherte Passwörter";
            Load += SavedPasswords_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.Button buttonSuche;
    }
}

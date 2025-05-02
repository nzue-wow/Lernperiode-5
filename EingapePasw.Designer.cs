namespace PasswortManager
{
    partial class EingabePasswort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Website = new System.Windows.Forms.TextBox();
            this.textBox2Passwort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3Passwort = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passwort eingabe:";
            // 
            // textBox1Website
            // 
            this.textBox1Website.Location = new System.Drawing.Point(35, 138);
            this.textBox1Website.Name = "textBox1Website";
            this.textBox1Website.Size = new System.Drawing.Size(269, 31);
            this.textBox1Website.TabIndex = 1;
            // 
            // textBox2Passwort
            // 
            this.textBox2Passwort.Location = new System.Drawing.Point(608, 138);
            this.textBox2Passwort.Name = "textBox2Passwort";
            this.textBox2Passwort.Size = new System.Drawing.Size(307, 31);
            this.textBox2Passwort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Website/App";
            // 
            // label3Passwort
            // 
            this.label3Passwort.AutoSize = true;
            this.label3Passwort.Location = new System.Drawing.Point(603, 99);
            this.label3Passwort.Name = "label3Passwort";
            this.label3Passwort.Size = new System.Drawing.Size(100, 25);
            this.label3Passwort.TabIndex = 4;
            this.label3Passwort.Text = "Passwort";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(770, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Speichern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // EingabePasswort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1174, 679);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3Passwort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2Passwort);
            this.Controls.Add(this.textBox1Website);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EingabePasswort";
            this.Text = "EingapePasw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Website;
        private System.Windows.Forms.TextBox textBox2Passwort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3Passwort;
        private System.Windows.Forms.Button button3;
    }
}
namespace ISOS.GUI.Windows
{
    partial class pokazListeZapisanychPrzedmiotow
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
            this.listaPrzedmiotow = new System.Windows.Forms.ListBox();
            this.buttonWypisz = new System.Windows.Forms.Button();
            this.buttonPokazProfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaPrzedmiotow
            // 
            this.listaPrzedmiotow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listaPrzedmiotow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaPrzedmiotow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.listaPrzedmiotow.FormattingEnabled = true;
            this.listaPrzedmiotow.Location = new System.Drawing.Point(12, 12);
            this.listaPrzedmiotow.Name = "listaPrzedmiotow";
            this.listaPrzedmiotow.Size = new System.Drawing.Size(322, 145);
            this.listaPrzedmiotow.TabIndex = 0;
            this.listaPrzedmiotow.SelectedIndexChanged += new System.EventHandler(this.listaPrzedmiotow_SelectedIndexChanged);
            // 
            // buttonWypisz
            // 
            this.buttonWypisz.Location = new System.Drawing.Point(259, 163);
            this.buttonWypisz.Name = "buttonWypisz";
            this.buttonWypisz.Size = new System.Drawing.Size(75, 23);
            this.buttonWypisz.TabIndex = 2;
            this.buttonWypisz.Text = "Wypisz";
            this.buttonWypisz.UseVisualStyleBackColor = true;
            this.buttonWypisz.Click += new System.EventHandler(this.buttonWypisz_Click);
            // 
            // buttonPokazProfil
            // 
            this.buttonPokazProfil.Location = new System.Drawing.Point(61, 163);
            this.buttonPokazProfil.Name = "buttonPokazProfil";
            this.buttonPokazProfil.Size = new System.Drawing.Size(192, 23);
            this.buttonPokazProfil.TabIndex = 3;
            this.buttonPokazProfil.Text = "Pokaż profil prowadzącego przedmiot";
            this.buttonPokazProfil.UseVisualStyleBackColor = true;
            this.buttonPokazProfil.Click += new System.EventHandler(this.buttonPokazProfil_Click);
            // 
            // pokazListeZapisanychPrzedmiotow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(349, 199);
            this.Controls.Add(this.buttonPokazProfil);
            this.Controls.Add(this.buttonWypisz);
            this.Controls.Add(this.listaPrzedmiotow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pokazListeZapisanychPrzedmiotow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zapisano na przedmioty";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokazListeZapisanychPrzedmiotow_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaPrzedmiotow;
        private System.Windows.Forms.Button buttonWypisz;
        private System.Windows.Forms.Button buttonPokazProfil;
    }
}
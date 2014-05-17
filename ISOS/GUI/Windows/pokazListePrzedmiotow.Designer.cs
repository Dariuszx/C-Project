namespace ISOS.GUI.Windows
{
    partial class pokazListePrzedmiotow
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
            this.label23 = new System.Windows.Forms.Label();
            this.labelProwadzacyNazwa = new System.Windows.Forms.Label();
            this.labelNazwaPrzedmiotu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKonsultacjeTakNie = new System.Windows.Forms.Label();
            this.buttonPokazProfilWykladowcy = new System.Windows.Forms.Button();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonWypisz = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
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
            this.listaPrzedmiotow.Size = new System.Drawing.Size(269, 145);
            this.listaPrzedmiotow.TabIndex = 0;
            this.listaPrzedmiotow.SelectedIndexChanged += new System.EventHandler(this.listaPrzedmiotow_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("AIGDT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label23.Location = new System.Drawing.Point(322, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 14);
            this.label23.TabIndex = 3;
            this.label23.Text = "NAZWA:";
            // 
            // labelProwadzacyNazwa
            // 
            this.labelProwadzacyNazwa.AutoSize = true;
            this.labelProwadzacyNazwa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelProwadzacyNazwa.Location = new System.Drawing.Point(378, 38);
            this.labelProwadzacyNazwa.Name = "labelProwadzacyNazwa";
            this.labelProwadzacyNazwa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProwadzacyNazwa.Size = new System.Drawing.Size(95, 13);
            this.labelProwadzacyNazwa.TabIndex = 4;
            this.labelProwadzacyNazwa.Text = "Jarosław Kowalski";
            this.labelProwadzacyNazwa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNazwaPrzedmiotu
            // 
            this.labelNazwaPrzedmiotu.AutoSize = true;
            this.labelNazwaPrzedmiotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazwaPrzedmiotu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelNazwaPrzedmiotu.Location = new System.Drawing.Point(378, 14);
            this.labelNazwaPrzedmiotu.Name = "labelNazwaPrzedmiotu";
            this.labelNazwaPrzedmiotu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNazwaPrzedmiotu.Size = new System.Drawing.Size(140, 13);
            this.labelNazwaPrzedmiotu.TabIndex = 5;
            this.labelNazwaPrzedmiotu.Text = "Teoria obwodów i sygnałów";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AIGDT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(287, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "PROWADZĄCY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AIGDT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(287, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "KONSULTACJE:";
            // 
            // labelKonsultacjeTakNie
            // 
            this.labelKonsultacjeTakNie.AutoSize = true;
            this.labelKonsultacjeTakNie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelKonsultacjeTakNie.Location = new System.Drawing.Point(379, 59);
            this.labelKonsultacjeTakNie.Name = "labelKonsultacjeTakNie";
            this.labelKonsultacjeTakNie.Size = new System.Drawing.Size(28, 13);
            this.labelKonsultacjeTakNie.TabIndex = 8;
            this.labelKonsultacjeTakNie.Text = "TAK";
            // 
            // buttonPokazProfilWykladowcy
            // 
            this.buttonPokazProfilWykladowcy.Location = new System.Drawing.Point(382, 115);
            this.buttonPokazProfilWykladowcy.Name = "buttonPokazProfilWykladowcy";
            this.buttonPokazProfilWykladowcy.Size = new System.Drawing.Size(136, 23);
            this.buttonPokazProfilWykladowcy.TabIndex = 9;
            this.buttonPokazProfilWykladowcy.Text = "Pokaż profil wykładowcy";
            this.buttonPokazProfilWykladowcy.UseVisualStyleBackColor = true;
            this.buttonPokazProfilWykladowcy.Visible = false;
            this.buttonPokazProfilWykladowcy.Click += new System.EventHandler(this.buttonPokazProfilWykladowcy_Click);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(443, 86);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 10;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Visible = false;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonWypisz
            // 
            this.buttonWypisz.Location = new System.Drawing.Point(443, 86);
            this.buttonWypisz.Name = "buttonWypisz";
            this.buttonWypisz.Size = new System.Drawing.Size(75, 23);
            this.buttonWypisz.TabIndex = 11;
            this.buttonWypisz.Text = "Wypisz";
            this.buttonWypisz.UseVisualStyleBackColor = true;
            this.buttonWypisz.Visible = false;
            this.buttonWypisz.Click += new System.EventHandler(this.buttonWypisz_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(443, 86);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytuj.TabIndex = 12;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Visible = false;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(175, 163);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(106, 23);
            this.buttonDodaj.TabIndex = 13;
            this.buttonDodaj.Text = "Dodaj przedmiot";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Visible = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(362, 86);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 14;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Visible = false;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // pokazListePrzedmiotow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(528, 192);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonWypisz);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.buttonPokazProfilWykladowcy);
            this.Controls.Add(this.labelKonsultacjeTakNie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNazwaPrzedmiotu);
            this.Controls.Add(this.labelProwadzacyNazwa);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.listaPrzedmiotow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pokazListePrzedmiotow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokaż listę przedmiotów";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokazListePrzedmiotow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaPrzedmiotow;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelProwadzacyNazwa;
        private System.Windows.Forms.Label labelNazwaPrzedmiotu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKonsultacjeTakNie;
        private System.Windows.Forms.Button buttonPokazProfilWykladowcy;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonWypisz;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
    }
}
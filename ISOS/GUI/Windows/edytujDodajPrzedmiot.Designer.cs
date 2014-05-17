namespace ISOS.GUI.Windows
{
    partial class edytujDodajPrzedmiot
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNazwaPrzedmiotow = new System.Windows.Forms.TextBox();
            this.inputIdPrzedmiotu = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.listaWykladowcow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa przedmiotu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(73, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID przedmiotu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wykładowca prowadzący:";
            // 
            // inputNazwaPrzedmiotow
            // 
            this.inputNazwaPrzedmiotow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.inputNazwaPrzedmiotow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNazwaPrzedmiotow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.inputNazwaPrzedmiotow.Location = new System.Drawing.Point(154, 14);
            this.inputNazwaPrzedmiotow.Name = "inputNazwaPrzedmiotow";
            this.inputNazwaPrzedmiotow.Size = new System.Drawing.Size(140, 20);
            this.inputNazwaPrzedmiotow.TabIndex = 3;
            // 
            // inputIdPrzedmiotu
            // 
            this.inputIdPrzedmiotu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.inputIdPrzedmiotu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputIdPrzedmiotu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.inputIdPrzedmiotu.Location = new System.Drawing.Point(154, 40);
            this.inputIdPrzedmiotu.Name = "inputIdPrzedmiotu";
            this.inputIdPrzedmiotu.Size = new System.Drawing.Size(140, 20);
            this.inputIdPrzedmiotu.TabIndex = 4;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(219, 177);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Visible = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(138, 179);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytuj.TabIndex = 7;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Visible = false;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // listaWykladowcow
            // 
            this.listaWykladowcow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listaWykladowcow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaWykladowcow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.listaWykladowcow.FormattingEnabled = true;
            this.listaWykladowcow.Location = new System.Drawing.Point(154, 78);
            this.listaWykladowcow.Name = "listaWykladowcow";
            this.listaWykladowcow.Size = new System.Drawing.Size(140, 93);
            this.listaWykladowcow.TabIndex = 8;
            this.listaWykladowcow.SelectedIndexChanged += new System.EventHandler(this.listaWykladowcow_SelectedIndexChanged_1);
            // 
            // edytujDodajPrzedmiot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(316, 216);
            this.Controls.Add(this.listaWykladowcow);
            this.Controls.Add(this.buttonEdytuj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.inputIdPrzedmiotu);
            this.Controls.Add(this.inputNazwaPrzedmiotow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "edytujDodajPrzedmiot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edytuj / dodaj przedmiot";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edytujDodajPrzedmiot_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNazwaPrzedmiotow;
        private System.Windows.Forms.TextBox inputIdPrzedmiotu;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.ListBox listaWykladowcow;
    }
}
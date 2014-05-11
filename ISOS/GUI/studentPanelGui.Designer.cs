namespace ISOS.GUI
{
    partial class studentPanelGui
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nickStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imieNazwiskoLabel = new System.Windows.Forms.Label();
            this.nazwaUzytkownikaLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pokazListeButton = new System.Windows.Forms.Button();
            this.pokazWykladowcowButton = new System.Windows.Forms.Button();
            this.zapiszNaPrzedmiotButton = new System.Windows.Forms.Button();
            this.zapiszNaKonsultacjeButton = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nickStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 327);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(655, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel1.Text = "Zalogowano jako:";
            // 
            // nickStatusLabel
            // 
            this.nickStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.nickStatusLabel.Name = "nickStatusLabel";
            this.nickStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.nickStatusLabel.Text = "dybkad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panel Studenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imie i nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(24, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwa użytkownika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(24, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email:";
            // 
            // imieNazwiskoLabel
            // 
            this.imieNazwiskoLabel.AutoSize = true;
            this.imieNazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieNazwiskoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.imieNazwiskoLabel.Location = new System.Drawing.Point(147, 44);
            this.imieNazwiskoLabel.Name = "imieNazwiskoLabel";
            this.imieNazwiskoLabel.Size = new System.Drawing.Size(86, 15);
            this.imieNazwiskoLabel.TabIndex = 5;
            this.imieNazwiskoLabel.Text = "Dariusz Dybka";
            // 
            // nazwaUzytkownikaLabel
            // 
            this.nazwaUzytkownikaLabel.AutoSize = true;
            this.nazwaUzytkownikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaUzytkownikaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.nazwaUzytkownikaLabel.Location = new System.Drawing.Point(147, 70);
            this.nazwaUzytkownikaLabel.Name = "nazwaUzytkownikaLabel";
            this.nazwaUzytkownikaLabel.Size = new System.Drawing.Size(46, 15);
            this.nazwaUzytkownikaLabel.TabIndex = 6;
            this.nazwaUzytkownikaLabel.Text = "dybkad";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(210)))), ((int)(((byte)(138)))));
            this.emailLabel.Location = new System.Drawing.Point(147, 95);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(128, 15);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "dybkad@ee.pw.edu.pl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(392, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zapisano na przedmioty:";
            // 
            // pokazListeButton
            // 
            this.pokazListeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pokazListeButton.ForeColor = System.Drawing.Color.Black;
            this.pokazListeButton.Location = new System.Drawing.Point(553, 41);
            this.pokazListeButton.Name = "pokazListeButton";
            this.pokazListeButton.Size = new System.Drawing.Size(75, 23);
            this.pokazListeButton.TabIndex = 9;
            this.pokazListeButton.Text = "Pokaż liste";
            this.pokazListeButton.UseVisualStyleBackColor = true;
            // 
            // pokazWykladowcowButton
            // 
            this.pokazWykladowcowButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pokazWykladowcowButton.ForeColor = System.Drawing.Color.Black;
            this.pokazWykladowcowButton.Location = new System.Drawing.Point(27, 170);
            this.pokazWykladowcowButton.Name = "pokazWykladowcowButton";
            this.pokazWykladowcowButton.Size = new System.Drawing.Size(158, 23);
            this.pokazWykladowcowButton.TabIndex = 10;
            this.pokazWykladowcowButton.Text = "Pokaż liste wykładowców";
            this.pokazWykladowcowButton.UseVisualStyleBackColor = true;
            this.pokazWykladowcowButton.Click += new System.EventHandler(this.pokazWykladowcowButton_Click);
            // 
            // zapiszNaPrzedmiotButton
            // 
            this.zapiszNaPrzedmiotButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.zapiszNaPrzedmiotButton.ForeColor = System.Drawing.Color.Black;
            this.zapiszNaPrzedmiotButton.Location = new System.Drawing.Point(27, 210);
            this.zapiszNaPrzedmiotButton.Name = "zapiszNaPrzedmiotButton";
            this.zapiszNaPrzedmiotButton.Size = new System.Drawing.Size(158, 23);
            this.zapiszNaPrzedmiotButton.TabIndex = 11;
            this.zapiszNaPrzedmiotButton.Text = "Zapisz się na przedmiot";
            this.zapiszNaPrzedmiotButton.UseVisualStyleBackColor = true;
            // 
            // zapiszNaKonsultacjeButton
            // 
            this.zapiszNaKonsultacjeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.zapiszNaKonsultacjeButton.ForeColor = System.Drawing.Color.Black;
            this.zapiszNaKonsultacjeButton.Location = new System.Drawing.Point(27, 249);
            this.zapiszNaKonsultacjeButton.Name = "zapiszNaKonsultacjeButton";
            this.zapiszNaKonsultacjeButton.Size = new System.Drawing.Size(158, 23);
            this.zapiszNaKonsultacjeButton.TabIndex = 12;
            this.zapiszNaKonsultacjeButton.Text = "Zapisz się na konsultacje";
            this.zapiszNaKonsultacjeButton.UseVisualStyleBackColor = true;
            // 
            // studentPanelGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(655, 349);
            this.Controls.Add(this.zapiszNaKonsultacjeButton);
            this.Controls.Add(this.zapiszNaPrzedmiotButton);
            this.Controls.Add(this.pokazWykladowcowButton);
            this.Controls.Add(this.pokazListeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nazwaUzytkownikaLabel);
            this.Controls.Add(this.imieNazwiskoLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "studentPanelGui";
            this.Text = "Internetowy System Obsługi Studenta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.studentPanelGui_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.studentPanelGui_FormClosed);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel nickStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label imieNazwiskoLabel;
        private System.Windows.Forms.Label nazwaUzytkownikaLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pokazListeButton;
        private System.Windows.Forms.Button pokazWykladowcowButton;
        private System.Windows.Forms.Button zapiszNaPrzedmiotButton;
        private System.Windows.Forms.Button zapiszNaKonsultacjeButton;
    }
}
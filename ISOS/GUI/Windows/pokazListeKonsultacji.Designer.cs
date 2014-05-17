namespace ISOS.GUI.Windows
{
    partial class pokazListeKonsultacji
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
            this.listaKonsultacji = new System.Windows.Forms.ListBox();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.edytujButton = new System.Windows.Forms.Button();
            this.usunButton = new System.Windows.Forms.Button();
            this.wypiszButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaKonsultacji
            // 
            this.listaKonsultacji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listaKonsultacji.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaKonsultacji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.listaKonsultacji.FormattingEnabled = true;
            this.listaKonsultacji.Location = new System.Drawing.Point(27, 21);
            this.listaKonsultacji.Name = "listaKonsultacji";
            this.listaKonsultacji.Size = new System.Drawing.Size(288, 106);
            this.listaKonsultacji.TabIndex = 0;
            this.listaKonsultacji.SelectedIndexChanged += new System.EventHandler(this.listaKonsultacji_SelectedIndexChanged);
            // 
            // zapiszButton
            // 
            this.zapiszButton.Location = new System.Drawing.Point(321, 21);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(75, 23);
            this.zapiszButton.TabIndex = 1;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            // 
            // edytujButton
            // 
            this.edytujButton.Location = new System.Drawing.Point(321, 21);
            this.edytujButton.Name = "edytujButton";
            this.edytujButton.Size = new System.Drawing.Size(75, 23);
            this.edytujButton.TabIndex = 2;
            this.edytujButton.Text = "Edytuj";
            this.edytujButton.UseVisualStyleBackColor = true;
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(321, 50);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(75, 23);
            this.usunButton.TabIndex = 3;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            // 
            // wypiszButton
            // 
            this.wypiszButton.Location = new System.Drawing.Point(321, 21);
            this.wypiszButton.Name = "wypiszButton";
            this.wypiszButton.Size = new System.Drawing.Size(75, 23);
            this.wypiszButton.TabIndex = 4;
            this.wypiszButton.Text = "Wypisz się";
            this.wypiszButton.UseVisualStyleBackColor = true;
            this.wypiszButton.Click += new System.EventHandler(this.wypiszButton_Click);
            // 
            // pokazListeKonsultacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(408, 142);
            this.Controls.Add(this.wypiszButton);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.edytujButton);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.listaKonsultacji);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pokazListeKonsultacji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zapisz na konsultacje";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokazListeKonsultacji_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaKonsultacji;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Button edytujButton;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.Button wypiszButton;
    }
}
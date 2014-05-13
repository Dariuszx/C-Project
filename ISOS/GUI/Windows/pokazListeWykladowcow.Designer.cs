namespace ISOS.GUI.Windows
{
    partial class pokazListeWykladowcow
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
            this.listaWykladowcow = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nickLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.imieLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edytujButton = new System.Windows.Forms.Button();
            this.usunButton = new System.Windows.Forms.Button();
            this.zapiszNaKonsultacjeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwisko";
            // 
            // listaWykladowcow
            // 
            this.listaWykladowcow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listaWykladowcow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaWykladowcow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.listaWykladowcow.FormattingEnabled = true;
            this.listaWykladowcow.Location = new System.Drawing.Point(12, 17);
            this.listaWykladowcow.Name = "listaWykladowcow";
            this.listaWykladowcow.Size = new System.Drawing.Size(296, 119);
            this.listaWykladowcow.TabIndex = 7;
            this.listaWykladowcow.SelectedIndexChanged += new System.EventHandler(this.listaWykladowcow_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Imie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nickLabel);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.nazwiskoLabel);
            this.groupBox1.Controls.Add(this.imieLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.groupBox1.Location = new System.Drawing.Point(330, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacje";
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.nickLabel.Location = new System.Drawing.Point(86, 96);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(45, 13);
            this.nickLabel.TabIndex = 9;
            this.nickLabel.Text = "jszostak";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(86, 73);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(117, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "jszostak@ee.pw.edu.pl";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.nazwiskoLabel.Location = new System.Drawing.Point(86, 50);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(72, 13);
            this.nazwiskoLabel.TabIndex = 7;
            this.nazwiskoLabel.Text = "Szostakowski";
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.imieLabel.Location = new System.Drawing.Point(86, 28);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(50, 13);
            this.imieLabel.TabIndex = 6;
            this.imieLabel.Text = "Jarosław";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // edytujButton
            // 
            this.edytujButton.Location = new System.Drawing.Point(233, 143);
            this.edytujButton.Name = "edytujButton";
            this.edytujButton.Size = new System.Drawing.Size(75, 23);
            this.edytujButton.TabIndex = 10;
            this.edytujButton.Text = "Edytuj";
            this.edytujButton.UseVisualStyleBackColor = true;
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(152, 142);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(75, 23);
            this.usunButton.TabIndex = 11;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            // 
            // zapiszNaKonsultacjeButton
            // 
            this.zapiszNaKonsultacjeButton.Location = new System.Drawing.Point(469, 143);
            this.zapiszNaKonsultacjeButton.Name = "zapiszNaKonsultacjeButton";
            this.zapiszNaKonsultacjeButton.Size = new System.Drawing.Size(145, 22);
            this.zapiszNaKonsultacjeButton.TabIndex = 12;
            this.zapiszNaKonsultacjeButton.Text = "Zapisz się na konsultacje";
            this.zapiszNaKonsultacjeButton.UseVisualStyleBackColor = true;
            this.zapiszNaKonsultacjeButton.Click += new System.EventHandler(this.zapiszNaKonsultacjeButton_Click);
            // 
            // pokazListeWykladowcow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(626, 181);
            this.Controls.Add(this.zapiszNaKonsultacjeButton);
            this.Controls.Add(this.usunButton);
            this.Controls.Add(this.edytujButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaWykladowcow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pokazListeWykladowcow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokaż listę wykładowców";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokazListeWykladowcow_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaWykladowcow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Button edytujButton;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.Button zapiszNaKonsultacjeButton;
    }
}
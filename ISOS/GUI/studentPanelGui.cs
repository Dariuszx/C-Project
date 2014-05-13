using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISOS.GUI.Windows;

namespace ISOS.GUI
{
    public partial class studentPanelGui : Form
    {
        private Engine main;

        public studentPanelGui( Engine main )
        {
            this.main = main;

            InitializeComponent();

            KeyPreview = true;
            imieNazwiskoLabel.Text = main.loginModul.zalogowanyUzytkownik.name + " " + main.loginModul.zalogowanyUzytkownik.surname;
            nazwaUzytkownikaLabel.Text = main.loginModul.zalogowanyUzytkownik.nickname;
            emailLabel.Text = main.loginModul.zalogowanyUzytkownik.email;
            nickStatusLabel.Text = main.loginModul.zalogowanyUzytkownik.nickname;
        }

        private void studentPanelGui_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.logOut();
        }

        private void studentPanelGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI.yesNoDialog optionDialog = new GUI.yesNoDialog();
            optionDialog.ShowDialog(this);

            if (optionDialog.optionChoosen == false) e.Cancel = true;
        }

        private void pokazWykladowcowButton_Click(object sender, EventArgs e)
        {
            pokazListeWykladowcow pokazListeDialog = new pokazListeWykladowcow(main);
            pokazListeDialog.ShowDialog(this);
        }

        private void pokazListePrzedmiotowButton_Click(object sender, EventArgs e)
        {
            pokazListePrzedmiotow oknoListaPrzedmiotow = new pokazListePrzedmiotow(main);
            oknoListaPrzedmiotow.ShowDialog(this);
        }

        private void studentPanelGui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pokazListeButton_Click(object sender, EventArgs e)
        {
            pokazListeZapisanychPrzedmiotow listaPrzedmiotowZapisanych = new pokazListeZapisanychPrzedmiotow(main);
            listaPrzedmiotowZapisanych.ShowDialog(this);
        }

        private void studentPanelGui_Load(object sender, EventArgs e)
        {

        }

    }
}

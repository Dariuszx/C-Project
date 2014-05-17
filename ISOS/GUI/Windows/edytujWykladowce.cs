using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISOS.Data;

namespace ISOS.GUI.Windows
{
    public partial class edytujWykladowce : Form
    {

        private Engine main;
        private Wykladowca wykladowca;

        public edytujWykladowce(Engine main)
        {
            this.main = main;
            InitializeComponent();
            buttonDodaj.Visible = true;
            KeyPreview = true;
        }

        public edytujWykladowce(Engine main, Wykladowca wykladowca)
        {
            this.main = main;
            this.wykladowca = wykladowca;
            InitializeComponent();
            KeyPreview = true;
            uzupelnijInformacje();
            buttonZapisz.Visible = true;
        }

        private void uzupelnijInformacje()
        {
            if (wykladowca != null)
            {
                inputImie.Text = wykladowca.user.name;
                inputNazwisko.Text = wykladowca.user.surname;
                inputNick.Text = wykladowca.getNickname();
                inputHaslo.Text = wykladowca.user.password;
                inputEmail.Text = wykladowca.user.email;
            }
        }
        
        private void edytujWykladowce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (main.bazaDanych.getUser(inputNick.Text) == null || inputNick.Text.Equals(wykladowca.getNickname()) )
            {
                wykladowca.user.name = inputImie.Text;
                wykladowca.user.surname = inputNazwisko.Text;
                wykladowca.user.nickname = inputNick.Text;
                wykladowca.user.password = inputHaslo.Text;
                wykladowca.user.email = inputEmail.Text;
                this.Close();
            }
            else
            {
                messageDialogGui errorDialog = new messageDialogGui("Podana nazwa użytkownika już istnieje w systemie", "Błąd");
                errorDialog.ShowDialog(this);
            }

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String imie = inputImie.Text.Trim();
            String nazwisko = inputNazwisko.Text.Trim();
            String email = inputEmail.Text.Trim();
            String nick = inputNick.Text.Trim();
            String password = inputHaslo.Text.Trim();

            if( main.bazaDanych.getUser(nick) == null &&
                imie.Length > 3 &&
                nazwisko.Length > 3 &&
                email.Length > 6 &&
                password.Length > 5 &&
                nick.Length > 5)
            {
                main.bazaDanych.addUser(new User(nick, password, "wykladowca", imie, nazwisko, email));
                main.bazaDanych.addWykladowca( main.bazaDanych.getUser(nick) );
                this.Close();
            }
            else
            {
                messageDialogGui errorDialog = new messageDialogGui("Formularz wypełniony nieprawidłowo", "Błąd");
                errorDialog.ShowDialog(this);
            }
        }
    }
}

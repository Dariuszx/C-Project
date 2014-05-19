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
    public partial class edytujStudentWykladowca : Form
    {

        private Engine main;
        private Wykladowca wykladowca;
        private Student student;
        private String value;

        public edytujStudentWykladowca(Engine main, String value)
        {
            this.main = main;
            this.value = value; //co dodaje Student czy Wykładowca

            initialize();

            buttonDodaj.Visible = true;
        }

        public edytujStudentWykladowca(Engine main, Wykladowca wykladowca)
        {
            this.main = main;
            this.wykladowca = wykladowca;
            this.value = "wykladowca";

            initialize();

            uzupelnijInformacje( wykladowca.user );
            
            buttonZapisz.Visible = true;
            buttonWyswietlListePrzedmiotow.Visible = true;
        }

        public edytujStudentWykladowca(Engine main, Student student)
        {
            this.main = main;
            this.student = student;
            this.value = "student";

            initialize();

            uzupelnijInformacje(student.user);

            buttonZapisz.Visible = true;
        }

        private void initialize()
        {
            InitializeComponent();
            KeyPreview = true;

            if (value.Equals("student"))
            {
                this.Text = "Edytuj/Dodaj studenta.";
            }
            else
            {
                this.Text = "Edytuj/Dodaj wykładowce.";
            }
        }

        private void uzupelnijInformacje(User user)
        {
            if (user != null)
            {
                inputImie.Text = user.name;
                inputNazwisko.Text = user.surname;
                inputNick.Text = user.nickname;
                inputHaslo.Text = user.password;
                inputEmail.Text = user.email;
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {

            User data;

            if (value.Equals("student"))
            {
                data = student.user;
            } else data = wykladowca.user;

            String imie = inputImie.Text.Trim();
            String nazwisko = inputNazwisko.Text.Trim();
            String nickname = inputNick.Text.Trim();
            String haslo = inputHaslo.Text.Trim();
            String email = inputEmail.Text.Trim();

            if ( imie.Length > 3 && nazwisko.Length > 3 && nickname.Length > 3 && haslo.Length > 3 && email.Length > 3 )
            {
                data.name = imie;
                data.surname = nazwisko;
                data.nickname = nickname;
                data.password = haslo;
                data.email = email;
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
                main.bazaDanych.addUser(new User(nick, password, value, imie, nazwisko, email));

                if (value.Equals("student"))
                {
                    main.bazaDanych.addStudent(main.bazaDanych.getUser(nick));
                }
                else
                {
                    main.bazaDanych.addWykladowca(main.bazaDanych.getUser(nick));
                }
                
                this.Close();
            }
            else
            {
                messageDialogGui errorDialog = new messageDialogGui("Formularz wypełniony nieprawidłowo", "Błąd");
                errorDialog.ShowDialog(this);
            }
        }

        private void edytujStudentWykladowca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

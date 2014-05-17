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
    public partial class edytujDodajPrzedmiot : Form
    {

        private Engine main;
        private int indexSelected=0;
        private Wykladowca wykladowcaSelected;
        private Przedmiot przedmiotSelected;

        public edytujDodajPrzedmiot(Engine main)
        {
            this.main = main;
            initialize();
            buttonDodaj.Visible = true;
        }

        public edytujDodajPrzedmiot( Engine main, String przedmiotId )
        {
            this.main = main;

            initialize();

            buttonEdytuj.Visible = true;

            przedmiotSelected = main.bazaDanych.getPrzedmiot(przedmiotId);
            indexSelected = main.bazaDanych.getWykladowcaIndex(przedmiotSelected.getWykladowcaNickname());
            wykladowcaSelected = main.bazaDanych.getWykladowca(indexSelected);
        
            listaWykladowcow.SetSelected(indexSelected, true);
            inputIdPrzedmiotu.Text = przedmiotSelected.id;
            inputNazwaPrzedmiotow.Text = przedmiotSelected.nazwa;

        }

        private void initialize()
        {
            InitializeComponent();
            KeyPreview = true;

            if (main.bazaDanych.wykladowcy.Count == 0)
            {
                messageDialogGui error = new messageDialogGui("Nie można dodać przedmiotu bez wykładowców.", "Błąd");
                error.ShowDialog(this);
                this.Close();
            }
  
            wyswietlListeWykladowcow();
            listaWykladowcow.SetSelected(indexSelected, true);
        }

        private void wyswietlListeWykladowcow()
        {
            foreach (Wykladowca w in main.bazaDanych.wykladowcy)
            {
                listaWykladowcow.Items.Add(w.user.name + " " + w.user.surname);
            }
        }

        private void edytujDodajPrzedmiot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void listaWykladowcow_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            indexSelected = listaWykladowcow.SelectedIndex;
            wykladowcaSelected = main.bazaDanych.getWykladowca(indexSelected);
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {

            String nazwa = inputNazwaPrzedmiotow.Text.Trim();
            String id = inputIdPrzedmiotu.Text.Trim();

            if (nazwa.Length < 5 || id.Length < 2)
            {
                new messageDialogGui("Nieprawidłowo wypełniony formularz", "Błąd").ShowDialog(this);
            }
            else
            {

                przedmiotSelected.nazwa = nazwa;
                przedmiotSelected.id = id;
                przedmiotSelected.wykladowca = wykladowcaSelected;
            }

            this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String nazwaPrzedmiotu = inputNazwaPrzedmiotow.Text.Trim();
            String idPrzedmiotu = inputIdPrzedmiotu.Text.Trim();

            if (nazwaPrzedmiotu.Length < 5 || idPrzedmiotu.Length < 2)
            {
                new messageDialogGui("Nieprawidłowo wypełniony formularz", "Błąd").ShowDialog(this);
            }
            else
            {
                main.bazaDanych.addPrzedmiot(wykladowcaSelected.getNickname(), nazwaPrzedmiotu, idPrzedmiotu);
            }
            this.Close();
        }
    }
}

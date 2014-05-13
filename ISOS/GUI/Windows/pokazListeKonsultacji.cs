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
using ISOS;

namespace ISOS.GUI.Windows
{
    public partial class pokazListeKonsultacji : Form
    {
        private ISOS.Data.Wykladowca wykladowca;
        private ISOS.Engine main;
        private int selectedIndex = 0;
        private Konsultacje konsultacjeSelected = null;

        public pokazListeKonsultacji( ISOS.Engine main, ISOS.Data.Wykladowca w )
        {
            this.wykladowca = w;
            this.main = main;
            InitializeComponent();
            KeyPreview = true;
            uzupelnijListe();

            if (main.loginModul.zalogowanyUzytkownik.permissions.Equals("student"))
            {
                edytujButton.Visible = false;
                usunButton.Visible = false;
            }
            else
            {
                zapiszButton.Visible = false;
                wypiszButton.Visible = false;
            }

            wyswietlOpcje();
        }

        public void wyswietlOpcje()
        {
            if (main.loginModul.zalogowanyUzytkownik.permissions.Equals("student"))
            {
                //Domyślne ustawienie przycisków
                zapiszButton.Visible = true;
                wypiszButton.Visible = false;

                //Iteruję po wszystkich konsultacjach, na których zapisany jest zalogowany student
                foreach (Konsultacje k in main.bazaDanych.getStudent(main.loginModul.getNicknameUserLoggedIn()).konsultacjeZapisane)
                {
                    //Sprawdzam czy aktualnie iterowany konsultacje nie jest zapisany 
                    if (konsultacjeSelected.getPrzedmiotId().Equals(k.getPrzedmiotId()))
                    {
                        wypiszButton.Visible = true;
                        zapiszButton.Visible = false;
                        break;
                    }
                }
            }
            else
            {
                edytujButton.Visible = true;
                usunButton.Visible = true;
                wypiszButton.Visible = false;
                zapiszButton.Visible = false;
            }
        }

        public void uzupelnijListe()
        {
            foreach (Konsultacje k in wykladowca.konsultacje)
            {
                listaKonsultacji.Items.Add(k.przedmiot.nazwa + " " + k.czasKonsultacji);
            }

            if (listaKonsultacji.Items.Count != 0)
            {
                listaKonsultacji.SetSelected(0, true);
                updateKonsultacjeSelected();
            }
        }

        public void updateKonsultacjeSelected()
        {
            konsultacjeSelected = wykladowca.getKonsultacje(selectedIndex);
        }

        private void wybierzButton_Click(object sender, EventArgs e)
        {
            selectedIndex = listaKonsultacji.SelectedIndex;
            updateKonsultacjeSelected();
            wyswietlOpcje();
        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            main.bazaDanych.studentZapiszNaKonsultacje(main.loginModul.getNicknameUserLoggedIn(), wykladowca.getNickname(), konsultacjeSelected.getPrzedmiotId());
            zapiszButton.Visible = false;
            wypiszButton.Visible = true;
        }

        private void wypiszButton_Click(object sender, EventArgs e)
        {
            main.bazaDanych.studentWypiszZKonsultacji(main.loginModul.getNicknameUserLoggedIn(), konsultacjeSelected.getPrzedmiotId());
            zapiszButton.Visible = true;
            wypiszButton.Visible = false;
        }

        private void listaKonsultacji_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listaKonsultacji.SelectedIndex;
            updateKonsultacjeSelected();
            wyswietlOpcje();
        }

        private void pokazListeKonsultacji_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}

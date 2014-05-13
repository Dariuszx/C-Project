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
    public partial class pokazListePrzedmiotow : Form
    {

        private Engine main;
        private int indexSelected = 0;
        private Przedmiot przedmiotSelected = null;

        public pokazListePrzedmiotow( Engine main )
        {
            this.main = main;

            InitializeComponent();
            uzupelnijListeWykladowcow();
            KeyPreview = true;
            listaPrzedmiotow.SetSelected(indexSelected, true); //ustawiam element zaznaczony
        }

        //Jeżeli otwieram okno i chcę wyświetlić konkretne dane
        public pokazListePrzedmiotow(Engine main, int indexSelected)
        {
            this.main = main;
            this.indexSelected = indexSelected;

            InitializeComponent();
            KeyPreview = true;
            uzupelnijListeWykladowcow();
            listaPrzedmiotow.SetSelected(indexSelected, true);
        }

        private bool uzupelnijListeWykladowcow()
        {
            if (main.bazaDanych.przedmioty.Count == 0) return false;

            //Dodaję jako zaznaczony pierwszy element z listy lub podany jako zaznaczony
            przedmiotSelected = main.bazaDanych.getPrzedmiot(indexSelected);

            foreach (Przedmiot p in main.bazaDanych.przedmioty)
            {
                listaPrzedmiotow.Items.Add(p.nazwa);
            }

            return true;
        }

        private void pokazInformacjePrzedmiotu()
        {
            if (main.loginModul.isStudent())
            {
                buttonEdytuj.Visible = false;
                buttonUsun.Visible = false;

                if (main.bazaDanych.getStudent(main.loginModul.getNicknameUserLoggedIn()).getPrzedmiotZapisany(przedmiotSelected.id) == null)
                {
                    buttonZapisz.Visible = true;
                    buttonWypisz.Visible = false;
                }
                else
                {
                    buttonZapisz.Visible = false;
                    buttonWypisz.Visible = true;
                }
            }

            labelNazwaPrzedmiotu.Text = przedmiotSelected.nazwa;
            labelProwadzacyNazwa.Text = przedmiotSelected.wykladowca.getNickname();
            if (main.bazaDanych.getKonsultacje(przedmiotSelected.id ) == null )
            {
                labelKonsultacjeTakNie.Text = "Nie ustalono konsultacji";
            }
            else labelKonsultacjeTakNie.Text = "TAK";
        }

        private void listaPrzedmiotow_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectedIndex();
            pokazInformacjePrzedmiotu();
        }

        private void updateSelectedIndex()
        {
            indexSelected = listaPrzedmiotow.SelectedIndex;
            przedmiotSelected = main.bazaDanych.getPrzedmiot(indexSelected);
        }

        private void buttonWypisz_Click(object sender, EventArgs e)
        {
            main.bazaDanych.studentWypiszZPrzedmiotu(main.loginModul.getNicknameUserLoggedIn(), przedmiotSelected.id);
            buttonWypisz.Visible = false;
            buttonZapisz.Visible = true;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            main.bazaDanych.studentZapiszNaPrzedmiot(main.loginModul.getNicknameUserLoggedIn(), przedmiotSelected.id);
            buttonZapisz.Visible = false;
            buttonWypisz.Visible = true;
        }

        private void buttonPokazProfilWykladowcy_Click(object sender, EventArgs e)
        {
            pokazListeWykladowcow listaWykladowcow = new pokazListeWykladowcow(main, main.bazaDanych.getWykladowcaIndex(przedmiotSelected.getWykladowcaNickname()));
            listaWykladowcow.ShowDialog(this);
        }

        private void pokazListePrzedmiotow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

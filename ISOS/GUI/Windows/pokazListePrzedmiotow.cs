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
using System.Collections;

namespace ISOS.GUI.Windows
{
    public partial class pokazListePrzedmiotow : Form
    {

        private Engine main;
        private int indexSelected = 0;
        private Przedmiot przedmiotSelected = null;
        private ArrayList przedmiotyWykladowcy;

        public pokazListePrzedmiotow( Engine main )
        {
            this.main = main;

            InitializeComponent();
            uzupelnijListePrzedmiotow();
            pokazInformacjePrzedmiotu();
            KeyPreview = true;
            if( listaPrzedmiotow.Items.Count != 0 ) listaPrzedmiotow.SetSelected(indexSelected, true); //ustawiam element zaznaczony
        }

        //Jeżeli otwieram okno i chcę wyświetlić konkretne dane
        public pokazListePrzedmiotow(Engine main, int indexSelected)
        {
            this.main = main;
            this.indexSelected = indexSelected;

            InitializeComponent();
            KeyPreview = true;
            uzupelnijListePrzedmiotow();
            pokazInformacjePrzedmiotu();
            listaPrzedmiotow.SetSelected(indexSelected, true);
        }

        public pokazListePrzedmiotow(Engine main, String wykladowcaNick)
        {
            this.main = main;

            InitializeComponent();
            KeyPreview = true;
            uzupelnijListePrzedmiotow(wykladowcaNick);
            pokazInformacjePrzedmiotu();
            if( listaPrzedmiotow.Items.Count != 0 ) listaPrzedmiotow.SetSelected(indexSelected, true);
        }

        private bool uzupelnijListePrzedmiotow()
        {
            if (main.bazaDanych.przedmioty.Count == 0) return false;

            //Dodaję jako zaznaczony pierwszy element z listy lub podany jako zaznaczony
            przedmiotSelected = main.bazaDanych.getPrzedmiot(indexSelected);

            listaPrzedmiotow.Items.Clear();

            foreach (Przedmiot p in main.bazaDanych.przedmioty)
            {
                listaPrzedmiotow.Items.Add(p.nazwa);
            }

            return true;
        }

        private bool uzupelnijListePrzedmiotow(String nickname)
        {
            przedmiotyWykladowcy = new ArrayList();

            foreach (Przedmiot p in main.bazaDanych.przedmioty)
            {
                if (p.getWykladowcaNickname().Equals(nickname))
                {
                    przedmiotyWykladowcy.Add(p);
                    listaPrzedmiotow.Items.Add(p.nazwa);
                }
            }

            return true;
        }

        private void pokazInformacjePrzedmiotu()
        {
            if (listaPrzedmiotow.Items.Count != 0)
            {

                if (main.loginModul.isStudent())
                {
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
                else if (main.loginModul.isDziekanat())
                {
                    buttonDodaj.Visible = true;
                    buttonEdytuj.Visible = true;
                    buttonUsun.Visible = true;
                    buttonPokazProfilWykladowcy.Visible = true;
                    
                }

                labelNazwaPrzedmiotu.Text = przedmiotSelected.nazwa;
                labelProwadzacyNazwa.Text = przedmiotSelected.wykladowca.getNickname();
                
                if (main.bazaDanych.getKonsultacje(przedmiotSelected.id) == null)
                {
                    labelKonsultacjeTakNie.Text = "Nie ustalono konsultacji";
                }
                else labelKonsultacjeTakNie.Text = "TAK";
            }
            else
            {
                buttonEdytuj.Visible = false;
                buttonUsun.Visible = false;
                labelNazwaPrzedmiotu.Text = "brak danych";
                labelProwadzacyNazwa.Text = "brak danych";
                labelKonsultacjeTakNie.Text = "brak danych";
            }
        }

        private void listaPrzedmiotow_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectedIndex();
            pokazInformacjePrzedmiotu();
        }

        private void updateSelectedIndex()
        {
            indexSelected = listaPrzedmiotow.SelectedIndex;
            if (indexSelected < 0 || indexSelected >= listaPrzedmiotow.Items.Count ) indexSelected = 0;

            if (przedmiotyWykladowcy == null)
                przedmiotSelected = main.bazaDanych.getPrzedmiot(indexSelected);
            else
                przedmiotSelected = getPrzedmiotWykladowcy(indexSelected);
        }

        private Przedmiot getPrzedmiotWykladowcy(int index)
        {
            int i = 0;

            foreach (Przedmiot p in przedmiotyWykladowcy)
            {
                if (i == index) return p;
                i++;
            }
            return null;
        }

        private void buttonWypisz_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(przedmiotSelected.id);
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

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            edytujDodajPrzedmiot edytujPrzedmiot = new edytujDodajPrzedmiot(main, przedmiotSelected.id);
            edytujPrzedmiot.ShowDialog(this);

            uzupelnijListePrzedmiotow();
            pokazInformacjePrzedmiotu();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            edytujDodajPrzedmiot dodajPrzedmiot = new edytujDodajPrzedmiot(main);
            dodajPrzedmiot.ShowDialog(this);

            uzupelnijListePrzedmiotow();
            pokazInformacjePrzedmiotu();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (listaPrzedmiotow.Items.Count > 0)
            {
                main.bazaDanych.usunPrzedmiot(przedmiotSelected.id);
                listaPrzedmiotow.Items.RemoveAt(indexSelected);
                uzupelnijListePrzedmiotow();
                updateSelectedIndex();
                pokazInformacjePrzedmiotu();
            }
        }
    }
}

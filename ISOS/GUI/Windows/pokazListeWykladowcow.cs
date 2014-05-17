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
    public partial class pokazListeWykladowcow : Form
    {
        private Engine main;
        private Wykladowca wykladowcaSelected;
        private int indexSelected = 0;

        public pokazListeWykladowcow( Engine main)
        {
            this.main = main;

            initialize();

            if( listaWykladowcow.Items.Count != 0 ) listaWykladowcow.SetSelected(0, true);
          
        }

        public pokazListeWykladowcow(Engine main, int selectedIndex)
        {
            this.main = main;
            this.indexSelected = selectedIndex;

            initialize();

            listaWykladowcow.SetSelected(selectedIndex, true);
        }

        private void initialize()
        {
            InitializeComponent();
            KeyPreview = true;
            uzupelnijListeWykladowcow();
            wykladowcaSelected = main.bazaDanych.getWykladowca(indexSelected);
            pokazInformacje();
        }


        private void uzupelnijListeWykladowcow()
        {
            foreach (Wykladowca w in main.bazaDanych.getWykladowcy() )
            {
                listaWykladowcow.Items.Add(w.user.name + " " + w.user.surname);
            }

            if (main.loginModul.isStudent())
            {
                buttonZapiszSieNaKonsultacje.Visible = true;
            }
            else if (main.loginModul.isDziekanat())
            {
                buttonDodajWykladowce.Visible = true;
                buttonEdytuj.Visible = true;
                buttonUsun.Visible = true;
            } 
        }

        private void pokazInformacje()
        {
            if (listaWykladowcow.Items.Count != 0)
            {

                //Uzupełniam formularz informacji
                imieLabel.Text = wykladowcaSelected.user.name;
                nazwiskoLabel.Text = wykladowcaSelected.user.surname;
                emailLabel.Text = wykladowcaSelected.user.email;
                nickLabel.Text = wykladowcaSelected.user.nickname;

                if (wykladowcaSelected.konsultacje.Count == 0 || !main.loginModul.isStudent()) buttonZapiszSieNaKonsultacje.Visible = false;
                else buttonZapiszSieNaKonsultacje.Visible = true;
            }
            else
            {
                imieLabel.Text = "brak danych";
                nazwiskoLabel.Text = "brak danych";
                emailLabel.Text = "brak danych";
                nickLabel.Text = "brak danych";

                buttonZapiszSieNaKonsultacje.Visible = false;
                buttonEdytuj.Visible = false;
                buttonUsun.Visible = false;
            }
        }

        private void updateIndexSelected()
        {
            indexSelected = listaWykladowcow.SelectedIndex;

            if (indexSelected >= listaWykladowcow.Items.Count || indexSelected < 0 ) indexSelected = 0;

            wykladowcaSelected = main.bazaDanych.getWykladowca(indexSelected);
        }


        //?
        private void pokazInformacjeButton_Click(object sender, EventArgs e)
        {
            indexSelected = listaWykladowcow.SelectedIndex;
            pokazInformacje();
        }


        private void zapiszNaKonsultacjeButton_Click(object sender, EventArgs e)
        {
            pokazListeKonsultacji konsultacjeDialog = new pokazListeKonsultacji(main, wykladowcaSelected);
            konsultacjeDialog.ShowDialog(this);
        }

        private void listaWykladowcow_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIndexSelected();
            pokazInformacje();
        }

        private void pokazListeWykladowcow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            edytujWykladowce edytujDialog = new edytujWykladowce(main, wykladowcaSelected);
            edytujDialog.ShowDialog(this);
            if( listaWykladowcow.Items.Count != 0 ) pokazInformacje();
        }

        private void buttonDodajWykladowce_Click(object sender, EventArgs e)
        {
            edytujWykladowce dodajDialog = new edytujWykladowce(main);
            dodajDialog.ShowDialog(this);

            listaWykladowcow.Items.Clear();
            uzupelnijListeWykladowcow();
            pokazInformacje();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (listaWykladowcow.Items.Count != 0)
            {
                main.bazaDanych.usunWykladowce(wykladowcaSelected.getNickname());
            }

            listaWykladowcow.Items.Clear();
            uzupelnijListeWykladowcow();
            updateIndexSelected();
            pokazInformacje();
        }
    }
}

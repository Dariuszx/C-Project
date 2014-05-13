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
        private int indexSelected = 0;

        public pokazListeWykladowcow( Engine main)
        {
            this.main = main;
            InitializeComponent();
            KeyPreview = true;
            uzupelnijListe();
            if( listaWykladowcow.Items.Count != 0 ) listaWykladowcow.SetSelected(0, true);
          
        }

        public pokazListeWykladowcow(Engine main, int selectedIndex)
        {
            this.main = main;
            this.indexSelected = selectedIndex;
            InitializeComponent();
            KeyPreview = true;
            uzupelnijListe();
            listaWykladowcow.SetSelected(selectedIndex, true);
        }

        private void uzupelnijListe()
        {

            //Wyświetlam tylko wymagane przyciski 
            if (!main.loginModul.isDziekanat())
            {
                edytujButton.Visible = false;
                usunButton.Visible = false;
            }

            foreach (Wykladowca w in main.bazaDanych.getWykladowcy())
            {
                listaWykladowcow.Items.Add(w);
            }



            pokazInformacje();
        }

        private void pokazInformacje()
        {
            Wykladowca w = main.bazaDanych.getWykladowca(indexSelected);

            //Uzupełniam formularz informacji
            imieLabel.Text = w.user.name;
            nazwiskoLabel.Text = w.user.surname;
            emailLabel.Text = w.user.email;
            nickLabel.Text = w.user.nickname;

            if ( w.konsultacje.Count == 0 ) zapiszNaKonsultacjeButton.Visible = false;
            else zapiszNaKonsultacjeButton.Visible = true;
        }

        private void updateIndexSelected()
        {
            indexSelected = listaWykladowcow.SelectedIndex;
        }

        private void pokazInformacjeButton_Click(object sender, EventArgs e)
        {
            indexSelected = listaWykladowcow.SelectedIndex;
            pokazInformacje();
        }

        private void zapiszNaKonsultacjeButton_Click(object sender, EventArgs e)
        {
            Wykladowca w = main.bazaDanych.getWykladowca(indexSelected);

            pokazListeKonsultacji konsultacjeDialog = new pokazListeKonsultacji(main, w);
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

    }
}

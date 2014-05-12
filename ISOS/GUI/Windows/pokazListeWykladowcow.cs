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

            if (!main.loginModul.zalogowanyUzytkownik.permissions.Equals("dziekanat"))
            {
                edytujButton.Visible = false;
                usunButton.Visible = false;
            }

            uzupelnijListe();
        }

        public void uzupelnijListe()
        {

            foreach (Wykladowca w in main.bazaDanych.getWykladowcy())
            {
                listaWykladowcow.Items.Add(w);
            }

            if (listaWykladowcow.Items.Count != 0)
            {
                listaWykladowcow.SetSelected(0, true);
            }

            pokazInformacje();
        }

        public void pokazInformacje()
        {
            int index = listaWykladowcow.SelectedIndex;
            Wykladowca w = main.bazaDanych.getWykladowca(index);

            //Uzupełniam formularz informacji
            imieLabel.Text = w.user.name;
            nazwiskoLabel.Text = w.user.surname;
            emailLabel.Text = w.user.email;
            nickLabel.Text = w.user.nickname;

            if ( w.konsultacje.Count == 0 ) zapiszNaKonsultacjeButton.Visible = false;
            else zapiszNaKonsultacjeButton.Visible = true;
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

    }
}

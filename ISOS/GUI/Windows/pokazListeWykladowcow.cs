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

        public pokazListeWykladowcow( Engine main)
        {
            this.main = main;
            InitializeComponent();

            uzupelnijListe();
        }

        public void uzupelnijListe()
        {

            foreach (Wykladowca w in main.bazaDanych.wykladowcy)
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
            imieLabel.Text = w.user.name;
            nazwiskoLabel.Text = w.user.surname;
            emailLabel.Text = w.user.email;
            nickLabel.Text = w.user.nickname;
            
        }

        private void pokazInformacjeButton_Click(object sender, EventArgs e)
        {
            pokazInformacje();
        }


    }
}

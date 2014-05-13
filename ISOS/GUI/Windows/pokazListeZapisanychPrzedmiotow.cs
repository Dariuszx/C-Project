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
    public partial class pokazListeZapisanychPrzedmiotow : Form
    {

        private Engine main;
        private int indexSelected=0;
        private Przedmiot przedmiotSelected;
        private Student student;

        public pokazListeZapisanychPrzedmiotow(Engine main)
        {
            this.main = main;
            this.student = main.bazaDanych.getStudent(main.loginModul.getNicknameUserLoggedIn());
            InitializeComponent();
            KeyPreview = true;
            uzupelnijListe();
            updateIndexSelected();
        }

        private void pokazListeZapisanychPrzedmiotow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void uzupelnijListe()
        {
            foreach (Przedmiot p in student.przedmiotyZapisane)
            {
                listaPrzedmiotow.Items.Add(p.nazwa);
            }
        }

        private void listaPrzedmiotow_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIndexSelected();
        }

        private void updateIndexSelected()
        {
            indexSelected = listaPrzedmiotow.SelectedIndex;
            przedmiotSelected = student.getPrzedmiotZapisany(indexSelected);
        }

        private void buttonPokazProfil_Click(object sender, EventArgs e)
        {
            if (przedmiotSelected != null)
            {
                pokazListeWykladowcow pokazWykladowcow = new pokazListeWykladowcow(main, main.bazaDanych.getWykladowcaIndex(przedmiotSelected.getWykladowcaNickname()));
                pokazWykladowcow.ShowDialog(this);
            }   
        }

        private void buttonWypisz_Click(object sender, EventArgs e)
        {
            if (przedmiotSelected != null)
            {
                student.wypiszZPrzedmiotu(przedmiotSelected.id);
                listaPrzedmiotow.Items.RemoveAt(indexSelected);
            }

        }
    }
}

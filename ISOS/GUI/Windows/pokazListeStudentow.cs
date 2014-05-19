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
    public partial class pokazListeStudentow : Form
    {

        private Engine main;
        private Student studentSelected;
        private int indexSelected = 0;

        public pokazListeStudentow(Engine main)
        {
            this.main = main;
            KeyPreview = true;
            InitializeComponent();
            updateIndex();
            uzupelnijListeStudentow();
            pokazInformacje();
        }

        private void uzupelnijListeStudentow()
        {
            if (main.bazaDanych.students.Count != 0)
            {

                listaStudentow.Items.Clear();

                foreach (Student s in main.bazaDanych.students)
                {
                    listaStudentow.Items.Add(s.user.name + " " + s.user.surname);
                }
            }
        }

        private void pokazInformacje()
        {
            buttonDodajStudenta.Visible = true;

            if (main.bazaDanych.students.Count != 0)
            {
                buttonEdytuj.Visible = true;
                buttonUsun.Visible = true;

                imieLabel.Text = studentSelected.user.name;
                nazwiskoLabel.Text = studentSelected.user.surname;
                emailLabel.Text = studentSelected.user.email;
                nickLabel.Text = studentSelected.user.nickname;
            }
            else
            {
                imieLabel.Text = "brak danych";
                nazwiskoLabel.Text = "brak danych";
                emailLabel.Text = "brak danych";
                nickLabel.Text = "brak danych";

                buttonEdytuj.Visible = false;
                buttonUsun.Visible = false;
            }
        }

        private void updateIndex()
        {
            indexSelected = listaStudentow.SelectedIndex;

            if (indexSelected >= main.bazaDanych.students.Count || indexSelected < 0 ) indexSelected = 0;

            studentSelected = main.bazaDanych.getStudent(indexSelected);
        }

        private void pokazListeStudentow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void listaStudentow_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateIndex();
            pokazInformacje();
        }

        private void buttonDodajStudenta_Click(object sender, EventArgs e)
        {
            new edytujStudentWykladowca(main, "student").ShowDialog(this);
            uzupelnijListeStudentow();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (listaStudentow.Items.Count > 0)
            {
                main.bazaDanych.usunStudenta(studentSelected.user.nickname);
                listaStudentow.Items.RemoveAt(indexSelected);
                updateIndex();
                uzupelnijListeStudentow();
                pokazInformacje();
            }
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            if (listaStudentow.Items.Count > 0)
            {
                new edytujStudentWykladowca(main, studentSelected).ShowDialog(this);
                pokazInformacje();
                uzupelnijListeStudentow();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOS.GUI
{
    public partial class studentPanelGui : Form
    {

        private Engine main;

        public studentPanelGui( Engine main )
        {
            this.main = main;

            InitializeComponent();

            nickStatusLabel.Text = main.accountPreferences.nickname;
        }

        private void studentPanelGui_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.logOut();
        }
    }
}

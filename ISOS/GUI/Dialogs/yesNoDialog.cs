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
    public partial class yesNoDialog : Form
    {

        public bool optionChoosen = false;

        public yesNoDialog( )
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            optionChoosen = false;
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            optionChoosen = true;
            this.Close();
        }

    }
}

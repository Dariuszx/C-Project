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
    public partial class messageDialogGui : Form
    {

        public messageDialogGui( String message, String title )
        {  
            InitializeComponent();
            titleLabel.Text = title;
            messageLabel.Text = message;
            KeyPreview = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageDialogGui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}

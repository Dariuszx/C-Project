using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOS
{
    public partial class loginGui : Form
    {

        private Engine main;

        public loginGui( Engine main )
        {
            this.main = main;
            InitializeComponent();
            KeyPreview = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String errorMessage = null;

            errorMessage = main.connect( loginInput.Text, passwordInput.Text );

            if (errorMessage != null)
            {
                loginInput.Text = null;
                passwordInput.Text = null;
                Form messageWindow = new GUI.messageDialogGui( errorMessage, "Błąd logowania");
                messageWindow.ShowDialog(this);
            }
            else
            {
                this.Close();
            }

        }

        private void loginGui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
         
    }
}

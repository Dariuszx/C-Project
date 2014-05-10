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
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String errorMessage = null;

            errorMessage = main.connect( loginInput.Text, passwordInput.Text );

            if (errorMessage != null)
            {
                loginInput.Text = null;
                passwordInput.Text = null;
                Form messageWindow = new GUI.messageWindowGui( errorMessage, "Błąd logowania");
                messageWindow.ShowDialog(this);
            }
            else
            {
                this.Close();
            }

        }
         
    }
}

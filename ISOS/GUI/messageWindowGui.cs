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
    public partial class messageWindowGui : Form
    {

        public messageWindowGui( String message, String title )
        {  
            InitializeComponent();
            titleLabel.Text = title;
            messageLabel.Text = message;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

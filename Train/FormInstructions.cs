using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class FormInstructions : Form
    {
        FormMenu formMenu = new FormMenu();
        public FormInstructions()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu.ShowDialog();
        }
    }
}

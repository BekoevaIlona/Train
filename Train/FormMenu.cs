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
    public partial class FormMenu : Form
    {
        FormInstructions instructions = new FormInstructions();
        FormLnguageSelection lnguageSelection = new FormLnguageSelection();
        public FormMenu()
        {
            InitializeComponent();
        }
        
        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructions.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            this.Hide();
            lnguageSelection.ShowDialog();
        }
    }
}

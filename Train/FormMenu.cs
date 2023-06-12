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
        FormLanguageSelection languageSelection = new FormLanguageSelection();
        FormAuthorization authorization = new FormAuthorization();
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
            languageSelection.ShowDialog();
        }

        private void buttonRentrance_Click(object sender, EventArgs e)
        {
            this.Hide();
            authorization.ShowDialog();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {

        }

        private void buttonTopic_Click(object sender, EventArgs e)
        {

        }
    }
}

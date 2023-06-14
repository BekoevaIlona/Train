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
        FormAuthorization authorization = new FormAuthorization();
        FormLeaderboard leaderboard = new FormLeaderboard();
        public FormMenu()
        {
            InitializeComponent();
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
            this.Hide();
            leaderboard.ShowDialog();
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLanguageSelection languageSelection = new FormLanguageSelection();
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

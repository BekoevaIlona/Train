using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Train
{
    public partial class FormVictory : Form
    {
        string username;

        public FormVictory(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FormVictory_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"audio\FormVictory.wav");
            player.Play();
            this.Activate();
            this.TopMost = true;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.Show(this);
        }

        private void buttonNO_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
        }
    }
}

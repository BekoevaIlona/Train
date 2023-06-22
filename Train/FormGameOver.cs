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
    public partial class FormGameOver : Form
    {
        string username;
        public FormGameOver(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }

        private void FormGameOver_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"audio\GameOver.wav");
            player.Play();
            this.Activate();
            this.TopMost = true;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FormGameTeach gameTeach = new FormGameTeach(username);
            //gameTeach.Show();
        }

        private void buttonNO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

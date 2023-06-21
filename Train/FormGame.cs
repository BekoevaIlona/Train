using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train.Train;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Train
{
    public partial class FormGame : Form
    {
        //private PlayerData playerData;
        public static Card MovedCard = null;
        int speed = 1;
        Level Level;
        public int lev;
        ListCards ListCards;
        ListWagons ListWagons;
        string username;
        public FormGame(string username)
        {
            InitializeComponent();
            lev = Level.level;
            this.username = username;
            timerTrainMove.Start();
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            string[] userData = File.ReadAllText(userFile).Split(',');
            string language = userData.Length >= 3 ? userData[2] : "";
            string tId = userData.Length >= 4 ? userData[3] : "";
            string scores = userData.Length >= 5 ? userData[4] : "";
            labelScores.Text = scores;
            Level = new Level(lev);
            ListCards = new ListCards( Level.IndexesCards, tId,  this, language);
            ListWagons = new ListWagons(tId, Level.IndexesWagons, language, this, labelScores);

            
        }
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void FormGame_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void timerTrainMove_Tick(object sender, EventArgs e)
        {
            ListWagons.Move(speed);
            ListWagons.Intersection(pictureBoxLife, MovedCard, username);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelScores_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (ListWagons.counter == Level.level_lst[Level.level])
            {
                Level.level++;
                if (Level.level == 3)
                {
                    //MessageBox.Show("Поздравляю!!! Вы прошли игру!!!");
                    PlayerScoreManager.UpdateScore(username, +100);
                    this.Hide();
                    FormVictory formVictory = new FormVictory(username);
                    formVictory.Show();
                }
                else
                {
                    //MessageBox.Show("Поздравляю!!! Вы успешно прошли уровень!!!");
                    ListWagons.counter = 0;
                    this.Hide();
                    FormGame formGame = new FormGame(username);
                    formGame.Show();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"audio\Victory.wav");
                    player.Play();
                }

            }
            else
            {
                this.Hide();
                FormGameOver formGameOver = new FormGameOver(username);
                formGameOver.Show();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu(); 
            this.Hide();
            formMenu.ShowDialog();
        }
    }
}

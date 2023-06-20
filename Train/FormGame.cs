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
        public FormGame(string username)
        {
            InitializeComponent();
            timerTrainMove.Start();
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            string[] userData = File.ReadAllText(userFile).Split(',');
            string language = userData.Length >= 3 ? userData[2] : "";
            string tId = userData.Length >= 4 ? userData[3] : "";

            Level = new Level(lev);
            ListCards = new ListCards( Level.IndexesCards, tId, this);
            ListWagons = new ListWagons(tId, Level.IndexesWagons, language, this);
        }
        public FormGame()
        {
            InitializeComponent();
        }

       

        private void buttonMenu_Click(object sender, EventArgs e)
        {

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
            ListWagons.Intersection(pictureBoxLife, MovedCard);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train.Train;

namespace Train
{
    public partial class FormGameTeach : Form
    {
        static FormMenu formMenu = new FormMenu();
        Level Level;
        public int lev;
        ListCards ListCards;

        public FormGameTeach()
        {
            InitializeComponent();
            string rulesText = "Совсем скоро ты отправишься в незабываемое приключение!\n\nНо перед этим тебе нужно изучить несколько новых слов\n\nДля того, чтобы изучать новые слова, ты находишься в\nрежиме \"Учить слова\".\n\nСейчас перед тобой находится несколько картинок-образов,\nчтобы услышать произношение слова, нажми на картинку,\nтакже, под каждой картинкой будет написано слово\nпрочитай его и запомни это пригодится тебе в\nследующем режиме.\n\nУдачи в изучении новых слов!";
            labelRules.Text = rulesText;
            lev = Level.level;
            Level = new Level(lev);
            ListCards = new ListCards(Level.IndexesCards, this);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelRules_Click(object sender, EventArgs e)
        {

        }
    }
}

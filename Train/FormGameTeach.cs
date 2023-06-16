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
    public partial class FormGameTeach : Form
    {
        static FormMenu formMenu = new FormMenu();

        public FormGameTeach()
        {
            InitializeComponent();
            string rulesText = "Совсем скоро ты отправишься в незабываемое приключение!\n\nНо перед этим тебе нужно изучить несколько новых слов\n\nДля того, чтобы изучать новые слова, ты находишьсяв\nрежиме \"Учить слова\".\n\nСейчас перед тобой находится несколько картинок-образов,\nчтобы услышать произношение слова, нажми на картинку,\nтакже, под каждой картинкой будет написано слово\nпрочитай его и запомни это пригодится тебе в\nследующем режиме.\n\nУдачи в изучении новых слов!";
            labelRules.Text = rulesText;
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

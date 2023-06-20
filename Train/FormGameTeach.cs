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
    public partial class FormGameTeach : Form
    {

        Level Level;
        public int lev;
        ListCards ListCards;
        private string username;
        private int cardListIndex = 0;
        public FormGameTeach(string username)
        {
            InitializeComponent();
            this.username = username;
            string rulesText = "Совсем скоро ты отправишься в незабываемое приключение!\n\nНо перед этим тебе нужно изучить несколько новых слов\n\nДля того, чтобы изучать новые слова, ты находишься в\nрежиме \"Учить слова\".\n\nСейчас перед тобой находится несколько картинок-образов,\nчтобы услышать произношение слова, нажми на картинку,\nтакже, под каждой картинкой будет написано слово\nпрочитай его и запомни это пригодится тебе в\nследующем режиме.\n\nУдачи в изучении новых слов!";
            labelRules.Text = rulesText;

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu(username);
            formMenu.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelRules_Click(object sender, EventArgs e)
        {

        }

        private void FormGameTeach_Load(object sender, EventArgs e)
        {
            buttonNextCards_Click(null, null);
        }
        private void buttonNextCards_Click(object sender, EventArgs e)
        {

            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            string[] userData = File.ReadAllText(userFile).Split(',');
            string tId = userData.Length >= 4 ? userData[3] : "";
            string languageMain = "Russian";
            string language = userData.Length >= 3 ? userData[2] : "";
            int countCards = 20;

            // Вычисляю начальный индекс картинки для ListCards
            int startIndex = cardListIndex;

            // Увеличиваю индекс первой картинки, которую нужно показать, на 3
            cardListIndex += 3;

            // Проверяю, не превышает ли индекс первой картинки количество картинок в списке
            if (cardListIndex >= 20)
            {
                cardListIndex = 0;
            }

            // Удаляю все картинки из контрола
            ListCards.lstCard.Clear();
            panelCards.Controls.Clear();
            panelCardsSelectedLanguage.Controls.Clear();

            // Обновляю список картинок
            ListCards = new ListCards(tId, countCards, languageMain, panelCards, startIndex);
            ListCards = new ListCards(tId, countCards, language, panelCardsSelectedLanguage, startIndex);

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGame formGame = new FormGame(username);
            formGame.ShowDialog();
        }

        private void panelCards_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

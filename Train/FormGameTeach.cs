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

            
            //ListCards = new ListCards(tId, 20, panelCards, AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
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
             

        }
        private void buttonNextCards_Click(object sender, EventArgs e)
        {
            
                // Вычисляем аргументы для метода ListCards
                string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
                string userFile = $"{usersDirectory}\\{username}.txt";
                string[] userData = File.ReadAllText(userFile).Split(',');
                string tId = userData.Length >= 4 ? userData[3] : "";
                string languageMain = "Russian";
                string language = userData.Length >= 3 ? userData[2] : "";
                int countCards = 20;
                Control control = panelCards;

                // Удаляем все картинки из контрола
                while (control.Controls.Count > 0)
                {
                    control.Controls.Remove(control.Controls[0]);
                    panelCardsSelectedLanguage.Controls.Remove(panelCardsSelectedLanguage.Controls[0]);
            }

                // Очищаем список картинок
               ListCards.lstCard.Clear();

                // Увеличиваем индекс первой картинки, которую нужно показать, на 3
                cardListIndex += 3;

                // Проверяем, не превышает ли индекс первой картинки количество картинок в списке
                if (cardListIndex >= 20)
                {
                    cardListIndex = 0;
                }
                
                // Вычисляем начальный индекс картинки для ListCards
                int startIndex = cardListIndex;

                // Вызываем метод ListCards с новым индексом
                ListCards = new ListCards(tId, countCards, languageMain, control, startIndex);
                ListCards = new ListCards(tId, countCards, language, panelCardsSelectedLanguage, startIndex);

            


        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGame formGame = new FormGame(username);
            formGame.ShowDialog();
        }
    }
}

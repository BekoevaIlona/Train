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

namespace Train
{
    public partial class FormLanguageSelection : Form
    {
        private string username;
        static FormMenu formMenu = new FormMenu();
        private PlayerData playerData;

        public FormLanguageSelection(string username)
        {
            InitializeComponent();
            this.username = username;
            //playerData = new PlayerData(username, "", "");
            //playerData.LoadData();
        }
        public FormLanguageSelection()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            playerData.SaveData();
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu.ShowDialog();
        }
        private void buttonOssetian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("ossetian");
            FormTopic topicForm = new FormTopic(username, "ossetian");
            topicForm.Show();
            this.Hide();
        }

        private void buttonArmenian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("armenian");
            FormTopic topicForm = new FormTopic(username, "armenian");
            topicForm.Show();
            this.Hide();
        }

        private void buttonGeorgian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("georgian");
            FormTopic topicForm = new FormTopic(username, "georgian");
            topicForm.Show();
            this.Hide();

        }

        private void SaveLanguageSelection(string language)
        {
            //string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            //string userFile = $"{usersDirectory}\\{username}.txt";
            //File.AppendAllText(userFile, $",{language}");
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";

            // Прочитать содержимое файла пользователя
            string fileContents = File.Exists(userFile) ? File.ReadAllText(userFile) : "";

            // Проверить, содержит ли файл язык
            if (fileContents.Contains(language))
            {
                // Заменить существующий язык на новый
                fileContents = fileContents.Replace(language, $"{language}");
            }
            else
            {
                // Добавить новый язык в файл
                fileContents += $",{language}";
            }

            // Записать обновленное содержимое обратно в файл
            File.WriteAllText(userFile, fileContents);

        }
    }
}

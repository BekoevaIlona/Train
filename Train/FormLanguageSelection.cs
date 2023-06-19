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
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu.ShowDialog();
        }
        private void buttonOssetian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("Ossetian");
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
            MessageBox.Show("Теперь вы можете выбрать тематику для обучения!");
            this.Hide();
        }

        private void buttonArmenian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("Armenian");
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
            MessageBox.Show("Теперь вы можете выбрать тематику для обучения!");
            this.Hide();
        }

        private void buttonGeorgian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("Georgian");
            

        }

        private void SaveLanguageSelection(string language)
        {
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";

            // Прочитать содержимое файла пользователя
            string fileContents = File.Exists(userFile) ? File.ReadAllText(userFile) : "";

            // Проверить, содержит ли файл язык на 3-м месте
            string[] userData = fileContents.Split(',');
            if (userData.Length >= 3)
            {
                userData[2] = language; // Заменить элемент на 3-м месте на язык
                fileContents = string.Join(",", userData);
            }
            else
            {
                // Добавить новый язык в файл
                fileContents += $",{language}";
            }

            // Записать обновленное содержимое обратно в файл
            File.WriteAllText(userFile, fileContents);

            //// Вывести сообщение о выбранном языке
            //if (language == "armenian")
            //{
            //    MessageBox.Show("Вы выбрали армянский язык");
            //}
            //else if (language == "georgian")
            //{
            //    MessageBox.Show("Вы выбрали грузинский язык");
            //}
            //else if (language == "ossetian")
            //{
            //    MessageBox.Show("Вы выбрали осетинский язык");
            //}
            //else
            //{
            //    MessageBox.Show($"Вы выбрали язык {language}");
            //}
        }

        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class FormTopic : Form
    {
        static FormMenu formMenu = new FormMenu();

        private string username;

        public FormTopic(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public FormTopic()
        {
            InitializeComponent();
        }

        private void SaveTopicSelection(string topic)
        {
            string usersDirectory = $"{Directory.GetCurrentDirectory()}/users";
            string userFile = $"{usersDirectory}/{username}.txt";

            string fileContents = File.Exists(userFile) ? File.ReadAllText(userFile) : "";

            string[] userData = fileContents.Split(',');
            if (userData.Length >= 4)
            {
                userData[3] = topic; // Заменяю элемент на 4-м месте на тему
                fileContents = string.Join(",", userData);
            }
            else
            {
                // Добавляю новую тему в файл
                fileContents += $",{topic},0";
            }
            File.WriteAllText(userFile, fileContents);
            //короче просто тоже самое что и с языками, только записываю это на четвуртое место. Лучше вынести в отдельный класс, но мне пока лень
            

            // Вывести сообщение о выбранной тематике
            //string message = "";
            //switch (topic)
            //{
            //    case "t1":
            //        message = "Дом";
            //        break;
            //    case "t2":
            //        message = "Домашние животные";
            //        break;
            //    case "t3":
            //        message = "Дикие животные";
            //        break;
            //    case "t4":
            //        message = "Овощи, фрукты и ягоды";
            //        break;
            //    case "t5":
            //        message = "Члены семьи и профессии";
            //        break;
            //    default:
            //        message = "неизвестная тематика";
            //        break;
            //}
            //MessageBox.Show($"Вы выбрали тематику \"{message}\"");
        }

        private void FormTopic_Load(object sender, EventArgs e)
        {

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


        private void buttonHouse_Click(object sender, EventArgs e)
        {
            SaveTopicSelection("t1");
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
            MessageBox.Show("Все данные выбраны. \nТеперь вы можете начать игру!");
            this.Hide();
        }

        private void buttonPets_Click(object sender, EventArgs e)
        {
            SaveTopicSelection("t2");
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
            this.Hide();
        }

        private void buttonWildAnimals_Click(object sender, EventArgs e)
        {
            SaveTopicSelection("t3");
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
            MessageBox.Show("Все данные выбраны. \nТеперь вы можете начать игру!");
            this.Hide();
        }

        private void buttonVegetablesFruitsBerries_Click(object sender, EventArgs e)
        {
            SaveTopicSelection("t4");
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
            MessageBox.Show("Все данные выбраны. \nТеперь вы можете начать игру!");
            this.Hide();
        }

        private void buttonFamily_membersProfessions_Click(object sender, EventArgs e)
        {
            SaveTopicSelection("t5");
            FormMenu formMenu = new FormMenu(username);
            formMenu.Show();
            MessageBox.Show("Все данные выбраны. \nТеперь вы можете начать игру!");
            this.Hide();
        }
    }
}
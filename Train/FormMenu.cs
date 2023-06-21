using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class FormMenu : Form
    {
        FormInstructions instructions = new FormInstructions();
        FormAuthorization authorization = new FormAuthorization();
        FormLeaderboard leaderboard = new FormLeaderboard();
        private string username;
        public FormMenu(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public FormMenu()
        {
            InitializeComponent();
            PrivateFontCollection myfont = new PrivateFontCollection();
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.MyFont))
            {
                var data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                byte[] fontdata = new byte[fontStream.Length];
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                myfont.AddMemoryFont(data, (int)fontStream.Length);
                Marshal.FreeCoTaskMem(data);
            }

            buttonAuthorization.Font = new Font(myfont.Families[0], 22);
            buttonAuthorization.UseCompatibleTextRendering = true;

            buttonLanguage.Font = new Font(myfont.Families[0], 22);
            buttonLanguage.UseCompatibleTextRendering = true;

            buttonPlay.Font = new Font(myfont.Families[0], 22);
            buttonPlay.UseCompatibleTextRendering = true;

            buttonInstruction.Font = new Font(myfont.Families[0], 22);
            buttonInstruction.UseCompatibleTextRendering = true;

            buttonTopic.Font = new Font(myfont.Families[0], 22);
            buttonTopic.UseCompatibleTextRendering = true;

            buttonRating.Font = new Font(myfont.Families[0], 22);
            buttonRating.UseCompatibleTextRendering = true;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();

            // Разблокировать кнопку языка, если пользователь авторизован
            if (!string.IsNullOrEmpty(formAuthorization.username))
            {
                buttonLanguage.Enabled = true;
            }
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGameTeach formGameTeach = new FormGameTeach(username);
            formGameTeach.ShowDialog();
        }
        private void buttonInstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            instructions.ShowDialog();
            
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            this.Hide();
            leaderboard.ShowDialog();
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            
            FormLanguageSelection language = new FormLanguageSelection(username);
            DialogResult result = language.ShowDialog();
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            
            
            if (File.Exists(userFile))
            {
                
                string fileContent = File.ReadAllText(userFile);

                string[] elements = fileContent.Split(',');

                // Проверяю, что в строке достаточно элементов для получения нужного элемента
                if (elements.Length >= 3)
                {
                    string l = elements[2]; // Получаю язык из третьего элемента строки

                    // Проверяю, что язык не пустой
                    if (!string.IsNullOrEmpty(l))
                    {
                        buttonTopic.Enabled = true; // Разблокирую кнопку
                    }
                }
            }
        }

        private void buttonTopic_Click(object sender, EventArgs e)
        {
            FormTopic topic = new FormTopic(username);
            DialogResult result = topic.ShowDialog();

            // Если пользователь выбрал тему, разблокировать кнопку buttonPlay
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";

            // Проверяем, существует ли файл с данными пользователя
            if (File.Exists(userFile))
            {
                // Считываем содержимое файла в строку
                string fileContent = File.ReadAllText(userFile);

                // Разбиваем строку на отдельные элементы, используя запятую в качестве разделителя
                string[] elements = fileContent.Split(',');

                // Проверяем, что в строке достаточно элементов для получения нужного элемента
                if (elements.Length >= 4)
                {
                    string l = elements[3]; // Получаем язык из третьего элемента строки

                    // Проверяем, что язык не пустой
                    if (!string.IsNullOrEmpty(l))
                    {
                        buttonPlay.Enabled = true; // Разблокируем кнопку
                    }
                }
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Блокировать все кнопки, кроме указанных
            buttonLanguage.Enabled = false;
            buttonTopic.Enabled = false;
            buttonPlay.Enabled = false;

            // Если пользователь авторизован, разблокировать кнопку языка
            if (!string.IsNullOrEmpty(username))
            {
                buttonLanguage.Enabled = true;
            }
        }
    }
}

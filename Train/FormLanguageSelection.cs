using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class FormLanguageSelection : Form
    {
        private string username;
        static FormMenu formMenu = new FormMenu();

        public FormLanguageSelection(string username)
        {
            InitializeComponent();
            this.username = username;
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

            buttonArmenian.Font = new Font(myfont.Families[0], 22);
            buttonArmenian.UseCompatibleTextRendering = true;

            buttonOssetian.Font = new Font(myfont.Families[0], 22);
            buttonOssetian.UseCompatibleTextRendering = true;

            buttonGeorgian.Font = new Font(myfont.Families[0], 22);
            buttonGeorgian.UseCompatibleTextRendering = true;

            buttonOK.Font = new Font(myfont.Families[0], 22);
            buttonOK.UseCompatibleTextRendering = true;
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
            this.Hide();
            formMenu.Show();
            MessageBox.Show("Теперь вы можете выбрать тематику для обучения!");
            
        }

        private void buttonArmenian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("Armenian");
            FormMenu formMenu = new FormMenu(username);
            this.Hide();
            formMenu.Show();
            MessageBox.Show("Теперь вы можете выбрать тематику для обучения!");
            
        }

        private void buttonGeorgian_Click(object sender, EventArgs e)
        {
            SaveLanguageSelection("Georgian");
            FormMenu formMenu = new FormMenu(username);
            this.Hide();
            formMenu.Show();
            MessageBox.Show("Теперь вы можете выбрать тематику для обучения!");
            
        }

        private void SaveLanguageSelection(string language)
        {
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";

            // Читаю содержимое файла пользователя
            string fileContents = File.Exists(userFile) ? File.ReadAllText(userFile) : "";

            // Проверяю, содержит ли файл язык на 3-м месте
            string[] userData = fileContents.Split(',');
            if (userData.Length >= 3)
            {
                userData[2] = language; // Заменяю элемент на 3-м месте на язык
                fileContents = string.Join(",", userData);
            }
            else
            {
                // Добавляю новый язык в файл
                fileContents += $",{language}";
            }

            // Записываю обновленное содержимое обратно в файл
            File.WriteAllText(userFile, fileContents);

        }

        
    }
}

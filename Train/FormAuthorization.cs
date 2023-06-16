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
    public partial class FormAuthorization : Form
    {
        static FormMenu formMenu = new FormMenu();
        public FormAuthorization()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            // Проверяем, чтобы поля логина и пароля были заполнены
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            // Проверяем, что пользователь с таким логином существует
            string userFile = $"{Directory.GetCurrentDirectory()}\\users\\{username}.txt";
            if (!File.Exists(userFile))
            {
                MessageBox.Show("Пользователь с таким логином не найден");
                return;
            }

            // Сверяем пароли
            string[] data = File.ReadAllText(userFile).Split(',');
            if (data.Length >= 2 && data[1] == password)
            {
                // Переходим на следующую форму
                FormLanguageSelection languageForm = new FormLanguageSelection(username);
                languageForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                return;
            }


            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
                string username = textBoxLogin.Text;
                string password = textBoxPassword.Text;

                // Проверяем, чтобы поля логина и пароля были заполнены
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Введите логин и пароль");
                    return;
                }

                // Записываем логин и пароль в файл
                string userData = $"{username},{password}";
                string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
                if (!Directory.Exists(usersDirectory))
                {
                    Directory.CreateDirectory(usersDirectory);
                }
                string userFile = $"{usersDirectory}\\{username}.txt";
                File.WriteAllText(userFile, userData);

                // Переходим на следующую форму
                FormLanguageSelection languageForm = new FormLanguageSelection(username);
                languageForm.Show();
                this.Hide();
            
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}

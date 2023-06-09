﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Train
{
    public partial class FormAuthorization : Form
    {
        public string username;
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
            FormMenu formMenu = new FormMenu(username);
            formMenu.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            // Проверяю, чтобы поля логина и пароля были заполнены
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            // Проверяю, что пользователь с таким логином существует
            string userFile = $"{Directory.GetCurrentDirectory()}\\users\\{username}.txt";
            if (!File.Exists(userFile))
            {
                MessageBox.Show("Пользователь с таким логином не найден");
                return;
            }

            // Сверяю пароли
            string[] data = File.ReadAllText(userFile).Split(',');
            if (data.Length >= 2 && data[1] == password)
            {
                FormMenu formMenu = new FormMenu(username);
                formMenu.Show();
                this.Hide();

                MessageBox.Show($"Вход прошел успешно. Добро пожаловать, {username}!\nТеперь можете выбрать язык");
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                return;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            username = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            // Проверяю, чтобы поля логина и пароля были заполнены
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            // Записываю логин и пароль в файл
            string userData = $"{username},{password}";
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            if (!Directory.Exists(usersDirectory))
            {
                Directory.CreateDirectory(usersDirectory);
            }
            string userFile = $"{usersDirectory}\\{username}.txt";
            File.WriteAllText(userFile, userData);

            FormMenu formMenu = new FormMenu(username); formMenu.Show();
            this.Hide();

            MessageBox.Show($"Регистрация прошла успешно. Добро пожаловать, {username}!\nТеперь можете выбрать язык");
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {

        }
    }
}

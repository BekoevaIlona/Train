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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            // проверяем, не зарегистрирован ли уже пользователь с таким логином
            if (IsUserRegistered(login))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
                return;
            }

            // создаем нового пользователя
            CreateUser(login, password);

            MessageBox.Show("Регистрация прошла успешно");
        }

        static bool IsUserRegistered(string login)
        {
            // проверяем, существует ли файл с информацией о пользователе
            string filePath = GetFilePathForUser(login);
            return File.Exists(filePath);
        }

        static void CreateUser(string login, string password)
        {
            // создаем файл для хранения информации о пользователе
            string filePath = GetFilePathForUser(login);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // записываем логин и хешированный пароль в файл
                writer.WriteLine(login);
                writer.WriteLine(HashPassword(password));
            }
        }

        static string GetFilePathForUser(string login)
        {
            // определяем путь к файлу с информацией о пользователе
            return Path.Combine(Environment.CurrentDirectory, "users", login + ".txt");
        }

        static string HashPassword(string password)
        {
            // хешируем пароль
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // получаем логин и пароль из текстовых полей
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            // проверяем, зарегистрирован ли пользователь с таким логином
            if (!IsUserRegistered(login))
            {
                MessageBox.Show("Пользователь с таким логином не зарегистрирован");
                return;
            }

            // проверяем, правильный ли пароль ввел пользователь
            if (!IsPasswordCorrect(login, password))
            {
                MessageBox.Show("Неправильный пароль");
                return;
            }

            // если логин и пароль верны, выполняем какое-либо действие, например, открываем новую форму
            MessageBox.Show("Вход выполнен успешно");
            this.Hide();
            FormInstructions formInstructions = new FormInstructions();
            formInstructions.Show();
        }
        static bool IsPasswordCorrect(string login, string password)
        {
            // проверяем, совпадает ли введенный пароль с сохраненным паролем пользователя
            string filePath = GetFilePathForUser(login);
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // читаем логин и хешированный пароль из файла
                    string storedLogin = reader.ReadLine();
                    string storedHashedPassword = reader.ReadLine();

                    // сравниваем введенный пароль с сохраненным хешированным паролем
                    string hashedPassword = HashPassword(password);
                    return hashedPassword == storedHashedPassword;
                }
            }
            else
            {
                return false;
            }
        }

        

        
    }
}

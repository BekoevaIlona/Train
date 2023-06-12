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
    //public partial class FormAuthorization : Form
    //{
    //    static FormMenu formMenu = new FormMenu();
    //    private PlayerData playerData;
    //    public FormAuthorization()
    //    {
    //        InitializeComponent();

    //    }
    //    private void buttonClose_Click(object sender, EventArgs e)
    //    {
    //        Application.Exit();
    //    }

    //    private void buttonMenu_Click(object sender, EventArgs e)
    //    {
    //        this.Hide();
    //        formMenu.ShowDialog();
    //    }
    //    private void buttonLogin_Click(object sender, EventArgs e)
    //    {
    //        // проверяем, что поля логина и пароля не пустые
    //        if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
    //        {
    //            MessageBox.Show("Пожалуйста, введите логин и пароль");
    //            return;
    //        }

    //        // создаем экземпляр класса PlayerData и заполняем его поля
    //        PlayerData playerData = new PlayerData
    //        {
    //            Login = textBoxLogin.Text,
    //            Password = textBoxPassword.Text,
    //            Language = "",
    //            Topic = "",
    //            Score = 0
    //        };

    //        // переходим на форму выбора языка
    //        FormLanguageSelection languageForm = new FormLanguageSelection(playerData);
    //        languageForm.Show();

    //        // скрываем текущую форму
    //        this.Hide();
    //    }

    //    private void buttonRegister_Click(object sender, EventArgs e)
    //    {
    //        // переходим на форму регистрации
    //        FormRegistration registrationForm = new FormRegistration();
    //        registrationForm.Show();

    //        // скрываем текущую форму
    //        this.Hide();
    //    }


    //}
    public partial class FormAuthorization : Form
    {
        public PlayerData playerData;
        static FormMenu formMenu = new FormMenu();
        public FormAuthorization()
        {
            InitializeComponent();

            // создаем экземпляр класса PlayerData
            playerData = new PlayerData();
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
            // проверяем, что поля логина и пароля не пустые
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль");
                return;
            }

            // проверяем, что пользователь уже зарегистрирован
            if (!playerData.IsRegistered(textBoxLogin.Text))
            {
                MessageBox.Show("Пользователь с таким логином не зарегистрирован");
                return;
            }

            // проверяем, что пароль введен правильно
            if (!playerData.CheckPassword(textBoxLogin.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Неправильный пароль");
                return;
            }

            // сохраняем логин игрока
            playerData.Login = textBoxLogin.Text;

            // переходим на форму выбора языка
            FormLanguageSelection languageForm = new FormLanguageSelection(playerData);
            languageForm.Show();

            // скрываем текущую форму
            this.Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // переходим на форму регистрации
            FormRegistration registrationForm = new FormRegistration(playerData);
            registrationForm.Show();

            // скрываем текущую форму
            this.Hide();
        }
    }
}

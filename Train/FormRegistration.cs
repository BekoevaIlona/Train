using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public partial class FormRegistration : Form
    {
        public PlayerData playerData;
        public FormRegistration(PlayerData playerData)
        {
            InitializeComponent();
            this.playerData = playerData;
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // проверяем, что поля логина и пароля не пустые
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль");
                return;
            }

            // проверяем, что пароль подтвержден
            if (textBoxPassword.Text != textBoxСonfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            // регистрируем игрока
            if (!playerData.Register(textBoxLogin.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован");
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
    }
}

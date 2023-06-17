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
            try
            {
                this.Hide();
                instructions.ShowDialog();
            }
            catch (Exception ex)
            {
                // Обработка исключения
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            this.Hide();
            leaderboard.ShowDialog();
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            // Отобразить форму выбора темы
            FormLanguageSelection language = new FormLanguageSelection(username);
            DialogResult result = language.ShowDialog();

            // Если пользователь выбрал тему, разблокировать кнопку buttonPlay
            if (result == DialogResult.OK)
            {
                buttonTopic.Enabled = true;
            }
        }

        private void buttonTopic_Click(object sender, EventArgs e)
        {
            FormTopic topic = new FormTopic(username);
            DialogResult result = topic.ShowDialog();

            // Если пользователь выбрал тему, разблокировать кнопку buttonPlay
            if (result == DialogResult.OK)
            {
                buttonPlay.Enabled = true;
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

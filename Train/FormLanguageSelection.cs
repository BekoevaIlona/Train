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
    public partial class FormLanguageSelection : Form
    {
        private PlayerData playerData;
        static FormMenu formMenu = new FormMenu();
        public FormLanguageSelection(PlayerData playerData)
        {
            InitializeComponent();
            this.playerData = playerData;
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

        private void FormLnguageSelection_Load(object sender, EventArgs e)
        {

        }

        private void buttonOssetian_Click(object sender, EventArgs e)
        {
            // выбран язык осетинский
            playerData.Language = "осетинский";

            // переходим на форму выбора тематики
            //TopicForm topicForm = new TopicForm(playerData);
            //topicForm.Show();

            // скрываем текущую форму
            this.Hide();
        }

        private void buttonArmenian_Click(object sender, EventArgs e)
        {
            // выбран язык армянский
            playerData.Language = "армянский";

            // переходим на форму выбора тематики
            //TopicForm topicForm = new TopicForm(playerData);
            //topicForm.Show();

            // скрываем текущую форму
            this.Hide();
        }

        private void buttonGeorgian_Click(object sender, EventArgs e)
        {
            // выбран язык грузинский
            playerData.Language = "грузинский";

            // переходим на форму выбора тематики
            //TopicForm topicForm = new TopicForm(playerData);
            //topicForm.Show();

            // скрываем текущую форму
            this.Hide();
        }
    }
}

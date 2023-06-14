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
    public partial class FormTopic : Form
    {
        private string username;
        private string language;

        public FormTopic(string username, string language)
        {
            InitializeComponent();
            this.username = username;
            this.language = language;
        }

        //private void buttonFruitsVegetables_Click(object sender, EventArgs e)
        //{
        //    SaveTopicSelection("fruits_vegetables");
        //    FormGame gameForm = new FormGame(username, language, "fruits_vegetables");
        //    gameForm.Show();
        //    this.Hide();
        //}

        //private void buttonAnimals_Click(object sender, EventArgs e)
        //{
        //    SaveTopicSelection("animals");
        //    FormGame gameForm = new FormGame(username, language, "animals");
        //    gameForm.Show();
        //    this.Hide();
        //}

        //private void buttonNature_Click(object sender, EventArgs e)
        //{
        //    SaveTopicSelection("nature");
        //    //FormGame gameForm = new FormGame(username, language, "nature");
        //    //gameForm.Show();
        //    //this.Hide();
        //}

        private void SaveTopicSelection(string topic)
        {
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            File.AppendAllText(userFile, $",{topic},0");
        }

        private void FormTopic_Load(object sender, EventArgs e)
        {

        }

        private void buttonFruitsVegetables_Click(object sender, EventArgs e)
        {
            SaveTopicSelection("fruits_vegetables");
            FormGame gameForm = new FormGame(username, language, "fruits_vegetables");
            gameForm.Show();
            this.Hide();
        }
    }
}

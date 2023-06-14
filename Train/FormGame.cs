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
    public partial class FormGame : Form
    {
        private PlayerData playerData;

        public FormGame(string username, string language, string topic)
        {
            InitializeComponent();
            playerData = new PlayerData(username, language, topic);
            playerData.LoadData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            playerData.SaveData();
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Обработка ответа игрока
            // ...
            // Увеличиваем количество баллов игрока
            playerData.Points++;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }
    }
}

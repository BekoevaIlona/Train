using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train.Train;

namespace Train
{
    public partial class FormGame : Form
    {
        //private PlayerData playerData;
        public static Card MovedCard = null;

        public FormGame(string username)
        {
            InitializeComponent();
            //playerData = new PlayerData(username, language, topic);
            //playerData.LoadData();
            //playerData.SaveData();
        }
        public FormGame()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //playerData.SaveData();
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {

        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }
    }
}

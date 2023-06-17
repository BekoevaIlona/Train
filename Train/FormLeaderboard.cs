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
    public partial class FormLeaderboard : Form
    {
        static FormMenu formMenu = new FormMenu();
        public FormLeaderboard()
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
        public class Player
        {
            public string Name { get; set; }
            public int Score { get; set; }

            public Player(string name, int score)
            {
                Name = name;
                Score = score;
            }
        }
        private void FormLeaderboard_Load(object sender, EventArgs e)
        {
            // Получаем список файлов в папке
            string folderPath = Path.Combine(Application.StartupPath, "users");
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            List<Player> players = new List<Player>();

            // Читаем данные из каждого файла и создаем объекты Player
            foreach (string file in files)
            {
                string[] lines = File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    string[] userData = line.Split(',');

                    if (userData.Length >= 5)
                    {
                        string name = userData[0];
                        int score;

                        if (int.TryParse(userData[4], out score))
                        {
                            players.Add(new Player(name, score));
                        }
                    }
                }
            }

            // Сортируем игроков по баллам в порядке убывания
            players = players.OrderByDescending(p => p.Score).ToList();

            // Выводим результаты
            listBoxLeaderboard.Items.Clear();

            int i = 1;
            foreach (Player player in players)
            {
                string listItem = i.ToString() + ". " + player.Name + " - " + player.Score;
                listBoxLeaderboard.Items.Add(listItem);
                i++;
            }
        }

        private void listBoxLeaderboard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



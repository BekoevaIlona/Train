using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{
    public class PlayerData
    {
        private string username;
        private string language;
        private string topic;
        private int points;

        public PlayerData(string username, string language, string topic)
        {
            this.username = username;
            this.language = language;
            this.topic = topic;
            this.points = 0;
        }

        public void LoadData()
        {
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            string[] data = File.ReadAllText(userFile).Split(',');
            language = data[1];
            topic = data[2];
            if (int.TryParse(data[3], out int pointsValue))
            {
                points = pointsValue;
            }
            else
            {
                // Обработка ошибки
                Console.WriteLine($"Недопустимое значение баллов: {data[3]}");
                points = 0; // Установка значения по умолчанию
            }

        }

        public void SaveData()
        {
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            string userData = $"{username},{language},{topic},{points}";
            File.AppendAllText(userFile, userData + ",");
        }

        public string Username
        {
            get { return username; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }
    }
}

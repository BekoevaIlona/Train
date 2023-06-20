using System;
using System.IO;

namespace Train
{
    public static class PlayerScoreManager
    {
        public static void UpdateScore(string username, int scoreDelta)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users", $"{username}.txt");
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found", filePath);
            }

            // Читаем все строки файла и ищем строку с именем пользователя
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] userScore = lines[i].Split(',');
                if (userScore.Length == 5 && userScore[0] == username)
                {
                    int score = int.Parse(userScore[4]);

                    // Обновляем количество баллов
                    score += scoreDelta;

                    // Записываем изменения в строку
                    lines[i] = $"{username},{userScore[1]},{userScore[2]},{userScore[3]},{score}";
                    break;
                }
            }

            // Записываем изменения в файл
            File.WriteAllLines(filePath, lines);
        }
        public static int GetScore(string username)
        {
            string usersDirectory = $"{Directory.GetCurrentDirectory()}\\users";
            string userFile = $"{usersDirectory}\\{username}.txt";
            if (File.Exists(userFile))
            {
                string[] userData = File.ReadAllText(userFile).Split(',');
                if (userData.Length >= 5 && int.TryParse(userData[4], out int score))
                {
                    return score;
                }
            }
            return 0; // если не удалось получить баллы, возвращаем 0
        }
    }
}
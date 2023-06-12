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
        public string Login { get; set; }
        private string Password { get; set; }
        public string Language { get; set; }
        public string Topic { get; set; }
        public int Score { get; set; }

        public PlayerData()
        {
            Score = 0;
        }

        public bool IsRegistered(string login)
        {
            // проверяем, что файл с данными игрока существует в папке пользователей
            string filePath = GetUserFilePath(login);
            return File.Exists(filePath);
        }

        public bool Register(string login, string password)
        {
            // проверяем, что пользователь с таким логином еще не зарегистрирован
            if (IsRegistered(login))
            {
                return false;
            }

            // сохраняем логин и хэш пароля в файле с данными игрока
            string filePath = GetUserFilePath(login);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(login);
                writer.WriteLine(HashPassword(password));
            }

            return true;
        }

        public bool CheckPassword(string login, string password)
        {
            // проверяем, что файл с данными игрока существует в папке пользователей
            string filePath = GetUserFilePath(login);
            if (!File.Exists(filePath))
            {
                return false;
            }

            // считываем хэш пароля из файла и сравниваем с введенным паролем
            using (StreamReader reader = new StreamReader(filePath))
            {
                reader.ReadLine(); // пропускаем логин
                string hashedPassword = reader.ReadLine();
                return HashPassword(password) == hashedPassword;
            }
        }

        public void Save()
        {
            // создаем папку пользователей, если ее нет
            string usersDirectory = Path.Combine(Application.StartupPath, "users");
            if (!Directory.Exists(usersDirectory))
            {
                Directory.CreateDirectory(usersDirectory);
            }

            // сохраняем данные игрока в txt файле в папке пользователей
            string filePath = GetUserFilePath(Login);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(Login);
                writer.WriteLine(HashPassword(Password));
                writer.WriteLine(Language);
                writer.WriteLine(Topic);
                writer.WriteLine(Score);
            }
        }

        private string GetUserFilePath(string login)
        {
            // формируем путь к файлу с данными игрока
            string fileName = login + ".txt";
            return Path.Combine(Application.StartupPath, "users", fileName);
        }

        private string HashPassword(string password)
        {
            // хэшируем пароль с помощью SHA256
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            using (SHA256Managed sha256 = new SHA256Managed())
            {
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}

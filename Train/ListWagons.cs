using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Train
{
    namespace Train
    {

        public enum Languages
        {
            Ossetian,
            Armenian,
            Georgian
        }

        public class Wagon : PictureBox
        {
            public int IdPicture { get; }
            public string language;
            public string idTopic;
            public Wagon(string tId, int pId,  string language, Control control, int x, int y)
            {
                this.language = language;
                IdPicture = pId;
                Tag = pId;
                this.idTopic = tId;

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wagons", $"{tId}p{IdPicture}{language}.JPG");
                this.Load(imagePath);
                control.Controls.Add(this);
                this.Size = new Size(270, 170);
                this.SizeMode = PictureBoxSizeMode.StretchImage;
                this.BackColor = Color.Transparent;
                Location = new Point(x, y);
            }

            public new void Move(int speed)
            {
                Left += speed;
            }
        }

        public class ListWagons
        {
            private readonly List<Wagon> lstWagon = new List<Wagon>();
            int life = 5;
            public static int counter = 0;

            public static int Counter { get; private set; }

            public ListWagons(string tId, List<int> arrayID, string language, Control control)
            {
                for (int j = 0; j < arrayID.Count; j++)
                {
                    Wagon wagon = new Wagon(tId, arrayID[j], language, control, 270*(-1) * j, 150);
                    lstWagon.Add(wagon);
                }
            }

            public void Intersection(PictureBox pictureBoxLife, Card movedCard, string username)
            {
                foreach (Wagon wagon in lstWagon)
                {
                    if (FormGame.MovedCard != null && FormGame.MovedCard.Bounds.IntersectsWith(wagon.Bounds))
                    {
                        if (wagon.Tag.ToString() == FormGame.MovedCard.Tag.ToString())
                        {
                            FormGame.MovedCard = null;
                            Counter++;
                            wagon.Image = Image.FromFile("img/FilledWagon.png");
                            movedCard.Dispose();

                            // Обновляем баллы игрока
                            UpdateScore(username, 10); // например, добавляем 10 баллов

                            return;
                        }

                        FormGame.MovedCard = null;

                        if (life > 0)
                        {
                            life--;
                            pictureBoxLife.Image = Image.FromFile($"Life/{life}.png");

                            if (life < 1)
                            {
                                // Обновляем баллы игрока
                                UpdateScore(username, -10); // например, отнимаем 10 баллов

                                MessageBox.Show("Жизни закончились");
                                FormGameOver formGameOver = new FormGameOver();
                                formGameOver.Show();
                                return;
                            }

                            return;
                        }
                    }
                }
            }

            private void UpdateScore(string username, int scoreDelta)
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

            public void Move(int speed)
            {
                foreach (Wagon wagon in lstWagon)
                {
                    wagon.Move(speed);
                }
            }
        }
    }
}

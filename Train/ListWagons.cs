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

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Wagons", $"{tId}p{IdPicture}{language}.JPG");
                this.Load(imagePath);
                control.Controls.Add(this);
                this.Size = new Size(270, 170);
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
            private int life = 5;

            public static int Counter { get; private set; }

            public ListWagons(string tId, List<int> arrayID, string language, Control control)
            {
                for (int j = 0; j < arrayID.Count; j++)
                {
                    Wagon wagon = new Wagon(tId, arrayID[j], language, control, 300 * (-1) * j, 10);
                    lstWagon.Add(wagon);
                }
            }

            public void Intersection(PictureBox pictureBoxLife, Card movedCard)
            {
                foreach (Wagon wagon in lstWagon)
                {
                    if (FormGame.MovedCard != null && FormGame.MovedCard.Bounds.IntersectsWith(wagon.Bounds))
                    {
                        if (wagon.Tag.ToString() == FormGame.MovedCard.Tag.ToString())
                        {
                            FormGame.MovedCard = null;
                            Counter++;
                            wagon.Image = Image.FromFile("Resurses/FilledWagon.png");
                            movedCard.Dispose();
                            return;
                        }

                        FormGame.MovedCard = null;

                        if (life > 0)
                        {
                            life--;
                            pictureBoxLife.Image = Image.FromFile($"Life/{life}.png");

                            if (life < 1)
                            {
                                MessageBox.Show("Жизни закончились");
                                //FormGameOver formGameOver = new FormGameOver();
                                //formGameOver.Show();
                                return;
                            }

                            return;
                        }
                    }
                }
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

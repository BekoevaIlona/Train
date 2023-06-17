﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

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
            public Languages Language { get; }

            public Wagon(int idPicture, Languages language, Control control, int x, int y)
            {
                Language = language;
                IdPicture = idPicture;
                Tag = idPicture;

                Load($"Wagons/p{IdPicture}{Language}.png");
                control.Controls.Add(this);
                SizeMode = PictureBoxSizeMode.AutoSize;
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

            public ListWagons(List<int> arrayID, Languages language, Control control)
            {
                for (int j = 0; j < arrayID.Count; j++)
                {
                    Wagon wagon = new Wagon(arrayID[j], language, control, 300 * (-1) * j, 10);
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
                            wagon.Image = Image.FromFile("Images/FilledWagon.png");
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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Train
{
    namespace Train
    {
        public class Card : PictureBox
        {
            public int id;
            public string idTopic;
            public string language;
            public Card(string tId, int pId, string language, Control control, int x, int y)
            {
                this.id = pId;
                this.idTopic = tId;
                this.Tag = pId;
                this.language = language;
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cards", $"{tId}p{pId}Russian.JPG");
                this.Load(imagePath);
                control.Controls.Add(this);
                this.SizeMode = PictureBoxSizeMode.Zoom;
                this.Size = new Size(140, 140);
                Location = new Point(x, y);
                
                this.MouseDown += Card_MouseDown;
                this.MouseMove += Card_MouseMove;
                this.MouseUp += Card_MouseUp;

                this.Click += PlaySound;
            }
            public Card(int pId, string tId,  string language, Control control, int x, int y)
            {
                this.id = pId;
                this.idTopic = tId;
                this.Tag = pId;
                this.language = language;
                this.Location = new Point(x, y);
                control.Controls.Add(this);
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cards", $"{tId}p{pId}{language}.JPG");
                this.Load(imagePath);
                control.Controls.Add(this);
                this.SizeMode = PictureBoxSizeMode.Zoom;
                this.Size = new Size(170, 170);
                Location = new Point(x, y);
                this.MouseClick += new MouseEventHandler(PlaySound);
            }

            private void PlaySound(object sender, EventArgs e)
            {
                string soundPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio", $"{idTopic}p{id}{language}.wav");
                if (File.Exists(soundPath))
                {
                    // Проигрываем звуковой файл
                    using (var player = new SoundPlayer(soundPath))
                    {
                        player.Play();
                    }
                }
                else
                {
                    // Обрабатываем случай, когда файл не найден
                    MessageBox.Show("Файл звука не найден!");
                }
            }

            private void Card_MouseUp(object sender, MouseEventArgs e)
            {
                FormGame.MovedCard = null;

            }

            int startX, startY;
            private void Card_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - startX;
                    this.Top += e.Y - startY;
                }
            }

            private void Card_MouseDown(object sender, MouseEventArgs e)
            {

                startX = e.X;
                startY = e.Y;
                FormGame.MovedCard = this;
                //MessageBox.Show(id.ToString());
                this.BringToFront();
            }
        }

        class ListCards
        {
            public static List<Card> lstCard = new List<Card>();

            public ListCards()
            {
            }

            public ListCards(string tId, int countCards, string language, Control control, int startIndex = 0)
            {
                int x = 0;
                int y = 0;
                int cardCounter = 0;
                int cardsPerRow = 1;
                int cardWidthWithPadding = (new Card( 0, tId, language, control, 0, 0)).Width + 1;
                for (int j = 0; j < countCards; j++)
                {
                    // Проверяю, нужно ли показывать текущую картинку
                    if (j < startIndex || j >= startIndex + 3) continue;

                    Card c = new Card(j, tId,language, control, x, y);
                    control.Controls.Add(c);
                    lstCard.Add(c);
                    cardCounter++;
                    if (cardCounter >= cardsPerRow)
                    {
                        y += c.Height + 1;
                        x = 0;
                        cardCounter = 0;
                    }
                    else
                    {
                        x += cardWidthWithPadding;
                    }
                }
            }
            public ListCards(List<int> arrayID, string tId, Control control, string language)
            {
                int a = 0, b = 0, q = 0;
                for (int j = 0; j < arrayID.Count; j++)
                {
                    if (j < 5)
                    {
                        Card c = new Card(tId, arrayID[j], language, control, 190 * a, 500);
                        lstCard.Add(c);
                        a++;
                    }
                    else
                    {
                        if (j >= 8 && j < 10)
                        {
                            Card c = new Card(tId, arrayID[j], language, control, 190 * b, 500);
                            lstCard.Add(c);
                            b++;
                        }
                        else
                        {
                            Card c = new Card(tId, arrayID[j], language, control, 190 * q, 700);
                            lstCard.Add(c);
                            q++;
                        }
                    }
                }
            }


        }
    }
}

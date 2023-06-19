using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
            public Card(int id, Control control, int x, int y)
            {
                this.id = id;
                this.Tag = id;

                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cards", $"t2p{id}.JPG");
                this.Load(imagePath);
                control.Controls.Add(this);
                this.SizeMode = PictureBoxSizeMode.Zoom;
                this.Size = new Size(100, 100);
                Location = new Point(x, y);
                this.MouseDown += Card_MouseDown;
                this.MouseMove += Card_MouseMove;
                this.MouseUp += Card_MouseUp;
            }
            public Card(string tId, int pId, Control control, int x, int y)
            {
                this.idTopic = tId;
                this.id = pId;
                this.Tag = pId;
                this.Location = new Point(x, y);
                control.Controls.Add(this);
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cards", $"{tId}p{pId}Russian.JPG");
                this.Load(imagePath);
                control.Controls.Add(this);
                this.SizeMode = PictureBoxSizeMode.Zoom;
                this.Size = new Size(180, 180);
                Location = new Point(x, y);
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
            public List<Card> lstCard = new List<Card>();

            public ListCards()
            {
            }

            public ListCards(string tId, int countCards, Control control, int startIndex = 0)
            {
                int x = 0;
                int y = 0;
                int cardCounter = 0;
                int cardsPerRow = 1;
                int cardWidthWithPadding = (new Card(tId, 0, control, 0, 0)).Width + 1; 
                for (int j = 0; j < countCards; j++)
                {
                    // Проверяю, нужно ли показывать текущую картинку
                    if (j < startIndex || j >= startIndex + 3) continue;

                    Card c = new Card(tId, j, control, x, y);
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
            public ListCards(List<int> arrayID, Control control)
            {
                int a = 0, b = 0, q = 0;
                for (int j = 0; j < arrayID.Count; j++)
                {
                    if (j < 8)
                    {
                        Card c = new Card(arrayID[j], control, 190 * a, 250);
                        lstCard.Add(c);
                        a++;
                    }
                    else
                    {
                        if (j >= 8 && j < 16)
                        {
                            Card c = new Card(arrayID[j], control, 190 * b, 500);
                            lstCard.Add(c);
                            b++;
                        }
                        else
                        {
                            Card c = new Card(arrayID[j], control, 190 * q, 700);
                            lstCard.Add(c);
                            q++;
                        }
                    }
                }
            }

            
        }
    }
}

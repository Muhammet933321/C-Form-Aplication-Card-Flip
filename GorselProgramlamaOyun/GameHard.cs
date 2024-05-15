using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaOyun
{
    public partial class GameHard : Form
    {
        Random rnd = new Random();
        public GameHard()
        {
            InitializeComponent();
            UpdateCards();
            LoadBoard();

            TimeTxt.Text = TotalTime.ToString();
            GameTimer.Start();
        }
        const int BOARDSCALE = 8;
        int TotalTime = 150;
        int CountDownTime = 150;
        
        bool IsGameOver = false;
        bool CanSelect = true;

        

        int FindeableCardCount = BOARDSCALE * BOARDSCALE / 2;
        int FindedCardCount;

        string firstCardTag;
        string secondCardTag;
        PictureBox FirstPicture;
        PictureBox SecondPicture;

        PictureBox[,] Board = new PictureBox[BOARDSCALE, BOARDSCALE];
        List<CardClass> Cards = new List<CardClass>();


        public void UpdateCards()
        {

            for (int i = 0; i < BOARDSCALE * BOARDSCALE / 2; i++)
            {
                CardClass newCard = new CardClass();
                PictureBox newPic = new PictureBox();

                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += Picture_Click;
                newPic.Tag = i;

                newPic.Image = Image.FromFile("pics/" + i + ".png");


                newCard.CardPicture(newPic);
                newCard.ID = i;

                Cards.Add(newCard);
                Cards.Add(newCard);

            }
        }

        public void LoadBoard()
        {
            int cardWidth = 70;
            int cardHeight = 70;
            int padding = 20;

            int screenWidth = this.ClientSize.Width;
            int screenHeight = this.ClientSize.Height;

            int boardWidth = (cardWidth + padding) * BOARDSCALE + padding;
            int boardHeight = (cardHeight + padding) * BOARDSCALE + padding;


            for (int i = 0; i < BOARDSCALE; i++)
            {
                for (int j = 0; j < BOARDSCALE; j++)
                {
                    int randomCardID = rnd.Next(Cards.Count);
                    CardClass newCard = Cards[randomCardID];
                    Cards.RemoveAt(randomCardID);

                    PictureBox newPic = new PictureBox();
                    newPic.Height = cardHeight;
                    newPic.Width = cardWidth;
                    newPic.BackColor = Color.LightGray;
                    newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    newPic.Click += Picture_Click;
                    newPic.Tag = newCard.ID;
                    newPic.Image = Image.FromFile("pics/" + newCard.ID + ".png");

                    newCard.CardPicture(newPic);
                    newCard.pictureBox.Left = j * (cardWidth + padding) + padding;
                    newCard.pictureBox.Top = i * (cardHeight + padding) + padding;

                    Board[i, j] = newPic;
                    this.Controls.Add(newCard.pictureBox);
                }
            }
        }

        private void Picture_Click(object? sender, EventArgs e)
        {
            if (CanSelect)
            {
                if (IsGameOver)
                {
                    return;
                }
                if (firstCardTag == null)
                {
                    FirstPicture = sender as PictureBox;
                    if (FirstPicture.Tag != null)
                    {
                        //MessageBox.Show("Picture Tag is Not Null");
                        if (FirstPicture.Image == null)
                        {
                            FirstPicture.Image = Image.FromFile("pics/" + FirstPicture.Tag + ".png");
                            firstCardTag = FirstPicture.Tag.ToString();
                            //MessageBox.Show("Picture Image is Not Null");
                        }
                        else
                        {
                            // MessageBox.Show("Picture Image is Null");
                        }

                    }
                    else
                    {
                        //MessageBox.Show("Picture Tag is Null");
                    }
                }
                else if (secondCardTag == null)
                {
                    SecondPicture = sender as PictureBox;

                    if (SecondPicture.Tag != null)
                    {
                        //MessageBox.Show("Picture Tag is Not Null");
                        if (SecondPicture.Image == null)
                        {
                            SecondPicture.Image = Image.FromFile("pics/" + SecondPicture.Tag + ".png");
                            secondCardTag = SecondPicture.Tag.ToString();
                            //MessageBox.Show("Picture Image is Not Null");
                        }
                        else
                        {
                            // MessageBox.Show("Picture Image is Null");
                        }

                    }
                    else
                    {
                        //MessageBox.Show("Picture Tag is Null");
                    }
                }
                else
                {
                    CheckPictures(FirstPicture, SecondPicture);
                }
            }


        }
        public void CheckPictures(PictureBox A, PictureBox B)
        {

            if (firstCardTag == secondCardTag)
            {
                Board = new PictureBox[0, 0];
                FindedCardCount++;
                A.Enabled = false;
                B.Enabled = false;
                if (FindedCardCount == FindeableCardCount)
                {
                    GameTimer.Stop();
                    GameTimer.Enabled = false;
                    CanSelect = false;
                    Win();

                }
            }
            else
            {
                FirstPicture.Image = null;
                SecondPicture.Image = null;
            }



            firstCardTag = null;
            secondCardTag = null;

        }

        public void DoInvisibleAllCards()
        {
            foreach (var card in Cards)
            {
                card.UnvisibleCard();
            }
        }
        public void Win()
        {
            MessageBox.Show("You Win!!!!!!!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            CountDownTime--;
            TimeTxt.Text = CountDownTime.ToString();
            if (CountDownTime < 1)
            {
                CanSelect = false;
                GameTimer.Stop();
                GameTimer.Enabled = false;
                MessageBox.Show("Times Up, You Lose :d");
            }
        }
    }
}

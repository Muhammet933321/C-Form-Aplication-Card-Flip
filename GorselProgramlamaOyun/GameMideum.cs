using System.Threading;

namespace GorselProgramlamaOyun
{
    public partial class GameMideum : Form
    {
        Random rnd = new Random();

        const int BOARDSCALE = 6;
        int TotalTime = 90;
        int CountDownTime = 90;

        int cardWidth = 70;
        int cardHeight = 70;
        int padding = 20;
        public GameMideum()
        {
            InitializeComponent();
            UpdateCards();
            LoadBoard();

            TimeTxt.Text = TotalTime.ToString();
            GameTimer.Start();
        }
        

        

        bool CanSelect = true;
        bool IsGameOver = false;



        int FindeableCardCount = BOARDSCALE * BOARDSCALE / 2;
        int FindedCardCount;

        string firstCardTag;
        string secondCardTag;
        CardClass FirstCard;
        CardClass SecondCard;

        CardClass[,] Board = new CardClass[BOARDSCALE, BOARDSCALE];
        List<CardClass> Cards = new List<CardClass>();


        public void UpdateCards()
        {

            for (int i = 0; i < BOARDSCALE * BOARDSCALE / 2; i++)
            {
                CardClass newCard1 = new CardClass();
                PictureBox newPic1 = new PictureBox();
                CardClass newCard2 = new CardClass();
                PictureBox newPic2 = new PictureBox();

                newPic1.Height = cardWidth;
                newPic1.Width = cardHeight;
                newPic1.BackColor = Color.LightGray;
                newPic1.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic1.Tag = i;
                newPic1.Image = Image.FromFile("pics/" + i + ".png");
                newCard1.CardPicture(newPic1);
                newCard1.ID = i;


                newPic2.Height = cardWidth;
                newPic2.Width = cardHeight;
                newPic2.BackColor = Color.LightGray;
                newPic2.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic2.Tag = i;
                newPic2.Image = Image.FromFile("pics/" + i + ".png");
                newCard2.CardPicture(newPic2);
                newCard2.ID = i;



                newCard2.Click += Card_Click;
                newCard1.Click += Card_Click;
                Cards.Add(newCard1);
                Cards.Add(newCard2);

            }
        }
        public void LoadBoard()
        {
            for (int i = 0; i < BOARDSCALE; i++)
            {
                for (int j = 0; j < BOARDSCALE; j++)
                {

                    int randomCardID = rnd.Next(Cards.Count);
                    Board[i, j] = Cards[randomCardID];
                    Cards.RemoveAt(randomCardID);

                    Board[i, j].pictureBox.Left = j * (cardWidth + padding) + padding;
                    Board[i, j].pictureBox.Top = i * (cardHeight + padding) + padding;
                    this.Controls.Add(Board[i, j].pictureBox);
                }
            }
        }

        private void Card_Click(object? sender, EventArgs e)
        {
            if (CanSelect)
            {
                if (IsGameOver)
                {
                    return;
                }
                if (firstCardTag == null)
                {
                    FirstCard = sender as CardClass;
                    if (FirstCard.pictureBox.Tag != null)
                    {
                        if (FirstCard.pictureBox.Image == null)
                        {
                            FirstCard.ShowCard();
                            firstCardTag = FirstCard.pictureBox.Tag.ToString();
                        }
                    }
                }
                else if (secondCardTag == null)
                {
                    SecondCard = sender as CardClass;

                    if (SecondCard.pictureBox.Tag != null)
                    {
                        if (SecondCard.pictureBox.Image == null)
                        {
                            SecondCard.ShowCard();
                            secondCardTag = SecondCard.pictureBox.Tag.ToString();
                        }
                    }
                }
                else
                {
                    CheckPictures(FirstCard.pictureBox, SecondCard.pictureBox);
                }
            }
        }
        public void CheckPictures(PictureBox A, PictureBox B)
        {

            if (firstCardTag == secondCardTag)
            {
                FindedCardCount++;
                if (FindedCardCount >= FindeableCardCount)
                {
                    Win();
                }
                A.Enabled = false;
                B.Enabled = false;
            }
            else
            {
                FirstCard.UnvisibleCard();
                SecondCard.UnvisibleCard();
            }
            firstCardTag = null;
            secondCardTag = null;

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

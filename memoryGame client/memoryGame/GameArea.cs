using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    public partial class GameArea : Form
    {
        private Game game;
        public GameArea()
        {
            InitializeComponent();
            lblScore.Anchor = AnchorStyles.None;
            Number.Anchor = AnchorStyles.None;
            btnRestart.Anchor = AnchorStyles.None;
            InitializeCards();
        }
        private void InitializeCards()
        {

            List<Card> cards = new List<Card>();

            int numOfCards = 32;
            for (int i = 0; i < numOfCards; i++)
            {
                PictureBox pictureBox = new PictureBox();
                int horizontalMargin = 17;
                int verticalMargin = 15;
                int row = i / 4;
                int column = i % 4;
                Point position = new Point(horizontalMargin + 120 * column, verticalMargin + 90 * row);
                pictureBox.Location = position;
                pictureBox.Name = "Card" + i.ToString();
                pictureBox.Size = new Size(114, 81);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                string cardID = "card" + i.ToString();
                pictureBox.Tag = cardID;
                pictureBox.Click += CardClick;
                panel1.Controls.Add(pictureBox);

                Card card = new Card(cardID, pictureBox);
                cards.Add(card);
            }

            game = new Game(cards, Number);

        }
        private void StartNewGame()
        {
            if (!game.GetClickEnabled())
            {
                return;
            }
            game.StartNewGame();
            game.SetClickEnabled(false);
            timer1.Start();
        }
        private void GameArea_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            game.HideAllCards();
            game.SetClickEnabled(true);
        }


        private void CardClick(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                game.ClickCard(pictureBox.Tag.ToString());
            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void GameArea_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
         }
    }
}

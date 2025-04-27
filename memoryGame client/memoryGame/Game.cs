using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    internal class Game
    {
        private List<Card> cards;
        private int score;
        //private int enemyScore;
        private Card[] selectedCards;
        private List<string> discoveredCards = new List<string>();
        private bool clickEnabled = true;
        private Label scoreLabel;
        private Image[] images = {
            Properties.Resources.asteroid,
            Properties.Resources.gauraNeagra,
            Properties.Resources.jupiter,
            Properties.Resources.luna,
            Properties.Resources.lunaEclipsa,
            Properties.Resources.mercur,
            Properties.Resources.neptun,
            Properties.Resources.ozn,
            Properties.Resources.pamant,
            Properties.Resources.planeta,
            Properties.Resources.pluto,
            Properties.Resources.racheta,
            Properties.Resources.saturn,
            Properties.Resources.soare,
            Properties.Resources.stea,
            Properties.Resources.uranus
        };

        public Game(List<Card> cards, Label scoreLabel)
        {
            this.scoreLabel = scoreLabel;
            this.cards = cards;
            score = 0;
            StartNewGame();
        }

        private Image[] ShuffleImages()
        {
            Image[] allimages = new Image[images.Length * 2];
            for(int i=0;i<images.Length;i++)
            {
                allimages[i*2] = images[i];
                allimages[i*2+1] = images[i];
            }

            Random random = new Random();
            for (int j = allimages.Length - 1; j > 0; j--)
            {
                int randomIndex = random.Next(j + 1);
                Image img = allimages[j];
                allimages[j] = allimages[randomIndex];
                allimages[randomIndex] = img;
            }

            return allimages;
        }

        private void InitializeCards()
        {
            Image[] shuffledImg = ShuffleImages();
            for (int i = 0; i < cards.Count; i++)
            {
                cards[i].IsFlipped(false);
                cards[i].SetImage(shuffledImg[i]);
            }
        }
        private Card FindID(List<Card> cards, string cardID)
        {
            for(int i=0;i< cards.Count;i++)
            {
                if (cards[i].GetCardID() == cardID)
                    return cards[i];
            }
            return null;
        }
        public void ClickCard(String cardID)
        {
            if (!clickEnabled)
            {
                return;
            }
            Card clickedCard = FindID(cards, cardID);
            if (clickedCard == null || discoveredCards.Contains(cardID))
            {
                return;
            }
            clickedCard.IsFlipped(false);

            if (selectedCards[0] == null)
            {
                selectedCards[0] = clickedCard;
            }
            else if (selectedCards[1] == null)
            {
                selectedCards[1] = clickedCard;
                if (selectedCards[0].GetCardID() == selectedCards[1].GetCardID())
                {
                    return; 
                }
                CompareCards(selectedCards[0], selectedCards[1]);
            }
        }
  
        private void CompareCards(Card card1, Card card2) {
          
            if (card1.Matches(card2))
            {
                UpdateScore();
                discoveredCards.Add(card1.GetCardID());
                discoveredCards.Add(card2.GetCardID());
                if (AllPairsFound())
                {
                    MessageBox.Show("Felicitări! Ai găsit toate perechile de cărți!");
                }
                selectedCards[0] = null;
                selectedCards[1] = null;
            }
            else
            {
                Task.Delay(600).ContinueWith(task =>
                {
                    card1.IsFlipped(true);
                    card2.IsFlipped(true);
                    selectedCards[0]=null;
                    selectedCards[1] = null;
                }).Wait();

            }
        }
    
        public void HideAllCards()
        {
            for(int i=0;i<cards.Count;i++)
            {
                cards[i].IsFlipped(true);
            }
        }
        public void UpdateScore()
        {
            if (scoreLabel != null)
            {
                scoreLabel.Text = score.ToString();
            }
            score = score + 10;
        }
       
        public void StartNewGame()
        {
            selectedCards = new Card[2];
            discoveredCards.Clear();
            InitializeCards();
            score = 0;
            UpdateScore();

        }

        public void SetClickEnabled(bool clickEnabled)
        {
            this.clickEnabled = clickEnabled;
        }

        public bool GetClickEnabled()
        {
            return clickEnabled;
        }
        public bool AllPairsFound()
        {
            return discoveredCards.Count == cards.Count;
        }
       /*/ public int GetScore()
        {
            return score;
        }/*/


    }
}


    


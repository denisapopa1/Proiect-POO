using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryGame
{
    internal class Card
    {
        private string CardID;
        private PictureBox pictureBox;
        private Image image;
        private bool Hidden;

        public Card(String cardID, PictureBox pictureBox)
        {
            this.CardID = cardID;
            this.pictureBox = pictureBox;
            IsFlipped(false);
        }

        public void SetImage(Image image)
        {
            this.image = image;
            if (Hidden == false)
            {
                pictureBox.Image = image;
            }

        }

        public void IsFlipped(bool Hidden)
        {
            if (Hidden)
            {
                pictureBox.Image = Properties.Resources.intrebare;
            }
            else
            {
                pictureBox.Image = image;
            }
        }
        public bool Matches(Card card)
        {
            if (image == card.image)
                return true;
            else
                return false;
        }

        public string GetCardID()
        {
            return CardID;
        }
    }
}

    

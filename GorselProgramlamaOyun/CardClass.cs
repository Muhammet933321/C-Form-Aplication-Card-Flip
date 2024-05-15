using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaOyun
{
    public class CardClass
    {
        public int ID;
        public PictureBox pictureBox;
        public Image pictureImage;
        public bool IsFinded = false;
        public void ShowCard()
        {
            if (pictureBox != null)
            {
                pictureBox.Image = pictureImage;
            }
        }

        public void UnvisibleCard()
        {
            if (!IsFinded && pictureBox != null)
            {
                pictureBox.Image = null;
            }
        }
        public void CardPicture(PictureBox newPictureBox)
        {
            this.pictureBox = newPictureBox;
            pictureImage = pictureBox.Image ;
            pictureBox.Image = null;
        }
        
    }
}

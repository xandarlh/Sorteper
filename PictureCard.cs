using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    public class PictureCard : ICard
    {                      
        private EPictures ePictures;
        public EPictures EPictures
        {
            get { return ePictures; }
            set { ePictures = value; }
        }
        private ESuits eSuits;
        public ESuits ESuits
        {
            get { return eSuits; }
            set { eSuits = value; }
        }
        public PictureCard(EPictures ePictures, ESuits eSuits)
        {
            this.EPictures = ePictures;
            this.ESuits = eSuits;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    public class GenerateCards
    {
        //This generates all cards EXCEPT jack of spades.
        public List<ICard> GenerateAllCards()
        {
            List<ICard> ls = new List<ICard>();

            ls.AddRange(GenerateNumberCards(ESuits.Hearts));
            ls.AddRange(GenerateNumberCards(ESuits.Diamonds));
            ls.AddRange(GenerateNumberCards(ESuits.Clubs));
            ls.AddRange(GenerateNumberCards(ESuits.Spades));

            ls.AddRange(GeneratePictureCards(EPictures.Jack));
            ls.AddRange(GeneratePictureCards(EPictures.Queen));
            ls.AddRange(GeneratePictureCards(EPictures.King));

            return ls;
        }

        private List<ICard> GenerateNumberCards(ESuits suits)
        {
            List<ICard> ls = new List<ICard>();

            for (int i = 1; i < 11; i++)
            {
                ICard card = new NumberCard(i, suits);
                ls.Add(card);
            }
            return ls;
        }
        //This generates all picture cards EXCEPT jack of spades.
        public virtual List<ICard> GeneratePictureCards(EPictures pictures)
        {
            List<ICard> ls = new List<ICard>();
          
            if (pictures == EPictures.Jack)
            {
                ls.Add(new PictureCard(pictures, ESuits.Hearts));
                ls.Add(new PictureCard(pictures, ESuits.Diamonds));
                ls.Add(new PictureCard(pictures, ESuits.Clubs));
            }
            else
            {
                ls.Add(new PictureCard(pictures, ESuits.Hearts));
                ls.Add(new PictureCard(pictures, ESuits.Diamonds));
                ls.Add(new PictureCard(pictures, ESuits.Clubs));
                ls.Add(new PictureCard(pictures, ESuits.Spades));
            }
                                    
            return ls;
        }
    }
}

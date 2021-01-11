using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    public class SortePerManager
    {
        private static Random random = new Random();
        public List<ICard> ShuffleCards(List<ICard> cards)
        {           
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                ICard value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
                return cards;
        }
        public List<ICard> GetCards()
        {
            GenerateCards generateCards = new GenerateCards();
            List<ICard> cards = generateCards.GenerateAllCards();
            ShuffleCards(cards);

            return cards;
        }
        public void DealCards(List<ICard> cards, Player[] players)
        {

        }
    }
}

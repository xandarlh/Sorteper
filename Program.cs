using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    class Program
    {
        static void Main(string[] args)
        {            
            SortePerManager sortePerManager = new SortePerManager();
            List<ICard> cards = sortePerManager.GetCards();

            foreach (ICard card in cards)
            {
                if (card.GetType().Name == "PictureCard")
                {
                    Console.WriteLine(((PictureCard)card).EPictures + " of " + card.ESuits);
                }
                else
                {                  
                        Console.WriteLine(((NumberCard)card).Number + " of " + card.ESuits);                  
                }
            }
                       
            Console.ReadLine();
        }
    }
}

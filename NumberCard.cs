using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortePer
{
    public class NumberCard : ICard
    {
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        private ESuits eSuits;
        public ESuits ESuits
        {
            get { return eSuits; }
            set { eSuits = value; }
        }
        public NumberCard(int number, ESuits eSuits)
        {
            this.Number = number;
            this.ESuits = eSuits;
        }
    }
}

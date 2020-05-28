using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class RollDice
    {
        private int sides;
        private int times;

        public RollDice(int sides, int times)
        {
            this.sides = sides;
            this.times = times;
        }

        public List<int> getValues
        {
            get
            {
                List<int> f = new List<int>();
                Random x = new Random();
                for (int i = 0; i < this.times; i++)
                {
                    f.Add(x.Next(1, this.sides));
                }
                return f;
            }
        }
    }
}

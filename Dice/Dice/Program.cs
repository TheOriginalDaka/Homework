using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());

            Console.Clear();
            dice.RollDice(size);

            Console.ReadLine();
        }
    }
}

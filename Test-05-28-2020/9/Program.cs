using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            History history = new History();

            string input = null;
            while (true)
            {
                input = Console.ReadLine();
                if(input.ToLower() == "history")
                {
                    Console.WriteLine(history.GetHistory);
                    break;
                }

                int times = int.Parse(input.Split('d')[0]);
                int sides = int.Parse(input.Split('d')[1]);

                var rollDice = new RollDice(sides, times);

                List<int> randomNumebers = new List<int>();
                randomNumebers = rollDice.getValues;

                int final = 0;
                foreach (var item in randomNumebers)
                {
                    final = final + item;
                }
                history.addToHistory(randomNumebers, final, input);
                Console.WriteLine("sum: " + final);
            }
            Console.ReadLine();
        }
    }
}

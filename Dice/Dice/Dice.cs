using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dice
{
    class Dice
    {
        Random random = new Random();
        public int RollDice(int size)
        {
            int randomNumber = random.Next(1, size + 1);
            Animate();
            Thread.Sleep(100);
            Display(randomNumber);
            Console.Title = randomNumber.ToString();
            return randomNumber;
        }

        public void Animate()
        {
            string result = null;
            int number = 0;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                result = null;
                number = random.Next(1,7);
                switch (number)
                {
                    case 1:
                        result += "███████\n";
                        result += "███*███\n";
                        result += "███████\n";
                        break;
                    case 2:
                        result += "█*█████\n";
                        result += "███████\n";
                        result += "█████*█\n";
                        break;
                    case 3:
                        result += "█*█████\n";
                        result += "███*███\n";
                        result += "█████*█\n";
                        break;
                    case 4:
                        result += "█*███*█\n";
                        result += "███████\n";
                        result += "█*███*█\n";
                        break;
                    case 5:
                        result += "█*███*█\n";
                        result += "███*███\n";
                        result += "█*███*█\n";
                        break;
                    case 6:
                        result += "█*███*█\n";
                        result += "█*███*█\n";
                        result += "█*███*█\n";
                        break;
                }
                Console.WriteLine(result);
                Thread.Sleep(500);
                Console.Clear();
            }
        }

        public void Display(int number)
        {
            string result = null;

            switch (number)
            {
                case 1:
                    result += "███████\n";
                    result += "███*███\n";
                    result += "███████\n";
                    break;
                case 2:
                    result += "█*█████\n";
                    result += "███████\n";
                    result += "█████*█\n";
                    break;
                case 3:
                    result += "█*█████\n";
                    result += "███*███\n";
                    result += "█████*█\n";
                    break;
                case 4:
                    result += "█*███*█\n";
                    result += "███████\n";
                    result += "█*███*█\n";
                    break;
                case 5:
                    result += "█*███*█\n";
                    result += "███*███\n";
                    result += "█*███*█\n";
                    break;
                case 6:
                    result += "█*███*█\n";
                    result += "█*███*█\n";
                    result += "█*███*█\n";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}

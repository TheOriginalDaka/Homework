using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string[] array = new string[x];
            for (int i = 0; i < x; i++)
            {
                array[i] = Console.ReadLine();
            }
            Array.Reverse(array);
            foreach (string item in array)
            {
                Console.Write(item + new string(' ', 2));
            }

            Console.ReadKey();
        }
    }
}

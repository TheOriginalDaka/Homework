using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[x];
            for (int i = 0; i < x; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(array);
            foreach (int item in array)
            {
                Console.Write(item + new string(' ', 2));
            }

            Console.ReadKey();
        }
    }
}

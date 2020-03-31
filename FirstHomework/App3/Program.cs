using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] third_array = new int[n];

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                array[i] = input;
            }

            int[] second_array = new int[n];
            array.CopyTo(second_array, 0);

            Array.Reverse(second_array);

            for (int i = 0; i < n; i++)
            {
                third_array[i] = array[i] + second_array[i];
                Console.WriteLine("{0} + {1} = {2}", array[i], second_array[i], third_array[i]);
            }

            foreach (int item in third_array)
            {
                Console.Write(item + new string(' ', 2));
            }

            Console.ReadKey();
        }
    }
}

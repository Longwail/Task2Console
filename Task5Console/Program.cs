using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 55, 44, 56, 79, 63, 90, 32, 21, 61, 89 };

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 11 != 0)
                    Console.WriteLine(numbers[i]+" ");
            }
            Console.WriteLine();
            int iterator = 0;
            while (iterator < numbers.Length)
            {
                if (numbers[iterator] % 11 != 0)
                    Console.WriteLine(numbers[iterator] + " ");
                iterator++;
            }
            Console.WriteLine();
            iterator = 0;
            do
            {
                if (numbers[iterator] % 11 != 0)
                    Console.WriteLine(numbers[iterator] + " ");
                iterator++;

            } while (iterator < numbers.Length);
        }
    }
}

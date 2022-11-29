using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int[] arr = { 1, 6, 2, 7, 3, 8, 4, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < count; j++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
                if (i % 2 == 1)
                    count++;
            }
            Console.ReadKey();
        }
    }
}

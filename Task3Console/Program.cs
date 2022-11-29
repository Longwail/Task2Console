using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.Write("x= ");
                float x = float.Parse(Console.ReadLine());
                Console.Write("y= ");
                float y = float.Parse(Console.ReadLine());
                if (x> -15 && y>-15 && y<0 && x<0)
                    Console.WriteLine("вне");
                else if (x < -15 || y < -15 || y >0 || x > 0)
                    Console.WriteLine("внутри");
                else Console.WriteLine("на границе");

        }
    }
}

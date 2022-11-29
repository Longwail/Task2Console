using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            Random r = new Random();
            string[] maleNames = { "Василий", "Виктор", "Александр", "Анатолий" };
            string[] femaleNames = { "Анжелика", "Анна", "Виктория", "Светлана" };
            while (true)
            {
                try
                {
                    str = Console.ReadLine();

                    if (str.Length != 1) throw new Exception("Ожидается символ м или ж");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            switch (str)
            {
                case "м":
                    string male = maleNames[r.Next(0,maleNames.Length-1)];
                    Console.WriteLine(male);
                    break;
                case "ж":
                    string female = femaleNames[r.Next(0, femaleNames.Length - 1)];
                    Console.WriteLine(female);
                    break;
                default: Console.WriteLine("Нужно ввести м или ж");
                    break;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechPrakt2024Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Title = "Технологічна практика Git. Завдання 1.5";

            int first = inputInt("перше");
            int second = inputInt("друге");


            Console.WriteLine($"\n{first} + {second} = {first + second}");

            Console.ReadKey();
        }

        private static int inputInt(string number)
        {
            Console.WriteLine($"Вкажіть {number} число та натисніть Enter");

            string value = Console.ReadLine();

            try
            {
                return int.Parse(value);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nПомилка вводу!!! Будь ласка, повторіть спробу!!!");
                return inputInt(number);
            }
        }
    }
}

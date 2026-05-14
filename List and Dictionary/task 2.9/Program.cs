//Розробіть ігровий симулятор шкільного класу, де гравець зіграє вчителя та буде оцінювати віртуальних учнів.

using System;
namespace Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>()
            {
                {"Gus" , 12 },
                {"Emy" , 9 },
                {"Maya" , 8 },
                {"Max" , 5 },
            };

            foreach (KeyValuePair<string, int> item in students)
            {
                Console.WriteLine($"The student {item.Key} got {item.Value} mark.");
            }
            
            Console.ReadKey();
        }
    }
}
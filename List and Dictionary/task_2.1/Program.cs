using System;

namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> countries = new Dictionary<string, string>()
        {
            {"USA", "Washington"},
            {"UK", "London"},
            {"France", "Paris"},
            {"Italy", "Rome"},
            {"Spain", "Madrid"},
            {"Czech Republic", "Prague"},
            {"Germany", "Berlin"},
            {"Japan", "Tokyo"},
            {"South Korea", "Seoul"},
        };
        
        while (countries.Count > 0)
        {
            Console.WriteLine("Enter the country you wanna start with:");
            Console.WriteLine("(USA, UK, France, Italy, Spain, Czech Republic, Germany, Japan, South Korea)");

            string input = Console.ReadLine();

            if (countries.ContainsKey(input))
            {
                Console.WriteLine($"Enter the capital city of {input}:");
                string input2 = Console.ReadLine();

                if (input2 == countries[input])
                {
                    Console.WriteLine("Correct!");
                    countries.Remove(input);
                }
                else
                {
                    Console.WriteLine($"Wrong! The capital is {countries[input]}.");
                }
            }
            else
            {
                Console.WriteLine("The country you entered is not valid!");
            }
        }

        Console.WriteLine("You guessed all countries!");
        Console.ReadKey();
    }
}
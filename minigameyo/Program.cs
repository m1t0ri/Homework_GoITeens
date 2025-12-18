using System;
using System.Numerics;
using System.Security.Cryptography;

namespace minigameyo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 101);
            int c;
            int counter;
            counter = 0;
            
            
            do
            {
                Console.WriteLine("Enter a number from 1 to 100");

                c = int.Parse(Console.ReadLine());
                Console.Clear();
                
                if (c > number)
                {
                    Console.WriteLine("You entered too big number " +
                                      "\nTry again");
                }
                if (c < number)
                {
                    Console.WriteLine("You entered too little number" +
                                      "\nTry again");
                }
                if (c == number)
                {
                  Console.WriteLine($"You entered correct number" +
                                    "\nGG" +
                                    $"\n Tries:{counter}");   
                }
                
            } while (c != number);

            Console.ReadKey();
        }
    }
}



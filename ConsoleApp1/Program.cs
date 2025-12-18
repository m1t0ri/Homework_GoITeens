// See https://aka.ms/new-console-template for more information


using System;
namespace GameDev
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;
        
            int difference = x - y;
        
            Console.WriteLine($"I had {x} apples, I ate {y}, now I have {difference} apples");
        
            int a = 3;
            int b = 4;
        
            int multiply = 4 * 3;
        
            Console.WriteLine($"You have {b} boxes, each containing {a} pencils, \n" +
                              $"in total you have {multiply} pencils");

            int z = 10;
            int v = 2;
        
            int depliy = z / v; 
        
            Console.WriteLine($"He has {z} cookies, after he divide them equally between himself and his gf," +
                              $"\n each have {depliy} cookies");
        }
    }
}


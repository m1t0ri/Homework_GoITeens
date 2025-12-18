using System;

using System.Collections.Generic;

namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        int x;
        Console.WriteLine("Write a time:");

        x = Convert.ToInt32(Console.ReadLine());

        if (x >= 6 && x <= 11)
        {
            Console.WriteLine("Good Morning!");
        }
        else if (x >= 12 && x <= 17)
        {
            Console.WriteLine("Good Afternoon!");
        }
        else if (x >= 18 && x <= 23)
        {
            Console.WriteLine("Good Evening!");
        }
        else if (x >= 0 && x < 6)
        {
            Console.WriteLine("Good Night!");
        }
        else
        {
            Console.WriteLine("Bad Night!");
        }
        Console.ReadLine();
    }
}
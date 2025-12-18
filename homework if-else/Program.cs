using System;

using System.Collections.Generic;

namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        int x;
        
        Console.WriteLine("Write a time");
        
        x = Convert.ToInt32(Console.ReadLine());

        if (x == 0)
        {
            Console.WriteLine("It`s still night"); 
        }
        
    }
}
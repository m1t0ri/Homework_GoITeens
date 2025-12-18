using System;

namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        int x;
        
        bool success = int.TryParse(Console.ReadLine(), out x);
        
        Console.WriteLine(success);
        
        Console.ReadLine();
    }
}
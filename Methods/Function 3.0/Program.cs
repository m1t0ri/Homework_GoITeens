using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        int enemy1 = 890;
        int enemy2 = 739;

        int best = whoIsStronger(enemy1, enemy2);
        Console.WriteLine(best);
        Console.ReadKey();

    }

    static int whoIsStronger(int x, int y)
    {
        bool s = x > y;
        if (s == true)
        {
            Console.WriteLine($"{x} is stronger");
            return x;
        }
        if(s == false)
        {
            Console.WriteLine($"{y} is stronger");
            return y;
        }
        return x;
    }
}
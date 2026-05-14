using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {

        List<int> big = new List<int>()
        {
            2,
            4,
            8,
            16,
            32,
            64,
            128,
        };
        for(int x = 0; x < big.Count; x++)
        {
            Console.WriteLine($"The world is {big[x]} km big ");
        }

        Console.ReadKey();
    }  
}
//Збір скарбів: Гравець повинен зібрати скарби, розташовані на рядку. Кожен скарб — це номер клітинки. Створіть і виведіть список цих скарбів.
using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        List<string> treasures = new List<string>()
        {
            "Treasure",
            "Diamond",
            "Amethyst",
            "Emerald",
            "Gold",
            "Treasure"
        };

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        
        Console.WriteLine("Take all treasures " +
                          "\nTo take a treasure, write the number of it" +
                          "\nTreasures:" +
                          "\n");
        for (int s = 0; s < numbers.Count; s++)
        {
            Console.WriteLine($"{treasures[s]} on the {numbers[s]} cell ");
        }
        int c = int.Parse(Console.ReadLine());
        int num = c - 1;
        
        Console.WriteLine($"You entered {c} cell and you took {treasures[num]}");
        
        Console.ReadKey();
        
    }  
}
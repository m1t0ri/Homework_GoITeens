//Будівництво міст: Гравець будує своє власне королівство та міста на території. Кількість міст визначається числами, які представляють ступені двійки. Створіть список кількості міст для кожного рівня.
using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        List<string> cities = new List<string>()
        {
            "London",
            "Paris",
            "New York",
            "San Francisco",
            "Austin",
            "San Antonio"
        };
        List<int> levels = new List<int>() { 1, 3, 5, 7, 9, 12};

        for (int z = 0; z < levels.Count; z++)
        {
            Console.WriteLine($"City:{cities[z]} stays on level {levels[z]}");
        }

        Console.ReadKey();
    }  
}
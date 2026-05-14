using System;
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        List<int> levels = new List<int>() {1, 10, 20, 30, 40, 50, 60, 70, 80, 90};

        List<string> names = new List<string>()
        {
            "Swamp",
            "Little House",
            "Dorm",
            "Village",
            "City",
            "Capital",
            "Region",
            "Nation",
            "Country",
            "Continent"
        };

        for(int c =  0; c < levels.Count; c++)
        {
            Console.WriteLine($"The {names} level opens at {levels} level.");
        }
        
        Console.ReadKey();

    }  
}
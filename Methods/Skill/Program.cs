//Перевірка "чи вистачить манни": Функція приймає кількість манни і вартість закляття, повертає true або false.

using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        int playerEnergy;
        
        Dictionary<int, string> dic = new Dictionary<int, string>()
        {
            { 10, "Fire" },
            { 40, "Ice Rain" },
            { 5, "Snowball" },
            { 70, "Thunder" }
        };
        
        foreach (KeyValuePair<int, string> item in dic)
        {
            Console.WriteLine($"Skill:{item.Key} - {item.Value}");
        }
        
        Console.WriteLine("Which skill would you like to use?(write only first number)");
        int energy = int.Parse(Console.ReadLine());

        Console.Write($"Your choice:{dic[energy]}\n");
        
        Console.WriteLine("Now write how many energy do you have");
        playerEnergy = int.Parse(Console.ReadLine());

        bool answer;
        
        answer = Calc(playerEnergy, energy);
        
        if (answer == true)
        {
            Console.WriteLine("You can use this item");
        }
        else
        {
            Console.WriteLine("You can't use this item again");
        }

        Console.ReadKey();
        
    }

    static bool Calc(int energy, int number)
    { 
        bool answer = energy >= number;
        return answer;
    }
    
    
}
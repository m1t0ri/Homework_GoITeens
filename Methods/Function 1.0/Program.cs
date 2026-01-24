using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        string namePlayer;
        namePlayer = Console.ReadLine();
        Function(namePlayer);

        Console.Clear();
        Console.WriteLine("Be careful! There is the first enemy!");
        
        Function();

        Console.ReadKey();
    }
    static string Function(string a)
    {
        
        Console.WriteLine($"Welcome in game, {a}!");
        return a;
    }

    static int Function()
    {
        int rnd = new Random().Next(0, 100);
        int player = 100;
        int damage = player - rnd;
        
        Console.WriteLine($" Your hp now is {damage}!");
        return damage;
    }
    
    
}
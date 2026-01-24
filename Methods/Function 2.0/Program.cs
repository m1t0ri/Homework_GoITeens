using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        
        
        int player1 = 3;
        int player2 = 6;
        int player3 = 10;

        int middleLevel1 = middleLevel(player1, player2, player3);
        
        Console.WriteLine($"Level of a first player: {player1}");
        Console.WriteLine($"Level of a second player: {player2}");
        Console.WriteLine($"Level of a third player: {player3}");
        
        Console.Write($"The middle Level of a team is {middleLevel1}");
        
        Console.ReadKey();
        
    }

    static int middleLevel(int a, int b, int c)
    {
        
        return (a + b + c) / 3;
    }
}
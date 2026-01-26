using System.Globalization;
using System.Text;

namespace _HomeWorksCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player1 = 3;
            int player2 = 6;
            int player3 = 10;

            Dictionary<string, int> players = new Dictionary<string, int>()
            {
                { "Player1", 3 },
                { "Player2", 6 },
                { "Player3", 10 }
            };

            int middleLevel1 = MiddleLevel(player1, player2, player3);
        
            Console.WriteLine($"Level of a first player: {player1}");
            Console.WriteLine($"Level of a second player: {player2}");
            Console.WriteLine($"Level of a third player: {player3}");
        
            Console.WriteLine($"The middle Level of a team is {middleLevel1}");
            
            int middleLevelDict =  MiddleLevel(players);
            
            int middleLevelDict1 =  MiddleLevel(players["Player1"], players["Player2"], players["Player3"]);
            
            Console.WriteLine("--------------");
            Console.WriteLine($"The middle Level of a team is {middleLevelDict}");
            Console.WriteLine("--------------");
            Console.WriteLine($"The middle Level of a team is {middleLevelDict1}");
        
            Console.ReadKey();
        
        }

        static int MiddleLevel(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
        
        static int MiddleLevel(Dictionary<string, int> players)
        {
            int middleLevel = 0;
            
            foreach (var player in players)
            {
                middleLevel += player.Value;
            }
            return middleLevel / players.Count;
        }
    }
}
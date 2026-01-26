using System.Globalization;
using System.Text;

namespace _HomeWorksCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                { "Enemy1", 890 },
                { "Enemy2", 900 }
            };
            int enemy1 = 890;
            int enemy2 = 900;

            int best = WhoIsStronger(enemy1, enemy2);
            int best1 = WhoIsStronger(dict["Enemy1"], dict["Enemy2"] );
            
            PrintStrogestEnemy(best);
            PrintStrogestEnemy(best1);
            
            
            //Console.WriteLine(best);
            Console.ReadKey();

        }

        static int WhoIsStronger(int x, int y)
        {
            if(x == y) return 0;
            return x > y ? x : y;
        }

        private static void PrintStrogestEnemy(int value)
        {
            Console.WriteLine(value == 0 ? "equals" : $"{value} is stronger");
        }
    }
}
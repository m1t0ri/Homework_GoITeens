using System.Globalization;
using System.Text;

namespace _HomeWorksCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rnd =  new Random().Next(1, 100);
            string namePlayer;
            namePlayer = Console.ReadLine();
            int damage = rnd;
            int health = 100;
            
            //int rnd = new Random().Next(0, 100);
            
            PrintName(namePlayer);

            Console.Clear();
            Console.WriteLine("Be careful! There is the first enemy!");

            CalcDamage(ref health, damage);
            //CalcDamage(damage, health);
            
            Console.WriteLine($" Your hp now is {health}!"); // 70
            
            CalcDamage(health, damage);
            
            Console.WriteLine($" Your hp now is {health}!"); // 70

            Console.ReadKey();
        }

        static void PrintName(string a)
        {
            Console.WriteLine($"Welcome in game, {a}!");
        }

        static void CalcDamage(ref int health, int damage)
        {
            health -= damage;
        }
        
        static void CalcDamage(int health, int damage)
        {
            health -= damage;
            Console.WriteLine($" Your hp now is {health}!"); // 40
        }
    }
}
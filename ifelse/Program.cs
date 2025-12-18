using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int damage = rnd.Next(1, 101);

        if (damage > 0 && <=33)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"EWnemy take middle damage: {damage}");
        }
        else if (damage >= 33 damage <= 70)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ewnemy take heavy damage: {damage}");
        }
        else if (damage >= 70 && damage <= 100) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ewnemy take Critical damage: {damage}");
        }
    }
}

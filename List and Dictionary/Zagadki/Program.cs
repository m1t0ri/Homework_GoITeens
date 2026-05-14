using System;

class Program
{
    static void Main()
    {
        Dictionary<string, string> riddles = new Dictionary<string, string>()
        {
            {"I am tall when I am young, and I am short when I am old. What am I?", "Candle"},
            {"What has a neck but no head, a body but no legs?", "Bottle"},
            {"What breaks as soon as you say its name?", "Silence"},
        };

        foreach (var riddle in riddles)
        {
            while (true)
            {
                Console.WriteLine($"Riddle {riddle.Key}");
                Console.Write($"Your answer: ");

                string input = Console.ReadLine();

                if (input == riddle.Value)
                {
                    Console.WriteLine($"Good job!");
                    break;
                }

                else
                {
                    Console.WriteLine($"Wrong, try again.");
                }
            }
        }

        Console.WriteLine("Congratulations! You guessed them all!");
        Console.ReadKey();
    }
}
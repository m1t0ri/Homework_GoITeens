using System;  
  
namespace MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        string question = null;
        do
        {
            Console.WriteLine("Write your question, and magic amethyst will answer(or write 143 to exit):");
            question = Console.ReadLine();

            if (question == "143")
            {
                break;
            }

            string answer = Answer();
            
            Color(answer);
            
            Console.WriteLine("The answer is: " + answer);
            
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;


        } while (true);



    }

    static string Answer()
    {
        string[] answers = GetAnswers();
        string answer = answers[new Random().Next(0, answers.Length)];
        return answer;
    }

    static string[] GetAnswers()
    {
        return new[]
        {
            "Yes",
            "No",
            "Maybe"
        };
    }

    static ConsoleColor Color(string answer)
    {
        switch (answer)
        {
            case "Yes":
                return Console.ForegroundColor = ConsoleColor.Green;
            case "No":
                return Console.ForegroundColor = ConsoleColor.Red;
            case "Maybe":
                return Console.ForegroundColor = ConsoleColor.Yellow;
            default:
                return Console.ForegroundColor = ConsoleColor.White;
        }
            
    }
}
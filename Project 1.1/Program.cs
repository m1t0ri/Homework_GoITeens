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
            Console.WriteLine("The answer is: " + answer);

            Console.ReadKey();

            Console.Clear();


        } while (true);



    }

    static string Answer()
    {
        string[] answers = GetAnswers();
        string answer = answers[new Random().Next(1, answers.Length)];
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
}
/*Напишіть програму, яка створює інтерактивний текстовий квест із загадками для гравця
Кожна загадка містить у собі ключове слово, яке гравець повинен вгадати. Коли гравець вгадує ключове слово, програма повинна переходити до наступної загадки.*/
using System;  
  
namespace MyNamespace;  
  
class Program  
{  
    static void Main(string[] args)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            { "Sky", "What is blue and above us?" },
            { "Red", "Which color is blood?" },
            { "Green", "Which color is grass?" },
            { "White", "Which color is sun?" },
        };

        string word;
        
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Value}");
            word = Console.ReadLine();
            
            if (word == item.Key)
            {
                Console.WriteLine($"{item.Value} - {item.Key}" +
                                  $"\n Right!");
            }

            if (word != item.Key)
            {
                Console.WriteLine($"Try again " +
                                  $"\n Right answer was:{item.Key}");
                continue;
            }
            Console.ReadKey();
        }
        
    }  
}
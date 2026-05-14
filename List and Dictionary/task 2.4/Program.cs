/*Напишіть програму, яка створює інтерактивний текстовий квест із загадками для гравця. Кожна загадка
містить у собі ключове слово, яке гравець повинен вгадати. Коли гравець вгадує ключове слово, програма повинна переходити до наступної загадки.*/

using System;  
  
namespace MyNamespace;  
  
class Program  
{  
    static void Main(string[] args)
    {
        Dictionary<string, string> questsAndWords = new Dictionary<string, string>()
        {
            {"Which Color is sky", "Blue" },
            {"Which Color is sun", "Yellow" },
            {"Which Color is grass", "Green" },
            {"Which color is snow", "White" },
        };
        
        foreach (var item in questsAndWords)
            {
            Console.WriteLine(item);
            }
        
        Console.ReadKey();
    }  
}
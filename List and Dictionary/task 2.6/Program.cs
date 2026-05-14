//Оцінки студентів у шкільній грі: Розробіть ігровий симулятор шкільного класу, де гравцеві потрібно буде виступати в ролі вчителя та встановлювати оцінки учням.

using System;  
  
namespace MyNamespace;  
  
class Program  
{  
    static void Main(string[] args)
    {
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Sahur", 12 },
            { "Hector", 9 },
            { "Tralalelo", 9 },
            { "Chigur", 4 },
            { "Arima", 8 },
            { "Kira", 11 },
            { "Jotaro", 12 },
        };

        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }
        
        Console.ReadKey();
    }  
}
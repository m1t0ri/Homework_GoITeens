/*Подорож у часі: Гравець подорожує у минуле, відвідуючи різні епохи.
    Кожен наступний рік у минулому знаходиться вдвічі далі за попередній.
    Створіть список років, які відвідав гравець.*/
using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        List<int> years = new List<int>()
        {
            2026,
            1013,
            506,
            253
        };

        foreach (var year in years)
        {
            Console.WriteLine(year);
        }
        
        Console.ReadKey();
        
        
    }  
}    
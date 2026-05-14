/*Героїчний похід: Гравець вирушає у героїчний похід через ліс, збираючи на своєму шляху магічні артефакти.
    Кожен наступний артефакт розташований на відстані, яка дорівнює сумі вже зібраних артефактів.
    Створіть список відстаней до кожного артефакту.*/
    
using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        List<int> artefacts = new List<int>()
        {
            1,
            1,
            2,
            3,
            5,
            8,
            13,

        };
        
        foreach (var item in artefacts)
            {
            Console.WriteLine(item);
            }
        
        Console.ReadKey();
    }  
}
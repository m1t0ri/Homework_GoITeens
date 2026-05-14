using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        /*Магічні кристали: Гравець збирає магічні кристали, розташовані
        у лісі на деревах. Кількість кристалів на кожному дереві визначається числами, що представляють степені чотирьох. 
            Створіть список кількості кристалів на кожному дереві. */

        List<int> stepeni_four = new List<int>()
        {
            4,
            16,
            64,
            256,
            1024,
            4096,
        };
        Console.WriteLine("Кiлькiсть Кристалiв на перших 6 деревах:");

        foreach (var item in stepeni_four)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();
        
    }  
}
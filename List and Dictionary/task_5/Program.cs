//Скарби на островах: Гравець шукає легендарні скрині зі скарбами, розташовані на островах. Кількість скарбів на кожному острові визначається числами Фібоначчі. Створіть список кількості скарбів на кожному острові.
using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        List<int> fibanachi = new List<int>()
        {
            1,
            1,
            2,
            3,
            5,
            8,
            13
        };
        
        Console.WriteLine("Treasures on the islands:");

        foreach (int item in fibanachi)
        {
            Console.WriteLine(item);
        }
        
        Console.ReadKey();
    }  
}
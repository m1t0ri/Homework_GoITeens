//Подорож на планети: Гравець здійснює подорож на планети галактики. Кожна наступна планета вдвічі віддаленіша за попередню. Створіть список відстаней до кожної планети.
using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {

        List<int> big = new List<int>()
        {
            2,
            4,
            8,
            16,
            32,
            64,
            128,
        };
        for(int x = 0; x < big.Count; x++)
        {
            Console.WriteLine($"The planet is in {big[x]} kilometers from us");
        }

        Console.ReadKey();
    }  
}
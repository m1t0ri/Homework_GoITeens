//Крамниця зі списком продуктів: Реалізуйте гру, де гравець виступає в ролі власника крамниці. Використовуйте словник для зберігання товарів, які можна придбати, та їх ціни.
using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        Dictionary<int, string> itemsInShop = new Dictionary<int, string>()
        {
            {10, "Bread"},
            {22, "Chicken"},
            {20, "Pasta"},
            {40, "Pizza"},
            {8, "Cheese"},
            {30, "Cake"}
        };

        foreach (KeyValuePair<int, string> item in itemsInShop)
        {
            Console.WriteLine($"The {item.Value} - costs {item.Key}");
        }
        
        Console.ReadKey();
        
        
    }  
}
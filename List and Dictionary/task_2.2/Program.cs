using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        /*Телефонний довідник у грі: Реалізуйте інтерфейс телефонного довідника у формі гри,
            де гравець може зберігати та використовувати контакти для спілкування з NPC (не гравців персонажів).*/
        Dictionary<int, string> numbers = new Dictionary<int, string>()
        {
            { 12898, "Mikel" },
            { 01823, "Jason" },
            { 68279, "Jessie" },
        };
    }  
}
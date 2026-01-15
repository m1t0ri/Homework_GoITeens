/*string.Concat(str1, str2): Об'єднання двох рядків.
string.Length: Повертає довжину рядка.
string.Substring(startIndex, length): Повертає підрядок починаючи з вказаного індексу.
string.Replace(oldValue, newValue): Замінює всі входження підрядка oldValue на newValue.
string.Split(delimiter): Розбиває рядок на масив підрядків, розділені delimiter.
string.Trim(): Видаляє пробільні символи на початку та в кінці рядка.
string.ToLower(), string.ToUpper(): Змінює регістр всіх символів рядка.
string.Contains(substring): Перевіряє, чи містить рядок певний підрядок.
string.IndexOf(substring): Повертає індекс першого входження підрядка, якщо він існує, або -1.*/

using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        string input;
        
        char[] aeu = {'a', 'e', 'i', 'o', 'u'};
        
        {
            input = Console.ReadLine();
            Console.WriteLine("Try Again!");
        }
        Console.ReadKey();

    }  
}

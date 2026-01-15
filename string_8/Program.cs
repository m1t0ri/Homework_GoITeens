using System;
using System.ComponentModel.Design;

namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        string input = "";

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        
        
        
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input a word");
            input = Console.ReadLine();
        }
        
        string textToLower = input.ToLower();
        string result = "";

        foreach (var c in textToLower)
        {
            if (vowels.Contains(c))
            {
                result += c;
            }
        }
        Console.WriteLine("All vowels leters:");
        Console.WriteLine(result);
        
        Console.WriteLine("Your word was:");
        Console.WriteLine(input);
        
        
        Console.ReadKey();

    }  
}
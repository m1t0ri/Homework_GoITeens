using System;

class Program2
{
    static void Main(string[] args)
    {
        string color;
        color =Console.ReadLine();

        string love;

        switch (color)
        {
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red");
                Console.WriteLine("Its a dragon");
                break;
            
            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
                Console.WriteLine("Its a Fairy");
                break;
            
            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                Console.WriteLine("Its a Woodman");
                break;
            case "yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow");
                Console.WriteLine("Its a King");
                break;
            
            default:
                Console.WriteLine("Try again");
                break; 
        }

        love = Console.ReadLine();
        
        switch (love)
        {
         case "Tania":
             Console.WriteLine("I love only Tania");
             break;
         
         case "Noone Else":
             Console.WriteLine("Yes, Because i love only her");
             break;
         default :
             Console.WriteLine("Try again");
             break;
        }

       
        
        Console.ReadKey();
    }
}


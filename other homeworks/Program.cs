using System;

namespace MyNamespace;


class Program;

static class MyClass
{
    static void Main(string[] args)
    {
        int x = 70;
        int y = 2;

        string c = "<Martin>";

        Console.CursorVisible = false;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(x, y);
        Console.Write(c);
       

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow)
            {
                y++;
            }
            else if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow)
            {
                y--;
            }
            else if (keyInfo.Key == ConsoleKey.A || keyInfo.Key == ConsoleKey.LeftArrow)
            {
                x--;
            }
            else if (keyInfo.Key == ConsoleKey.D || keyInfo.Key == ConsoleKey.RightArrow)
            {
                x++;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            
            




        }

        Console.ReadKey();
    }
}
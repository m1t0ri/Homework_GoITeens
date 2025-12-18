using System;

class Program
{
    static void Main(string[] args)
    {
        string[] colors = new[]
        {
            "Red",
            "Green",
            "Blue",
            "Yellow"
        };
        
        string[] characters = new[]
        {
            "Dragon",
            "Woodman",
            "King",
            "Fairy"
        };

        string color = string.Empty;
        string formatedColor = string.Empty;
        string Character = string.Empty;
        string CharacterNew = string.Empty;

        do
        {
            Console.WriteLine("Enter color: Red, Green, Blue or Yellow");
            color = Console.ReadLine()?.Trim();

            for (int i = 0; i < color.Length; i++)
            {
                if (i == 0)
                {
                    formatedColor += char.ToUpper(color[i]);
                }
                else
                {
                    formatedColor += char.ToLower(color[i]);
                }
            }

            string logMessage
                = colors.Contains(formatedColor) ? "Color already exists" : "Color not exists, try again";
            Console.WriteLine(logMessage);

            /*if (colors.Contains(formatedColor))
            {
                Console.WriteLine("Color already exists");
            }
            else
            {
                Console.WriteLine("Color not exists, try again");
            }*/

            /*if (colors.Contains(formatedColor))
                Console.WriteLine("Color already exists");
            else
                Console.WriteLine("Color not exists, try again");*/


        } while (!colors.Contains(formatedColor));


        switch (formatedColor)
        {
            case "Red":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Red-Its a Dragon");
                break;
            case "Blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue-Its a Fairy");
                break;
            case "Green":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Green-Its a Woodman");
                break;
            case "Yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Yellow-Its a King");
                break;
            default:
                Console.WriteLine("In our Land there`s no one with this kind of colour :(");
                break;
        }

        do
        {


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Now Write Any Character: Dragon, Woodman, King, Fairy");

            Character = Console.ReadLine();

            for (int s = 0; s < Character.Length; s++)
            {
                if (s == 0)
                {
                    CharacterNew += char.ToUpper(Character[s]);
                }
                else
                {
                    CharacterNew += char.ToLower(Character[s]);
                }
            }

            switch (CharacterNew)
            {
                case "Dragon":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dragon is Red");
                    break;
                case "Woodman":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Woodman is Green");
                    break;
                case "King":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("King is Yellow");
                    break;
                case "Fairy":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Fairy is Blue");
                    break;
                default:
                    Console.WriteLine("Try again!");
                    break;

            }
        } while (!characters.Contains(CharacterNew));

    Console.ReadKey();
    }
}
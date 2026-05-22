

namespace Homework_16_17;

class Program
{
    static void Main(string[] args)
    {
        //Збір скарбів: Гравець повинен зібрати скарби, розташовані на рядку. Кожен скарб — це номер клітинки. Створіть і виведіть список цих скарбів.
        List<string> treasures = new List<string>()
        {
            "Treasure",
            "Diamond",
            "Amethyst",
            "Emerald",
            "Gold",
            "Treasure"
        };

        for (int i = 0; i < treasures.Count; i++)
        {
            Console.WriteLine($"{i}. {treasures[i]}");

        }

        Console.WriteLine("2 Task-------------------------------------------------------------------------");

        /*Будівництво міст: Гравець будує своє власне королівство та міста на території.
            Кількість міст визначається числами, які представляють ступені двійки. Створіть список кількості міст для кожного рівня.*/

        List<double> citysNumbers = new List<double>(10);

        for (double i = 0; i < citysNumbers.Capacity; i++)
        {
            citysNumbers.Add(Math.Pow(2, i));
        }

        foreach (double number in citysNumbers)
        {
            Console.WriteLine($"{number}");
        }


        
        Console.WriteLine("3 Task-------------------------------------------------------------------------");


        List<int> portals = new List<int>(10);

        for (int i = 0; i < portals.Capacity; i++)
        {
            if (i == 0)
            {
                portals.Add(1);
            }
            else
            {
                portals.Add(portals[i - 1] * 2);
            }

        }

        foreach (int number in portals)
        {
            Console.WriteLine($"{number}");
        }


        Console.WriteLine("4 Task-------------------------------------------------------------------------");

        List<int> distant = new List<int>()
        {
            2
        };

        for (int i = 0; i < 5; i++)
        {
            distant.Add(distant[i] * 2);
        }

        foreach (var item in distant)
        {
            Console.WriteLine($"The next planet is in {item} km");
        }


        Console.WriteLine("5 Task-------------------------------------------------------------------------");

        List<int> fibanachi = new List<int>()
        {
            0,
            1
        };

        for (int i = 1; i < 10; i++)
        {
            int number = fibanachi[i - 1] + fibanachi[i];
            fibanachi.Add(number);
            Console.WriteLine($"{number}");

        }


        Console.WriteLine("6 Task-------------------------------------------------------------------------");

        List<int> cityStages = new List<int>()
        {
            7,
            15
        };

        for (int i = 1; i < 10; i++)
        {
            int number = cityStages[i - 1] + cityStages[i];
            cityStages.Add(number);
            Console.WriteLine($"{number}");
        }

        Console.WriteLine("7 Task-------------------------------------------------------------------------");
        /*Будівництво космічних станцій: Гравець будує космічні станції на орбіті навколо планети.
            Кількість станцій на кожній орбіті визначається числами, що представляють ступені трійки. Створіть список кількості станцій для кожної орбіти.#1#*/

        List<double> cosmicStation = new List<double>(10);

        for (double i = 0; i < cosmicStation.Capacity; i++)
        {
            cosmicStation.Add(Math.Pow(3, i));
        }

        foreach (double number in cosmicStation)
        {
            Console.WriteLine($"{number}");
        }

        Console.WriteLine("8 Task-------------------------------------------------------------------------");
        /*Магічні кристали: Гравець збирає магічні кристали, розташовані у лісі на деревах.
            Кількість кристалів на кожному дереві визначається числами, що представляють степені чотирьох. Створіть список кількості кристалів на кожному дереві.#1#*/

        List<double> magicCrystals = new List<double>(10);

        for (double i = 0; i < magicCrystals.Capacity; i++)
        {
            magicCrystals.Add(Math.Pow(4, i));
        }

        foreach (double number in magicCrystals)
        {
            Console.WriteLine($"{number}");
        }

        Console.WriteLine("9 Task-------------------------------------------------------------------------");
        /*Подорож у часі: Гравець подорожує у минуле, відвідуючи різні епохи.
            Кожен наступний рік у минулому знаходиться вдвічі далі за попередній. Створіть список років, які відвідав гравець.#1#*/

        List<int> timeLine = new List<int>()
        {
            2026,
            1984
        };

        for (int i = 1; i < 10; i++)
        {
            int dif = (timeLine[i - 1] - timeLine[i]) * 2;
            int difYears = timeLine[i] - dif;

            timeLine.Add(difYears);
        }

        foreach (var item in timeLine)
        {
            Console.WriteLine($"The next year is{item}");
        }

        Console.WriteLine("10 Task-------------------------------------------------------------------------");

        /*Героїчний похід: Гравець вирушає у героїчний похід через ліс, збираючи на своєму шляху магічні артефакти.
            Кожен наступний артефакт розташований на відстані, яка дорівнює сумі вже зібраних артефактів. Створіть список відстаней до кожного артефакту.#1#*/

        List<int> magicArtefacts = new List<int>()
        {
            10,
            12,
        };

        int sum = magicArtefacts[0];

        for (int i = 1; i < 10; i++)
        {
            sum += magicArtefacts[i];
            magicArtefacts.Add(sum);
        }

        foreach (var item in magicArtefacts)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine("2.1 Task-------------------------------------------------------------------------");

        

        Dictionary<string, string> countries = new Dictionary<string, string>()
        {
            { "USA", "Washington" },
            { "UK", "London" },
            { "France", "Paris" },
            { "Italy", "Rome" },
            { "Spain", "Madrid" },
            { "Czech Republic", "Prague" },
            { "Germany", "Berlin" },
            { "Japan", "Tokyo" },
            { "South Korea", "Seoul" },
        };

        foreach (var item in countries)
        {
            string input = String.Empty;

            do
            {
                Console.WriteLine($"Enter capital of {item.Key}:");
                input = Console.ReadLine();

                if (input == item.Value)
                {
                    Console.WriteLine($"Capital of {item.Key} is {item.Value}");
                    break;
                }
                else
                {
                    Console.WriteLine($"{input} is not a capital of {item.Key}.");
                }
            } while (input != item.Value);



        }



        Console.WriteLine("2.2 Task-------------------------------------------------------------------------");
        Dictionary<string, int> people = new Dictionary<string, int>()
        {
            { "Mikael", 12982 },
            { "Jason", 01823 },
            { "Jessie", 68279 }
        };
        Dictionary<int, string> options = new Dictionary<int, string>()
        {
            { 1, "Call" },
            { 2, "Add Contact" },
            { 3, "Delete Contact" }
        };

        Console.WriteLine("Enter an option:");
        foreach (var item in options)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (var item in people)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        string inputNumber = Console.ReadLine();
        int inputNumber1 = int.Parse(inputNumber);

        switch (inputNumber1)
        {
            case 1:
                Console.WriteLine("Enter a name:");
                string name = Console.ReadLine();
                if (people.ContainsKey(name))
                {
                    Console.WriteLine($"User call {name} on phone number {people[name]}");
                }
                else
                {
                    Console.WriteLine($"You don`t have a people with that {name}");

                }

                break;
            case 2:
                Console.WriteLine("Enter a name:");
                string nameOfNewContact = Console.ReadLine();
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (people.ContainsKey(nameOfNewContact))
                {
                    people[nameOfNewContact] = number;
                    Console.WriteLine($"you uptaded {nameOfNewContact} on phone number {number}");
                }
                else
                {
                    people.Add(nameOfNewContact, number);
                    Console.WriteLine("New contact add");
                }

                break;
            case 3:
                Console.WriteLine("Enter a name:");
                string nameOfNewContact2 = Console.ReadLine();
                if (people.ContainsKey(nameOfNewContact2))
                {
                    people.Remove(nameOfNewContact2);
                    Console.WriteLine("This contact removed");
                }
                else
                {
                    Console.WriteLine("You don`t have a people with that name");
                }

                break;

        }


        Console.WriteLine("2.3 Task-------------------------------------------------------------------------");



        Dictionary<string, string> itemsDictionary = new Dictionary<string, string>()
        {
            { "Bread", "In Kitchen" },
            { "Stone", "In cave" },
            { "Phone", "In pocket" },
            { "Bed", "In the room" },
            { "Clouds", "In the scy" }
        };

        Console.WriteLine("What item you are you looking for?");

        foreach (var item in itemsDictionary.Keys)
        {
            Console.WriteLine($"{item}");
        }

        string itemImLookingFor = Console.ReadLine();

        if (itemsDictionary.ContainsKey(itemImLookingFor))
        {
            Console.WriteLine($"{itemImLookingFor} locate {itemsDictionary[itemImLookingFor]}");
        }
        else
        {
            Console.WriteLine("You don`t have this item");
        }





        Console.WriteLine("2.4 Task-------------------------------------------------------------------------");

        Dictionary<string, double> itemsToSell = new Dictionary<string, double>()
        {
            { "Bread", 1.50 },
            { "Cookie", 2.59 },
            { "Meat", 3.50 },
            { "Water", 0.59 },
            { "Milk", 1.09 }
        };

        Dictionary<int, string> optionsOnShop = new Dictionary<int, string>()
        {
            { 1, "Sell" },
            { 2, "Add item" },
            { 3, "Delete item" }
        };

        Console.WriteLine("Your items to sell:");

        foreach (var item in itemsToSell)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }


        Console.WriteLine("Options to do (write only numbers):");

        foreach (var VARIABLE in optionsOnShop)
        {
            Console.WriteLine($"{VARIABLE.Key}: {VARIABLE.Value}");
        }

        int optionSeelected = Convert.ToInt32(Console.ReadLine());

        switch (optionSeelected)
        {
            case 1:
                Console.WriteLine("Enter a name of item:");
                string name1 = Console.ReadLine();
                if (itemsToSell.ContainsKey(name1))
                {
                    Console.WriteLine($"You sell {name1} by {itemsToSell[name1]} euro");
                }
                else
                {
                    Console.WriteLine($"You don`t have a item with that name");

                }

                break;
            case 2:
                Console.WriteLine("Enter a name:");
                string nameOfNewItem1 = Console.ReadLine();
                Console.WriteLine("Enter a value:");
                double number2 = double.Parse(Console.ReadLine());
                if (itemsToSell.ContainsKey(nameOfNewItem1))
                {
                    itemsToSell[nameOfNewItem1] = number2;
                    Console.WriteLine($"you uptaded {nameOfNewItem1} on sell {number2}");
                }
                else
                {
                    itemsToSell.Add(nameOfNewItem1, number2);
                    Console.WriteLine("New item add");
                }

                break;
            case 3:
                Console.WriteLine("Enter an item:");
                string nameOfNewItem2 = Console.ReadLine();
                if (itemsToSell.ContainsKey(nameOfNewItem2))
                {
                    itemsToSell.Remove(nameOfNewItem2);
                    Console.WriteLine("This item removed");
                }
                else
                {
                    Console.WriteLine("You don`t have an items with that name");
                }

                break;


        }
        


        Console.WriteLine("2.5 Task-------------------------------------------------------------------------");

        Dictionary<string, string> zagadki = new Dictionary<string, string>()
        {
            { "I am tall when I am young, and I am short when I am old. What am I?", "Candle" },
            { "What has a neck but no head, a body but no legs?", "Bottle" },
            { "What breaks as soon as you say its name?", "Silence" },
        };

        foreach (var item in zagadki)
        {
            string input = String.Empty;

            do
            {
                Console.WriteLine($"{item.Key}:");
                input = Console.ReadLine();

                if (input == item.Value)
                {
                    Console.WriteLine($"{item.Key} is {item.Value}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Wrong answer");
                }
            } while (input != item.Value);



            Console.ReadKey();

        }

        Console.WriteLine("2.6 Task-------------------------------------------------------------------------");

        Dictionary<string, int> students = new Dictionary<string, int>()
        {
            { "Alex", 10 },
            { "Sabrina", 7 },
            { "Simon", 12 }
        };

        Dictionary<int, string> optionsForTeacher = new Dictionary<int, string>()
        {
            { 1, "Add Student" },
            { 2, "Change grade" },
        };

        Console.WriteLine("All students:");

        foreach (var item in students)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        Console.WriteLine("All options:");

        foreach (var item in optionsForTeacher)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        
        int choosedOption =  int.Parse(Console.ReadLine());

        switch (choosedOption)
        {
            case 1:
                Console.WriteLine("Add Student:");
                Console.WriteLine("Write Name:");
                string name = Console.ReadLine();
                
                Console.WriteLine("Write Grade:");
                int grade = int.Parse(Console.ReadLine());
                
                students.Add(name, grade);

                Console.WriteLine("Student add");
                
                break;
            
            
            case 2:
                Console.WriteLine("Write Name:");
                string nameOfStudent = Console.ReadLine();
                
                if (students.ContainsKey(nameOfStudent))
                {
                    Console.WriteLine($"Write new grade:");
                    int newGrade = int.Parse(Console.ReadLine());
                    
                    students[nameOfStudent] = newGrade;
                }
                else
                {
                    Console.WriteLine($"There`s no that student");
                }
                break;
                
        }
        
        Console.WriteLine("2.7 Task-------------------------------------------------------------------------");
        Dictionary<string, string> wordsInGerman= new Dictionary<string, string>()
        {
            { "Hello", "Hallo!" },
            { "Apple", "Apfel" },
            { "Look", "Sehen" },
            { "You", "Du" },
        };
            
        Console.WriteLine("Write a word you want to know on german");
        string word1 = Console.ReadLine();

        switch (word1)
        {
            case "Hello":
                Console.WriteLine(wordsInGerman[word1]);
                
                break;
            case "Apple":
                Console.WriteLine(wordsInGerman[word1]);
                break;
            case "Look":
                Console.WriteLine(wordsInGerman[word1]);
                break;
            case "You":
                Console.WriteLine(wordsInGerman[word1]);
                break;
            default:
                Console.WriteLine("We don`t have this word");
                break;
        }
       
        Console.WriteLine("2.8 Task-------------------------------------------------------------------------");

        Dictionary<string, double> words = new Dictionary<string, double>()
        {
            { "Apples", 10 },
            { "Bananas", 20 },
            { "Cherries", 30 },
        };
        Console.WriteLine("Your garden:");
        foreach (KeyValuePair<string, double> word in words)
        {
            Console.WriteLine($"{word.Key} - {word.Value}");
        }
        
        Console.WriteLine("2.9 Task-------------------------------------------------------------------------");

        Dictionary<string, int> students1 = new Dictionary<string, int>()
        {
            { "Mikael", 12 },
            { "Jason", 4 },
            { "Jessie", 8 }
        };
        
        foreach (var student in students1)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }


        int sumGrades = 0;

        int countOfStudents = students1.Count;

        double averageGrade;

        foreach (var stud in students1)
        {
            sumGrades += stud.Value;
        }
        
        averageGrade = sumGrades / countOfStudents;
        
        Console.WriteLine("Your average grade:  " + averageGrade);
        
        Console.ReadLine();
    }
}
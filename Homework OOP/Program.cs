/*Завдання 1: Створення Класу "Ворог" 
Створіть клас "Enemy" з властивостями "ім'я" та "здоров'я". 
    Додайте метод "Attack", який дозволяє ворогу атакувати.
    Завдання 2: Створення Класу "Магія"
Створіть клас "Magic" з методами "CastSpell" та "UsePotion", які відображають використання заклинання та зілля.
    Завдання 3: Створення Класу "Скринька з Скарбами" 
Створіть клас "TreasureChest" з можливістю відкривати та взяти скарби.
    Завдання 4: Створення Класу "Бойовий Інвентар" 
Створіть клас "Inventory" з можливістю додавати та видаляти предмети.
    Завдання 5: Створення Класу "Лікарська Рослина" 
Створіть клас "MedicinalPlant" з можливістю зібрати лікарські рослини та виготовити ліки.
    Завдання 6: Створення Класу "Засідка" 
Створіть клас "Trap" з можливістю встановити пастку та спрацювання пастки.
    Завдання 7: Створення Класу "Меч Лицаря" 
Створіть клас "KnightSword" з можливістю атакувати та відображати стан меча.
﻿
Завдання 8: Створення Класу "Рецепт" 
Створіть клас "Recipe" з можливістю додавати інгредієнти та переглядати рецепт.*/

namespace Homework_OOP;  
  
class Program  
{  
    static void Main(string[] args)
    {
        string silver;
        string gold;
        string diamond;
        
        silver = "Silver";
        gold = "Gold";
        diamond = "Diamond";
        
        Random random = new Random();
        
        Enemy enemy = new Enemy("Ronin", 100);
        
        Trap trap = new Trap();
        
        KnightSword knightSword = new KnightSword();
        
        knightSword.Atack();
        knightSword.Atack();
        
        
        trap.Trigered();
        
        enemy.Atack();
        
        enemy.TakeDamage(random.Next(1, 100));
        
        TreasureChest treasureChest = new TreasureChest();
        
        treasureChest.Open();
        
        treasureChest.AddTreasure(silver, 2);
        treasureChest.AddTreasure(gold, 3);
        treasureChest.AddTreasure(diamond, 3);
        
        treasureChest.RemoveTreasure(diamond, 1);
        
        Inventory inventory = new Inventory();
        
        inventory.OpenInventory();
        
        inventory.AddInventory("Treasure");
        
        inventory.CloseInventory();

        inventory.TakeTreasure("lie");
        
        Healing healing = new Healing();

        string cherry = "Cherry";
        
        healing.AddPlant(cherry);
        healing.AddPlant(cherry);
        healing.AddPlant("Strawberry");
        healing.AddPlant("Strawberry");
        healing.AddPlant("Grass");
        healing.AddPlant("Water");
        
        healing.HealingPlants();
        
        healing.CreateHeal();
        
        
        
        
        Console.ReadKey();
    }  
}

public class Enemy
{
    private string _name;
    public int _health;

    public Enemy(string name, int health)
    {
        _name = name;
        _health = health;
    }
    
    public void Atack()
    {
        _health--;
        Console.WriteLine($"Enemy {_name} is atacking.");
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"You health is {_health} now.");
    }
}

public class Magic
{
    public void CastSpell()
    {
        Console.WriteLine("You used a spell");
    }

    public void UsePotion()
    {
        Console.WriteLine("You used a potion");
    }
}

public class TreasureChest
{
    private Dictionary<string, int> _treasuresList = new Dictionary<string, int>();

    private bool _isOpen =  false;

    public void Open()
    {
        _isOpen = true;
    }

    public void Close()
    {
        _isOpen = false;
    }

    public void AddTreasure(string treasure, int count)
    {
        if (_isOpen)
        {
            if (!_treasuresList.ContainsKey(treasure))
            {
                _treasuresList.Add(treasure, count);
            }
            else
            {
                _treasuresList[treasure]+=  count;
            }
        }
        else
        {
            Console.WriteLine("Chest is closed");
        }
    }

    public void RemoveTreasure(string treasure, int count)
    {
        if (_isOpen)
        {
            
            if (_treasuresList.ContainsKey(treasure))
            {
                if (_treasuresList[treasure] - count > 0)
                {
                    _treasuresList[treasure]-= count;
                }
                else
                {
                    Console.WriteLine($"There`s no {treasure} treasure. There`s no {count} treasures.");
                }
                
            }

            if (_treasuresList[treasure] == 0)
            {
                _treasuresList.Remove(treasure);
            }
        }
        else
        {
                Console.WriteLine("Chest is closed");
            
        }
    }
    
    public string TakeTreasure(string treasure)
    {
        if (_treasuresList.ContainsKey(treasure))
        {
            _treasuresList[treasure]--;
            
        }

        if (_treasuresList[treasure] == 0)
        { 
            _treasuresList.Remove(treasure);
        }
        
        return treasure;
    }
    
}

public class Trap
{
    private bool _isInstall = false;

    public Trap()
    {
        Installed();
    }

    public void Trigered()
    {
        _isInstall = false;
        Console.WriteLine($"Trap is trigered.");
    }

    public void Installed()
    {
        _isInstall = true;
        Console.WriteLine($"Trap is installed.");
    }
}
public class KnightSword
{
    private int _health = 100;

    
    public void Atack()
    {
        Random random = new Random();
        
        
        if (_health <= 0)
        {
            Console.WriteLine("Sword is broken");
            return;
        }

        _health -= random.Next(1, 100);
        Console.WriteLine($"Knight {_health} is atacking.");
        
    }
}

public class Inventory
{
    private List<string> _inventoryList = new List<string>();

    private bool _isOpeninventory = false;

    public void OpenInventory()
    {
        _isOpeninventory = true;
    }

    public void CloseInventory()
    {
        _isOpeninventory = false;
    }

    public void AddInventory(string treasure)
    {
        if (_isOpeninventory)
        {
            if (!_inventoryList.Contains(treasure))
            {
                _inventoryList.Add(treasure);
            }


        }
        else
        {
            Console.WriteLine($"Inventory is closed.");
        }
    }

    public void RemoveInventory(string treasure)
    {
        if (_isOpeninventory)
        {
            if (!_inventoryList.Contains(treasure))
            {
                _inventoryList.Remove(treasure);
            }
        }
        else
        {
            Console.WriteLine($"Inventory is closed.");
        }
    }

    public string TakeTreasure(string treasure)
    {
        if (_inventoryList.Contains(treasure))
        {
            _inventoryList.Remove(treasure);
        }

        if (!_inventoryList.Contains(treasure))
        {
            Console.WriteLine($"You don`t have a {treasure} treasure.");
        }

        return treasure;
    }

    
    }
public class Healing
{
    private List<string> plants = new List<string>();

    public void AddPlant(string plant)
    {
        plants.Add(plant);
    }

    public void HealingPlants()
    {
        foreach (string plant in plants)
        {
            Console.WriteLine($"Healing {plant}");
        }
        
    }

    public string UseHeal(string heal)
    {
        Console.WriteLine("Your HP is 100 now.");
        return heal;
        
    }

    public void CreateHeal()
    {
       Console.WriteLine("Write a plants you want to use");

        
       
       string plant1 = Console.ReadLine();
       string plant2 = Console.ReadLine();
       string plant3 = Console.ReadLine();

       
       Console.WriteLine($"You used {plant1}, {plant2} and {plant3}");   
    }
}
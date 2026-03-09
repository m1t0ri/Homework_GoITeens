using System;  
  
namespace MyNamespace;  
  
class Program  
{  
    static void Main(string[] args)
    {
        Console.WriteLine("Write A name of your character:");
        
        string name =  Console.ReadLine();

        Character character = new Character(name);
        
        Console.Clear();
        
        character.DisplayInfo();

        Console.WriteLine("Press Any Key To Continue...");
        
        Console.ReadKey();

        Weapon weapon = new Weapon(1, 20);
        Enemy enemy = new Enemy(100, 5);
        
        character.WeaponAtack();
        
        enemy.TakeDamage(weapon.Damage);
        
        Console.ReadKey();
        
        character.WeaponAtack();
        
        enemy.TakeDamage(weapon.Damage);
        
        Console.ReadKey();
        
        character.WeaponAtack();
        
        enemy.TakeDamage(weapon.Damage);
        
        Console.ReadKey();
        
        
        

    }  
}


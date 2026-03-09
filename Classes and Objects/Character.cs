using MyNamespace;

class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    
    

    public Character (string name, int health = 100)
    {  
        Name = name;
        Health = health;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Health: {Health}");
    }

    public void WeaponAtack()
    {
        Weapon weapon = new Weapon(1, 20);
        
        weapon.Atack(1, 20);
        
        Console.WriteLine($"Your health now is {Health}");
        
        
    }
}
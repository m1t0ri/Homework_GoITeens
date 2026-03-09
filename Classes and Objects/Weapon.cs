namespace MyNamespace;

public class Weapon
{
    public int Range { get;  set; }
    public int Damage { get; set; }

    public Weapon(int range, int damage)
    {
        Range = range;
        Damage = damage;
    }

    public void Atack(int range, int damage)
    {
        Console.WriteLine($"Your weapon has {damage} damage and {range} range");
        
        
    }
}
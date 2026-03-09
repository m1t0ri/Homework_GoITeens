namespace MyNamespace;

public class Enemy
{
    int Health { get; set; }
    int Damage { get; set; }

    public Enemy (int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        
        
        Console.WriteLine($"Enemy`s health now is {Health}");
    }

    
}


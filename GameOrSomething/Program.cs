using  System;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("AK-47", 5, 1);
            weapon.Attack();
            Sword sword = new Sword("Sword", 20, 5, 1);
            sword.Attack();
            
            Bow bow = new Bow("Bow", 20, 5, 20);
            bow.Attack();

            Unit unit = new Unit("Bob", 100);
            
            sword.SpecialAtack(unit);
            
            bow.SpecialAtack(unit);

            Console.WriteLine("---------------------------------");
            
            sword.Attack();

            bow.Reload(5);
            
            
            Console.ReadKey();
            
        }
    }

    public class Unit
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Unit(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Health = 0;
            }
            Console.WriteLine($"{Name} damaged {damage}");
            
            Console.WriteLine($"{Name} health {Health}");
        }
        
    }
    public class Weapon
    {
        public string Name { get; private set; }
        public int Damage { get; protected set; }
        public int Range { get; private set; }
        public int Status { get; private set; } = 100;
        public int Efficiency { get; private set; } = 100;
        
        

        public Weapon(string name, int damage, int range)
        {
            Name = name;
            Damage = damage;
            Range = range;
            Efficiency = 100;
        }

        public virtual void Attack()
        {
            Console.WriteLine("{0} attacks {1} damage {2} range", Name, Damage, Range);
            
            Efficiency --;
            Damage -= 1;
        }

        public virtual void SpecialAtack(Unit unit)
        {
            Console.WriteLine($"Weapon {Name} atacked {unit.Name} ");
            Efficiency -= 3;
            Damage -= 3;
        }
    }

    public class Sword: Weapon
    {
        public int BladeLength { get; private set; }
     
        public Sword(string name, int damage, int bladelength, int range) : base(name, damage, range)
        {
            BladeLength = bladelength;
            
        }
        public override void Attack()
        {
            base.Attack();
            Console.WriteLine($"Blade length is {BladeLength}" +
                              $"\nThe status of sword is:{iaSharpened(Status)}");
            iaSharpened(Status);
            
            
        }

        public override void SpecialAtack(Unit unit)
        {
            base.SpecialAtack(unit);
            
            int prevDamage = Damage;
            Damage *= 2;
            unit.TakeDamage(Damage);
            Damage = prevDamage;

        }

        public int iaSharpened(int status)
        {
            status = Status;
            
            status--;
            
            return status;
        }
        
    }

    public class Bow: Weapon
    {
        public int ArrowCount { get; private set; }
        
        public Bow(string name, int damage, int count, int range) : base(name, damage, range)
        {
            ArrowCount = count;
        }

        public override void Attack()
        {
            base.Attack();
            Console.WriteLine($"Arrow count is {ArrowCount}");
        }

        public override void SpecialAtack(Unit unit)
        {
            int maximumDamage = Damage * ArrowCount;
            unit.TakeDamage(maximumDamage);

            ArrowCount = 0;
            
        }

        public int Reload(int amount)
        {
            ArrowCount = amount;
            
            Console.WriteLine($"Bow is reload {ArrowCount}");
            return amount;
        }
    }
    
}
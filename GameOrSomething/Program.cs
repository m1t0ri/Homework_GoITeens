using  System;
using System.Security.Cryptography.X509Certificates;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Unit unit = new Unit("Bob", 100);
            
            Weapon weapon = new Weapon("AK-47", 5, 1);
            weapon.Attack(unit);
            Sword sword = new Sword("Sword", 20, 5, 1);
            sword.Attack(unit);
            
            Bow bow = new Bow("Bow", 20, 5, 20);
            bow.Attack(unit);

            
            sword.SpecialAtack(unit);
            
            bow.SpecialAtack(unit);

            Console.WriteLine("---------------------------------");
            
            sword.Attack(unit);

            bow.Reload();
            
            
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

        public virtual void Attack(Unit unit)
        {
            unit .TakeDamage(Damage);
            
            Efficiency --;
            Damage -= 1;
        }

        public virtual void SpecialAtack(Unit unit)
        {
            Console.WriteLine($"Weapon {Name} atacked {unit.Name} ");
            Efficiency -= 3;
            Damage -= 3;
        }

        public virtual void ShowStatus()
        {
            Console.WriteLine("{0} attacks {1} damage {2} range", Name, Damage, Range);
        }
    }

    public class Sword: Weapon
    {
        public int BladeLength { get; private set; }
     
        public Sword(string name, int damage, int bladelength, int range) : base(name, damage, range)
        {
            BladeLength = bladelength;
            
        }
        public override void Attack(Unit unit)
        {
            base.Attack(unit);
            
            IsSharpened(Status);
            
            Console.WriteLine($"Blade length is {BladeLength}" +
                              $"\nThe status of sword is:{Status}");
        }

        public override void SpecialAtack(Unit unit)
        {
            base.SpecialAtack(unit);
            
            int prevDamage = Damage;
            Damage *= 2;
            unit.TakeDamage(Damage);
            Damage = prevDamage;

        }

        public void IsSharpened(int status)
        {
            Damage += Status;
            /*status = Status;
            status--;*/
        }
        
    }

    public class Bow: Weapon
    {
        public int ArrowCount { get; private set; }
        public int MaxArrows = 30;
        public Bow(string name, int damage, int count, int range) : base(name, damage, range)
        {
            ArrowCount = count;
        }

        public override void Attack(Unit unit)
        {
            base.Attack(unit);
            Console.WriteLine($"Arrow count is {ArrowCount}");
        }

        public override void SpecialAtack(Unit unit)
        {
            int maximumDamage = Damage * ArrowCount;
            unit.TakeDamage(maximumDamage);

            ArrowCount = 0;
            
        }

        public void Reload()
        {
            ArrowCount = MaxArrows;
            
            Console.WriteLine($"Bow is reload {ArrowCount}");
        }
    }
    
}
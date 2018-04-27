using System;

namespace human
{
    public class Human
    {
        public string name;
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public Human(string new_name, int new_str = 3, int new_int = 3, int new_dex = 3, int new_hp = 100)
        {
            name = new_name;
            strength = new_str;
            intelligence = new_int;
            dexterity = new_dex;
            health = new_hp;
        }
        public void Status()
        {
            Console.WriteLine($"-------{name}-------");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Intelligence: {intelligence}");
            Console.WriteLine($"Dexterity: {dexterity}");
            Console.WriteLine($"--------------------");
        }
        public void Attack(Human target)
        {
            int damage = strength * 5; // Determine amount of damage based on attacker stats
            target.health -= damage; // Deal this damage to the target
            Console.WriteLine($"{name} deals {damage} damage to {target.name}");
            Console.WriteLine($"{target.name}'s hp has been reduced to {target.health}.");
        }
    }

    // Wizard subclass of Human
    public class Wizard : Human
    {
        public Wizard(string new_name) : base(new_name)
        {
            intelligence = 25;
            health = 50;
        }
        public void Heal() // Increase own health by 10xintelligence
        {
            int hp_amt = 10 * intelligence;
            health += hp_amt;
            Console.WriteLine($"{name} has been healed for {hp_amt}.");
            Console.WriteLine($"{name}'s hp is now at {health}.");
        }
        public void Fireball(Human target) // Decrease target health by random 20-50 hp
        {
            Random rand = new Random();
            int burn_amt = rand.Next(20,51);
            target.health -= burn_amt;
            Console.WriteLine($"{name} burned {target.name} for {burn_amt}.");
            Console.WriteLine($"{target.name}'s health is now at {target.health}.");
        }
    }

    // Ninja subclass of Human
    public class Ninja : Human
    {
        public Ninja(string new_name) : base(new_name)
        {
            dexterity = 175;
        }
        public void Steal(Human target) // Steals 10 life
        {
            int steal_amt = 10;
            health += steal_amt;
            target.health -= steal_amt;
            Console.WriteLine($"{name} has stolen {steal_amt} hp from {target.name}.");
            Console.WriteLine($"{name}'s hp is now at {health}.");
            Console.WriteLine($"{target.name}'s hp is now at {target.health}.");
        }
        public void Get_away() // Gets away but loses 15 hp
        {
            int get_away_amt = 15;
            health -= get_away_amt;
            Console.WriteLine($"{name} used up some energy to get away and lost {health} hp in the process.");
            Console.WriteLine($"{name}'s health is now at {health}.");
        }
    }

    // Samurai subclass of Human
    public class Samurai : Human
    {
        public Samurai(string new_name) : base(new_name)
        {
            health = 200;
        }
        public void Death_blow(Human target) // Kills target if they are below 50 hp
        {
            if(target.health < 50)
            {
                int damage = target.health;
                target.health = 0;
                Console.WriteLine($"{name} has dealt {damage} damage and killed {target.name}.");
            }
            else
            {
                Console.WriteLine($"{target.name} dodges the attack and leaves unscathed.");
            }
        }
        public void Meditate()
        {
            health = 200;
            Console.WriteLine($"{name} has regained full health.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Human adrian = new Human("Adrian",4,4,2,2000);
            // Human dude = new Human("Dude");
            // Console.WriteLine($"Name: {adrian.name}");
            // Console.WriteLine($"Health: {adrian.health}");
            // Console.WriteLine($"Strength: {adrian.strength}");
            // Console.WriteLine($"Dexterity: {adrian.dexterity}");
            // Console.WriteLine($"Intelligence: {adrian.intelligence}");

            // Console.WriteLine($"Name: {dude.name}");
            // Console.WriteLine($"Health: {dude.health}");
            // Console.WriteLine($"Strength: {dude.strength}");
            // Console.WriteLine($"Dexterity: {dude.dexterity}");
            // Console.WriteLine($"Intelligence: {dude.intelligence}");

            // adrian.Attack(dude);

            Wizard Harry = new Wizard("Harry Potter");
            Harry.Status();

            Wizard Ron = new Wizard("Ronald Weasley");
            Ron.Status();
            Harry.Fireball(Ron);

            Samurai Hanzo = new Samurai("Hattori Hanzo");
            Harry.Fireball(Hanzo);

            Hanzo.Meditate();
            Hanzo.Status();
            Hanzo.Death_blow(Ron);
        }
    }
}

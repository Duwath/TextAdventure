using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Character
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Character(string name, int health, int dmg)
        {
            Name = name;
            Health = health;
            Damage = dmg;
        }

        public virtual void Angriff(Character target)
        {
            Console.WriteLine($"{Name} greift {target.Name} an und verursacht {Damage} Schaden.");
            target.Health -= Damage;
            if (target.Health <= 0)
            {
                Console.WriteLine($"{target.Name} wurde besiegt!");
            }
        }
    }
}


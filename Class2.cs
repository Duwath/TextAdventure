using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Character
    {
        public string Name { get; set; }
        public string Klasse { get; set; }
        public int Leben { get; set; }
        public int Schaden { get; set; }
        public int ID { get; set; }

        public Character(string name, string klasse, int hp, int dmg, int iD)
        {
            Name = name;
            Klasse = klasse;
            Leben = hp;
            Schaden = dmg;
            ID = iD;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Priester : Character
    {
        public Priester(string name, string klasse, int leben, int dmg) : base(name, klasse, leben, dmg)
        {
            name = "Thurion";
            klasse = "Priester";
            leben = 30;
            dmg = 5;
        }
    }
}

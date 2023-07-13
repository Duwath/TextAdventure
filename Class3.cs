using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Krieger : Character
    {
        public Krieger(string name, string klasse, int leben, int dmg) : base(name, klasse, leben, dmg)
        {
            name = "Hrothgar";
            klasse = "Krieger";
            leben = 50;
            dmg = 10;
        }
    }
}

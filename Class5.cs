﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdventureGame
{
    internal class Magier : Character
    {
        public Magier(string name, string klasse, int leben, int dmg) : base(name, klasse, leben, dmg)
        {
            name = "Alannah";
            klasse = "Priesterin";
            leben = 30;
            dmg = 15;
        }
    }
}

namespace AdventureGame
{
    public class Character
    {
        public string Name { get; set; }
        public string Klasse { get; set; }
        public int Leben { get; set; }
        public int Schaden { get; set; }
        public int ID { get; set; }
        public string Pfad { get; set; }

        public Character(string name, string klasse, int hp, int dmg, int iD, string pfad)
        {
            Name = name;
            Klasse = klasse;
            Leben = hp;
            Schaden = dmg;
            ID = iD;
            Pfad = pfad;
        }

    }
}


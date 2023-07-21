namespace AdventureGame
{
    public partial class Form1 : Form
    {
        // Attribute
        List<Character> character = new List<Character>();
        List<Story> storys = new List<Story>();
        List<Character> enemy = new List<Character>();
        Character Spielcharacter;
        Character Enemy;
        int speicher = 0;
        int charSpeicher = 9;        
        int[] enemySpeicher = new int[5];

        public Form1()
        {
            InitializeComponent();
            ImportChar();
            ImportStory();
            Ausgabe();


        }
        private void CharBild()
        {
            if (charSpeicher == 0)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\warrior.png");
            }
            else if (charSpeicher == 1)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\warrior.png");
            }
            else if (charSpeicher == 2)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\rogue.png");
            }
            else if (charSpeicher == 3)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\mage.png");
            }
            else if (charSpeicher == 4)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\monk.png");
            }
            else { }
        }
        

        private Character ErstelleChar()
        {
            if (charSpeicher == 0)
            {
                Character Spielcharacter = character[0];
                CharBild();
                return Spielcharacter;
            }
            else if (charSpeicher == 1)
            {
                Character Spielcharacter = character[1];
                CharBild();
                return Spielcharacter;
            }
            else if (charSpeicher== 2)
            {
                Character Spielcharacter = character[2];
                CharBild();
                return Spielcharacter;
            }
            else if (charSpeicher == 3)
            {
                Character Spielcharacter = character[3];
                CharBild();
                return Spielcharacter;
            }
            else if (charSpeicher == 4)
            {
                Character Spielcharacter = character[4];
                CharBild();
                return Spielcharacter;
            }
            else
            {
                Character Spielcharacter1 = null;
                return Spielcharacter1;
            }
        }
                
           
        
        private void Ausgabe()
        {
            
            rtbMain.SelectionAlignment = HorizontalAlignment.Center;
            rtbMain.Text = storys[speicher].Stories;
            rtb1.SelectionAlignment = HorizontalAlignment.Center;
            rtb1.Text = storys[speicher].Answer1;
            rtb2.SelectionAlignment = HorizontalAlignment.Center;
            rtb2.Text = storys[speicher].Answer2;
            rtb3.SelectionAlignment = HorizontalAlignment.Center;
            rtb3.Text = storys[speicher].Answer3;
            rtb4.SelectionAlignment = HorizontalAlignment.Center;
            rtb4.Text = storys[speicher].Answer4;
            


        }
        private void charspeichercheck()
        {   //Hier wird gecheckt ob schon ein Character erstellt wurde
            if (charSpeicher == 9)
            {
                charSpeicher = storys[speicher].Character;
                ErstelleChar();
                
            }
        }
        private void enemyspeichercheck()
        {   //Hier wird gecheckt ob Gegner im Speicher sind.
            //und der enemyspeicher mit gegnern oder dummys gefüllt.
            if (enemySpeicher[0] == 9)
            {

                enemySpeicher[4] = storys[speicher].Gegner5;
                enemySpeicher[3] = storys[speicher].Gegner4;
                enemySpeicher[2] = storys[speicher].Gegner3;
                enemySpeicher[1] = storys[speicher].Gegner2;
                enemySpeicher[0] = storys[speicher].Gegner1;
            }
        }



        private void ImportStory()
        {
            storys.Clear();
            StreamReader sr = new StreamReader("..\\..\\..\\ExcelCSV\\Story.csv");
            while (!sr.EndOfStream)
            {
                string GesamteLine = sr.ReadLine();
                string[] Splitted = GesamteLine.Split(';');
                Story kundeTemp = new Story(Convert.ToInt32(Splitted[0]), Convert.ToInt32(Splitted[1]), Splitted[2], Splitted[3], Splitted[4], Splitted[5], Splitted[6], Convert.ToInt32(Splitted[7]), Convert.ToInt32(Splitted[8]), Convert.ToInt32(Splitted[9]), Convert.ToInt32(Splitted[10]), Convert.ToInt32(Splitted[11]), Convert.ToInt32(Splitted[12]), Convert.ToInt32(Splitted[13]), Convert.ToInt32(Splitted[14]), Convert.ToInt32(Splitted[15]), Convert.ToInt32(Splitted[16]));
                storys.Add(kundeTemp);
            }
            sr.Close();
        }
        private void ImportChar()
        {
            storys.Clear();
            StreamReader sr = new StreamReader("..\\..\\..\\ExcelCSV\\Character.csv");
            while (!sr.EndOfStream)
            {
                string GesamteLine = sr.ReadLine();
                string[] Splitted = GesamteLine.Split(';');
                Character characterTemp = new Character(Splitted[0], Splitted[1], Convert.ToInt32(Splitted[2]), Convert.ToInt32(Splitted[3]), Convert.ToInt32(Splitted[4]));
                character.Add(characterTemp);
            }
            sr.Close();
        }
        private void ImportEnemy()
        {
            storys.Clear();
            StreamReader sr = new StreamReader("..\\..\\..\\ExcelCSV\\Gegner.csv");
            while (!sr.EndOfStream)
            {
                string GesamteLine = sr.ReadLine();
                string[] Splitted = GesamteLine.Split(';');
                Character characterTemp = new Character(Splitted[0], Splitted[1], Convert.ToInt32(Splitted[2]), Convert.ToInt32(Splitted[3]), Convert.ToInt32(Splitted[4]));
                enemy.Add(characterTemp);
            }
            sr.Close();
        }
        private void OnClick1(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option1;
            charspeichercheck();
            enemyspeichercheck();                                
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick2(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option2;
            charspeichercheck();
            enemyspeichercheck();
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick3(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option3;
            charspeichercheck();
            enemyspeichercheck();
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick4(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option4;
            charspeichercheck();
            enemyspeichercheck();
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }
    }

}

using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing.Text;

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
        int bl�dsinn = 0;

        public Form1()
        {
            InitializeComponent();


            rtbMain.SelectionLength = 0;

            ImportChar();
            ImportStory();
            
            Ausgabe();


        }
        private void CharBild()
        {
            if (Spielcharacter == null)
            {

            }
            else if (Spielcharacter.ID == 0)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\warrior.png");
            }
            else if (Spielcharacter.ID == 1)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\warrior.png");
            }
            else if (Spielcharacter.ID == 2)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\rogue.png");
            }
            else if (Spielcharacter.ID == 3)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\mage.png");
            }
            else if (Spielcharacter.ID == 4)
            {
                pbLeft.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\monk.png");
            }
            else { }
        }
        /*private void Kampf()
        {
            if (Gegner != null)
            {
                


            }

        }*/

        private Character ErstelleChar()
        {
            if (storys[speicher].Character == 0)
            {
                Character Spielcharacter = character[0];
                CharBild();
                return Spielcharacter;
            }
            else if (storys[speicher].Character == 1)
            {
                Character Spielcharacter = character[1];
                CharBild();
                return Spielcharacter;
            }
            else if (storys[speicher].Character == 2)
            {
                Character Spielcharacter = character[2];
                CharBild();
                return Spielcharacter;
            }
            else if (storys[speicher].Character == 3)
            {
                Character Spielcharacter = character[3];
                CharBild();
                return Spielcharacter;
            }
            else if (storys[speicher].Character == 4)
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
        private Character ErstelleGegner()
        {
            if (storys[speicher].Gegner == 1)
            {
                Character Enemy = enemy[0];
                return Enemy;
            }
            else if (storys[speicher].Gegner == 2)
            {
                Character Enemy = enemy[1];
                return Enemy;
            }
            else if (storys[speicher].Gegner == 3)
            {
                Character Enemy = enemy[2];
                return Enemy;
            }
            else if (storys[speicher].Gegner == 4)
            {
                Character Enemy = enemy[3];
                return Enemy;
            }
            else if (storys[speicher].Gegner == 5)
            {
                Character Enemy = enemy[4];
                return Enemy;
            }
            else
            {
                Character Enemy1 = null;
                return Enemy1;
            }
        }
        private void Ausgabe()
        {
            ErstelleChar();
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
            }
        }
        private void enemyspeichercheck()
        {   //Hier wird gecheckt ob Gegner im Speicher sind.
            //und der enemyspeicher mit gegnern oder dummys gef�llt.
            if (enemySpeicher[4] == 9)
            {
                
                    enemySpeicher[4] = storys[speicher].Gegner5;
                    enemySpeicher[3] = storys[speicher].Gegner4;
                    enemySpeicher[2] = storys[speicher].Gegner3;
                    enemySpeicher[1] = storys[speicher].Gegner2;
                    enemySpeicher[0] = storys[speicher].Gegner1;
                }
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
                Story kundeTemp = new Story(Convert.ToInt32(Splitted[0]), Splitted[1], Splitted[2], Splitted[3], Splitted[4], Splitted[5], Convert.ToInt32(Splitted[6]), Convert.ToInt32(Splitted[7]), Convert.ToInt32(Splitted[8]), Convert.ToInt32(Splitted[9]), Convert.ToInt32(Splitted[10]), Convert.ToInt32(Splitted[11]));
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
<<<<<<< HEAD
            charspeichercheck();
            enemyspeichercheck();
            speicher = storys[speicher].Option1;        
=======
            speicher = storys[speicher].Option1;
            if (charSpeicher== 9)
            {
                charSpeicher = storys[speicher].Character;
            }
            charSpeicher = storys[speicher].Character;
>>>>>>> parent of 7d5bccb (Fertig für heute)
            // Speicher hat sich ge�ndert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick2(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option2;
            charspeichercheck();
            enemyspeichercheck();
            // Speicher hat sich ge�ndert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick3(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option3;
            charspeichercheck();
            enemyspeichercheck();
            // Speicher hat sich ge�ndert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick4(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option4;
            charspeichercheck();
            enemyspeichercheck();
            // Speicher hat sich ge�ndert durch options klick, lade neuen inhalt
            Ausgabe();
        }

    }
}
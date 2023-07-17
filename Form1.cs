using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        // Attribute
        List<Character> character = new List<Character>();
        List<Story> storys = new List<Story>();
        List<Character> enemy = new List<Character>(); 
        int speicher = 0;
        int blödsinn = 0;
        Character Spielcharacter;
        public Form1()
        {
            InitializeComponent();
            
            rtbMain.SelectionLength = 0;

            ImportChar();
            ImportStory();

            Ausgabe();

        }
        
        private Character ErstelleChar()
        {
            if (storys[speicher].Character == 0)
            {
                Character Spielcharacter = character[0];
                return Spielcharacter;
            }
            else if (storys[speicher].Character == 1) 
            {
                Character Spielcharacter = character[1];
                return Spielcharacter;  
            }
            else if (storys[speicher].Character == 2)
            {
                Character Spielcharacter = character[2];
                return Spielcharacter;  
            }
            else if (storys[speicher].Character == 3)
            {
                Character Spielcharacter = character[3];
                return Spielcharacter;
            }
            else if (storys[speicher].Character == 4)
            {
                Character Spielcharacter = character[4];
                return Spielcharacter;
            }
            else { return null; }
        }
        private Character ErstelleGegner()
        {
            if (storys[speicher].Gegner == 0)
            {
                Character Spielcharacter = enemy[0];
                return Spielcharacter;
            }
            else if (storys[speicher].Gegner == 1)
            {
                Character Spielcharacter = enemy[1];
                return Spielcharacter;
            }
            else if (storys[speicher].Gegner == 2)
            {
                Character Spielcharacter = enemy[2];
                return Spielcharacter;
            }
            else if (storys[speicher].Gegner == 3)
            {
                Character Spielcharacter = enemy[3];
                return Spielcharacter;
            }
            else if (storys[speicher].Gegner == 4)
            {
                Character Spielcharacter = enemy[4];
                return Spielcharacter;
            }
            else { return null; }
        }
        private void Ausgabe()
        {
            ErstelleChar();
            rtbMain.Text = storys[speicher].Stories;
            rtb1.Text = storys[speicher].Answer1;
            rtb2.Text = storys[speicher].Answer2;
            rtb3.Text = storys[speicher].Answer3;
            rtb4.Text = storys[speicher].Answer4;
            
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
                Character characterTemp = new Character(Splitted[0], Splitted[1],Convert.ToInt32(Splitted[2]), Convert.ToInt32(Splitted[3]));
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
                Character characterTemp = new Character(Splitted[0], Splitted[1], Convert.ToInt32(Splitted[2]), Convert.ToInt32(Splitted[3]));
                enemy.Add(characterTemp);
            }
            sr.Close();
        }
        private void OnClick1(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option1;
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick2(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option2;
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick3(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option3;
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }

        private void OnClick4(object sender, EventArgs e)
        {
            speicher = storys[speicher].Option4;
            // Speicher hat sich geändert durch options klick, lade neuen inhalt
            Ausgabe();
        }

    }
}
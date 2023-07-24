using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Kampf : Form
    {
        List<Character> character = new List<Character>();
        List<Story> storys = new List<Story>();
        List<Character> enemy = new List<Character>();
        Character Spielcharacter;

        int speicher = 0;
        int[] enemySpeicher = new int[5];
        public Kampf(int speicher, Character Spielcharacter, List<Character> enemy)
        {
            InitializeComponent();

            this.speicher = speicher;
            this.Spielcharacter = Spielcharacter;
            this.enemy = enemy;
            ImportChar();
            ImportStory();
            enemyspeichercheck();
            Charerstellung();
            EnemyErstellung();
        }


        private void enemyspeichercheck()
        {   //Hier wird gecheckt ob Gegner im Speicher sind.
            //und der enemyspeicher mit gegnern oder dummys gefüllt.
            if (storys[speicher].Kampf == 1)
            {
                enemySpeicher[4] = storys[speicher].Gegner5;
                enemySpeicher[3] = storys[speicher].Gegner4;
                enemySpeicher[2] = storys[speicher].Gegner3;
                enemySpeicher[1] = storys[speicher].Gegner2;
                enemySpeicher[0] = storys[speicher].Gegner1;
            }
        }
        private void Charerstellung()
        {
            CharName();
            CharStats();
            CharBild();
        }
        private void CharName()
        {
            tbCharName.Text = Spielcharacter.Name;
        }
        private void CharStats()
        {
            rtbCharStats.Text = "HP: " + Spielcharacter.Leben + " // Attack: " + Spielcharacter.Schaden;
        }
        private void CharBild()
        {
            if (storys[speicher].Character == 0)
            {
                pbChar.BackgroundImage = Image.FromFile(Spielcharacter.Pfad);
            }
            else if (storys[speicher].Character == 1)
            {
                pbChar.BackgroundImage = Image.FromFile(Spielcharacter.Pfad);
            }
            else if (storys[speicher].Character == 2)
            {
                pbChar.BackgroundImage = Image.FromFile(Spielcharacter.Pfad);
            }
            else if (storys[speicher].Character == 3)
            {
                pbChar.BackgroundImage = Image.FromFile(Spielcharacter.Pfad);
            }
            else if (storys[speicher].Character == 4)
            {
                pbChar.BackgroundImage = Image.FromFile(Spielcharacter.Pfad);
            }
            else { }
        }
        private void EnemyErstellung()
        {
            EnemyName();
            EnemyBild();
            EnemyStats();
        }
        private void EnemyStats()
        {
            int i = 0;
            for (int j = 0; j < enemySpeicher.Length; j++)
            {
                if (enemySpeicher[j] == 9)
                {
                    i = j;
                    break;
                }
            }
            switch (i)
            {
                case 1:
                    rtbEnemy1Stats.Text = "HP: " + enemy[enemySpeicher[0]].Leben + " // Attack: " + enemy[enemySpeicher[0]].Schaden;
                    break;
                case 2:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + " // Attack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + " // Attack: " + enemy[enemySpeicher[1]].Schaden;
                    break;
                case 3:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + " // Attack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + " // Attack: " + enemy[enemySpeicher[1]].Schaden;
                    tbEnemy3Name.Text = "HP: " + enemy[enemySpeicher[2]].Leben + " // Attack: " + enemy[enemySpeicher[2]].Schaden;
                    break;
                case 4:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + " // Attack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + " // Attack: " + enemy[enemySpeicher[1]].Schaden;
                    tbEnemy3Name.Text = "HP: " + enemy[enemySpeicher[2]].Leben + " // Attack: " + enemy[enemySpeicher[2]].Schaden;
                    tbEnemy4Name.Text = "HP: " + enemy[enemySpeicher[3]].Leben + " // Attack: " + enemy[enemySpeicher[3]].Schaden;
                    break;
                case 5:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + " // Attack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + " // Attack: " + enemy[enemySpeicher[1]].Schaden;
                    tbEnemy3Name.Text = "HP: " + enemy[enemySpeicher[2]].Leben + " // Attack: " + enemy[enemySpeicher[2]].Schaden;
                    tbEnemy4Name.Text = "HP: " + enemy[enemySpeicher[3]].Leben + " // Attack: " + enemy[enemySpeicher[3]].Schaden;
                    tbEnemy5Name.Text = "HP: " + enemy[enemySpeicher[4]].Leben + " // Attack: " + enemy[enemySpeicher[4]].Schaden;
                    break;
                default:
                    break;

            }
        }
        private void EnemyName()
        {
            int i = 0;
            for (int j = 0; j < enemySpeicher.Length; j++)
            {
                if (enemySpeicher[j] == 9)
                {
                    i = j;
                    break;
                }
            }
            switch (i)
            {
                case 1:
                    tbEnemy1Name.Text = enemy[enemySpeicher[0]].Name;
                    break;
                case 2:
                    tbEnemy1Name.Text = enemy[enemySpeicher[0]].Name;
                    tbEnemy2Name.Text = enemy[enemySpeicher[1]].Name;
                    break;
                case 3:
                    tbEnemy1Name.Text = enemy[enemySpeicher[0]].Name;
                    tbEnemy2Name.Text = enemy[enemySpeicher[1]].Name;
                    tbEnemy3Name.Text = enemy[enemySpeicher[2]].Name;
                    break;
                case 4:
                    tbEnemy1Name.Text = enemy[enemySpeicher[0]].Name;
                    tbEnemy2Name.Text = enemy[enemySpeicher[1]].Name;
                    tbEnemy3Name.Text = enemy[enemySpeicher[2]].Name;
                    tbEnemy4Name.Text = enemy[enemySpeicher[3]].Name;
                    break;
                case 5:
                    tbEnemy1Name.Text = enemy[enemySpeicher[0]].Name;
                    tbEnemy2Name.Text = enemy[enemySpeicher[1]].Name;
                    tbEnemy3Name.Text = enemy[enemySpeicher[2]].Name;
                    tbEnemy4Name.Text = enemy[enemySpeicher[3]].Name;
                    tbEnemy5Name.Text = enemy[enemySpeicher[4]].Name;
                    break;
                default:
                    break;

            }
        }
        private void EnemyBild()
        {
            {
                int i = 0;
                for (int j = 0; j < enemySpeicher.Length; j++)
                {
                    if (enemySpeicher[j] == 9)
                    {
                        i = j;
                        break;
                    }

                }
                switch (i)
                {
                    case 1:
                        pbEnemy1.BackgroundImage = Image.FromFile(enemy[enemySpeicher[0]].Pfad);
                        break;
                    case 2:
                        pbEnemy1.BackgroundImage = Image.FromFile(enemy[enemySpeicher[0]].Pfad);
                        pbEnemy2.BackgroundImage = Image.FromFile(enemy[enemySpeicher[1]].Pfad);
                        break;
                    case 3:
                        pbEnemy1.BackgroundImage = Image.FromFile(enemy[enemySpeicher[0]].Pfad);
                        pbEnemy2.BackgroundImage = Image.FromFile(enemy[enemySpeicher[1]].Pfad);
                        pbEnemy3.BackgroundImage = Image.FromFile(enemy[enemySpeicher[2]].Pfad);
                        break;
                    case 4:
                        pbEnemy1.BackgroundImage = Image.FromFile(enemy[enemySpeicher[0]].Pfad);
                        pbEnemy2.BackgroundImage = Image.FromFile(enemy[enemySpeicher[1]].Pfad);
                        pbEnemy3.BackgroundImage = Image.FromFile(enemy[enemySpeicher[2]].Pfad);
                        pbEnemy4.BackgroundImage = Image.FromFile(enemy[enemySpeicher[3]].Pfad);
                        break;
                    case 5:
                        pbEnemy1.BackgroundImage = Image.FromFile(enemy[enemySpeicher[0]].Pfad);
                        pbEnemy2.BackgroundImage = Image.FromFile(enemy[enemySpeicher[1]].Pfad);
                        pbEnemy3.BackgroundImage = Image.FromFile(enemy[enemySpeicher[2]].Pfad);
                        pbEnemy4.BackgroundImage = Image.FromFile(enemy[enemySpeicher[3]].Pfad);
                        pbEnemy5.BackgroundImage = Image.FromFile(enemy[enemySpeicher[4]].Pfad);
                        break;
                    default:
                        break;

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
                Character characterTemp = new Character(Splitted[0], Splitted[1], Convert.ToInt32(Splitted[2]), Convert.ToInt32(Splitted[3]), Convert.ToInt32(Splitted[4]), Splitted[5]);
                character.Add(characterTemp);
            }
            sr.Close();
        }

    }

}

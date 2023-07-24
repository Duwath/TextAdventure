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
        int opt = 0;
        string Combatlog;


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
            BtnErstellung();
            CombatLoop();
        }
        private async void CombatLoop()
        {
            String Combatlogtemp = Combatlog;

            switch (opt)
            {

                case 1:
                    Combatlog = Spielcharacter.Name + " greift " + enemy[enemySpeicher[0]].Name + " an und verursacht " + Spielcharacter.Schaden + " Schaden.\n";
                    Combatlog = Combatlogtemp + Combatlog;
                    rtbCombatlog.Text = Combatlog;
                    rtbEnemy1Stats.Text = "HP: " + (enemy[enemySpeicher[0]].Leben - Spielcharacter.Schaden) + "\nAttack: " + enemy[enemySpeicher[0]].Schaden;
                    enemy[0].Leben = enemy[0].Leben - Spielcharacter.Schaden;

                    if (enemy[0].Leben <= 0)
                    {
                        rtbCombatlog.Text = "Du hast gewonnen!";
                        this.Close();

                    }
                    
                        
                    
                    break;
                case 2:
                    Combatlog = Spielcharacter.Name + " greift  " + enemy[enemySpeicher[0]].Name + " mit seinem Spezialangriff an und verursacht " + (Spielcharacter.Schaden * 2) + " Schaden.\n";
                    Combatlog = Combatlogtemp + Combatlog;
                    rtbCombatlog.Text = Combatlog;
                    rtbEnemy1Stats.Text = "HP: " + (enemy[enemySpeicher[0]].Leben - (Spielcharacter.Schaden * 2)) + "\nAttack: " + enemy[enemySpeicher[0]].Schaden;
                    enemy[0].Leben = enemy[0].Leben - (Spielcharacter.Schaden * 2);
                    if (enemy[0].Leben <= 0)
                    {                     
                        rtbCombatlog.Text = "Du hast gewonnen!";
                        this.Close();
                    }
                    break;
                case 3:
                    Combatlog = Spielcharacter.Name + " heilt sich mit seiner Heilfähigkeit um " + 10 + " Leben.";
                    Combatlog = Combatlogtemp + Combatlog;
                    rtbCombatlog.Text = Combatlog;
                    break;
                case 4:
                    Combatlog = Spielcharacter.Name + " verteidigt sich vor dem nächsten eingehenden Schaden.";
                    Combatlog = Combatlogtemp + Combatlog;
                    rtbCombatlog.Text = Combatlog;
                    break;
            }
        }
        private void BtnErstellung()
        {
            btnOp1.Text = "Einfacher Angriff\n (" + Spielcharacter.Schaden + " Dmg)";
            btnOp2.Text = "Spezialangriff \n(" + (Spielcharacter.Schaden * 2) + " Dmg)";
            btnOp3.Text = "Heilung \n(10 HP)";
            btnOp4.Text = "Block \n(-10 Dmg)";

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
            rtbCharStats.Text = "HP: " + Spielcharacter.Leben + "\nAttack: " + Spielcharacter.Schaden;
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
                    rtbEnemy1Stats.Text = "HP: " + enemy[enemySpeicher[0]].Leben + "\nAttack: " + enemy[enemySpeicher[0]].Schaden;
                    break;
                case 2:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + "\nAttack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + "\nAttack: " + enemy[enemySpeicher[1]].Schaden;
                    break;
                case 3:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + "\nAttack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + "\nAttack: " + enemy[enemySpeicher[1]].Schaden;
                    tbEnemy3Name.Text = "HP: " + enemy[enemySpeicher[2]].Leben + "\nAttack: " + enemy[enemySpeicher[2]].Schaden;
                    break;
                case 4:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + "\nAttack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + "\nAttack: " + enemy[enemySpeicher[1]].Schaden;
                    tbEnemy3Name.Text = "HP: " + enemy[enemySpeicher[2]].Leben + "\nAttack: " + enemy[enemySpeicher[2]].Schaden;
                    tbEnemy4Name.Text = "HP: " + enemy[enemySpeicher[3]].Leben + "\nAttack: " + enemy[enemySpeicher[3]].Schaden;
                    break;
                case 5:
                    tbEnemy1Name.Text = "HP: " + enemy[enemySpeicher[0]].Leben + "\nAttack: " + enemy[enemySpeicher[0]].Schaden;
                    tbEnemy2Name.Text = "HP: " + enemy[enemySpeicher[1]].Leben + "\nAttack: " + enemy[enemySpeicher[1]].Schaden;
                    tbEnemy3Name.Text = "HP: " + enemy[enemySpeicher[2]].Leben + "\nAttack: " + enemy[enemySpeicher[2]].Schaden;
                    tbEnemy4Name.Text = "HP: " + enemy[enemySpeicher[3]].Leben + "\nAttack: " + enemy[enemySpeicher[3]].Schaden;
                    tbEnemy5Name.Text = "HP: " + enemy[enemySpeicher[4]].Leben + "\nAttack: " + enemy[enemySpeicher[4]].Schaden;
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

        private void btn1Click(object sender, EventArgs e)
        {
            opt = 1;
            CombatLoop();


        }

        private void btn2Click(object sender, EventArgs e)
        {
            opt = 2;
            CombatLoop();
        }

        private void btn3Click(object sender, EventArgs e)
        {
            opt = 3;
            CombatLoop();
        }

        private void btn4Click(object sender, EventArgs e)
        {
            opt = 4;
            CombatLoop();
        }
    }
}


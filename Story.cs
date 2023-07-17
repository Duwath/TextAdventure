using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    internal class Story
    {
        public class Geschichte
        {
            public int Zeile { get; set; }
            public string Stories { get; set; }
            public string Answer1 { get; set; }
            public string Answer2 { get; set; }
            public string Answer3 { get; set; }
            public string Answer4 { get; set; }
            public int Option1 { get; set; }
            public int Option2 { get; set; }
            public int Option3 { get; set; }
            public int Option4 { get; set; }


            public Geschichte(int zeile, string stories, string answer1, string answer2, string answer3, string answer4, int option1, int option2, int option3, int option4)
            {
                Zeile = zeile;
                Stories = stories;
                Answer1 = answer1;
                Answer2 = answer2;
                Answer3 = answer3;
                Answer4 = answer4;
                Option1 = option1;
                Option2 = option2;
                Option3 = option3;
                Option4 = option4;
            }
            public int GetZeile() { return Zeile; }
            public string GetStories() {  return Stories; }
            public string GetAnswer1() {  return Answer1; }
            public string GetAnswer2() {  return Answer2; }
            public string GetAnswer3() {  return Answer3; }
            public string GetAnswer4() {  return Answer4; }
            public int GetOption1() { return Option1; } 
            public int GetOption2() { return Option2; }
            public int GetOption3() { return Option3; }
            public int GetOption4() { return Option4; }

        }
    }
}

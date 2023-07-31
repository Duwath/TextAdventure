namespace AdventureGame
{
    public class Story
    {
        public int Zeile { get; set; }
        public int Kampf { get; set; }  
        public string Stories { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int Option1 { get; set; }
        public int Option2 { get; set; }
        public int Option3 { get; set; }
        public int Option4 { get; set; }
        public int Character { get; set; }
        public int Gegner1 { get; set; }
        public int Gegner2 { get; set; }
        public int Gegner3 { get; set; }
        public int Gegner4 { get; set; }
        public int Gegner5 { get; set; }


        public Story(int zeile, int kampf, string stories, string answer1, string answer2, string answer3, string answer4, int option1, int option2, int option3, int option4, int character, int gegner1, int gegner2,int gegner3,int gegner4,int gegner5)
        {
            Zeile = zeile;
            Kampf = kampf;
            Stories = stories;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
            Character = character;
            Gegner1 = gegner1;
            Gegner2 = gegner2;
            Gegner3 = gegner3;
            Gegner4 = gegner4;
            Gegner5 = gegner5;
            
    }
        public int GetZeile() { return Zeile; }
        public int GetKampf() {  return Kampf; }      
        public string GetStories() { return Stories; }      
        public string GetAnswer1() { return Answer1; }
        public string GetAnswer2() { return Answer2; }
        public string GetAnswer3() { return Answer3; }
        public string GetAnswer4() { return Answer4; }
        public int GetOption1() { return Option1; }
        public int GetOption2() { return Option2; }
        public int GetOption3() { return Option3; }
        public int GetOption4() { return Option4; }
        public int GetCharacter() { return Character; }
        public int GetGegner1() { return Gegner1; }
        public int GetGegner2() {  return Gegner2; }
        public int GetGegner3() {  return Gegner3; }
        public int GetGegner4() {  return Gegner4; }
        public int GetGegner5() {  return Gegner5; }

    }
}


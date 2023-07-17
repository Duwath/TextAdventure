using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*String Start = "Ein neues Abenteuer! Bist du bereit?";*/
            rtbMain.SelectionLength = 0;
            
            rtbMain.SelectedText = UmbauenStory();
            rtb1.SelectedText = UmbauenTB1();
            rtb2.SelectedText = UmbauenTB2();
            rtb3.SelectedText = UmbauenTB3();
            rtb4.SelectedText = UmbauenTB4();

        }

        private string LeseFile()
        {
            int Choice;
            StreamReader sr = new StreamReader("../../../ExcelCSV/Story.csv");
            //sr.Seek(Choice, SeekOrigin.Begin);
            string GelesenerText = sr.ReadLine();


            sr.Close();

            return GelesenerText;
        }

        

        private string UmbauenStory()
        {
            string[] arrayMitStrings = LeseFile().Split(";");
            string Story = arrayMitStrings[1];
            
            return Story;       
        }
        private string UmbauenTB1()
        {           
            string[] arrayMitStrings = LeseFile().Split(";");
            string Text1 = arrayMitStrings[2];

            return Text1;
        }
        private string UmbauenTB2()
        {            
            string[] arrayMitStrings = LeseFile().Split(";");
            string Text2 = arrayMitStrings[3];

            return Text2;
        }
        private string UmbauenTB3()
        {
            string[] arrayMitStrings = LeseFile().Split(";");            
            string Text3 = arrayMitStrings[4];

            return Text3;
        }
        private string UmbauenTB4()
        {
            string[] arrayMitStrings = LeseFile().Split(";");
            string Text4 = arrayMitStrings[5];

            return Text4;
        }
        private string Choose1()
        {
            string[] arrayMitStrings = LeseFile().Split(";");
            string Option1 = arrayMitStrings[6];

            return Option1;
        }
        private string Choose2()
        {
            string[] arrayMitStrings = LeseFile().Split(";");
            string Option2 = arrayMitStrings[7];

            return Option2;
        }
        private string Choose3()
        {
            string[] arrayMitStrings = LeseFile().Split(";");
            string Option3 = arrayMitStrings[8];

            return Option3;
        }
        private string Choose4()
        {
            string[] arrayMitStrings = LeseFile().Split(";");
            string Option4 = arrayMitStrings[9];

            return Option4;
        }



        private int OnClick1(object sender, EventArgs e)
        {
            int Op = int.Parse(Choose1());
            return Op;
            LeseFile();
        }

        private int OnClick2(object sender, EventArgs e)
        {
            int Op = int.Parse(Choose1());
            return Op;
            LeseFile();

        }

        private int OnClick3(object sender, EventArgs e)
        {
            int Op = int.Parse(Choose1());
            return Op;
            LeseFile();

        }

        private int OnClick4(object sender, EventArgs e)
        {
            int Op = int.Parse(Choose1());
            return Op;
            LeseFile();
        }

    }
}
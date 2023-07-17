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
        public Form1()
        {
            InitializeComponent();
            /*String Start = "Ein neues Abenteuer! Bist du bereit?";*/
            rtbMain.SelectionLength = 0;
            
          

        }
        private void ImportStory()
        {
            storys.Clear();
            StreamReader sr = new StreamReader("..\\..\\..\\Story.csv");
            while (!sr.EndOfStream)
            {
                string GesamteLine = sr.ReadLine();
                string[] Splitted = GesamteLine.Split(';');
                Story kundeTemp = new Story(Convert.ToInt32(Splitted[0]), Splitted[1], Splitted[2], Splitted[3], Splitted[4], Splitted[5], Convert.ToInt32(Splitted[6]), Convert.ToInt32(Splitted[7]), Convert.ToInt32(Splitted[8]), Convert.ToInt32(Splitted[9]));
                storys.Add(kundeTemp);
            }
            sr.Close();

            
        }
        private string LeseFileStory()
        {            
            StreamReader sr = new StreamReader("../../../ExcelCSV/Story.csv");
            
            string GelesenerText = sr.ReadToEnd();


            sr.Close();

            return GelesenerText;
        }

        

       



        private void OnClick1(object sender, EventArgs e)
        {
            
        }

        private void OnClick2(object sender, EventArgs e)
        {
            

        }

        private void OnClick3(object sender, EventArgs e)
        {
            

        }

        private void OnClick4(object sender, EventArgs e)
        {
            
        }

    }
}
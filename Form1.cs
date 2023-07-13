using System.Windows.Forms;
using System.IO;
namespace AdventureGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String Start = "Ein neues Abenteuer! Bist du bereit?";
            rtbMain.SelectionLength = 0;
            rtbMain.SelectedText = Start;
            
        }

        
        private void OnClick1(object sender, EventArgs e)
        {
            int Eins = 1;

        }

        private void OnClick2(object sender, EventArgs e)
        {
            int Zwei = 2;

        }

        private void OnClick3(object sender, EventArgs e)
        {
            int Drei = 3;

        }

        private void OnClick4(object sender, EventArgs e)
        {
            int Vier = 4;
        }

    }
}
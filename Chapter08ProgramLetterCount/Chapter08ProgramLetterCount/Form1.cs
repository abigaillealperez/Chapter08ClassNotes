using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter08ProgramLetterCount
{
    public partial class Form1 : Form
    {
        private const int MAXLETTERS = 26; //SYMBOLIC CONSTANS
        private const int MAXCHARS = MAXLETTERS -1;
        private const int LETTERA = 65;

        
     

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char oneLetter;
            int index;
            int i;
            int length;
            int[] count = new int[MAXLETTERS];
            string input;
            string buff;
            length = txtInput.TextLength;
            if (length == 0) //ANYTHING TO COUNT??
            {
                MessageBox.Show("You need to enter somo text.", "Missing Input");
                txtInput.Focus();
                return;
            }
            input = txtInput.Text;
            input = input.ToUpper();

            for (i = 0; i < input.Length; i++)  //EXAMINE ALL LETTERS
            {
                oneLetter = input[i]; //GET A CHARACTER
                index = oneLetter - LETTERA;  //MAKE INTO AN INDEX
                if (index < 0 || index > MAXCHARS)  //A LETTER?
                    continue;
                count[index]++;
            }

            for (i = 0; i < MAXLETTERS; i++)
            {
                buff = string.Format("{0, 4} {1, 20} [{2}]", (char)(i + LETTERA),
                    " ", count[i]);
                lstOutput.Items.Add(buff);
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

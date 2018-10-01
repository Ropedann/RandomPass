using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] RandomElements = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", 
                                "A", "a", "B", "b", "C", "c", "D", "d", "E", "e",
                                "j", "J", "i", "I", "h", "H", "g", "G", "f", "F",
                                "K", "k", "L", "l", "M", "m", "N", "n", "O", "o",
                                "t", "T", "s", "S", "r", "R", "q", "Q", "p", "P",
                                "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y",
                                "Z", "z" };

            // textBox2.Text = Convert.ToString(LengthPass);
            string pass = "";
            Random mran = new Random();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int index = Convert.ToUInt16(mran.NextDouble() * RandomElements.Length) % RandomElements.Length;
                char ScharS = Convert.ToChar(RandomElements[index]);
                pass += Convert.ToString(ScharS);
            }
            textBox2.Text = pass;
        }
    }
}

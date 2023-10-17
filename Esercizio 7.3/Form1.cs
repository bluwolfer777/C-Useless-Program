using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercizio_7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] parola;
        private void button1_Click(object sender, EventArgs e)
        {
            parola = new char[textBox1.Text.Length];
            textBox2.Text = "";
            for (int i = 0; i < parola.Length; i++)
            {
                parola[i] = textBox1.Text[i];
            }
            for (int i = parola.Length-1;i >= 0;i--)
            {
                textBox2.Text += parola[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vocali = 0;
            int consonanti = 0;
            parola = new char[textBox1.Text.Length];
            for (int i = 0; i < parola.Length; i++)
            {
                parola[i] = textBox1.Text[i];
            }
            for (int i = 0;i < parola.Length;i++)
            {
                if ((parola[i] == 'a') || (parola[i] == 'e') || (parola[i] == 'i') || (parola[i] == 'o') || (parola[i] == 'u') || (parola[i] == 'A') || (parola[i] == 'E') || (parola[i] == 'I') || (parola[i] == 'O') || (parola[i] == 'U'))
                {
                    vocali++;
                }
                else if (parola[i] == ' ')
                {

                }
                else
                {
                    consonanti++;
                }
            }
            textBox3.Text = vocali.ToString();
            textBox4.Text = consonanti.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{

    public partial class Form2 : Form
    {
<<<<<<< HEAD
        static int counter;
        string[] naskah = new string[] { "siapa ayah hamo?", "kenapa dipanggil hamo ?", "apa itu hamo?" };
        string[] option1 = new string[] { "gak tau", "sulit nih", "mager jawab" };
        string[] option2 = new string[] { "hm apa ya", "kepo lu", "C mungkin?" };
        string[] option3 = new string[] { "sumpah gatau", "apa urusan anda bertanya?", "Yang bener B kok" };
        string[] option4 = new string[] { "nyerah bang", "jawab sndiri aja", "Arrg gatau" };
=======
         static int counter = 1;
        string[] naskah = new string[] 
        { "siapa ayah hamo?", "kenapa dipanggil hamo ?" , "apa itu hamo?"};

>>>>>>> 6f0f9d095b14cf607c65529237607c456b48d726




        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = option1[counter];
            button2.Text = option2[counter];
            button3.Text = option3[counter];
            button4.Text = option4[counter];
            string a = naskah[counter];
            soal.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                counter++;
                button1.Text = option1[counter];
                button2.Text = option2[counter];
                button3.Text = option3[counter];
                button4.Text = option4[counter];
                string a = naskah[counter];
                soal.Text = a.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                counter++;
                button1.Text = option1[counter];
                button2.Text = option2[counter];
                button3.Text = option3[counter];
                button4.Text = option4[counter];
                string a = naskah[counter];
                soal.Text = a.ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                counter++;
                button1.Text = option1[counter];
                button2.Text = option2[counter];
                button3.Text = option3[counter];
                button4.Text = option4[counter];
                string a = naskah[counter];
                soal.Text = a.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                counter++;
                button1.Text = option1[counter];
                button2.Text = option2[counter];
                button3.Text = option3[counter];
                button4.Text = option4[counter];
                string a = naskah[counter];
                soal.Text = a.ToString();
            }
        }
    }
}

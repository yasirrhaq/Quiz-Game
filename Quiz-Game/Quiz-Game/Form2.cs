﻿using System;
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
         static int counter = 1;
        string[] naskah = new string[] 
        { "siapa ayah hamo?", "kenapa dipanggil hamo ?" , "apa itu hamo?"};
=======
         static int counter;
        string []naskah = new string[] { "siapa ayah hamo?", "kenapa dipanggil hamo ?" , "apa itu hamo?"};
>>>>>>> f1e18b3a3fa1ead46ffa78ded3db6c124000fc5f





        public Form2()
        {

            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = naskah[counter];
            counter = counter + 1;
            soal.Text = a.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = naskah[counter];
            counter = counter + 1;
            soal.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = naskah[counter];
            counter = counter + 1;
            soal.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = naskah[counter];
            counter = counter + 1;
            soal.Text = a.ToString();

        }
    }
}

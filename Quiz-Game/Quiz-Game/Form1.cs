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
    public partial class Form1 : Form
    {
        public static string username = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Masukkan Nama Terlebih Dahulu!");
            }
            else
            {
                username = textBox1.Text;
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
        }

        private void buttonHighscore_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terimakasih sudah memainkan Quiz Game !");
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz Game"+"\nTerdiri dari 10 Soal acak"+"\nUser harus memilih jawaban yang benar"+"\nBenar nilai +10 dan Salah +0");
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            this.Hide();
            f5.Show();
        }
    }
}

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
                Form2 f2 = new Form2();
                f2.FormClosed += new FormClosedEventHandler(formClosed);
                this.Hide();
                f2.Show();
            }
        }

        private void formClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHighscore_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terimakasih sudah memainkan Quiz Game !");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

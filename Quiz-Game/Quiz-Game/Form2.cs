using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Game
{
    public partial class Form2 : Form
    {
        public MySqlConnection myCon;
        int counter = 0;
        string[] naskah, jawaban, option1, option2, option3, option4,mapel;
        string[] jenisMapel = {"sejarah","matematika","biologi","kimia","fisika"};
        int banyakRow = 10;
        public int counterBiologi, counterFisika, counterSejarah, counterMatematika, counterKimia;
        public static int nilai=0;
        Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            string conStr = "datasource=sql12.freemysqlhosting.net; port=3306; username=sql12259336; password=K2cckElyBj;database=sql12259336;SslMode=none";
            myCon = new MySqlConnection(conStr);
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            naskah = new string[banyakRow];
            option1 = new string[banyakRow];
            option2 = new string[banyakRow];
            option3 = new string[banyakRow];
            option4 = new string[banyakRow];
            jawaban = new string[banyakRow];
            mapel = new string[banyakRow];
            MySqlDataReader myReader;

            int i = 0;

            myCon.Open();
            for (int j = 0; j < jenisMapel.Length; j++)
            {
                string query = "SELECT * FROM soal where mapel='" + jenisMapel[j] + "' ORDER BY RAND()LIMIT 2";
                MySqlCommand myCommand = new MySqlCommand(query, myCon);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    naskah[i] = myReader[1].ToString();
                    option1[i] = myReader[2].ToString();
                    option2[i] = myReader[3].ToString();
                    option3[i] = myReader[4].ToString();
                    option4[i] = myReader[5].ToString();
                    jawaban[i] = myReader[6].ToString();
                    mapel[i] = myReader[7].ToString();
                    i++;
                }
                myReader.Close();
            }
            myCon.Close();
            soal.Text = (counter + 1) + ". " + naskah[counter];
            button1.Text = option1[counter];
            button2.Text = option2[counter];
            button3.Text = option3[counter];
            button4.Text = option4[counter];
        }

        private void newGame(object sender, EventArgs e)
        {
            this.form1.newGameToolStripMenuItem_Click(sender, e);
            this.Hide();
        }

        private void exit(object sender, EventArgs e)
        {
            this.form1.buttonExit_Click(sender, e);
        }

        private void aboutUs(object sender, EventArgs e)
        {
            this.form1.aboutUsToolStripMenuItem_Click(sender, e);
            this.Hide();
        }

        private void help(object sender, EventArgs e)
        {
            this.form1.helpToolStripMenuItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PindahSoal(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PindahSoal(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PindahSoal(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PindahSoal(button4.Text);
        }

        private void PindahSoal(string pilihan)
        {
            
            if (jawaban[counter].Equals(pilihan))
            {
                MessageBox.Show("BENAR");
            }
            else
            {
                MessageBox.Show("SALAH");
            }

            if (counter < 9)
            {
                counter++;

                soal.Text = (counter + 1) + ". " + naskah[counter];
                button1.Text = option1[counter];
                button2.Text = option2[counter];
                button3.Text = option3[counter];
                button4.Text = option4[counter];
            }
            else
            {
                Form f4 = new Form4(form1);
                this.Hide();
                f4.Show();
            }
        }
    }
}
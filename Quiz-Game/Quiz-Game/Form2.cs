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
        string[] naskah;
        string[] option1;
        string[] option2;
        string[] option3;
        string[] option4;
        string[] jawaban;
        int banyakRow = 0;

        public Form2()
        {
            InitializeComponent();
            string conStr = "datasource=sql12.freemysqlhosting.net; port=3306; username=sql12259336; password=K2cckElyBj;database=sql12259336;SslMode=none";
            myCon = new MySqlConnection(conStr);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MySqlDataReader myReader;
            try
            {
                myCon.Open();
                MySqlCommand myCommand = new MySqlCommand("select* from soal", myCon);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    banyakRow++;
                }

                naskah = new string[banyakRow];
                option1 = new string[banyakRow];
                option2 = new string[banyakRow];
                option3 = new string[banyakRow];
                option4 = new string[banyakRow];
                jawaban = new string[banyakRow];
                myReader.Close();

                myReader = myCommand.ExecuteReader();
                int i = 0;
                while (myReader.Read())
                {
                    naskah[i] = myReader[1].ToString();
                    option1[i] = myReader[2].ToString();
                    option2[i] = myReader[3].ToString();
                    option3[i] = myReader[4].ToString();
                    option4[i] = myReader[5].ToString();
                    jawaban[i] = myReader[6].ToString();
                    i++;
                }

                myReader.Close();
                myCon.Close();

                soal.Text = naskah[counter];
                button1.Text = option1[counter];
                button2.Text = option2[counter];
                button3.Text = option3[counter];
                button4.Text = option4[counter];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PindahSoal(button1.Text);
            string a = naskah[counter];
            counter = counter + 1;
            soal.Text = a.ToString();
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
                MessageBox.Show("salah");
            }

            if (counter < banyakRow - 1)
            {
                counter++;
            }
               
            soal.Text = naskah[counter];
            button1.Text = option1[counter];
            button2.Text = option2[counter];
            button3.Text = option3[counter];
            button4.Text = option4[counter];
        }
    }
}
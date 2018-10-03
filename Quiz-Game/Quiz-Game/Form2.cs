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
        string[] mapel;
        bool[] sudahMuncul;
        int banyakRow = 0;
        int counterBiologi, counterFisika, counterSejarah, counterMatematika,counterKimia;
        static Random rnd = new Random();
        int random;
        public static int nilai=0;

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
                random = rnd.Next(banyakRow);

                naskah = new string[banyakRow];
                option1 = new string[banyakRow];
                option2 = new string[banyakRow];
                option3 = new string[banyakRow];
                option4 = new string[banyakRow];
                jawaban = new string[banyakRow];
                mapel = new string[banyakRow];
                sudahMuncul=new bool[banyakRow];
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
                    mapel[i]= myReader[7].ToString();
                    sudahMuncul[i] = false;
                    i++;
                }
                myReader.Close();
                myCon.Close();
                soal.Text = (counter + 1) + ". " + naskah[random];
                hitungCounter(random);
                button1.Text = option1[random];
                button2.Text = option2[random];
                button3.Text = option3[random];
                button4.Text = option4[random];
                sudahMuncul[random] = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            
            if (jawaban[random].Equals(pilihan))
            {
                MessageBox.Show("BENAR");
                nilai = nilai + 10;
            }
            else
            {
                MessageBox.Show("SALAH");
            }

            if (counter < 9)
            {
                counter++;

                while (sudahMuncul[random])
                {
                    random = rnd.Next(banyakRow);
                }
                soal.Text = (counter + 1) + ". " + naskah[random];
                hitungCounter(random);
                button1.Text = option1[random];
                button2.Text = option2[random];
                button3.Text = option3[random];
                button4.Text = option4[random];
                sudahMuncul[random] = true;
            }
            else
            {
                Form f3 = new Form3();
                this.Hide();
                f3.Show();
            }
        }
        //hitung counter per soal
        private void hitungCounter(int cek)
        {
            if (mapel[cek].ToString().Equals("kimia"))
            {
                counterKimia++;
            }
            else if (mapel[cek].ToString().Equals("matematika"))
            {
                counterMatematika++;
            }
            else if (mapel[cek].ToString().Equals("sejarah"))
            {
                counterSejarah++;
            }
            else if (mapel[cek].ToString().Equals("biologi"))
            {
                counterBiologi++;
            }
            else if (mapel[cek].ToString().Equals("fisika"))
            {
                counterFisika++;
            }
            label1.Text = "b" + counterBiologi + " f" + counterFisika + " k" + counterKimia
    + " M" + counterMatematika + " s" + counterSejarah;
        }
    }
}
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
        static int counter = 1;
        string[] naskah = new string[] 
        { "siapa ayah hamo?", "kenapa dipanggil hamo ?" , "apa itu hamo?"};


        public MySqlConnection myCon;


        public Form2()
        {

            InitializeComponent();

            string conStr = "datasource=localhost; port=3306; username=root; password=12345;database=ppk;SslMode=none";
            myCon = new MySqlConnection(conStr);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string query = "select*from soal";
            MySqlDataReader myReader; 

            try
            {
                myCon.Open();
                MySqlCommand myCommand = new MySqlCommand(query, myCon);

                myReader = myCommand.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while(myReader.Read())
                {
                    sb.Append("soal : "+myReader[1]);
                }

                myReader.Close();
                myCon.Close();
                MessageBox.Show(sb.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();
                MessageBox.Show("koneksi berhasil");
                myCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

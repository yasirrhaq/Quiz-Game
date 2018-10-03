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
    public partial class Form3 : Form
    {
        public MySqlConnection myCon;
        string[] dataUsername = new string[5];
        int[] dataNilai=new int[5];

        public Form3()
        {
            InitializeComponent();
            string conStr = "datasource=sql12.freemysqlhosting.net; port=3306; username=sql12259336; password=K2cckElyBj;database=sql12259336;SslMode=none";
            myCon = new MySqlConnection(conStr);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            myCon.Open();
            string query = "SELECT * FROM player ORDER BY nilai DESC LIMIT 5";
            MySqlCommand myCommand = new MySqlCommand(query, myCon);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            for (int i = 0; myReader.Read(); i++)
            {
                dataUsername[i] = myReader[1].ToString();
                dataNilai[i] =Convert.ToInt16(myReader[2]);
            }
            myReader.Close();
            myCon.Close();
            player1.Text = dataUsername[0];
            player2.Text = dataUsername[1];
            player3.Text = dataUsername[2];
            player4.Text = dataUsername[3];
            player5.Text = dataUsername[4];

            nilai1.Text = dataNilai[0].ToString();
            nilai2.Text = dataNilai[1].ToString();
            nilai3.Text = dataNilai[2].ToString();
            nilai4.Text = dataNilai[3].ToString();
            nilai5.Text = dataNilai[4].ToString();
        }
        
    }
}

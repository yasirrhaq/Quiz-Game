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
    public partial class Form4 : Form
    {

        Form1 form1
        private MySqlConnection myCon;
        public Form4()
        {

            InitializeComponent();
            string conStr = "datasource=sql12.freemysqlhosting.net; port=3306; username=sql12259336; password=K2cckElyBj;database=sql12259336;SslMode=none";
            myCon = new MySqlConnection(conStr);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            nilaiBio.Text = Form2.counterBiologi.ToString() + " / 2";
            nilaiPhysics.Text = Form2.counterFisika.ToString() + " / 2";
            nilaiMath.Text = Form2.counterMatematika.ToString() + " / 2";
            nilaiHistory.Text = Form2.counterSejarah.ToString() + " / 2";
            nilaiChemistry.Text = Form2.counterKimia.ToString() + " / 2";
            total.Text = (Form2.counterBiologi + Form2.counterFisika + Form2.counterMatematika + Form2.counterSejarah + Form2.counterKimia).ToString() + " / 10";
            try
            {
                myCon.Open();
                string query = "insert into player(username,nilai) values ('"+Form1.username.ToString()+ "','"  + total.Text+ "')";
                MySqlCommand myCommand = new MySqlCommand(query, myCon);
                myCommand.ExecuteNonQuery();
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
        string[] dataUsername = new string[3];
        int[] dataNilai=new int[3];
        Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            string conStr = "datasource=sql12.freemysqlhosting.net; port=3306; username=sql12259336; password=K2cckElyBj;database=sql12259336;SslMode=none";
            myCon = new MySqlConnection(conStr);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PLAYER where order by nilai desc LIMIT 2";
            MySqlCommand myCommand = new MySqlCommand(query, myCon);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            for (int i = 0; myReader.Read(); i++)
            {
                dataUsername[i] = myReader[1].ToString();
                dataNilai[i] = Convert.ToInt16(myReader[1]);
            }
        }
    }
}
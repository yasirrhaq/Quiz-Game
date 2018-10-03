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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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
    }
}

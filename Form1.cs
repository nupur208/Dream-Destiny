using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Destiny
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void cONTACTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Toll Free 1800 41 99099
Monday - Saturday(9:00AM to 7:00PM IST)
Email: feedback@dreamdestiny.com");
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Dream Destiny
With the ever-evolving online search behaviour, dreamdestiny.com shares updated information 
pertinent to real estate activities,assisting prospective buyers to make informed buying decision. 

We make online property search easier, quicker and smarter!");
        }

        private void fEEDBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback f = new feedback();
            f.ShowDialog();
            this.Close();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDPROPERTYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
            login l= new login();
            l.ShowDialog();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dream_Destiny
{
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
           h.ShowDialog();
            this.Close();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void feedback_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\aasth\source\repos\Dream Destiny\Dream Destiny\dreamdestiny.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Feedback values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thank you for the valuable feedback");
            feedback NewForm = new feedback();
            NewForm.Show();
            this.Dispose(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

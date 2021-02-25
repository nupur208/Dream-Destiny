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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aasth\source\repos\Dream Destiny\Dream Destiny\dreamdestiny.mdf;Integrated Security=True");

        public login()
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
                return;
            }
            con.Open();
            //string query=;
            SqlDataAdapter sdt = new SqlDataAdapter("select count(*) from Logindetails where Email_Address = '" + textBox1.Text + "'  and Password = '" + textBox5.Text + "' ", con);
            DataTable dt = new DataTable();
            sdt.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") 
            {
                this.Hide();
                Dashboard d = new Dashboard();
                d.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter correct details \n Email address or Password wrong");
                textBox1.Clear();
                textBox5.Clear();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.ShowDialog();
            this.Close();
        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void login_Load(object sender, EventArgs e)
        {
            flowLayoutPanel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            flowLayoutPanel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            label8.BackColor = Color.FromArgb(100, 0, 0, 0);
            label7.BackColor = Color.FromArgb(100, 0, 0, 0);
            label4.BackColor = Color.FromArgb(100, 0, 0, 0);
            checkBox2.BackColor = Color.FromArgb(100, 0, 0, 0);
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
            label5.BackColor = Color.FromArgb(100, 0, 0, 0);
            label9.BackColor = Color.FromArgb(100, 0, 0, 0);
            button1.Enabled = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into logindetails values ('" + textBox4.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(@"Registered successfully
Now Login into your account.");
            textBox4.Clear();
            textBox3.Clear();
            checkBox2.Checked = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel2.Text == "Show")
            {
                textBox5.PasswordChar = '\0';
                linkLabel2.Text = "Hide";
            }
            else
            {
                textBox5.PasswordChar = '*';
                linkLabel2.Text = "Show";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Show")
            {
                textBox3.PasswordChar = '\0';
                linkLabel1.Text = "Hide";
            }
            else
            {
                textBox3.PasswordChar = '*';
                linkLabel1.Text = "Show";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
        }
    }
}

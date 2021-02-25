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
using System.IO;

namespace Dream_Destiny
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aasth\source\repos\Dream Destiny\Dream Destiny\dreamdestiny.mdf;Integrated Security=True");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buyerdetails b1 = new buyerdetails();
            b1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sell s = new sell();
            s.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Propertylist p= new Propertylist();
            p.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            feedback f = new feedback();
            f.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].Name = "PropertyId";
            dataGridView1.Columns[0].HeaderText = "Property Id";
            dataGridView1.Columns[0].DataPropertyName = "PropertyId";

            dataGridView1.Columns[1].Name = "Seller_Name";
            dataGridView1.Columns[1].HeaderText = "Seller Name";
            dataGridView1.Columns[1].DataPropertyName = "Seller_Name";

            dataGridView1.Columns[2].Name = "Mobile_Number";
            dataGridView1.Columns[2].HeaderText = "Mobile Number";
            dataGridView1.Columns[02].DataPropertyName = "Mobile_Number";

            dataGridView1.Columns[3].Name = "Property_Type";
            dataGridView1.Columns[3].HeaderText = "Property Type";
            dataGridView1.Columns[3].DataPropertyName = "Property_Type";

            dataGridView1.Columns[4].Name = "Address";
            dataGridView1.Columns[4].HeaderText = "Address";
            dataGridView1.Columns[4].DataPropertyName = "Address";

            dataGridView1.Columns[5].Name = "City";
            dataGridView1.Columns[5].HeaderText = "City";
            dataGridView1.Columns[5].DataPropertyName = "City";

            dataGridView1.Columns[6].Name = "Selling_Price";
            dataGridView1.Columns[6].HeaderText = "Price";
            dataGridView1.Columns[6].DataPropertyName = "Selling_Price";

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";
            imageColumn.DataPropertyName = "Data";
            imageColumn.HeaderText = "Picture";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Insert(7, imageColumn);
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Columns[7].Width = 100;

        }

        private void BindDataGridView()
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aasth\source\repos\Dream Destiny\Dream Destiny\dreamdestiny.mdf;Integrated Security=True";
            string query = "select PropertyId,Seller_Name,Mobile_Number,Property_Type,Address,City,Selling_Price,Picture from Propertydetails where City = '" + textBox1.Text + "'";
            using (SqlConnection conn = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dt.Columns.Add("Data", Type.GetType("System.Byte[]"));

                    foreach (DataRow row in dt.Rows)
                    {
                        row["Data"] = File.ReadAllBytes(row["Picture"].ToString());
                    }

                    dataGridView1.DataSource = dt;
                    dataGridView1.Visible = true;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buyerdetails b1 = new buyerdetails();
            int row = dataGridView1.CurrentRow.Index;
            
            b1.textBox6.Text = Convert.ToString(dataGridView1[0, row].Value);
            b1.ShowDialog();
        }
    }
}

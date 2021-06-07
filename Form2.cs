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
using System.IO;

namespace Project
{
    public partial class Form2 : Form
    {
        string userid = Program.userid;
        string table;
        public int sum = 0;
        private MySqlConnection databaseConnection()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=pro;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        
        
        private void showproduct(string sqlsent)
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM product";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }
        
       
        

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataproduct.DataSource = null;
            showproduct("SELECT * FROM product ");
            table = "product";
            
        }

        private void addbasket_Click(object sender, EventArgs e)
        {
            int selectedRow = dataproduct.CurrentCell.RowIndex;
            string addname = Convert.ToString(dataproduct.Rows[selectedRow].Cells["name"].Value);
            string addcost = Convert.ToString(dataproduct.Rows[selectedRow].Cells["ราคา"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "INSERT INTO basket ( ชื่อสินค้า,จำนวน,ราคา,รวม) VALUES ( '" + addname + "','" + numproduct.Text + "', '" + addcost + "',('" + numproduct.Text + "'* '" + addcost + "'))";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close(); 
            

            if (rows > 0)
            {
                MessageBox.Show("เพิ่มลงตะกร้าสำเร็จ");
                
                numproduct.Clear();
            }
           
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void dataproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataproduct.CurrentRow.Selected = true;
            int selectedRow = dataproduct.CurrentCell.RowIndex;
            string addname = Convert.ToString(dataproduct.Rows[selectedRow].Cells["name"].Value);
            



            MySqlConnection con = databaseConnection(); 
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT picture FROM " + table + " WHERE name = '" + addname + "'  ";


            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count > 0 )
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["picture"]);
                pictureBox1.Image = new Bitmap(ms);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }


        private void epui(string sqlsent)
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM equipment ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataproduct.DataSource = ds.Tables[0].DefaultView;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataproduct.DataSource = null;
            epui("SELECT * FROM equipment");
            table = "equipment";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void ประวตการสงซอสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            dataproduct.DataSource = null;
            showproduct("SELECT * FROM product ");
            table = "product";
        }

        private void อปกรณเบเกอรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataproduct.DataSource = null;
            epui("SELECT * FROM equipment");
            table = "equipment";
        }

        private void ออกจากโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ดสนคาในToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}

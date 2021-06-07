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
    public partial class Form4 : Form
    {
        string userid = Program.userid;
        List<Bill> allbill = new List<Bill>();
        private MySqlConnection databaseConnection()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=pro;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        

        private void summ()
        {
            if (databasket1.Rows.Count > 0)
            {
                int selected = databasket1.CurrentCell.RowIndex;
                int sum = 0;
                for (int i = 0; i < databasket1.Rows.Count; i++)
                {
                    if (databasket1.Rows[i].Cells[3].Value != null && databasket1.Rows[selected].Cells[3].Value.ToString() != "")
                    {
                        sum = sum + Convert.ToInt32(databasket1.Rows[i].Cells[3].Value.ToString());

                    }

                }
                textBox1.Text = Convert.ToString(sum);

            }

        }
        public Form4()
        {
            InitializeComponent();
        }
        private void kidd()
        {
            MySqlConnection conn = databaseConnection();
            MySqlCommand bnn = new MySqlCommand("SELECT * FROM basket ", conn);
            conn.Open();
            MySqlDataReader adapter = bnn.ExecuteReader();
            while (adapter.Read())
            {
               
                Program.name = adapter.GetString("ชื่อสินค้า").ToString();
                Program.cost = adapter.GetString("ราคา").ToString();
                Program.num = adapter.GetString("จำนวน").ToString();
                Program.sumd = adapter.GetString("รวม").ToString();
                Bill item = new Bill()
                {
                    name = Program.name,
                    cost = Program.cost,
                    num = Program.num,
                    sumd = Program.sumd,
                };
                allbill.Add(item);
            }
            conn.Close();
        }
        private void showbasket()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM basket  ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            databasket1.DataSource = ds.Tables[0].DefaultView;

        }



        private void edit_Click(object sender, EventArgs e)
        {
            int selected = databasket1.CurrentCell.RowIndex;

            string edit = Convert.ToString(databasket1.Rows[selected].Cells["ชื่อสินค้า"].Value);
            string addcost = Convert.ToString(databasket1.Rows[selected].Cells["ราคา"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "UPDATE basket SET จำนวน = '" + numproduct.Text + "' ,รวม =  ('" + numproduct.Text + "' * '" + addcost + "') WHERE ชื่อสินค้า = '" + edit + "'";


            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("แก้ไขจำนวนสินค้าสำเร็จ");
                showbasket();
                
                summ();
                
                numproduct.Clear();
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int selectedRow = databasket1.CurrentCell.RowIndex;
            string delete = Convert.ToString(databasket1.Rows[selectedRow].Cells["ชื่อสินค้า"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "DELETE FROM basket WHERE ชื่อสินค้า = '" + delete + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบรายการสินค้าสำเร็จ");
                showbasket();
                
                summ();
                
            }
            
        }



        private void order_Click(object sender, EventArgs e)
        {

            
            if (textBox2.Text == "")
            {
                MessageBox.Show("กรุณาใส่จำนวนเงิน");
            }
            else

            {
                if (databasket1.Rows.Count > 0)
                {
                    int selected = databasket1.CurrentCell.RowIndex;
                    int sum = 0;
                    for (int i = 0; i < databasket1.Rows.Count; i++)
                    {
                        if (databasket1.Rows[i].Cells[3].Value != null && databasket1.Rows[selected].Cells[3].Value.ToString() != "")
                        {
                            sum = sum + Convert.ToInt32(databasket1.Rows[i].Cells[3].Value.ToString());

                        }

                    }
                    textBox1.Text = Convert.ToString(sum);

                    
                    double money = double.Parse(textBox2.Text);
                    if (money >= sum)
                    {
                        kidd();
                        textBox3.Text = Convert.ToString(money - sum);
                        MySqlConnection conn = databaseConnection();
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT * FROM basket ";
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {

                                MySqlConnection conn2 = databaseConnection();
                                conn2.Open();

                                string sql = $"INSERT INTO `order` (userid,ชื่อสินค้า,ราคา,จำนวน,รวม	) VALUES (\"{userid}\",\"{dr.GetValue(0).ToString()}\",\"{dr.GetValue(1).ToString()}\",\"{dr.GetValue(2).ToString()}\",\"{dr.GetValue(3).ToString()}\")";
                                MySqlCommand cmd2 = new MySqlCommand(sql, conn2);
                                cmd2.ExecuteNonQuery();

                            }


                            MessageBox.Show("สั่งสินค้าสำเร็จ");
                            MySqlConnection conn3 = databaseConnection();
                            conn3.Open();
                            MySqlCommand cmd3 = conn3.CreateCommand();
                            cmd3.CommandText = "TRUNCATE TABLE basket";
                            cmd3.ExecuteNonQuery();
                            showbasket();
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            allbill.Clear();
                        }

                    }
                    else if (money < sum)
                    {
                        MessageBox.Show("จำนวนเงินไม่พอ");
                    }


                }
                
            }
            



        }


        private void showhit()
        {

            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `order` WHERE userid = '" + userid + "'   ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            databasket1.DataSource = ds.Tables[0].DefaultView;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }



        private void Form4_Load(object sender, EventArgs e)
        {   
            allbill.Clear();

            showbasket();
            
            summ();
            
            


        }


        private void ยอนกลบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void ประวตการสงซอสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void ออกจากโปรแกรมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ///List<Bill>= new List<Bill>();
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                e.Graphics.DrawString("ใบเสร็จ", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(400, 50));
                e.Graphics.DrawString("ปังหลายรสอุปกรณ์เบเกอรี่", new Font("FC Muffin", 24, FontStyle.Bold), Brushes.Black, new Point(300, 90));
                e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
                e.Graphics.DrawString("ข้อมูลร้าน : FBปังหลายรสอุปกรณ์เบเกอรี่ 0981195361", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 150));
                e.Graphics.DrawString("       จำหน่ายอุปกรณ์และวัตถุดิบเบเกอรี่ครบวงจร ในราคาประหยัดเครื่องครัวทำขนมคุณภาพ  ", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 195));
                e.Graphics.DrawString("       วัสดุแข็งแรงทนทาน ใช้งานง่าย กระจายความร้อนได้ดี อบสนุกได้ทุกเมนู ", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 240));

                e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 285));
                e.Graphics.DrawString("    ลำดับ          ชื่อเมนู                  ราคา(ชิ้น)          จำนวน          ราคา (บาท)", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 315));
                e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, 345));
                int number = 1;
                int y = 345;
                foreach (var i in allbill)
                {
                    y = y + 35;
                    e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                    e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(190, y));
                    e.Graphics.DrawString("   " + i.cost, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(365, y));
                    e.Graphics.DrawString("   " + i.num, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                    e.Graphics.DrawString("   " + i.sumd, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(600, y));

                    number = number + 1;
                }

                e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
                e.Graphics.DrawString("รวมทั้งสิ้น         " + textBox1.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, (y + 30) + 45));
                e.Graphics.DrawString("ชื่อผู้ให้บริการ    " + Program.userid.ToString(), new Font("DB Helvethaica X v3.2", 16, FontStyle.Bold), Brushes.Black, new Point(80, (y + 30) + 45));
                e.Graphics.DrawString("รับเงิน            " + textBox2.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, ((y + 30) + 45) + 45));
                e.Graphics.DrawString("เงินทอน           " + textBox3.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, (((y + 30) + 45) + 45) + 45));
                e.Graphics.DrawString("       ร้านปังหลายรสอุปกรณ์เบเกอรี่       ", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(290, ((((y + 30) + 45) + 45) + 45) + 45));
                e.Graphics.DrawString("           ขอบคุณที่ใช้บริการ      ", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(290, (((((y + 30) + 45) + 45) + 45) + 45) + 45));

            }
        }

        private void ตะกราสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

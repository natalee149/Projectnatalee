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
namespace Project
{
    public partial class Form3 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = " datasource=127.0.0.1;port=3306;username=root;password=;database=pro;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form3()
        {
            InitializeComponent();
        }

        

        private void bot1_Click(object sender, EventArgs e)
        {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM user WHERE user =\"{userl.Text}\"";

                MySqlDataReader row = cmd.ExecuteReader();
            if (name.Text == "")
            {
                MessageBox.Show("กรุณากรอกชื่อและนามสกุล");
            }
            else
            {
                if (tell.Text == "")
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์");
                }
                else
                {
                    if (userl.Text == "")
                    {
                        MessageBox.Show("กรุณากรอกชื่อผู้ใช้งาน");
                    }
                    else
                    {
                        if (passl.Text == "")
                        {
                            MessageBox.Show("กรุณากรอกรหัสผ่าน");
                        }
                        else
                        {
                            if (row.HasRows)
                            {

                                MessageBox.Show("ชื่อผู้ใช้นี้มีบัญชีแล้ว");
                                userl.Clear();
                                passl.Clear();
                            }
                            else
                            {
                                int a;
                                if (int.TryParse(tell.Text, out a) && tell.Text.Length > 9)
                                {
                                    log();

                                }
                                else
                                {
                                    MessageBox.Show("เบอร์โทรศัพท์ไม่ถูกต้อง");
                                    tell.Clear();

                                }


                            }
                        }

                    }
                }
            }
        }

        private void log()
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO user (name,user,pass,Phonnumber) VALUES('" + name.Text + "','" + userl.Text + "','" + passl.Text + "','" + tell.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("สมัครสมาชิกเรียบร้อยค่ะ");
                name.Clear();
                userl.Clear();
                passl.Clear();
                tell.Clear();

            }
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void userl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1 )
            {
                
                e.Handled = true;
            }

        }

        private void tell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1&& tell.Text.Length>9)
            {
               
                e.Handled = true;               
            }
        }

        private void passl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }

        }


    }
}

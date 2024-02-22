using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using Mysqlx.Notice;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banking_System
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, fname, nic, pnum, accno, acctype, add;


            name = textBox1.Text;
            fname = textBox2.Text;
            nic = textBox3.Text;
            pnum = textBox6.Text;
            add = textBox4.Text;
            accno = textBox5.Text;
            acctype = comboBox1.Text;
            string connect = "Server=127.0.0.1;Database=bank;username=root;Password=";
            MySqlConnection connection = new MySqlConnection(connect);

            try
            {


                connection.Open();
                MessageBox.Show("Record successfully updated");
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO account (name, firstname,nic,phonenumber,address) VALUES (@name, @firstname,@nic,@phonenumber,@address)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@firstname", fname);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@phonenumber", pnum);
                cmd.Parameters.AddWithValue("@address", add);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;


        }
    }
}

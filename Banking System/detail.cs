using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            //private void click(object sender, MouseEventArgs e)
            {
                dataGridView1.Rows.Add(5.09, 2300);
                dataGridView1.Rows.Add(7.01, 3500);
                dataGridView1.Rows.Add(8.11, 2500);
            }

        }

        // private void Detail_Load(object sender, EventArgs e)



    }
}

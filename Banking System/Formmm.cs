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
    public partial class Formmm : Form
    {
        public Formmm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account frm = new Account();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detail detail = new Detail();
            detail.Show();

        }
    }
}

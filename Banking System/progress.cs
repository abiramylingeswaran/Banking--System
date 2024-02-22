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
    public partial class progress : Form
    {
        public progress()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value >= 99)
            {
                Formmm from = new Formmm();
                this.Hide();
                from.Show();

                timer1.Enabled = false;
                progressBar1.Value = progressBar1.Value - 1;

            }

        }

        // private void progress_Load(object sender, EventArgs e)



    }
}

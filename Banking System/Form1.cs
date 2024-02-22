namespace Banking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = string.Empty;
            txt2.Text = string.Empty;
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txt1.Text;
            password = txt2.Text;
            if (username == "" && password == "")
            {
                label3.Text = "enter username, password";
            }
            else
            {

                if (username == "abiramy" && password == "555")
                {
                    label3.Text = "sucssfully login";
                    progress pr = new progress();
                    this.Hide();
                    pr.Show();

                }
                else
                {
                    label3.Text = "invaild username";

                }

            }

        }

        private void Timer1(object sender, EventArgs e)
        {
            label3.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

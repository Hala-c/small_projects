using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace dotNet_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-CCUAH460;Initial Catalog=loginapp;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT (*) FROM login WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@password", textBox2.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("error in login");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }
    }
}

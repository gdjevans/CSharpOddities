using System.Data;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=SUMMER_MASH\SQLEXPRESS;Initial Catalog=userLogin;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string query = "select * from logins where username = '" + textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlConn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                frmLoggedIn frmLogin = new frmLoggedIn();
                this.Hide();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("please check your username and password");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

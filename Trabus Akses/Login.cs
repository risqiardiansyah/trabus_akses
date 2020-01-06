using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trabus_Akses
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True";
            con.Open();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            SqlCommand cmd = new SqlCommand("SELECT * FROM admin WHERE username='" + username + "' AND password='" + password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["jenis_admin"].ToString() == "admin")
                {
                    //redirect halaman admin
                    NavAdmin adm = new NavAdmin();
                    adm.Show();
                    this.Hide();
                    con.Close();
                }
                else if (dt.Rows[0]["jenis_admin"].ToString() == "petugas")
                {
                    Form1 halaman_utama = new Form1();
                    halaman_utama.Show();
                    this.Hide();
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Gagal Login !!");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class KonfirmasiPemesanan : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public KonfirmasiPemesanan(String id_bus)
        {
            InitializeComponent();
            label13.Enabled = false;
            label13.Text = id_bus;
        }

        private void buttonLanjut_Click(object sender, EventArgs e)
        {
            Insert();
        }

        public void Insert()
        {
            RandomGenerator gen = new RandomGenerator();
            string kode = gen.RandomIntStr();
            if (textBoxNama.Text != "" && textBoxHp.Text != "" && textBoxEmail.Text != "" && textBoxNoIden.Text != "" && richTextBoxAlamat.Text != "")
            {
                cmd = new SqlCommand("insert into data_pemesanan(id_bus,nama_pemesan,nomor_identitas,nomor_hp,email,alamat,kode_pemesanan,status_pemesanan) values(@id_bus,@nama,@noiden,@nohp,@email,@alamat,@kode,@status)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id_bus", label13.Text);
                cmd.Parameters.AddWithValue("@nama", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@noiden", textBoxNoIden.Text);
                cmd.Parameters.AddWithValue("@nohp", textBoxHp.Text);
                cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@alamat", richTextBoxAlamat.Text);
                cmd.Parameters.AddWithValue("@kode", kode);
                cmd.Parameters.AddWithValue("@status", "dipesan");
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pemesanan Berhasil !!!");
                PemesananSelesai sls = new PemesananSelesai(kode);
                sls.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Isi Semua Form!");
            }
        }

        public class RandomGenerator
        {
            // Generate a random number between two numbers    
            public int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            // Generate a random string with a given size    
            public string RandomString(int size, bool lowerCase)
            {
                StringBuilder builder = new StringBuilder();
                Random random = new Random();
                char ch;
                for (int i = 0; i < size; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    builder.Append(ch);
                }
                if (lowerCase)
                    return builder.ToString().ToLower();
                return builder.ToString();
            }

            // Generate a random password    
            public string RandomIntStr()
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(RandomString(4, true));
                builder.Append(RandomNumber(1000, 9999));
                builder.Append(RandomString(2, false));
                return builder.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from daftar_bus where id_bus='"+ label13.Text +"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            string asal = dt.Rows[0]["asal"].ToString();
            string tujuan = dt.Rows[0]["tujuan"].ToString();
            string harga = dt.Rows[0]["harga"].ToString();
            string berangkat = dt.Rows[0]["tgl_keberangkatan"].ToString();
            string jam = dt.Rows[0]["jam_keberangkatan"].ToString();

            labelJurusan.Text = "Jurusan : "+ asal + " - " + tujuan;
            labelHarga.Text = "Harga : "+ harga;
            labelBerangkat.Text = "Berangkat Pada : "+ berangkat;
            labelJam.Text = "Jam Keberangkatan : " + jam;
        }

        private void KonfirmasiPemesanan_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void textBoxHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNoIden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }    
    }
}

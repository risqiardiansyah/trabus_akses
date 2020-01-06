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
    public partial class FormBus : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public FormBus()
        {
            InitializeComponent();
            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            DisplayDataCari();
        }
        private void DisplayData()
        {
            String bus = "bus";
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from daftar_bus where jenis='"+ bus +"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DisplayDataCari()
        {
            String tgl = dateTimePicker1.Text;
            String asal = textBoxAsal.Text;
            String tujuan = textBoxTujuan.Text;
            String bus = "bus";

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select id_bus,nama_bus,asal,tujuan,jml_kursi,tgl_keberangkatan,jam_keberangkatan,jenis from daftar_bus where asal = '"+ asal +"' AND tujuan = '"+ tujuan +"' AND jenis = '"+ bus +"'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String id_bus = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            KonfirmasiPemesanan konfirm = new KonfirmasiPemesanan(id_bus);
            konfirm.Show();
            this.Hide();
        }

        private void buttonSemua_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}

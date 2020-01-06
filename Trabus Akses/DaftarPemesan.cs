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
    public partial class DaftarPemesan : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True");
        private DataSet ds;
        public DaftarPemesan()
        {
            InitializeComponent();
            DisplayData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxIdCari.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxKode.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("SELECT data_pemesanan.*,daftar_bus.* FROM daftar_bus INNER JOIN data_pemesanan ON daftar_bus.id_bus=data_pemesanan.id_bus", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        public void ClearData()
        {
            textBoxId.Text = "";
            textBoxIdCari.Text = "";
            textBoxNama.Text = "";
        }

        private void buttonHapusId_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Anda Yakin Ingin Menghapus Data Ini??", "Hapus Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd1 = new SqlCommand("delete data_pemesanan where id_pemesanan=@id", con);
                    con.Open();
                    cmd1.Parameters.AddWithValue("@id", textBoxId.Text);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Dihapus!");
                    DisplayData();
                    ClearData();
                }
                else if (dialogResult == DialogResult.No)
                {
                    con.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Pilih Data Untuk Dihapus");
                    con.Close();
                }
            }
        }

        private void buttonHapusNama_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Anda Yakin Ingin Menghapus Data Ini??", "Hapus Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd1 = new SqlCommand("delete data_pemesanan where id_bus=@id", con);
                    con.Open();
                    cmd1.Parameters.AddWithValue("@id", textBoxNama.Text);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Dihapus!");
                    DisplayData();
                    ClearData();
                }
                else if (dialogResult == DialogResult.No)
                {
                    con.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Pilih Data Untuk Dihapus");
                    con.Close();
                }
            }
        }

        private void buttonCariId_Click(object sender, EventArgs e)
        {
            string id = textBoxIdCari.Text;
            string constr = "Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM data_pemesanan where id_pemesanan='"+ id +"'";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "data_pemesanan");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "data_pemesanan";
            dataGridView1.Refresh();
            conn.Close();
        }

        private void buttonCariJam_Click(object sender, EventArgs e)
        {
            string jam = comboBoxJam.Text;
            string menit = comboBoxMenit.Text;
            string constr = "Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT data_pemesanan.*,daftar_bus.* FROM daftar_bus INNER JOIN data_pemesanan ON daftar_bus.id_bus=data_pemesanan.id_bus WHERE jam_keberangkatan= '" + jam + ":" + menit + "'";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "data_pemesanan");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "data_pemesanan";
            dataGridView1.Refresh();
            conn.Close();
        }

        private void buttonSemua_Click(object sender, EventArgs e)
        {
            DisplayData();
            ClearData();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string kode = textBoxKode.Text;
            PemesananSelesai sls = new PemesananSelesai(kode);
            sls.Show();
        }

        private void buttonCariKode_Click(object sender, EventArgs e)
        {
            string kode = textBoxKode.Text;
            string constr = "Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT data_pemesanan.*,daftar_bus.* FROM daftar_bus INNER JOIN data_pemesanan ON daftar_bus.id_bus=data_pemesanan.id_bus WHERE kode_pemesanan = '" + kode + "'";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "data_pemesanan");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "data_pemesanan";
            dataGridView1.Refresh();
            conn.Close();
        }
    }
}

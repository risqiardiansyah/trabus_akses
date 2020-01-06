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
    public partial class DaftarTiket : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        private DataSet ds;
        public DaftarTiket()
        {
            InitializeComponent();
            DisplayData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayData()
        {
            string constr = "Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT * FROM daftar_bus";
            ds = new DataSet();
            da = new SqlDataAdapter(cmd1);
            da.Fill(ds, "daftar_bus");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "daftar_bus";
            dataGridView1.Refresh();
            conn.Close();
        }

        public void ClearData()
        {
            textBoxId.Text = "";
            textBoxNama.Text = "";
            textBoxAsal.Text = "";
            textBoxTujuan.Text = "";
            textBoxHarga.Text = "";
            textBoxJmlKursi.Text = "";
            dateTimePickerTgl.Text = "";
            comboBoxJenis.Text = "";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAsal.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTujuan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxJmlKursi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePickerTgl.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBoxJenis.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text != "" && textBoxAsal.Text != "" && textBoxTujuan.Text != "" && textBoxJmlKursi.Text != "" && textBoxHarga.Text != "" && comboBoxJenis.Text != "" && comboBoxJam.Text != "" && comboBoxMenit.Text != "" )
            {
                cmd1 = new SqlCommand("insert into daftar_bus(nama_bus,asal,tujuan,harga,jml_kursi,tgl_keberangkatan,jam_keberangkatan,jenis) values(@nama,@asal,@tujuan,@harga,@jml,@tgl,@jam,@jenis)", conn);
                conn.Open();
                cmd1.Parameters.AddWithValue("@nama", textBoxNama.Text);
                cmd1.Parameters.AddWithValue("@asal", textBoxAsal.Text);
                cmd1.Parameters.AddWithValue("@tujuan", textBoxTujuan.Text);
                cmd1.Parameters.AddWithValue("@harga", textBoxHarga.Text);
                cmd1.Parameters.AddWithValue("@jml", textBoxJmlKursi.Text);
                cmd1.Parameters.AddWithValue("@tgl", dateTimePickerTgl.Text);
                cmd1.Parameters.AddWithValue("@jam", comboBoxJam.Text+ ":" +comboBoxMenit.Text);
                cmd1.Parameters.AddWithValue("@jenis", comboBoxJenis.Text);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Disimpan");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Isi Semua Form !!");
                conn.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text != "" && textBoxAsal.Text != "" && textBoxTujuan.Text != "" && textBoxJmlKursi.Text != "" && textBoxHarga.Text != "" && comboBoxJenis.Text != "" && comboBoxJam.Text != "" && comboBoxMenit.Text != "")
            {
                cmd1 = new SqlCommand("update daftar_bus set nama_bus=@nama,asal=@asal,tujuan=@tujuan,harga=@harga,jml_kursi=@jml,tgl_keberangkatan=@tgl,jam_keberangkatan=@jam,jenis=@jenis where id_bus=@id ", conn);
                conn.Open();
                cmd1.Parameters.AddWithValue("@id", textBoxId.Text);
                cmd1.Parameters.AddWithValue("@nama", textBoxNama.Text);
                cmd1.Parameters.AddWithValue("@asal", textBoxAsal.Text);
                cmd1.Parameters.AddWithValue("@tujuan", textBoxTujuan.Text);
                cmd1.Parameters.AddWithValue("@harga", textBoxHarga.Text);
                cmd1.Parameters.AddWithValue("@jml", textBoxJmlKursi.Text);
                cmd1.Parameters.AddWithValue("@tgl", dateTimePickerTgl.Text);
                cmd1.Parameters.AddWithValue("@jam", comboBoxJam.Text + " : " + comboBoxMenit.Text);
                cmd1.Parameters.AddWithValue("@jenis", comboBoxJenis.Text);
                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Disimpan");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Isi Semua Form !!");
                conn.Close();
            }
        }

        private void textBoxHarga_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxJmlKursi_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Anda Yakin Ingin Menghapus Data Ini??", "Hapus Data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd1 = new SqlCommand("delete daftar_bus where id_bus=@id", conn);
                    conn.Open();
                    cmd1.Parameters.AddWithValue("@id", textBoxId.Text);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data Dihapus!");
                    DisplayData();
                    ClearData();
                }
                else if (dialogResult == DialogResult.No)
                {
                    conn.Close();
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Pilih Data Untuk Dihapus");
                    conn.Close();
                }
            }
        }
    }
}

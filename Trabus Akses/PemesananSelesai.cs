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
    public partial class PemesananSelesai : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-89NJATH;Initial Catalog=db_trabus_akses;Integrated Security=True");
        private DataSet ds;
        Bitmap bmp;
        public PemesananSelesai(string kode)
        {
            InitializeComponent();
            labelKode.Text = kode;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void PemesananSelesai_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("SELECT data_pemesanan.*,daftar_bus.* FROM daftar_bus INNER JOIN data_pemesanan ON daftar_bus.id_bus=data_pemesanan.id_bus WHERE kode_pemesanan='" + labelKode.Text + "'", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            labelNama.Text = dt.Rows[0]["nama_pemesan"].ToString();
            labelBus.Text = dt.Rows[0]["nama_bus"].ToString() + "(" +dt.Rows[0]["id_bus"].ToString() +")";

        }

        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics eg = Graphics.FromImage(bmp);
            eg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}

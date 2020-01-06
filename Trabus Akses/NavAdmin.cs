using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabus_Akses
{
    public partial class NavAdmin : Form
    {
        public NavAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DaftarTiket dt = new DaftarTiket();
            dt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DaftarPemesan dp = new DaftarPemesan();
            dp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}

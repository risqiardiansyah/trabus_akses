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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBus_Click(object sender, EventArgs e)
        {
            FormBus frmbus = new FormBus();
            frmbus.Show();
        }

        private void buttonTravel_Click(object sender, EventArgs e)
        {
            FormTravel frmtra = new FormTravel();
            frmtra.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}

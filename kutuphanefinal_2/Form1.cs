
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphanefinal_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }

        
        private void kisiIsemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkisi_islemleri    kisiislemleri = new frmkisi_islemleri();
            kisiislemleri.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkitapislemleri kitapIslem = new frmkitapislemleri();
            kitapIslem.Show();
        }

        private void kİTAPİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

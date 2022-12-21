using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkitapislemleri kitapislemleri = new frmkitapislemleri();
            kitapislemleri.Show();
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeslimEt frmTeslimEt= new FrmTeslimEt();
            frmTeslimEt.Show();
        }

        private void teslimVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTeslimAl  frmTeslimAl= new FrmTeslimAl();
            frmTeslimAl.Show();
        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKISILER kISILER = new FrmKISILER();
            kISILER.Show();
        }

        private void kitaplarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKITAPLAR kITAPLAR = new FrmKITAPLAR();
            kITAPLAR.Show();
        }
    }
}

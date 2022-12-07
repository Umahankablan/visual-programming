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


namespace görsel_programlama
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
      
       

        private void BtnUyeEkle_Click(object sender, EventArgs e)
        {
           UyeEkleFrm uyeEkle = new UyeEkleFrm();
            uyeEkle.ShowDialog();
        }
    }
}

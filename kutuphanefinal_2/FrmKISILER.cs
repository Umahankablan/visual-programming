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

namespace kutuphanefinal_2
{
    public partial class FrmKISILER : Form
    {
        public FrmKISILER()
        {
            InitializeComponent();
        }
        void listele()
        {
            //SqlDataAdapter da = new SqlDataAdapter("Select * from kisiler", bgl.baglanti());
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource= dt;
        }


        private void FrmKISILER_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}

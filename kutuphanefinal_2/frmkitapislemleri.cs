using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Net.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphanefinal_2
{
    public partial class frmkitapislemleri : Form
    {
        public frmkitapislemleri()
        {
            InitializeComponent();
        }
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=Dbkutuphane;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        void listele()
        {

            dt = new DataTable();
            adapter = new MySqlDataAdapter("SELECT *FROM kitaplar", mysqlbaglan);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;
            mysqlbaglan.Close();

        }


        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string sql = "insert into  kitaplar (ad,yazar,sayfa,tür,yayin_evi)" +
            "values (@p1 ,@p2,@p3,@p4,@p5)";

            cmd = new MySqlCommand(sql, mysqlbaglan);

            cmd.Parameters.AddWithValue("@p1", mskEkle_ad.Text);
            cmd.Parameters.AddWithValue("@p2", mskEkle_yazar.Text);
            cmd.Parameters.AddWithValue("@p3", Convert.ToString(mskEkleSayfa.Text));
            cmd.Parameters.AddWithValue("@p4", mskEkleTur.Text);
            cmd.Parameters.AddWithValue("@p5", mskEkleYayinEv.Text);
            mysqlbaglan.Open();
            cmd.ExecuteNonQuery();
            mysqlbaglan.Close();
            MessageBox.Show("Kitap eklendi", "Bilgi", MessageBoxButtons.OK);
            listele();
        }
        private void frmkitapislemleri_Load(object sender, EventArgs e)
        {
            try
            {
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti");
                    mysqlbaglan.Close();
                }
                else
                {
                    MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                    mysqlbaglan.Close();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mysqlbaglan.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Seçilen id değerine göre silme işlemi yapıyoruz.
            string sql = "Delete from kitaplar where id=@p1";
            cmd = new MySqlCommand(sql, mysqlbaglan);
            cmd.Parameters.AddWithValue("@p1", mskSil_id.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kitap silindi.", "Bilgi", MessageBoxButtons.OK);
            mysqlbaglan.Close();
            listele();
        }




        private void frmkitapislemleri_Load_1(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            mskSil_id.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            mskSil_ktp_ad.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            mskSil_ktp_yzr.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            mskSil_ktp_syfa.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            mskSil_ktp_turu.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            mskSil_ktp_yayn_ev.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();


            string sql = "UPDATE kitaplar " +
                "SET ad=@p1,yazar=@p2,sayfa=@p3,tür=@p4,yayin_evi=@p5" +
                " WHERE id=@p6";
            cmd = new MySqlCommand(sql, mysqlbaglan);
            cmd.Parameters.AddWithValue("@p1", mskGktp_ad.Text);
            cmd.Parameters.AddWithValue("@p2", mskG_Yazar.Text);
            cmd.Parameters.AddWithValue("@p3",  Convert.ToString(mskG_Sayfa.Text));
            cmd.Parameters.AddWithValue("@p4", mskG_turu.Text);
            cmd.Parameters.AddWithValue("@p5", mskG_yayn_evi.Text);
            cmd.Parameters.AddWithValue("@p6", mskG_id.Text);
        

            cmd.ExecuteNonQuery();
            mysqlbaglan.Close();
            MessageBox.Show("Kitab bilgileri güncellendi.");
            listele();



            mysqlbaglan.Close();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            mskG_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            mskGktp_ad.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            mskG_Yazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            mskG_Sayfa.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            mskG_turu.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            mskG_yayn_evi.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();


        }
    }
}

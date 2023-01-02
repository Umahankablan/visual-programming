using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

namespace kutuphanefinal_2
{
    public partial class frmkisi_islemleri : Form
    {
        
        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=Dbkutuphane;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public frmkisi_islemleri()
        {
            InitializeComponent();

        }



        void VeriGetir()
        {
            dt = new DataTable();
            mysqlbaglan.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM kisiler", mysqlbaglan);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView3.DataSource = dt;
            mysqlbaglan.Close();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string sql = "insert into kisiler(ad,soyad,dogum_tarih,tc,tel,mail,uye_tarih,adres)" +
            "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";

            cmd = new MySqlCommand(sql, mysqlbaglan);

            cmd.Parameters.AddWithValue("@p1", textBoxEkleAd.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxEkleSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", Convert.ToString(maskedGuncelleDogum.Text));
            cmd.Parameters.AddWithValue("@p4", Convert.ToString(maskedTextBox2.Text));
            cmd.Parameters.AddWithValue("@p5", Convert.ToString(maskedEkleTel.Text));
            cmd.Parameters.AddWithValue("@p6", textBoxEkleMail.Text);
            cmd.Parameters.AddWithValue("@p7", Convert.ToString(maskedEkleDogumTarih.Text));
            cmd.Parameters.AddWithValue("@p8", richTextBox1.Text);
            mysqlbaglan.Open();
            cmd.ExecuteNonQuery();
            mysqlbaglan.Close();
            MessageBox.Show("Kişi eklendi", "Bilgi", MessageBoxButtons.OK);
            VeriGetir();

        }

        private void frmkisi_islemleri_Load(object sender, EventArgs e)
        {
            VeriGetir();
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

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                mysqlbaglan.Open();
                string sql = "Delete From kisiler Where id=@p";
                cmd = new MySqlCommand(sql, mysqlbaglan);
                cmd.Parameters.AddWithValue("@p", textBoxDeleteId.Text);
                cmd.ExecuteNonQuery();
                mysqlbaglan.Close();
                VeriGetir();
                MessageBox.Show("Kayıt silindi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Sil işlemi sırasında hata oluştu.", "Hata", MessageBoxButtons.OK);
            }

        }

        private void buttonGuncel_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();


            string sql = "UPDATE kisiler " +
                "SET ad=@p1,soyad=@p2,dogum_tarih=@p3 , tc=@p4 , tel=@p5,mail=@p6,uye_tarih=@p7,adres=@p8" +
                " WHERE id=@p9";
            cmd = new MySqlCommand(sql, mysqlbaglan);
            
            cmd.Parameters.AddWithValue("@p1", textBoxGuncelleAd.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxGuncelleSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", Convert.ToString(maskedGuncelleDogum.Text));
            cmd.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@p5", Convert.ToString(maskedGuncelleTel.Text));
            cmd.Parameters.AddWithValue("@p6", textboxGuncelleMail.Text);
            cmd.Parameters.AddWithValue("@p7", Convert.ToString(maskedGuncelleUyeTarih.Text));
            cmd.Parameters.AddWithValue("@p8", richTextBox2.Text);
            cmd.Parameters.AddWithValue("@p9", guncelleID.Text);
            cmd.ExecuteNonQuery();
            mysqlbaglan.Close();
            MessageBox.Show("Kayıt güncellendi.");

            VeriGetir();

            mysqlbaglan.Close();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guncelleID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxGuncelleAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxGuncelleSoyad.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            maskedGuncelleDogum.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            maskedGuncelleTel.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textboxGuncelleMail.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            maskedGuncelleUyeTarih.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            richTextBox2.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxDeleteId.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

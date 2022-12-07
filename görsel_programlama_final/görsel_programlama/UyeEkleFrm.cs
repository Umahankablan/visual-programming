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
    public partial class UyeEkleFrm : Form
    {
        public UyeEkleFrm()
        {
            InitializeComponent();
        }
        
        
        SqlConnection baglanti = new SqlConnection("Data Source=KABLAN;Initial\r\n Catalog=kütüphane3;Integrated Security=True");
        private void Btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e )
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into uye(TC,ADSOYAD,YAS,CİNSİYET,TELEFON,ADRES,E-MAİL,OKUNAN_KİTAP)" +
                " values(@TC,@ADSOYAD,@YAS,@CİNSİYET,@TELEFON,@ADRES,@E-MAİL,@OKUNAN_KİTAP)", baglanti);
            komut.Parameters.AddWithValue("@TC", textTC.Text);
            komut.Parameters.AddWithValue("@ADSOYAD",textAd.Text);
            komut.Parameters.AddWithValue("@YAS", textYas.Text);
            komut.Parameters.AddWithValue("@CİNSİYET", combocinsiyet.Text);
            komut.Parameters.AddWithValue("@TELEFON", texttel.Text);
            komut.Parameters.AddWithValue("@ADRES", textadres.Text);
            komut.Parameters.AddWithValue("@E-MAİL", textmail.Text);
            komut.Parameters.AddWithValue("@OKUNAN_KİTAP", textoku.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("üye giriş işlemi başarıyla gerçekleşti");


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item!= textoku) //okunan texti temizlenmeyecek..
                    {
                        item.Text = " "; // diğer textler temizlemecek...
                    }
                }
            }



        }
    }
}

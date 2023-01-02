using MySql.Data.MySqlClient;
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
    public partial class frmLogin : Form
    {

        MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=Dbkutuphane;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            string sql = "Select * from tbl_admin where kullanici_adi=@p1 and sifre=@p2";

            cmd = new MySqlCommand(sql, mysqlbaglan);
            cmd.Parameters.AddWithValue("@p1", tbxUserName.Text);
            cmd.Parameters.AddWithValue("@p2", tbxPassword.Text);
            try
            {

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    Form1 fr1 = new Form1();
                    fr1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgileriniz Hatalı! Lütfen kontrol ediniz.", "Bilgi", MessageBoxButtons.OK);
                }

            }

            catch (Exception)
            {
                MessageBox.Show("", "bilgi", MessageBoxButtons.OK);

            }

            mysqlbaglan.Close();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

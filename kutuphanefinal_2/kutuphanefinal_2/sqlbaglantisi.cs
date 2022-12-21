using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kutuphanefinal_2
{
    public partial class sqlbaglantisi : Component
    {
        public sqlbaglantisi()
     
        {
            InitializeComponent();
        }

        public sqlbaglantisi(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
           public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=KABLAN;Initial Catalog=kutuphanefinal;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}

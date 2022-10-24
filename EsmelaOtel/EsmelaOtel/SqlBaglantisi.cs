using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EsmelaOtel
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=FIRUZE\SQLEXPRESS;Initial Catalog=DBOtelOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}

using System.Data.SqlClient;
using System.Drawing;

namespace HastaTakipSistemi
{
    internal class formsqlBaglanti
    {
        string adres = @"Data Source=.;Initial Catalog = db_HastaneYönetim; Integrated Security = True; TrustServerCertificate=True;";



        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(adres);

            baglanti.Open();
            return baglanti;
             
                
        }
    }
}

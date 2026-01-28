using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace HastaTakipSistemi
{
    public partial class frmıstatıstık : Form
    {
        public frmıstatıstık()
        {
            InitializeComponent();
        }
        formsqlBaglanti bgl=new formsqlBaglanti();

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmıstatıstık_Load(object sender, EventArgs e)
        {
            toplamHasta();
            ortalamaYas();
            ErkekHasataSayısı();
            KadınHasataSayısı();
            ExHasataSayısı();



        }
        private void toplamHasta()
        {
            SqlCommand  toplam= new SqlCommand("select count(*) from Hasta_Bilgi",bgl.baglan());
            IDataReader reader = toplam.ExecuteReader();
            while (reader.Read())
            {
                lblToplamHasta.Text = reader[0].ToString();
            }
        }
        private void ortalamaYas()
        {
            SqlCommand ortalamaYas = new SqlCommand(" select avg(hYas)from Hasta_Bilgi", bgl.baglan());
            IDataReader read= ortalamaYas.ExecuteReader();
            while (read.Read())
            {
                lblYasortalama.Text = read[0].ToString();
            }

        }
        private void ErkekHasataSayısı()
        {
            SqlCommand EHasta = new SqlCommand(" select count(*) from Hasta_Bilgi where hCinsiyeti='erkek'", bgl.baglan());
            IDataReader read = EHasta.ExecuteReader();
            while (read.Read())
            {
                lblErkekH.Text = read[0].ToString();
            }
        }
        private void KadınHasataSayısı()
        {
            SqlCommand Khasta = new SqlCommand("select count(*) from Hasta_Bilgi where hCinsiyeti = 'kadın'", bgl.baglan());
            IDataReader reader= Khasta.ExecuteReader();
            while (reader.Read())
            {
                lblKadınH.Text = reader[0].ToString();
            }
        }
        private void ExHasataSayısı()
        {
            SqlCommand Khasta = new SqlCommand(" select count(*) from Hasta_Bilgi where hExmi=1", bgl.baglan());
            IDataReader reader = Khasta.ExecuteReader();
            while (reader.Read())
            {
                lblExHSayısı.Text = reader[0].ToString();
            }
        }


        private void lblYasortalama_Click(object sender, EventArgs e)
        {
           
        }
    }
}

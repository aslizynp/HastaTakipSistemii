using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;



namespace HastaTakipSistemi
{
    public partial class formKayit : Form
    {

        public formKayit()
        {
            InitializeComponent();
        }

        formsqlBaglanti bgl=new formsqlBaglanti();


        private void button1_Click(object sender, EventArgs e)
        {
            if(txtKulAdi.Text!="" && txtSifre.Text!="")
            {
                SqlCommand kayit = new SqlCommand("kayitOl",bgl.baglan());
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.Parameters.AddWithValue("kullaniciAdi",txtKulAdi.Text);
                kayit.Parameters.AddWithValue("sifre",txtSifre.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("KAYIT İŞLEMİ BAŞARILI","KAYIT BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

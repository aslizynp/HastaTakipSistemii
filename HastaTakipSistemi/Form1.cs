using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        formsqlBaglanti bgl = new formsqlBaglanti();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (label1.Text != " " && label2.Text != " ")
            {
                SqlCommand giris = new SqlCommand("GirisYap", bgl.baglan());
                giris.CommandType = CommandType.StoredProcedure;
                giris.Parameters.AddWithValue("@kullaniciAdi", txtKulAdi.Text);
                giris.Parameters.AddWithValue("@sifre", txtSifre.Text);
                SqlDataReader dataReader = giris.ExecuteReader();
               
                if (dataReader.Read())
                {
                    MessageBox.Show("GİRİŞ BAŞARILI", "GİRİŞ BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAnaSayfa fr = new frmAnaSayfa();
                    this.Hide();
                    fr.Show();

                }


                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            formKayit girişeBaglan = new formKayit();
            girişeBaglan.Show();

        }

    } 
}
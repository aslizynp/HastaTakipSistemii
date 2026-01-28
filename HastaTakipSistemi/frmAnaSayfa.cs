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

namespace HastaTakipSistemi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        formsqlBaglanti bgl = new formsqlBaglanti();
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            Listele();
            durumDoldur();
            bolumDoldur();

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
            durumDoldur();
            bolumDoldur();
        }
        private void Listele()
        {
            SqlCommand liste = new SqlCommand("listele", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(liste);
            DataTable dt = new DataTable();
            da.Fill(dt);
            rbEvet.DataSource = dt;
        }
        private void durumDoldur()
        {
            SqlCommand durum = new SqlCommand("durumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DURUMcmbbx.DataSource = dt;
            DURUMcmbbx.DisplayMember = "durumAdı";
            DURUMcmbbx.ValueMember = "durumID";
            
        }
        private void bolumDoldur()
        {
            SqlCommand bolum = new SqlCommand("bolumdoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(bolum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bolumcmbx.DataSource = dt;
            bolumcmbx.DisplayMember = "bolumAd";
            bolumcmbx.ValueMember = "bolumID";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEvet.Checked == true)
            {
                lblex.Text = "TRUE";

            }
            else
            {
                lblex.Text = "FALSE";
            }
        }

        private void lblex_TextChanged(object sender, EventArgs e)
        {
            if (lblex.Text == "TRUE")
            {
                radioButtonEvet.Checked = true;

            }
            else
            {
                radioButtonhayır.Checked = false;
            }
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            if (ADtxt.Text != " " && SOYADItxt.Text != " " && TCtxt.Text != " " && TELEFONtxt.Text != " "
                && SIKAYETtxt.Text != " " && CINSIYETtxt.Text != " " && YAStxt.Text != " ")
            {
                kaydet();

            }
            else
            {
                MessageBox.Show("lutfen ilgili tum alanları doldurun", "kayıt başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void kaydet()
        {
            SqlCommand kaydet = new SqlCommand("kaydet", bgl.baglan());
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("ad", ADtxt.Text);
            kaydet.Parameters.AddWithValue("soyad", SOYADItxt.Text);
            kaydet.Parameters.AddWithValue("tc", TCtxt.Text);
            kaydet.Parameters.AddWithValue("telefon", TELEFONtxt.Text);
            kaydet.Parameters.AddWithValue("yas", int.Parse(YAStxt.Text.ToString()));
            kaydet.Parameters.AddWithValue("cinsiyet", CINSIYETtxt.Text);
            kaydet.Parameters.AddWithValue("sikayet", SIKAYETtxt.Text);
            kaydet.Parameters.AddWithValue("tarih", DateTime.Now);
            kaydet.Parameters.AddWithValue("durum", DURUMcmbbx.SelectedValue);
            kaydet.Parameters.AddWithValue("bolum", bolumcmbx.SelectedValue);
            if (lblex.Text == "True")
            {
                kaydet.Parameters.AddWithValue("ex", 1);
            }
            else
            {
                kaydet.Parameters.AddWithValue("ex", 0);
            }
            kaydet.ExecuteNonQuery();
            MessageBox.Show("kKAYIT BAŞARIYLA EKLENDI", "kayıt başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            sil();
        }
        private void sil()
        {
            DialogResult dr = MessageBox.Show($"{IDtxt.Text} numaralı kayıt siilinecek.Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("SIL", bgl.baglan());
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("id", int.Parse(IDtxt.Text));
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başsarıyla Silindi", "Kayıt Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();

            }

        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{IDtxt.Text} numaralı kayıt güncellenecek .Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                guncelle();
            }
           
        }
        private void guncelle()
        {
            SqlCommand guncel = new SqlCommand("guncelle", bgl.baglan());
            guncel.CommandType = CommandType.StoredProcedure;
            guncel.Parameters.AddWithValue("id", int.Parse(IDtxt.Text.ToString()));
            guncel.Parameters.AddWithValue("ad", ADtxt.Text.ToString());
            guncel.Parameters.AddWithValue("soyad", SOYADItxt.Text.ToString()) ;
            guncel.Parameters.AddWithValue("tc", TCtxt.Text.ToString()) ;
            guncel.Parameters.AddWithValue("telefon", TELEFONtxt.Text.ToString());
            guncel.Parameters.AddWithValue("yas", int.Parse(YAStxt.Text.ToString()));
            guncel.Parameters.AddWithValue("cinsiyet", CINSIYETtxt.Text.ToString());
            guncel.Parameters.AddWithValue("sikayet", SIKAYETtxt.Text.ToString());
            guncel.Parameters.AddWithValue("tarih", DateTime.Now);
            guncel.Parameters.AddWithValue("durum", DURUMcmbbx.SelectedValue);
            guncel.Parameters.AddWithValue("bolum", bolumcmbx.SelectedValue);
            if (lblex.Text == "True")
            {
                guncel.Parameters.AddWithValue("ex", 1);
            }
            else
            {
                guncel.Parameters.AddWithValue("ex", 0);
            }
            guncel.ExecuteNonQuery();
            MessageBox.Show("GUNCELLEME ISLEMI BASARILI", "guncelleme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void rbEvet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = rbEvet.SelectedCells[0].RowIndex;
            IDtxt.Text = rbEvet.Rows[secilen].Cells[0].Value.ToString();
            TCtxt.Text = rbEvet.Rows[secilen].Cells[3].Value.ToString();
            ADtxt.Text = rbEvet.Rows[secilen].Cells[1].Value.ToString();
            TELEFONtxt.Text = rbEvet.Rows[secilen].Cells[4].Value.ToString();
            SOYADItxt.Text = rbEvet.Rows[secilen].Cells[2].Value.ToString();
            YAStxt.Text = rbEvet.Rows[secilen].Cells[5].Value.ToString();
            CINSIYETtxt.Text = rbEvet.Rows[secilen].Cells[6].Value.ToString();
            SIKAYETtxt.Text = rbEvet.Rows[secilen].Cells[7].Value.ToString();
            TARIHtxt.Text = rbEvet.Rows[secilen].Cells[9].Value.ToString();
            DURUMcmbbx.SelectedValue = rbEvet.Rows[secilen].Cells[8].Value.ToString();
            bolumcmbx.SelectedValue = rbEvet.Rows[secilen].Cells[10].Value.ToString();
            lblex.Text = rbEvet.Rows[secilen].Cells[11].Value.ToString();

        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void temizle()
        {
            ADtxt.Text = "";
            SOYADItxt.Text = "";
            CINSIYETtxt.Text = "";
            SIKAYETtxt.Text = "";
            TCtxt.Text = "";
            TELEFONtxt.Text = "";
            YAStxt.Text = "";
            DURUMcmbbx.Text = "";
            bolumcmbx.Text = "";
            radioButtonhayır.Checked = true;
            lblex.Text = "FALSE";

        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Doldurulan kayıt silincek.Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                temizle();
            }
        }

        private void istatistikbtn_Click(object sender, EventArgs e)
        {
            frmıstatıstık formIstatistık=new frmıstatıstık();
            formIstatistık.Show();
        }
    }

  }


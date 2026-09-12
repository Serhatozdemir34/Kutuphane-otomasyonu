using Kütüphane_otomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace Kütüphane_otomasyonu
{
    public partial class AdminSayfasi : Form
    {
        List<Kisi> kisilerim;
        List<Kitap> kitaplarim;
        public AdminSayfasi(List<Kisi> kisilerim, List<Kitap> kitaplarim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
            this.kitaplarim = kitaplarim;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getId(), kisi.getIsim(), kisi.getSoyisim(), kisi.getOlusturmaTarihi(), kisi.getKullaniciAdi(), kisi.getSifre(), kisi.getYetki());
            }
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayınEvi(), kitap.getTür(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_uyeİslemler_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
    Convert.ToInt32(textBox1.Text),
    textBox3.Text,
    textBox2.Text,
    maskedTextBox2.Text,
    textBox5.Text,
    textBox6.Text,
    textBox7.Text
);
        }



        public void textleriDoldur()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string isim = textBox3.Text;
            string Soyisim = textBox2.Text;
            string OlusturmaTarihi = maskedTextBox2.Text;
            string kullaniciAdi = textBox5.Text;
            string sifre = textBox6.Text;
            string yetki = textBox7.Text;


            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id, isim, Soyisim, OlusturmaTarihi, kullaniciAdi, sifre, yetki);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleriDoldur();

        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox2.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_KitapEkle_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(
        txt_kitapid.Text,
        txt_Kitapİsim.Text,
        txt_KitapYazar.Text,
        txt_KitapDili.Text,
        txt_KitapYAyınEvi.Text,
        txt_KitapTür.Text,
        txt_kitapAdet.Text,
        txt_KitapSayfa.Text,
        txt_kitapBasımYılı.Text
    );

        }
        private void btn_KitapSil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
        }

        private void btn_KitapGüncelle_Click(object sender, EventArgs e)
        {
            string kitapid = txt_kitapid.Text;
            string kitapİsmi = txt_Kitapİsim.Text;
            string kitapYazar = txt_KitapYazar.Text;
            string dil = txt_KitapDili.Text;
            string yayinEvi = txt_KitapYAyınEvi.Text;
            string tur = txt_KitapTür.Text;
            string adet = txt_kitapAdet.Text;
            string sayfa = txt_KitapSayfa.Text;
            string basimYili = txt_kitapBasımYılı.Text;
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            dataGridView2.Rows.Add(kitapid, kitapİsmi, kitapYazar, dil, yayinEvi, tur, adet, sayfa, basimYili);

        }

        private void btn_KitapTemizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBoxKitap.Controls.Count; i++)
            {
                if (groupBoxKitap.Controls[i] is System.Windows.Forms.TextBox)
                {
                    groupBoxKitap.Controls[i].Text = string.Empty;
                }
            }
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kitapid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_Kitapİsim.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_KitapYazar.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_KitapDili.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_KitapYAyınEvi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_KitapTür.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_kitapAdet.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_KitapSayfa.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            txt_kitapBasımYılı.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();

        }

        private void btn_KişiAra_Click(object sender, EventArgs e)
        {
            Kisi hedefKisi = null;
            int secilenKişiId = Convert.ToInt32(textBox4.Text);
            foreach (Kisi kisi in kisilerim)
            {
                if (kisi.getId() == secilenKişiId)
                {
                    hedefKisi = kisi;
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarihi(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
        }

        private void btn_KişiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            foreach (Kisi hedefKisi in kisilerim)
            {
                dataGridView1.Rows.Add(hedefKisi.getId(), hedefKisi.getIsim(), hedefKisi.getSoyisim(), hedefKisi.getOlusturmaTarihi(), hedefKisi.getKullaniciAdi(), hedefKisi.getSifre(), hedefKisi.getYetki());
            }
        }

        private void btn_KitapAra_Click(object sender, EventArgs e)
        {
            Kitap hedefKitap = null;
            int kitapID = Convert.ToInt32(textBox8.Text);
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == kitapID)
                {
                    hedefKitap = kitap;
                    break;
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayınEvi(), hedefKitap.getTür(), hedefKitap.getAdet(), hedefKitap.getSayfaSayisi(), hedefKitap.getBasimYili());
        }

        private void btn_KitapYenile_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayınEvi(), kitap.getTür(), kitap.getAdet(), kitap.getSayfaSayisi(), kitap.getBasimYili());
            }
        }

        private void btn_Çıkış_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
                        this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

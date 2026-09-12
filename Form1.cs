using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kütüphane_otomasyonu.Model;

namespace Kütüphane_otomasyonu
{
    public partial class Form1 : Form
    {
        List<Kisi> kisilerim = new List<Kisi>();
        List<Kitap> kitaplarim = new List<Kitap>();

        public Form1()
        {
            InitializeComponent();

            
            kisilerim.Add(new Kisi(1, "Serhat", "Özdemir", DateTime.Now, "admin", "1", "admin"));
            kisilerim.Add(new Kisi(2, "Ahmet", "Yılmaz", DateTime.Now, "ahmet", "2", "uye"));
            kisilerim.Add(new Kisi(3, "Bilal", "Can", DateTime.Now, "bilal", "3", "uye"));
            kisilerim.Add(new Kisi(4, "Yakup", "Kara", DateTime.Now, "yakup", "4", "uye"));
            kitaplarim.Add(new Kitap(1, "İçimizdeki Şeytan", "Sabahattin Ali", "Türkçe", "Yapı Kredi Yayınları", "Roman", 100, 250, 2016));
            kitaplarim.Add(new Kitap(2, "Tutunamayanlar", "Oğuz Atay", "Türkçe", "İletişim Yayıncılık", "Roman", 85, 760, 2015));
            kitaplarim.Add(new Kitap(3, "Uçurtma Avcısı", "Khaled Hosseini", "İngilizce", "Everest Yayıncılık", "Roman", 120, 375, 2018));
            kitaplarim.Add(new Kitap(4, "Küçük Prens", "Antoine de Saint-Exupéry", "Fransızca", "Can Çocuk Yayınları", "Masal", 50, 112, 2020));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Şifre_TextBox.PasswordChar = '*';
        }

        private void TemizleButton_Click(object sender, EventArgs e)
        {
            Kullanıcı_TextBox.Text = string.Empty;
            Şifre_TextBox.Text = string.Empty;
            Kullanıcı_TextBox.Focus();
        }

        private void GirişYap_Clicked(object sender, EventArgs e)
        {
            string kullaniciAdi = Kullanıcı_TextBox.Text.Trim();
            string sifre = Şifre_TextBox.Text.Trim();

            bool kontrol = false;

            foreach (Kisi kisi in kisilerim)
            {
                bool kadiEsit = string.Equals(kisi.getKullaniciAdi(), kullaniciAdi, StringComparison.OrdinalIgnoreCase);
                bool sifreEsit = string.Equals(kisi.getSifre(), sifre);

                if (kadiEsit && sifreEsit && kisi.getYetki() == "admin")
                {
                    AdminSayfasi adminSayfasi = new AdminSayfasi(kisilerim,kitaplarim);
                    adminSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
                else if (kadiEsit && sifreEsit && kisi.getYetki() == "uye")
                {
                    UyeSayfasi uyeSayfasi = new UyeSayfasi(kitaplarim);
                    uyeSayfasi.Show();
                    this.Hide();
                    kontrol = true;
                    break;
                }
            }

            if (!kontrol)
            {
                MessageBox.Show("Hatalı Giriş", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void Kullanıcı_TextBox_TextChanged(object sender, EventArgs e) { }
        private void Şifre_TextBox_TextChanged(object sender, EventArgs e) { }
    }
}
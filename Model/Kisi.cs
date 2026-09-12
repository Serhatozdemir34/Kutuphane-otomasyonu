using System;

namespace Kütüphane_otomasyonu.Model
{
    public class Kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }

        public Kisi()
        {
        }

        public Kisi(int id, string isim, string soyisim, DateTime olusturmaTarihi, string kullaniciAdi, string sifre, string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarihi = olusturmaTarihi;
            this.kullaniciAdi = kullaniciAdi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public int getId() => this.id;
        public void setId(int id) => this.id = id;

        public string getIsim() => this.isim;
        public void setIsim(string isim) => this.isim = isim;

        public string getSoyisim() => this.soyisim;
        public void setSoyisim(string soyisim) => this.soyisim = soyisim;

        public DateTime getOlusturmaTarihi() => this.olusturmaTarihi;
        public void setOlusturmaTarihi(DateTime olusturmaTarihi) => this.olusturmaTarihi = olusturmaTarihi;

        public string getKullaniciAdi() => this.kullaniciAdi;
        public void setKullaniciAdi(string kullaniciAdi) => this.kullaniciAdi = kullaniciAdi;

        public string getSifre() => this.sifre;
        public void setSifre(string sifre) => this.sifre = sifre;

        public string getYetki() => this.yetki;
        public void setYetki(string yetki) => this.yetki = yetki;

        public override string ToString()
        {
            return $"Kisi [id={id}, isim={isim}, soyisim={soyisim}, olusturmaTarihi={olusturmaTarihi}, kullaniciAdi={kullaniciAdi}, yetki={yetki}]";
        }
    }
}
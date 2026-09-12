using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_otomasyonu.Model
{
    public class Kitap
    {
        public int kitapid { get; set; }
        public string kitapIsim { get; set; }
        public string kitapYazar { get; set; }
        public string kitapDili { get; set; }
        public string yayınEvi { get; set; }

        public string tür { get; set; }
        public int adet { get; set; }
        public int sayfaSayisi { get; set; }
        public int basimYili { get; set; }
        public Kitap()
        {
            
        }
        public Kitap(int kitapid, string kitapIsim, string kitapYazar, string kitapDili, string yayınEvi, string tür, int adet, int sayfaSayisi, int basimYili)
        {
            this.kitapid = kitapid;
            this.kitapIsim = kitapIsim;
            this.kitapYazar = kitapYazar;
            this.kitapDili = kitapDili;
            this.yayınEvi = yayınEvi;
            this.tür = tür;
            this.adet = adet;
            this.sayfaSayisi = sayfaSayisi;
            this.basimYili = basimYili;
        }
        public int getKitapId()
        {
                       return this.kitapid;
        }
        public string getKitapIsim()
        {
            return this.kitapIsim;
        }
        public string getKitapYazar()
        {
            return this.kitapYazar;
        }
        public string getKitapDili()
        {
            return this.kitapDili;
        }
        public string getYayınEvi()
        {
            return this.yayınEvi;
        }
        public string getTür()
        {
            return this.tür;
        }
        public int getAdet()
        {
            return this.adet;
        }
        public int getSayfaSayisi()
        {
            return this.sayfaSayisi;
        }
        public int getBasimYili()
        {
            return this.basimYili;
        }


    }
    
}

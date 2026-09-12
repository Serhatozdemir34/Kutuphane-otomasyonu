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

namespace Kütüphane_otomasyonu
{
    public partial class UyeSayfasi : Form
    {
        List<Kitap> kitaplarim;
        public UyeSayfasi(List<Kitap> kitaplarım)
        {
            InitializeComponent();
            this.kitaplarim = kitaplarım;
        }

        private void button2_Click(object sender, EventArgs e)

        {
            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
            foreach (Kitap hedefKitap in kitaplarim)
            {
                dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayınEvi(), hedefKitap.getTür(), hedefKitap.adet, hedefKitap.sayfaSayisi, hedefKitap.basimYili);
            }
        }

        private void btn_Çıkış_Click(object sender, EventArgs e)
        {
            Form1 loginSayfasi = new Form1();
            loginSayfasi.Show();
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UyeSayfasi_Load(object sender, EventArgs e)
        {
            foreach (Kitap kitap in kitaplarim)
            {
                dataGridView2.Rows.Add(kitap.getKitapId(), kitap.getKitapIsim(), kitap.getKitapYazar(), kitap.getKitapDili(), kitap.getYayınEvi(), kitap.getTür(), kitap.adet, kitap.sayfaSayisi, kitap.basimYili);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int kitapId = Convert.ToInt32(txt_KitapID.Text);
            Kitap hedefKitap=null;
            foreach (Kitap kitap in kitaplarim)
            {
                if (kitap.getKitapId() == kitapId)
                {
                   hedefKitap = kitap;
                    
                   
                }
            }
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add(hedefKitap.getKitapId(), hedefKitap.getKitapIsim(), hedefKitap.getKitapYazar(), hedefKitap.getKitapDili(), hedefKitap.getYayınEvi(), hedefKitap.getTür(), hedefKitap.adet, hedefKitap.sayfaSayisi, hedefKitap.basimYili);
        }
    }
}


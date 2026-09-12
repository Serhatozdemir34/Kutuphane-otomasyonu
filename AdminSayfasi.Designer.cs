namespace Kütüphane_otomasyonu
{
    partial class AdminSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_isim = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            btn_Temizle = new Button();
            btn_Güncelle = new Button();
            btn_Sil = new Button();
            btn_Ekle = new Button();
            textBox7 = new TextBox();
            txt_Yetki = new Label();
            textBox6 = new TextBox();
            txt_Şifre = new Label();
            textBox5 = new TextBox();
            txt_KullanıcıAdı = new Label();
            txt_oluşturmaTarihi = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            txt_Soyİsim = new Label();
            textBox1 = new TextBox();
            txt_id = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            İsim = new DataGridViewTextBoxColumn();
            soyisim = new DataGridViewTextBoxColumn();
            oluşturmTarih = new DataGridViewTextBoxColumn();
            kullaniciAdi = new DataGridViewTextBoxColumn();
            sifre = new DataGridViewTextBoxColumn();
            yetki = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            kitapid = new DataGridViewTextBoxColumn();
            kitapisim = new DataGridViewTextBoxColumn();
            kitapyazar = new DataGridViewTextBoxColumn();
            kitapdili = new DataGridViewTextBoxColumn();
            yayinevi = new DataGridViewTextBoxColumn();
            tür = new DataGridViewTextBoxColumn();
            adet = new DataGridViewTextBoxColumn();
            sayfaSayisi = new DataGridViewTextBoxColumn();
            basimyili = new DataGridViewTextBoxColumn();
            groupBoxKitap = new GroupBox();
            txt_kitapBasımYılı = new TextBox();
            txt_KitapSayfa = new TextBox();
            label12 = new Label();
            txt_KitapDili = new TextBox();
            label11 = new Label();
            btn_KitapTemizle = new Button();
            btn_KitapGüncelle = new Button();
            btn_KitapSil = new Button();
            btn_KitapEkle = new Button();
            txt_kitapAdet = new TextBox();
            label4 = new Label();
            txt_KitapTür = new TextBox();
            label5 = new Label();
            txt_KitapYAyınEvi = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txt_Kitapİsim = new TextBox();
            label8 = new Label();
            txt_KitapYazar = new TextBox();
            label9 = new Label();
            txt_kitapid = new TextBox();
            label10 = new Label();
            btn_KişiAra = new Button();
            textBox4 = new TextBox();
            btn_KişiYenile = new Button();
            btn_KitapYenile = new Button();
            textBox8 = new TextBox();
            btn_KitapAra = new Button();
            btn_Çıkış = new Button();
            txt_isim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBoxKitap.SuspendLayout();
            SuspendLayout();
            // 
            // txt_isim
            // 
            txt_isim.Controls.Add(maskedTextBox2);
            txt_isim.Controls.Add(btn_Temizle);
            txt_isim.Controls.Add(btn_Güncelle);
            txt_isim.Controls.Add(btn_Sil);
            txt_isim.Controls.Add(btn_Ekle);
            txt_isim.Controls.Add(textBox7);
            txt_isim.Controls.Add(txt_Yetki);
            txt_isim.Controls.Add(textBox6);
            txt_isim.Controls.Add(txt_Şifre);
            txt_isim.Controls.Add(textBox5);
            txt_isim.Controls.Add(txt_KullanıcıAdı);
            txt_isim.Controls.Add(txt_oluşturmaTarihi);
            txt_isim.Controls.Add(textBox3);
            txt_isim.Controls.Add(label3);
            txt_isim.Controls.Add(textBox2);
            txt_isim.Controls.Add(txt_Soyİsim);
            txt_isim.Controls.Add(textBox1);
            txt_isim.Controls.Add(txt_id);
            txt_isim.Location = new Point(23, 29);
            txt_isim.Name = "txt_isim";
            txt_isim.Size = new Size(285, 519);
            txt_isim.TabIndex = 0;
            txt_isim.TabStop = false;
            txt_isim.Text = "uye_İslemleri";
            txt_isim.Enter += groupBox_uyeİslemler_Enter;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(129, 196);
            maskedTextBox2.Mask = "00/00/0000 90:00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(145, 23);
            maskedTextBox2.TabIndex = 19;
            // 
            // btn_Temizle
            // 
            btn_Temizle.Location = new Point(23, 451);
            btn_Temizle.Name = "btn_Temizle";
            btn_Temizle.Size = new Size(251, 23);
            btn_Temizle.TabIndex = 17;
            btn_Temizle.Text = "Temizle";
            btn_Temizle.UseVisualStyleBackColor = true;
            btn_Temizle.Click += btn_Temizle_Click;
            // 
            // btn_Güncelle
            // 
            btn_Güncelle.Location = new Point(23, 422);
            btn_Güncelle.Name = "btn_Güncelle";
            btn_Güncelle.Size = new Size(251, 23);
            btn_Güncelle.TabIndex = 16;
            btn_Güncelle.Text = "Güncelle";
            btn_Güncelle.UseVisualStyleBackColor = true;
            btn_Güncelle.Click += button3_Click;
            // 
            // btn_Sil
            // 
            btn_Sil.Location = new Point(23, 393);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(251, 23);
            btn_Sil.TabIndex = 15;
            btn_Sil.Text = "Sil";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += button2_Click;
            // 
            // btn_Ekle
            // 
            btn_Ekle.Location = new Point(23, 364);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(251, 23);
            btn_Ekle.TabIndex = 14;
            btn_Ekle.Text = "Ekle";
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(129, 321);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(145, 23);
            textBox7.TabIndex = 13;
            // 
            // txt_Yetki
            // 
            txt_Yetki.AutoSize = true;
            txt_Yetki.Location = new Point(23, 329);
            txt_Yetki.Name = "txt_Yetki";
            txt_Yetki.Size = new Size(35, 15);
            txt_Yetki.TabIndex = 12;
            txt_Yetki.Text = "Yetki:";
            txt_Yetki.Click += label7_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(129, 282);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(145, 23);
            textBox6.TabIndex = 11;
            // 
            // txt_Şifre
            // 
            txt_Şifre.AutoSize = true;
            txt_Şifre.Location = new Point(23, 290);
            txt_Şifre.Name = "txt_Şifre";
            txt_Şifre.Size = new Size(33, 15);
            txt_Şifre.TabIndex = 10;
            txt_Şifre.Text = "Şifre:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 242);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(145, 23);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // txt_KullanıcıAdı
            // 
            txt_KullanıcıAdı.AutoSize = true;
            txt_KullanıcıAdı.Location = new Point(23, 250);
            txt_KullanıcıAdı.Name = "txt_KullanıcıAdı";
            txt_KullanıcıAdı.Size = new Size(73, 15);
            txt_KullanıcıAdı.TabIndex = 8;
            txt_KullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // txt_oluşturmaTarihi
            // 
            txt_oluşturmaTarihi.AutoSize = true;
            txt_oluşturmaTarihi.Location = new Point(23, 199);
            txt_oluşturmaTarihi.Name = "txt_oluşturmaTarihi";
            txt_oluşturmaTarihi.Size = new Size(95, 15);
            txt_oluşturmaTarihi.TabIndex = 6;
            txt_oluşturmaTarihi.Text = "Oluşturma Tarihi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 114);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "İsim:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txt_Soyİsim
            // 
            txt_Soyİsim.AutoSize = true;
            txt_Soyİsim.Location = new Point(23, 164);
            txt_Soyİsim.Name = "txt_Soyİsim";
            txt_Soyİsim.Size = new Size(48, 15);
            txt_Soyİsim.TabIndex = 2;
            txt_Soyİsim.Text = "Soyİsim";
            txt_Soyİsim.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 1;
            // 
            // txt_id
            // 
            txt_id.AutoSize = true;
            txt_id.Location = new Point(23, 62);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(20, 15);
            txt_id.TabIndex = 0;
            txt_id.Text = "id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(428, 29);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Üyeler";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, İsim, soyisim, oluşturmTarih, kullaniciAdi, sifre, yetki });
            dataGridView1.Location = new Point(314, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(444, 530);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "İD";
            id.Name = "id";
            // 
            // İsim
            // 
            İsim.HeaderText = "ISIM";
            İsim.Name = "İsim";
            // 
            // soyisim
            // 
            soyisim.HeaderText = "SOYİSİM";
            soyisim.Name = "soyisim";
            // 
            // oluşturmTarih
            // 
            oluşturmTarih.HeaderText = "Oluşturma Tarih";
            oluşturmTarih.Name = "oluşturmTarih";
            // 
            // kullaniciAdi
            // 
            kullaniciAdi.HeaderText = "Kullanıcı Adı";
            kullaniciAdi.Name = "kullaniciAdi";
            // 
            // sifre
            // 
            sifre.HeaderText = "ŞİFRE";
            sifre.Name = "sifre";
            // 
            // yetki
            // 
            yetki.HeaderText = "YETKİ";
            yetki.Name = "yetki";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1118, 29);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "kitaplar";
            label2.Click += label2_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { kitapid, kitapisim, kitapyazar, kitapdili, yayinevi, tür, adet, sayfaSayisi, basimyili });
            dataGridView2.Location = new Point(1100, 70);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(335, 507);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // kitapid
            // 
            kitapid.HeaderText = "KitapID";
            kitapid.Name = "kitapid";
            kitapid.Width = 75;
            // 
            // kitapisim
            // 
            kitapisim.HeaderText = "Kitap İsim";
            kitapisim.Name = "kitapisim";
            kitapisim.Width = 75;
            // 
            // kitapyazar
            // 
            kitapyazar.HeaderText = "Kitap yazarı";
            kitapyazar.Name = "kitapyazar";
            kitapyazar.Width = 75;
            // 
            // kitapdili
            // 
            kitapdili.HeaderText = "Kitap Dili";
            kitapdili.Name = "kitapdili";
            kitapdili.Width = 75;
            // 
            // yayinevi
            // 
            yayinevi.HeaderText = "Yayın Evi";
            yayinevi.Name = "yayinevi";
            yayinevi.Width = 75;
            // 
            // tür
            // 
            tür.HeaderText = "Tür";
            tür.Name = "tür";
            tür.Width = 75;
            // 
            // adet
            // 
            adet.HeaderText = "Adet";
            adet.Name = "adet";
            adet.Width = 75;
            // 
            // sayfaSayisi
            // 
            sayfaSayisi.HeaderText = "Sayfa Sayısı";
            sayfaSayisi.Name = "sayfaSayisi";
            sayfaSayisi.Width = 75;
            // 
            // basimyili
            // 
            basimyili.HeaderText = "Basım Yılı";
            basimyili.Name = "basimyili";
            basimyili.Width = 75;
            // 
            // groupBoxKitap
            // 
            groupBoxKitap.Controls.Add(txt_kitapBasımYılı);
            groupBoxKitap.Controls.Add(txt_KitapSayfa);
            groupBoxKitap.Controls.Add(label12);
            groupBoxKitap.Controls.Add(txt_KitapDili);
            groupBoxKitap.Controls.Add(label11);
            groupBoxKitap.Controls.Add(btn_KitapTemizle);
            groupBoxKitap.Controls.Add(btn_KitapGüncelle);
            groupBoxKitap.Controls.Add(btn_KitapSil);
            groupBoxKitap.Controls.Add(btn_KitapEkle);
            groupBoxKitap.Controls.Add(txt_kitapAdet);
            groupBoxKitap.Controls.Add(label4);
            groupBoxKitap.Controls.Add(txt_KitapTür);
            groupBoxKitap.Controls.Add(label5);
            groupBoxKitap.Controls.Add(txt_KitapYAyınEvi);
            groupBoxKitap.Controls.Add(label6);
            groupBoxKitap.Controls.Add(label7);
            groupBoxKitap.Controls.Add(txt_Kitapİsim);
            groupBoxKitap.Controls.Add(label8);
            groupBoxKitap.Controls.Add(txt_KitapYazar);
            groupBoxKitap.Controls.Add(label9);
            groupBoxKitap.Controls.Add(txt_kitapid);
            groupBoxKitap.Controls.Add(label10);
            groupBoxKitap.Location = new Point(764, 47);
            groupBoxKitap.Name = "groupBoxKitap";
            groupBoxKitap.Size = new Size(330, 530);
            groupBoxKitap.TabIndex = 5;
            groupBoxKitap.TabStop = false;
            groupBoxKitap.Text = "Kitap İşlemleri";
            // 
            // txt_kitapBasımYılı
            // 
            txt_kitapBasımYılı.Location = new Point(108, 326);
            txt_kitapBasımYılı.Name = "txt_kitapBasımYılı";
            txt_kitapBasımYılı.Size = new Size(143, 23);
            txt_kitapBasımYılı.TabIndex = 20;
            // 
            // txt_KitapSayfa
            // 
            txt_KitapSayfa.Location = new Point(108, 291);
            txt_KitapSayfa.Name = "txt_KitapSayfa";
            txt_KitapSayfa.Size = new Size(143, 23);
            txt_KitapSayfa.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 329);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 7;
            label12.Text = "Basım Yıl";
            // 
            // txt_KitapDili
            // 
            txt_KitapDili.Location = new Point(108, 138);
            txt_KitapDili.Name = "txt_KitapDili";
            txt_KitapDili.Size = new Size(145, 23);
            txt_KitapDili.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 294);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 6;
            label11.Text = "Sayfa";
            // 
            // btn_KitapTemizle
            // 
            btn_KitapTemizle.Location = new Point(23, 451);
            btn_KitapTemizle.Name = "btn_KitapTemizle";
            btn_KitapTemizle.Size = new Size(251, 23);
            btn_KitapTemizle.TabIndex = 17;
            btn_KitapTemizle.Text = "Temizle";
            btn_KitapTemizle.UseVisualStyleBackColor = true;
            btn_KitapTemizle.Click += btn_KitapTemizle_Click;
            // 
            // btn_KitapGüncelle
            // 
            btn_KitapGüncelle.Location = new Point(23, 422);
            btn_KitapGüncelle.Name = "btn_KitapGüncelle";
            btn_KitapGüncelle.Size = new Size(251, 23);
            btn_KitapGüncelle.TabIndex = 16;
            btn_KitapGüncelle.Text = "Güncelle";
            btn_KitapGüncelle.UseVisualStyleBackColor = true;
            btn_KitapGüncelle.Click += btn_KitapGüncelle_Click;
            // 
            // btn_KitapSil
            // 
            btn_KitapSil.Location = new Point(23, 393);
            btn_KitapSil.Name = "btn_KitapSil";
            btn_KitapSil.Size = new Size(251, 23);
            btn_KitapSil.TabIndex = 15;
            btn_KitapSil.Text = "Sil";
            btn_KitapSil.UseVisualStyleBackColor = true;
            btn_KitapSil.Click += btn_KitapSil_Click;
            // 
            // btn_KitapEkle
            // 
            btn_KitapEkle.Location = new Point(23, 364);
            btn_KitapEkle.Name = "btn_KitapEkle";
            btn_KitapEkle.Size = new Size(251, 23);
            btn_KitapEkle.TabIndex = 14;
            btn_KitapEkle.Text = "Ekle";
            btn_KitapEkle.UseVisualStyleBackColor = true;
            btn_KitapEkle.Click += btn_KitapEkle_Click;
            // 
            // txt_kitapAdet
            // 
            txt_kitapAdet.Location = new Point(108, 247);
            txt_kitapAdet.Name = "txt_kitapAdet";
            txt_kitapAdet.Size = new Size(145, 23);
            txt_kitapAdet.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 255);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 12;
            label4.Text = "Adet:";
            // 
            // txt_KitapTür
            // 
            txt_KitapTür.Location = new Point(108, 208);
            txt_KitapTür.Name = "txt_KitapTür";
            txt_KitapTür.Size = new Size(145, 23);
            txt_KitapTür.TabIndex = 11;
            txt_KitapTür.TextChanged += textBox8_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 211);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 10;
            label5.Text = "Tür";
            // 
            // txt_KitapYAyınEvi
            // 
            txt_KitapYAyınEvi.Location = new Point(108, 173);
            txt_KitapYAyınEvi.Name = "txt_KitapYAyınEvi";
            txt_KitapYAyınEvi.Size = new Size(145, 23);
            txt_KitapYAyınEvi.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 176);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 8;
            label6.Text = "Yayın evi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 138);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 6;
            label7.Text = "dil:";
            // 
            // txt_Kitapİsim
            // 
            txt_Kitapİsim.Location = new Point(108, 49);
            txt_Kitapİsim.Name = "txt_Kitapİsim";
            txt_Kitapİsim.Size = new Size(145, 23);
            txt_Kitapİsim.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 52);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 4;
            label8.Text = "Kitap İsim:";
            // 
            // txt_KitapYazar
            // 
            txt_KitapYazar.Location = new Point(108, 96);
            txt_KitapYazar.Name = "txt_KitapYazar";
            txt_KitapYazar.Size = new Size(145, 23);
            txt_KitapYazar.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 96);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 2;
            label9.Text = "Kitap YAzar:";
            // 
            // txt_kitapid
            // 
            txt_kitapid.Location = new Point(108, 20);
            txt_kitapid.Name = "txt_kitapid";
            txt_kitapid.Size = new Size(145, 23);
            txt_kitapid.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 23);
            label10.Name = "label10";
            label10.Size = new Size(20, 15);
            label10.TabIndex = 0;
            label10.Text = "id:";
            // 
            // btn_KişiAra
            // 
            btn_KişiAra.Location = new Point(12, 2);
            btn_KişiAra.Name = "btn_KişiAra";
            btn_KişiAra.Size = new Size(107, 29);
            btn_KişiAra.TabIndex = 6;
            btn_KişiAra.Text = "Ara";
            btn_KişiAra.UseVisualStyleBackColor = true;
            btn_KişiAra.Click += btn_KişiAra_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 6);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // btn_KişiYenile
            // 
            btn_KişiYenile.Location = new Point(231, 2);
            btn_KişiYenile.Name = "btn_KişiYenile";
            btn_KişiYenile.Size = new Size(107, 29);
            btn_KişiYenile.TabIndex = 8;
            btn_KişiYenile.Text = "Yenile";
            btn_KişiYenile.UseVisualStyleBackColor = true;
            btn_KişiYenile.Click += btn_KişiYenile_Click;
            // 
            // btn_KitapYenile
            // 
            btn_KitapYenile.Location = new Point(978, 8);
            btn_KitapYenile.Name = "btn_KitapYenile";
            btn_KitapYenile.Size = new Size(107, 29);
            btn_KitapYenile.TabIndex = 11;
            btn_KitapYenile.Text = "Yenile";
            btn_KitapYenile.UseVisualStyleBackColor = true;
            btn_KitapYenile.Click += btn_KitapYenile_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(872, 12);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 10;
            // 
            // btn_KitapAra
            // 
            btn_KitapAra.Location = new Point(759, 8);
            btn_KitapAra.Name = "btn_KitapAra";
            btn_KitapAra.Size = new Size(107, 29);
            btn_KitapAra.TabIndex = 9;
            btn_KitapAra.Text = "Ara";
            btn_KitapAra.UseVisualStyleBackColor = true;
            btn_KitapAra.Click += btn_KitapAra_Click;
            // 
            // btn_Çıkış
            // 
            btn_Çıkış.Location = new Point(46, 626);
            btn_Çıkış.Name = "btn_Çıkış";
            btn_Çıkış.Size = new Size(233, 64);
            btn_Çıkış.TabIndex = 12;
            btn_Çıkış.Text = "Çıkış Yap";
            btn_Çıkış.UseVisualStyleBackColor = true;
            btn_Çıkış.Click += btn_Çıkış_Click;
            // 
            // AdminSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1462, 788);
            Controls.Add(btn_Çıkış);
            Controls.Add(btn_KitapYenile);
            Controls.Add(textBox8);
            Controls.Add(btn_KitapAra);
            Controls.Add(btn_KişiYenile);
            Controls.Add(textBox4);
            Controls.Add(btn_KişiAra);
            Controls.Add(groupBoxKitap);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txt_isim);
            Name = "AdminSayfasi";
            Text = "AdminSayfasi";
            Load += AdminSayfasi_Load;
            txt_isim.ResumeLayout(false);
            txt_isim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBoxKitap.ResumeLayout(false);
            groupBoxKitap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox txt_isim;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label txt_Soyİsim;
        private TextBox textBox1;
        private Label txt_id;
        private TextBox textBox7;
        private Label txt_Yetki;
        private TextBox textBox6;
        private Label txt_Şifre;
        private TextBox textBox5;
        private Label txt_KullanıcıAdı;
        private Label txt_oluşturmaTarihi;
        private Button btn_Güncelle;
        private Button btn_Sil;
        private Button btn_Ekle;
        private Button btn_Temizle;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn İsim;
        private DataGridViewTextBoxColumn soyisim;
        private DataGridViewTextBoxColumn oluşturmTarih;
        private DataGridViewTextBoxColumn kullaniciAdi;
        private DataGridViewTextBoxColumn sifre;
        private DataGridViewTextBoxColumn yetki;
        private MaskedTextBox maskedTextBox2;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn kitapid;
        private DataGridViewTextBoxColumn kitapisim;
        private DataGridViewTextBoxColumn kitapyazar;
        private DataGridViewTextBoxColumn kitapdili;
        private DataGridViewTextBoxColumn yayinevi;
        private DataGridViewTextBoxColumn tür;
        private DataGridViewTextBoxColumn adet;
        private DataGridViewTextBoxColumn sayfaSayisi;
        private DataGridViewTextBoxColumn basimyili;
        private GroupBox groupBoxKitap;
        private Button btn_KitapTemizle;
        private Button btn_KitapGüncelle;
        private Button btn_KitapSil;
        private Button btn_KitapEkle;
        private TextBox txt_kitapAdet;
        private Label label4;
        private TextBox txt_KitapTür;
        private Label label5;
        private TextBox txt_KitapYAyınEvi;
        private Label label6;
        private Label label7;
        private TextBox txt_Kitapİsim;
        private Label label8;
        private TextBox txt_KitapYazar;
        private Label label9;
        private TextBox txt_kitapid;
        private Label label10;
        private TextBox txt_kitapBasımYılı;
        private TextBox txt_KitapSayfa;
        private Label label12;
        private TextBox txt_KitapDili;
        private Label label11;
        private Button btn_KişiAra;
        private TextBox textBox4;
        private Button btn_KişiYenile;
        private Button btn_KitapYenile;
        private TextBox textBox8;
        private Button btn_KitapAra;
        private Button btn_Çıkış;
    }
}
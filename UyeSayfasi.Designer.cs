namespace Kütüphane_otomasyonu
{
    partial class UyeSayfasi
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
            btn_ara = new Button();
            btn_Yenile = new Button();
            txt_KitapID = new TextBox();
            btn_Çıkış = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btn_ara
            // 
            btn_ara.Location = new Point(60, 45);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(75, 24);
            btn_ara.TabIndex = 0;
            btn_ara.Text = "ara";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            // 
            // btn_Yenile
            // 
            btn_Yenile.Location = new Point(247, 45);
            btn_Yenile.Name = "btn_Yenile";
            btn_Yenile.Size = new Size(75, 24);
            btn_Yenile.TabIndex = 1;
            btn_Yenile.Text = "yenile";
            btn_Yenile.UseVisualStyleBackColor = true;
            btn_Yenile.Click += button2_Click;
            // 
            // txt_KitapID
            // 
            txt_KitapID.Location = new Point(141, 46);
            txt_KitapID.Name = "txt_KitapID";
            txt_KitapID.Size = new Size(100, 23);
            txt_KitapID.TabIndex = 2;
            // 
            // btn_Çıkış
            // 
            btn_Çıkış.Location = new Point(12, 359);
            btn_Çıkış.Name = "btn_Çıkış";
            btn_Çıkış.Size = new Size(103, 32);
            btn_Çıkış.TabIndex = 4;
            btn_Çıkış.Text = "Çıkış Yap";
            btn_Çıkış.UseVisualStyleBackColor = true;
            btn_Çıkış.Click += btn_Çıkış_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { kitapid, kitapisim, kitapyazar, kitapdili, yayinevi, tür, adet, sayfaSayisi, basimyili });
            dataGridView2.Location = new Point(12, 77);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(718, 276);
            dataGridView2.TabIndex = 5;
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
            // UyeSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(btn_Çıkış);
            Controls.Add(txt_KitapID);
            Controls.Add(btn_Yenile);
            Controls.Add(btn_ara);
            Name = "UyeSayfasi";
            Text = "UyeSayfasi";
            Load += UyeSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ara;
        private Button btn_Yenile;
        private TextBox txt_KitapID;
        private Button btn_Çıkış;
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
    }
}
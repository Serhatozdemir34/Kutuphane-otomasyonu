namespace Kütüphane_otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Kullanıcı_TextBox = new TextBox();
            label2 = new Label();
            Şifre_TextBox = new TextBox();
            Giriş_buttuon = new Button();
            TemizleButton = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            label1.Click += label1_Click;
            // 
            // Kullanıcı_TextBox
            // 
            Kullanıcı_TextBox.Location = new Point(223, 37);
            Kullanıcı_TextBox.Name = "Kullanıcı_TextBox";
            Kullanıcı_TextBox.Size = new Size(156, 23);
            Kullanıcı_TextBox.TabIndex = 2;
            Kullanıcı_TextBox.TextChanged += Kullanıcı_TextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 94);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            label2.Click += label2_Click;
            // 
            // Şifre_TextBox
            // 
            Şifre_TextBox.Location = new Point(223, 94);
            Şifre_TextBox.Name = "Şifre_TextBox";
            Şifre_TextBox.Size = new Size(156, 23);
            Şifre_TextBox.TabIndex = 4;
            Şifre_TextBox.TextChanged += Şifre_TextBox_TextChanged;
            // 
            // Giriş_buttuon
            // 
            Giriş_buttuon.Location = new Point(223, 144);
            Giriş_buttuon.Name = "Giriş_buttuon";
            Giriş_buttuon.Size = new Size(75, 23);
            Giriş_buttuon.TabIndex = 5;
            Giriş_buttuon.Text = "Giriş Yap";
            Giriş_buttuon.UseVisualStyleBackColor = true;
            Giriş_buttuon.Click += GirişYap_Clicked;
            // 
            // TemizleButton
            // 
            TemizleButton.Location = new Point(304, 144);
            TemizleButton.Name = "TemizleButton";
            TemizleButton.Size = new Size(75, 23);
            TemizleButton.TabIndex = 6;
            TemizleButton.Text = "temizle";
            TemizleButton.UseVisualStyleBackColor = true;
            TemizleButton.Click += TemizleButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(380, 413);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 272);
            Controls.Add(button3);
            Controls.Add(TemizleButton);
            Controls.Add(Giriş_buttuon);
            Controls.Add(Şifre_TextBox);
            Controls.Add(label2);
            Controls.Add(Kullanıcı_TextBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Kullanıcı_TextBox;
        private Label label2;
        private TextBox Şifre_TextBox;
        private Button Giriş_buttuon;
        private Button TemizleButton;
        private Button button3;
    }
}

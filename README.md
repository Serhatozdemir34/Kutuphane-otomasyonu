# 📚 Kütüphane Yönetim Otomasyonu

C# ve Windows Forms (WinForms) kullanılarak geliştirilmiş, rol tabanlı (Admin / Üye) bir kütüphane yönetim masaüstü uygulamasıdır.

---

## 🚀 Özellikler

### 🔐 Kimlik Doğrulama & Yetkilendirme
- Kullanıcı adı ve şifre ile güvenli giriş kontrolü.
- Giriş yapan kullanıcının yetkisine göre (**Admin** veya **Üye**) dinamik yönlendirme.

### 🛠️ Admin Paneli
- **Üye Yönetimi:** Yeni üye ekleme, mevcut üyeleri silme, bilgilerini güncelleme ve tüm üyeleri listeleme.
- **Kitap Yönetimi:** Kütüphaneye kitap ekleme, silme, güncelleme ve kitap bilgilerini (Yazar, Dil, Yayınevi, Sayfa Sayısı vb.) görüntüleme.
- **Arama & Filtreleme:** Üyeler ve kitaplar arasında hızlı arama yapabilme.
- `DataGridView` entegrasyonu ile seçilen kaydın otomatik olarak giriş alanlarına doldurulması.

### 📖 Üye Paneli
- Mevcut kütüphane arşivini inceleme ve kitap arama.
- Kitapların detay bilgilerine ve durumlarına erişim.

---

## 🛠️ Kullanılan Teknolojiler
- **Dil:** C# (.NET)
- **Arayüz:** Windows Forms (WinForms)
- **Mimari/Kavramlar:** Nesne Yönelimli Programlama (OOP), Model Sınıfları (`Kisi`, `Kitap`), Olay Tabanlı Programlama (Event-driven)

---

## 💻 Kurulum ve Çalıştırma

1. Bu depoyu klonlayın veya ZIP olarak indirin:
   ```bash
   git clone [https://github.com/Serhatozdemir34/Kutuphane-otomasyonu.git](https://github.com/Serhatozdemir34/Kutuphane-otomasyonu.git)

<img src="https://opengraph.githubassets.com/1/abdullahal1114/OgrenciNotTakipSistemi" alt="Social Preview" width="0" height="0" style="display:none;" />


## Öğrenci Not Takip Sistemi

Bu proje, öğrencilerin sisteme kaydedilmesi, ders atamalarının yapılması ve seçilen derslere ait vize, final ve bütünleme (büt) notlarının yönetilmesini sağlayan masaüstü tabanlı bir **Windows Forms** uygulamasıdır. 

Eğitim kurumlarında dönem sonu not yönetim süreçlerini kolaylaştırmak ve verileri düzenli bir şekilde tutmak amacıyla tasarlanmıştır.

## 🚀 Projenin Özellikleri
* **Kullanıcı Yetkilendirmesi:** Güvenli giriş ekranı ile sisteme yetkisiz erişimlerin engellenmesi.
* **Yönetim Paneli:** Öğrenci ekleme, ders atama ve not girişi gibi ana modüllere kolay erişim sağlayan arayüz.
* **Öğrenci Yönetimi:** Yeni öğrencilerin ad, soyad ve okul numarası bilgileriyle sisteme kaydedilmesi.
* **Ders Atama Yapısı:** Kayıtlı öğrencilere dinamik olarak alacakları derslerin tanımlanması.
* **Esnek Not Hesaplama:** Seçilen öğrenci ve derse göre Vize (%40), Final (%60) veya gerektiğinde Bütünleme (%60) notlarının girilerek dönem sonu başarı notunun otomatik hesaplanması ve listelenmesi.

## 🛠️ Kullanılan Teknolojiler
* **Dil:** C# (.NET)
* **Arayüz:** Windows Forms (WinForms)
* **Veritabanı:** Microsoft SQL Server (MS SQL)
* **Veri Erişimi:** ADO.NET / Entity Framework Core (Repository Pattern)
  
## 📖 Uygulama Kullanım Kılavuzu

Projenin tüm fonksiyonlarını doğru bir şekilde test etmek için aşağıdaki adımları sırasıyla takip edebilirsiniz:

1. **Sisteme Giriş:** Uygulama açıldığında karşınıza gelen ekranda, kılavuzun altındaki test kullanıcı adı ve şifresini girerek **Giriş** butonuna basın.
2. **Yönetim Paneli:** Başarılı giriş yaptıktan sonra açılan ana panel üzerinden yapmak istediğiniz modülü (Öğrenci Ekleme, Ders Atama veya Not Girişi) seçin.
3. **Öğrenci Kaydı:** İlk olarak Öğrenci Ekleme ekranına giderek yeni bir öğrenci adı, soyadı ve okul numarası girip **Kaydet** butonuna basın.
4. **Ders Tanımlama:** Ders Atama ekranına geçiş yapın. Listeden az önce eklediğiniz öğrenciyi seçin ve bu öğrenciye alması gereken dersi atayarak sisteme tanımlayın.
5. **Not Girişi ve Hesaplama:** Son olarak Not Giriş ekranına gelin. İlgili öğrenciyi ve dersi seçtikten sonra Vize ve Final notlarını girip **Hesapla ve Kaydet** butonuna basın. Sistem dönem sonu başarı notunu otomatik hesaplayıp alt taraftaki listede (DataGridView) anlık olarak gösterecektir.
6. **Bütünleme (Büt) Durumu:** Eğer öğrencinin final notu yetersizse ve bütünleme sınavına girdiyse, Bütünleme notunu girerek başarı notunun güncellenmesini sağlayabilirsiniz.

## 📸 Uygulama Ekran Görüntüleri

### 1. Kullanıcı Giriş Ekranı

<img width="796" height="483" alt="ogrencinottakip1" src="https://github.com/user-attachments/assets/469b90e1-6e7f-416b-b13e-22a8ad01b73d" />


### 2. İşlem Seçim (Yönetim) Paneli

<img width="799" height="480" alt="ogrencinottakip2" src="https://github.com/user-attachments/assets/07268353-b970-40f2-9420-88bc0742569a" />



### 3. Öğrenci Kayıt Ekranı (Öğrenci Adı ve Numarası Ekleme)

<img width="800" height="466" alt="ogrencinottakip3" src="https://github.com/user-attachments/assets/1080f47b-0aa8-4545-a086-092da7570d0b" />



### 4. Ders Atama Ekranı (Öğrenciye Ders Tanımlama)

<img width="799" height="476" alt="ogrencinottakip4" src="https://github.com/user-attachments/assets/a4eb38dd-bd1b-4c92-943d-39f3922eeb96" />





### 5. Not Giriş ve Hesaplama Ekranı (Vize, Final, Büt Notları)

<img width="799" height="483" alt="ogrencinottakip5" src="https://github.com/user-attachments/assets/09a2ded1-94d7-4ef6-bdb0-3fe7ae7dc5e4" />



## 💻 Kurulum, Çalıştırma ve Giriş Bilgileri

### 🔑 Test Giriş Bilgileri
Projenin kullanıcı giriş ekranını geçmek için aşağıdaki bilgileri kullanabilirsiniz:
* **Kullanıcı Adı:** admin
* **Şifre:** 1234


### 🛠️ Kurulum Adımları
1. Bu projeyi bilgisayarınıza indirin (Clone veya Download ZIP).
2. Proje klasöründe bulunan `.sln` uzantılı dosyayı **Visual Studio** ile açın.
3. Veritabanı bağlantı adresini (Connection String) kendi SQL Server yapınıza göre düzenleyin.
4. Projeyi derlemek ve çalıştırmak için Visual Studio üzerinden **Start (Başlat)** butonuna basın.

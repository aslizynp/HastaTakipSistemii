# 🏥 Hasta Takip Otomasyon Sistemi

C# ve SQL Server tabanlı bu masaüstü uygulaması, bir sağlık kuruluşunun hasta kayıtlarını yönetmek, verileri güvenli bir şekilde depolamak ve demografik analizler yapmak amacıyla geliştirilmiştir.

## 🚀 Öne Çıkan Özellikler

### 🔐 Güvenlik ve Erişim Modülü
* **Kullanıcı Kayıt Sistemi:** Personellerin sisteme dahil olabileceği özel kayıt ekranı.
* **Giriş Paneli:** Yetkilendirilmiş kullanıcılar için şifreli giriş arayüzü.

### 📋 Hasta Yönetim Merkezi (Ana Sayfa)
Uygulamanın ana yönetim paneli üzerinden aşağıdaki işlemler dinamik olarak gerçekleştirilmektedir:
* **Kaydet:** Hasta bilgilerini (Ad, Soyad, Yaş, Cinsiyet vb.) SQL Server'a işler.
* **Güncelle:** Mevcut kayıtları anlık olarak modernize eder.
* **Sil:** Geçersiz veya hatalı kayıtları veritabanından temizler.
* **Listele:** Tüm verileri `DataGridView` üzerinde anlık görüntüler.
* **Form Temizle:** Yeni girişler için veri alanlarını hızlıca sıfırlar.

### 📊 İstatistik ve Analiz Modülü
Veritabanındaki verileri otomatik olarak işleyen analiz sayfası:
* **Toplam Hasta Sayısı:** Kayıtlı güncel kapasiteyi raporlar.
* **Cinsiyet Dağılımı:** Kadın ve erkek hasta sayılarını ayrı ayrı sunar.
* **Yaş Analizi:** Kayıtlı hastaların yaş ortalamasını otomatik hesaplar.

## 🛠 Teknik Mimari
* **Dil:** C# (Windows Form)
* **Veritabanı:** Microsoft SQL Server
* **Veri Erişimi:** ADO.NET / SQL Client
* **Geliştirme Ortamı:** Visual Studio

## ⚙️ Kurulum ve Çalıştırma
1. Bu depoyu (repository) klonlayın.
2. SQL Server bağlantı dizesini (`connectionString`) kendi yerel sunucunuza göre güncelleyin.
3. Projeyi Visual Studio ile derleyip çalıştırın.

---

## 📸 Uygulama Görselleri

### 1. Giriş ve Kayıt Ekranları
| Giriş Yap | Yeni Kullanıcı Kaydı |
| :---: | :---: |
| ![Giriş Ekranı](https://github.com/aslizynp/HastaTakipSistemii/blob/master/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-29%20000744.png?raw=true) | ![Kayıt Ekranı](https://github.com/aslizynp/HastaTakipSistemii/blob/master/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-29%20000810.png?raw=true) |

### 2. Ana Yönetim Paneli
![Ana Sayfa](https://github.com/aslizynp/HastaTakipSistemii/blob/master/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-29%20001022.png?raw=true)

### 3. İstatistik ve Analiz Sayfası
![İstatistik Sayfası](https://github.com/aslizynp/HastaTakipSistemii/blob/master/Ekran%20g%C3%B6r%C3%BCnt%C3%BCs%C3%BC%202026-01-29%20001036.png?raw=true)

---
⭐ **Geliştiren:** [Aslı Zeynep Çelen]
📍 **Zonguldak Bülent Ecevit Üniversitesi** - Bilgisayar Mühendisliği 3. Sınıf 

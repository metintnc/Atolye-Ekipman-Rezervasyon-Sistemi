# 🛠️ Atölye Ekipman Rezervasyon Sistemi

Bu proje, bir atölyedeki ekipmanların üyeler tarafından ödünç alınmasını, rezerve edilmesini ve iade süreçlerini yöneten bir C# Konsol uygulamasıdır. **Nesne Yönelimli Programlama (OOP)** prensiplerine uygun olarak geliştirilmiştir.

## 📝 Proje Hakkında

Uygulama, kullanıcıların sisteme giriş yaparak matkap, testere gibi atölye ekipmanlarını kiralamasına olanak tanır. Sistem; ekipmanların müsaitlik durumunu, bakımda olup olmadıklarını ve önceki kullanıcı geçmişini takip eder.

Bu proje, **Bilgisayar Mühendisliği OOP Dersi** kapsamında; sınıf tasarımı, kapsülleme (encapsulation) ve iş akışı yönetimi yeteneklerini sergilemek amacıyla hazırlanmıştır.

## 🚀 Teknik Özellikler ve Mimari

Proje toplamda **5 temel sınıf** üzerine kurulmuştur:

1.  **Kullanıcı:** Üye bilgilerini ve giriş işlemlerini yönetir.
2.  **Ekipman:** Atölyedeki aletlerin isimlerini ve kodlarını tutar.
3.  **Musaitlik:** Ekipmanların doluluk/boşluk durumunu kontrol eder.
4.  **Bakım:** Rastgele olarak bazı ekipmanları "Bakımda" durumuna getirir ve kiralanmasını engeller.
5.  **İslem:** Ödünç alma, rezervasyon ve iade iş akışlarını yönetir; önceki kullanıcıyı hafızada tutar.

## ✨ Eklenen Özgün Kurallar

Ödev kapsamında istenen "Özgün Kurallar" şu şekilde sisteme entegre edilmiştir:

* **🔞 Yaş Sınırlaması:** Tehlikeli ekipmanlar (Örn: Matkap, Testere) için 18 yaş kontrolü vardır. 18 yaşından küçük üyeler bu ekipmanları ödünç alamaz.
* **📅 Süre Kısıtlaması:** Bir ekipman en fazla **7 gün** süreyle ödünç alınabilir.

## 💻 Nasıl Çalışır?

Program başlatıldığında rastgele bazı ekipmanlar "Bakım" moduna alınır.

1.  **Giriş:** Kullanıcı üye olur veya mevcut listeden giriş yapar.
2.  **Yaş Kontrolü:** Kullanıcının yaşı istenir.
3.  **İşlem Seçimi:** Ödünç Alma, Rezervasyon veya İade seçilir.
4.  **Kontroller:** Seçilen ekipman bakımda mı? Başkası kullanıyor mu? Yaş yetiyor mu?
5.  **Sonuç:** İşlem başarılıysa ekrana döküm verilir:
    > *"Ekipman: Matkap, Kodu: M001, Ödünç Alan: Ali, Süre: 3 Gün, Önceki Kullanıcı: Ahmet"*

## 🛠 Kullanılan Teknolojiler

* **Dil:** C# (.NET)
* **Veri Yönetimi:** `List<T>` koleksiyonları (Veritabanı yerine bellek içi yönetim)
* **Hata Yönetimi:** `Try-Catch` blokları ile kullanıcı hataları yakalanır.

---
**Geliştirici:** [Adın Soyadın]

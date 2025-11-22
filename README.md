Bir Atölye Ekipman Rezervasyon Sistemi

Bu proje, bir atölyedeki ekipmanların üyeler tarafından rezervasyon, ödünç alma ve iade süreçlerinin yönetilmesini sağlayan basit bir OOP tabanlı C# konsol uygulamasıdır. Tüm veriler bellek içinde tutulur.

🎯 Amaç

OOP prensiplerine uygun bir sınıf yapısı tasarlamak

En az 5 farklı sınıf ve anlamlı bir hiyerarşi kullanmak

Ekipmanların müsaitlik, bakım durumu ve işlem akışlarının kontrolünü sağlamak

Özgün kurallar ekleyerek sistemi zenginleştirmek



🧩 Temel Özellikler

✔ Üyeler

Sisteme kayıtlı üyeler ekipmanları rezervasyon yapabilir ve ödünç alabilir.

Geçmiş işlem bilgileri tutulur.


✔ Ekipmanlar

Her ekipmanın bir kodu, adı ve durumu vardır.

Bakımda olan ekipman ödünç verilemez.

Müsaitlik kontrolü tüm işlemlerden önce zorunludur.


✔ İş Akışları

Rezervasyon

Ödünç Alma

İade

İade işleminden sonra önceki kullanıcı bilgisi sistemde saklanır ve gösterilir.


🛠 Ek OOP Gereksinimleri

Tüm alanlar private, dış erişim property/metot ile sağlanır.

Anlamlı hata/istisna yönetimi içerir.

Veriler List<> ve Dictionary<> yapılarıyla RAM’de tutulur.

En az 5 sınıf bulunur (örnek: Member, Equipment, Reservation, LoanManager, WorkshopSystem).



⭐ Özgün Kurallar

Projeye iki özel kural eklenmiştir:


1. Eğitim Zorunluluğu

Bazı ekipmanlar için belirli bir eğitim tamamlamış olmak gerekir.

Eğitim almamış üyeler bu ekipmanı rezervasyon yapamaz veya ödünç alamaz.


2. Maksimum Kullanım Süresi

Her ekipmanın maksimum kullanım süresi vardır.

Süre aşıldığında sistem uyarı verir veya işlem reddedilir.

```
📤 Örnek Çıktı
Ekipman: Matkap  
Kodu: EQ-101  
Ödünç: Metin  
İade: 22.11.2025  
Önceki: Ahmet
```

🚀 Çalıştırma

Proje bir C# .NET konsol uygulamasıdır.

Herhangi bir veritabanı kullanılmaz.

Uygulama doğrudan Program.cs üzerinden başlatılır.

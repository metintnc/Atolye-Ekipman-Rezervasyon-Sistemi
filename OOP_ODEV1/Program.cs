using System;
Bakım B = new Bakım();
B.RastgeleBakımAta();
İslem islemler = new İslem();

while (true)
{
    bool devam = false;
    int secilenkullanıcı = 0;
    while (devam == false)
    {
        try
        {
            Console.WriteLine("Üye Ol(1)/Giriş Yap(2)");
            int sonuc = Convert.ToInt32(Console.ReadLine());

            if (sonuc == 1)
            {
                Console.WriteLine("Adınız: ");
                islemler.Uye.KaydetKullanıcıAdi(Console.ReadLine());
                devam = true;
                secilenkullanıcı = islemler.Uye.GetListuzunluğu();
                islemler.Uye.ShowKullanıcılar();
            }
            else if (sonuc == 2)
            {
                Console.WriteLine("Kullanıcı Adınızı Seçiniz.");
                islemler.Uye.ShowKullanıcılar();
                try
                {
                    secilenkullanıcı = Convert.ToInt32(Console.ReadLine());
                    islemler.Uye.SecKullanıcıAdı(secilenkullanıcı);
                    devam = true;
                }
                catch
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
                }
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen 1 veya 2 giriniz.");
            }
        }
        catch
        {
            Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
        }
    } // girişyap kısmı
    int yas = 0;
    bool devamyas = false;
    while (devamyas == false)
    {
        try
        {
            Console.WriteLine("Kaç Yaşındasınız?");
            yas = Convert.ToInt32(Console.ReadLine());
            devamyas = true;
        }
        catch
        {
            Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
        }
    }

    int islemsecim = 0;
    bool devamislem = false;
    while (devamislem == false)
    {
        try
        {
            Console.WriteLine("\nYapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("Ödünç Alma(1)\nRezervasyon(2)\nİade(3)");
            islemsecim = Convert.ToInt32(Console.ReadLine());
            if (islemsecim == 1 || islemsecim == 2 || islemsecim == 3)
                devamislem = true;
            else
                Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen 1, 2 veya 3 giriniz.");
        }
        catch
        {
            Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
        }
    } // islem secme

    if (islemsecim == 1 || islemsecim == 2)
    {
        Console.WriteLine("İşlem Yapmak İstediğiniz Ekipmanı Seçiniz");
        islemler.E.ShowEkipmanlar();
    }
    else
    {
        Console.WriteLine("İade Etmek İstediğiniz Ekipmanı Seçiniz.");
        islemler.M.DoluEkipmanlar();
        islemler.E.DoluEkipmanlarıGöster(islemler.M.GetDolular());
    }

    bool ekipmansecdevam = false;
    int ekipmansecim = 0;
    while (!ekipmansecdevam)
    {
        try
        {
            ekipmansecim = Convert.ToInt32(Console.ReadLine());
            

            if (islemsecim == 3 && islemler.M.KontrolEt(ekipmansecim))
                Console.WriteLine("Seçtiğiniz Ekipman kimse tarafından ödünç alınmamıştır. İade edemezsiniz.");
            else if (islemsecim == 3)
                ekipmansecdevam = true;
            else if (!islemler.M.KontrolEt(ekipmansecim))
                Console.WriteLine("Bu ekipman müsait değil. Lütfen farklı bir ekipman seçiniz.");
            else if (B.BakımKontrol(ekipmansecim))
                Console.WriteLine("Bu Ekipman Şuanda Bakımda.");
            else if (ekipmansecim < 8 && ekipmansecim > 0)
            {
                ekipmansecdevam = true;
                islemler.E.SecEkipman(ekipmansecim);
            }
            else
                Console.WriteLine("Hatalı Seçim Yaptınız. Lütfen tekrar deneyin.");
            if (yas < 18)
            {
                if (ekipmansecim == 1 || ekipmansecim == 3 || ekipmansecim == 4)
                {
                    Console.WriteLine("18yaşından küçük olduğunuz için bu ekipmanı kullanamazsınız.");
                    ekipmansecdevam = false;
                }
            }
        }
        catch
        {
            Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
        }
    } // ekipman secme

    islemler.M.DoluGöster(ekipmansecim);
    islemler.GetSonEkipman(ekipmansecim);

    if (islemsecim == 1)
    {
        bool oduncbool = false;
        while (!oduncbool)
        {
            try
            {
                Console.WriteLine("\nKaç gün ödünç almak istiyorsunuz? (1-7)");
                int oduncsuresi = Convert.ToInt32(Console.ReadLine());
                if (oduncsuresi >= 1 && oduncsuresi <= 7)
                {
                    oduncbool = true;
                    islemler.Odunc(oduncsuresi);
                }
                else
                    Console.WriteLine("1 ile 7 arasında bir sayı giriniz.");
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
            }
        }
    }
    else if (islemsecim == 2)
    {
        bool rezervasyonbool = false;
        Console.WriteLine("\nKaç gün sonrası için rezervasyon yaptırmak istiyorsunuz?");
        int rezervasyon = Convert.ToInt32(Console.ReadLine());
        while (!rezervasyonbool)
        {
            try
            {
                Console.WriteLine($"{rezervasyon} gün sonrası için kaç günlük ödünç almak istiyorsunuz? (1-7)");
                int rezervodunc = Convert.ToInt32(Console.ReadLine());
                if (rezervodunc >= 1 && rezervodunc <= 7)
                {
                    rezervasyonbool = true;
                    islemler.Rezervasyon(rezervasyon, rezervodunc);
                }
                else
                    Console.WriteLine("1 ile 7 arasında bir sayı giriniz.");
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Lütfen sayı giriniz.");
            }
        }
    }
    else if (islemsecim == 3)
    {
        islemler.M.İadeEt(ekipmansecim);
        islemler.İade();
    }

    Console.WriteLine("\nBaşka bir işlem yapmak istiyor musunuz? Evet(1), Hayır(2)");
    try
    {
        int kapat = Convert.ToInt32(Console.ReadLine());
        if (kapat == 1)
            Console.WriteLine("Başa dönülüyor.");
        else if (kapat == 2)
        {
            Console.WriteLine("Program kapatılıyor.");
            break;
        }
    }
    catch
    {
        Console.WriteLine("Geçersiz giriş! Program başa dönüyor.");
    }
}



public class Kullanıcı
{
    private string kullanıcıadi;
    private List<string> Uyeler = new List<string>() {"Ali","Ayşe","Miraç","Ahmet","İsmail","Furkan","Ege","Hamza"};  
    
    public void KaydetKullanıcıAdi(string kullanıcıadi)
    {
        this.kullanıcıadi = kullanıcıadi;
        Uyeler.Add(kullanıcıadi);
    }
    public void SecKullanıcıAdı(int secilen)
    {
        kullanıcıadi = Uyeler[secilen-1];
    }
    public void ShowKullanıcılar()
    {   
        int sıra = 1;
        foreach (var i in Uyeler)
        {
            Console.WriteLine(sıra + " - " + i);
            sıra++;
        }
    }
    public string GetKullanıcı()
    {
        return kullanıcıadi;
    }
    public int GetListuzunluğu()
    {
        return Uyeler.Count;
    }
}

public class Ekipman
{
    private List<string> Ekipmanlar = new List<string>() {"Matkap","Tornavida","Testere","Lehim Seti","Pense","İngiliz Anahtarı","Çekiç" };
    private List<string> EkipmanKodları = new List<string>() { "M001", "M002", "M003", "M004", "M005", "M006", "M007" };
    private string secilenekipman;
    private string secilenkod;
    public void ShowEkipmanlar()
    {
        int sıra = 1;
        foreach (var i in Ekipmanlar)
        {
            Console.WriteLine(sıra + " - " + i);
            sıra++;
        }
    }
    public void SecEkipman(int secilensayı)
    {
        secilenekipman = Ekipmanlar[secilensayı-1];
        secilenkod = EkipmanKodları[secilensayı-1];
    }
    public string GetEkipman()
    {
        return secilenekipman;
    }
    public string GetEkipmanKodu()
    {
        return secilenkod;
    }

    public void DoluEkipmanlarıGöster(List<int> dolular)
    {
        foreach(var i in dolular)
        {
            Console.WriteLine(i+1 + " - " + Ekipmanlar[i]);       
        }
    }
}

public class Musaitlik
{
    private int secilen;
    private List<bool> Musaitmi = new List<bool>() { true, true, true, true, true, true, true };
    private List<int> Dolular = new List<int>();

    public bool KontrolEt(int secilen)
    {
        Console.Write("Kontrol Ediliyor\n");
        if (Musaitmi[secilen-1] == true)
        {
            Console.WriteLine("Ekipman Müsait");
            return true;
        }
        else
            return false;
    }
    public void DoluGöster(int secilen)
    {
        this.secilen = secilen;
        Musaitmi[secilen - 1] = false;
    }
    public void İadeEt(int iadeedilen)
    {
        Musaitmi[iadeedilen - 1] = true;
        Dolular.Remove(iadeedilen);
        Console.WriteLine("İade İşleminiz Tamamlandı.\n");
    }
    public void DoluEkipmanlar()
    {
        Dolular.Clear();
        for (int i = 0; i < Musaitmi.Count; i++)
        {
            if(Musaitmi[i] == false)
                Dolular.Add(i);
        }
    }
    public List<int> GetDolular()
    {
        return Dolular;
    }
}

public class İslem
{
    private int sonkullanılanekip;
    public Kullanıcı Uye = new Kullanıcı();
    public Ekipman E = new Ekipman();
    public Musaitlik M = new Musaitlik();
    private string[] sonkullanıcı = new string []{"Yok","Yok","Yok", "Yok", "Yok", "Yok", "Yok"};
  
    public void GetSonEkipman(int sonkullanılanekipman)
    {
        this.sonkullanılanekip = sonkullanılanekipman-1;
    }
    public void Odunc(int odunc)
    {
        Console.WriteLine("Ekipman: "+ E.GetEkipman()+", Ekipman Kodu: "+E.GetEkipmanKodu()+", Ödünç Alan: "+ Uye.GetKullanıcı()+", Ödünç Alma Süresi: "+odunc+", Önceki Kullanıcı: " + sonkullanıcı[sonkullanılanekip]);
    }
    public void Rezervasyon(int rezervasyon, int odunc)
    {
        Console.WriteLine("Ekipman: " + E.GetEkipman() + ", Ekipman Kodu: " + E.GetEkipmanKodu() + ", Ödünç Alan: " + Uye.GetKullanıcı() + ", Ödünç Alma Süresi: " + odunc + ", Alınan Rezervasyon Tarihi: "+ rezervasyon + "Gün Sonra, Önceki Kullanıcı" + sonkullanıcı[sonkullanılanekip]);
    }
    public void İade()
    {
        Console.WriteLine("Ekipman: " + E.GetEkipman() + ", Ekipman Kodu: " + E.GetEkipmanKodu() + ", İade Eden: " + Uye.GetKullanıcı());
        sonkullanıcı[sonkullanılanekip] = Uye.GetKullanıcı();
    }
}
public class Bakım
{
    private List<bool> bakımda = new List<bool> { false, false,false, false, false, false, false, };
    Random rnd = new Random();
    public void RastgeleBakımAta()
    {
        int birinci = rnd.Next(0,7);
        int ikinci = rnd.Next(0,7);
        bakımda[birinci] = true;
        bakımda[ikinci] = true;
    }
    public bool BakımKontrol(int secilen)
    {
        if (bakımda[secilen - 1] == true)
            return true;
        else
            return false;
    }
}
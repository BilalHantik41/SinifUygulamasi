using System.ComponentModel.Design;
using İlkSınıf;

Person Öğrenci = new Person();
Person Öğretmen = new Person();

// Öğretmenmi Öğrenci mi Bilgisi Girileceğini Seçtiriyoruz
Console.WriteLine("Lütfen Bilgilerini girmek istediğiniz kişiyi seçiniz:");
Console.Write("Seçiminiz (1-2): ");
string giris = Console.ReadLine();

// Giriş geçerli bir tam sayı mı ve sözlükte tanımlı bir anahtar mı kontrol et
if (!int.TryParse(giris, out int secim))
{
    // Hatalı giriş: kullanıcı bilgilendirilir ve işlemi kapatır.
    Console.WriteLine(" Geçersiz seçim. Program sonlaniyor.");
    return;
}

if (secim == 1)
{

    Console.WriteLine("Öğretmen bilgilerini Dolduruyorsunuz");
    Console.WriteLine("************************************");
    Console.WriteLine("Lütfen Adınızı Giriniz: ");
    Öğretmen.Ad = Console.ReadLine();
    Console.WriteLine("Lütfen SoyAdınızı Giriniz: ");
    Öğretmen.SoyAd = Console.ReadLine();

    Console.Write("Doğum tarihinizi gg.aa.yyyy formatında giriniz: ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime dt))
    {
        Öğretmen.DogumTarihi = dt;
    }
    else
    {
        Console.WriteLine("Geçersiz tarih girdiniz.");
        return;
    }


}
else if (secim == 2)
{

    Console.WriteLine("Öğrenci bilgilerini dolduruyorsunuz");
    Console.WriteLine("************************************");
    Console.WriteLine("Lütfen Adınızı Giriniz: ");
    Öğrenci.Ad = Console.ReadLine();
    Console.WriteLine("Lütfen SoyAdınızı Giriniz: ");
    Öğrenci.SoyAd = Console.ReadLine();

    Console.Write("Doğum tarihinizi gg.aa.yyyy formatında giriniz: ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime dt))
    {
        Öğrenci.DogumTarihi = dt;
    }
    else
    {
        Console.WriteLine("Geçersiz tarih girdiniz.");
        return;
    }


}
else
{
    Console.WriteLine("Hatalı seçim yapılmış.!");
}


static void Yazdir(Person kişi)
{
    Console.WriteLine("-----------");
    Console.WriteLine($"Ad: {kişi.Ad}");
    Console.WriteLine($"Soyad: {kişi.SoyAd}");
    Console.WriteLine($"Doğum Tarihi: {kişi.DogumTarihi}");
    Console.WriteLine("-----------");
}


// Kullanımı:
Console.WriteLine("************************************");
Yazdir(Öğrenci);
Console.WriteLine("************************************");
Yazdir(Öğretmen);
Console.WriteLine("************************************");

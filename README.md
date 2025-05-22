Sınıf Uygulaması (İlkSınıf)

Açıklama
Bu proje, öğretmen ve öğrenci bilgilerini konsol üzerinden alıp işleyen basit bir .NET konsol uygulamasıdır.

Özellikler

Kullanıcıyı öğretmen veya öğrenci olarak seçmeye yönlendiren menü.

Seçilen role göre Ad, Soyad ve Doğum Tarihi (gg.aa.yyyy formatı) bilgisi girişi.

Girilen bilgilerin ekrana yazdırılması.

Önkoşullar

.NET 6.0 SDK veya daha yeni bir sürüm

C# diline aşinalık

Kurulum ve Çalıştırma

Depoyu klonlayın:

git clone https://github.com/BilalHantik41/SinifUygulamasi.git

Proje klasörüne gidin:

cd SinifUygulamasi/İlkSınıf

Bağımlılıkları yükleyip projeyi derleyin:

dotnet build

Uygulamayı çalıştırın:

dotnet run

Proje Yapısı

SinifUygulamasi/
├── İlkSınıf/                  # "Person" sınıfını içerir
│   └── Person.cs             
├── Program.cs                # Uygulamanın giriş noktası (top-level statements)
├── SinifUygulamasi.csproj    # Proje tanımı
└── README.md                 # Proje dokümantasyonu

Kullanım

Uygulamayı başlattığınızda aşağıdaki gibi bir menü görüntülenir:

Lütfen bilgilerini girmek istediğiniz kişiyi seçiniz:
1 => Öğretmen
2 => Öğrenci
Seçiminiz (1-2):

1 girildiğinde öğretmen, 2 girildiğinde öğrenci bilgisi girişi kabul edilir.

Ardından, sırasıyla Ad, Soyad ve Doğum Tarihi bilgilerini girin.

Girilen bilgiler ekrana yazdırılacaktır.

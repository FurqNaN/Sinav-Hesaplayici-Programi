🎓 SINAV NOTU HESAPLAYICI (C# WinForms)

Bu proje, öğrencilerin vize ve final notlarını girerek dönem sonu başarı puanlarını ve harf notlarını hesaplamalarını sağlayan basit ve kullanıcı dostu bir Windows Forms uygulamasıdır.

🚀 ÖZELLİKLER

Otomatik Hesaplama: 
Vize notunun %40'ı ve final notunun %60'ı alınarak genel ortalama hesaplanır.

Harf Notu Baremi:
Hesaplanan ortalamaya göre AA'dan FF'e kadar otomatik harf notu ataması yapılır.

Final Barajı Kontrolü:
Final notu 35'in altında olan öğrenciler, ortalamaya bakılmaksızın doğrudan kalmış sayılır.

Dinamik Görsel Geri Bildirim:
* Geçme durumunda form arka planı Yeşil,Sorumlu geçme durumunda Gri,Kalma durumunda ise Koyu Kırmızı renge dönüşür.

Hata Yönetimi (Exception Handling):

* Boş veya geçersiz (metin vb.) girişler için FormatException kontrolü.
* 0-100 aralığı dışındaki değerler için özel ArithmeticException uyarısı.
* Büyük sayı girişleri için OverflowException kontrolü.

🛠️ KULLANILAN TEKNOLOJİLER

Dil:C#

Platform: .NET Windows Forms

AppIDE: Visual Studio📋 

📋 NOT BAREMİ
Program içerisinde kullanılan harf notu aralıkları aşağıdadır:

    Ortalama,Harf Notu,Durum
    80 - 100,AA,Başarıyla Geçti
    70 - 79,BA,Başarıyla Geçti
    65 - 69,BB,Başarıyla Geçti
    55 - 64,CB,Başarıyla Geçti
    45 - 54,CC,Başarıyla Geçti
    40 - 44,DC,Sorumlu Geçti
    35 - 39,DD,Sorumlu Geçti
    0 - 34,FF,Kaldı


⚠️ Önemli Kod Bloğu: Hata Yakalama Uygulama, hatalı veri girişlerini önlemek için kapsamlı bir try-catch yapısı kullanmaktadır:
  
    {
        int vizenotu = Convert.ToInt32(textVize.Text);
        // Hesaplama ve mantıksal kontroller...
    }
    
    catch (FormatException)
    
    {
        MessageBox.Show("Lütfen sadece sayısal değerler giriniz!");
    }

Bu proje eğitim amaçlı geliştirilmiştir.

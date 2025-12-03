# 🌍 C# Konsol Çeviri Uygulaması

Bu proje, **C#** ve **.NET Framework** kullanılarak geliştirilmiş, komut satırı üzerinden çalışan pratik bir çeviri aracıdır. **MyMemory Translation API** kullanarak metinleri diller arasında ücretsiz ve hızlı bir şekilde çevirir.

## 🚀 Özellikler

* **Ücretsiz API:** Herhangi bir API anahtarı (API Key) veya üyelik gerektirmez.
* **Çoklu Dil Desteği:** Türkçe, İngilizce, Almanca, Japonca, Rusça ve daha fazlası dahil olmak üzere 10 farklı dil arasında çeviri yapabilir.
* **Kullanıcı Dostu Arayüz:** Dilleri kod (tr, en) yazmak yerine numaralı liste üzerinden kolayca seçebilirsiniz.
* **Renkli Çıktılar:** Hatalar ve başarılı sonuçlar farklı renklerle gösterilerek okunabilirlik artırılmıştır.

## 🛠 Gereksinimler

Projeyi çalıştırmak için bilgisayarınızda şunların yüklü olması önerilir:

* **Visual Studio** (2019, 2022 veya daha yenisi)
* **.NET Framework** (4.7.2 veya uyumlu bir sürüm)
* İnternet bağlantısı (API erişimi için şarttır)

## ⚙️ Kurulum ve Çalıştırma

Projeyi bilgisayarınıza indirip çalıştırmak için şu adımları izleyin:

1.  **Projeyi Klonlayın:**
    Terminali açın ve şu komutu yazın (veya sağ üstteki "Code" butonundan ZIP olarak indirin):
   
    git clone [https://github.com/caanergulerr/CokluDilCevirisi.git](https://github.com/caanergulerr/CokluDilCevirisi.git)
  

2.  **Projeyi Açın:**
    İndirdiğiniz klasördeki `.sln` uzantılı dosyaya çift tıklayarak Visual Studio'da açın.

3.  **Paketleri Yükleyin (Önemli):**
    Proje `Newtonsoft.Json` kütüphanesini kullanmaktadır. Visual Studio genellikle bunu otomatik yükler ancak yüklemezse:
    * Visual Studio'da **Solution Explorer**'a sağ tıklayın.
    * **Restore NuGet Packages** seçeneğine tıklayın.

4.  **Çalıştırın:**
    `F5` tuşuna basın veya üst menüdeki **Start** butonuna tıklayın.

## ▶️ Kullanım

1.  Uygulama açıldığında çevirmek istediğiniz cümleyi yazın ve `Enter`a basın.
2.  Listeden **Kaynak Dil** numarasını seçin (Örn: Türkçe için `1`).
3.  Listeden **Hedef Dil** numarasını seçin (Örn: İngilizce için `2`).
4.  Çeviri sonucu ekranda yeşil renkli olarak görünecektir.

## 📦 Kullanılan Teknolojiler

* C#
* .NET Framework
* System.Net.Http (API İstekleri için)
* Newtonsoft.Json (JSON Veri İşleme için)
* [MyMemory API](https://mymemory.translated.net/doc/)


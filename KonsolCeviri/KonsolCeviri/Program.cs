using System;
using System.Collections.Generic; 
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace KonsolCeviri
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();

        
        private static readonly Dictionary<int, (string Ad, string Kod)> diller = new Dictionary<int, (string, string)>
        {
            { 1, ("Türkçe", "tr") },
            { 2, ("İngilizce", "en") },
            { 3, ("Almanca", "de") },
            { 4, ("Fransızca", "fr") },
            { 5, ("İspanyolca", "es") },
            { 6, ("İtalyanca", "it") },
            { 7, ("Rusça", "ru") },
            { 8, ("Japonca", "ja") },
            { 9, ("Çince", "zh") },
            { 10, ("Azerice", "az") }
        };

        static async Task Main(string[] args)
        {
            Console.Title = "Gelişmiş Konsol Çeviri Uygulaması";

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== GENİŞLETİLMİŞ ÇEVİRİ UYGULAMASI ===");
                Console.ResetColor();
                Console.WriteLine("---------------------------------------");

                
                Console.Write("Çevrilecek metni girin: ");
                string metin = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(metin)) continue;

                
                Console.WriteLine("\n--- KAYNAK DİL SEÇİN ---");
                string kaynakKod = DilSecimiYap();

               
                Console.WriteLine("\n--- HEDEF DİL SEÇİN ---");
                string hedefKod = DilSecimiYap();

                
                Console.WriteLine("\nÇeviri yapılıyor...");

                try
                {
                    string sonuc = await CeviriYap(metin, kaynakKod, hedefKod);

                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("SONUÇ: " + sonuc);
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hata: " + ex.Message);
                    Console.ResetColor();
                }

                Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                Console.ReadKey();
            }
        }

        
        private static string DilSecimiYap()
        {
            
            foreach (var dil in diller)
            {
                Console.WriteLine($"{dil.Key}. {dil.Value.Ad}");
            }

            Console.Write("Seçiminiz (Numara yazın): ");

           
            if (int.TryParse(Console.ReadLine(), out int secim) && diller.ContainsKey(secim))
            {
               
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Seçilen: {diller[secim].Ad}");
                Console.ResetColor();
                return diller[secim].Kod;
            }
            else
            {
                
                Console.WriteLine("Hatalı seçim! Varsayılan olarak İngilizce (en) seçildi.");
                return "en";
            }
        }

        private static async Task<string> CeviriYap(string metin, string kaynak, string hedef)
        {
            string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(metin)}&langpair={kaynak}|{hedef}";

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string jsonCevap = await response.Content.ReadAsStringAsync();

            JObject veri = JObject.Parse(jsonCevap);

            
            if (veri["responseData"]["translatedText"] != null)
            {
                return (string)veri["responseData"]["translatedText"];
            }
            else
            {
                return "Çeviri bulunamadı.";
            }
        }
    }
}
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable Arac = new Hashtable();

        // Arac.Add(Anahtar,Değer);
        Arac.Add("33 RK 373", "SKODA");
        Arac.Add("63 ALI 1968", "FIAT");
        Arac.Add("63 SBH 1966", "VOLKSWAGEN");
        Arac.Add("63 FKN 2003", "JEEP");

        while (true) // Sonsuz döngü başlatıyoruz
        {
            Console.Write("Plaka Giriniz (Çıkmak için 'exit' yazın): ");
            string Plaka = Console.ReadLine();

            // Kullanıcı 'exit' yazarsa döngü sonlanır
            if (Plaka.ToLower() == "exit")
            {
                Console.WriteLine("Program sonlandırılıyor...");
                break;
            }

            // Plaka doğruysa markayı göster, değilse hata mesajı yazdır
            if (Arac.ContainsKey(Plaka))
                Console.WriteLine("Araç Markası: " + Arac[Plaka]);
            else
                Console.WriteLine("Araç Bulunamadı.");
        }
    }
}


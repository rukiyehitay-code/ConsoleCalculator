bool devam = true;
while (devam)
{
    Console.WriteLine("== HESAP MAKİNESİ ==");
    Console.WriteLine("1 - Toplama");
    Console.WriteLine("2 - Çıkarma");
    Console.WriteLine("3 - Çarpma");
    Console.WriteLine("4 - Bölme");
    Console.WriteLine("5 - Karekök");
    Console.WriteLine("6 - Kare Alma");
    Console.WriteLine("7 - Üs Alma");
    Console.WriteLine("0 - Çıkış");

    Console.Write("Seçiminiz:");
    int secim = Convert.ToInt32(Console.ReadLine());

    if (secim == 0)
    {
        Console.WriteLine("Çıkış yapıldı");
        devam = false;
    }
    else if (secim == 1)
    {
        Console.WriteLine("Birinci sayi:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci sayi:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Toplama işleminin sonucu:{sayi1 + sayi2} ");
    }
    else if (secim == 2)
    {
        Console.WriteLine("Birinci sayi:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci sayi:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Çıkarma işleminin sonucu:{sayi1 - sayi2} ");
    }
    else if (secim == 3)
    {
        Console.WriteLine("Birinci sayi:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci sayi:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Çarpma işleminin sonucu:{sayi1 * sayi2} ");
    }
    else if (secim == 4)
    {
        Console.WriteLine("Birinci sayi:");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci sayi:");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        if (sayi2 == 0)
            Console.WriteLine("2. sayı 0 olamaz.");

        else
            Console.WriteLine($"Bölme işleminin sonucu:{sayi1 / sayi2} ");
    }
    else if (secim == 5)
    {
        Console.WriteLine("Karekökünü almak istediğiniz sayıyı girin:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi < 0)
            Console.WriteLine("Negatif sayının karekökü alınamaz.");
        else
        {
            double sonuc = Math.Sqrt(sayi);
            Console.WriteLine($"Karekök sonucu: {sonuc}");
        }
    }
    else if (secim == 6)
    {
        Console.WriteLine("Karesini almak istediğiniz sayıyı girin:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Kare sonucu:{sayi * sayi}");
    }
    else if (secim == 7)
    {
        Console.WriteLine("Taban olmasını istediğiniz sayıyı girin:");
        int tabanSayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Üs olmasını istediğiniz sayıyı girin:");
        int usSayi = Convert.ToInt32(Console.ReadLine());
        double sonuc = Math.Pow(tabanSayi, usSayi);
        Console.WriteLine($"Üs alma işleminin sonucu: {sonuc}");
    }
    else
    {
        Console.WriteLine("Geçersiz rakam girdiniz. ");
    }

}


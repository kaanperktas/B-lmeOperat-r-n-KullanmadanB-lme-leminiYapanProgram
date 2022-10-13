class Program
    {
        static void Main(string[] args)
        {
            //örnek olarak 15 ve 4 değerleri girilmiştir.
            int sayi1 = 15, sayi2 = 4;
            int sonuc;
 
            Console.WriteLine("bölünen:{0}, bölen:{1}",sayi1,sayi2);
            if (sayi1 == 0)
                sonuc = 0;
            if (sayi2 == 0)
                sonuc = int.MaxValue;
 
            bool negSonuc = false;
 
            // Negatif sayıları kontrol
            if (sayi1 < 0)
            {
                sayi1 = -sayi1;
                if (sayi2 < 0)
                    sayi2 = -sayi2;
                else
                    negSonuc = true;
            }
            else if (sayi2 < 0)
            {
                sayi2 = -sayi2;
                negSonuc = true;
            }
 
            //eğer sayi1 büyük yada sayı2ye eşitse
            //sayi2 yi sayi1den çıkar
            //
            int bolum = 0;
            while (sayi1 >= sayi2)
            {
                sayi1 = sayi1 - sayi2;
                bolum++;
            }
 
            // negatif kontrolü
            if (negSonuc)
                bolum = -bolum;
            sonuc = bolum;
 
            Console.WriteLine("Elde edilen bölüm {0} dir", sonuc);
 
            Console.ReadLine();
        }
    }
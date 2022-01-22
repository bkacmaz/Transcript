using System;

namespace Homework1_Ogrenci_Transkript
{

    class program
    {

        struct Dersler
        {
            public string dersAdi;
            public string vize1;
            public string vize2;
            public string final; 
            
        }
        static string[] al()
        {
            string notlar;
            string[] array;
            Console.WriteLine();
            Console.WriteLine("Vize1, vize2, final notlarınızı bu formatta giriniz");


            return Console.ReadLine().Split(',');
            /*
            notlar = Console.ReadLine();
            array = notlar.Split(',');
            return notlar.Split(','); */
        }
        static void Main(string[] args)
        {
           
            Dersler[] ders = new Dersler[100];
            bool check = true;
            int sayac = 0;
            int x = 0;
            // Veri alma bölümü

            while (check)
            {

                try
                {
                   
                    Console.Write("\n \n Ders Adi:");
                    ders[sayac].dersAdi = Console.ReadLine();

                    if (ders[sayac].dersAdi.Trim().Equals(""))
                    {
                        check = false;
                    }
                    else
                    {
                        string[] notu = al();
                        
                        ders[sayac].vize1 = notu[0];
                        ders[sayac].vize2 = notu[1];
                        ders[sayac].final = notu[2];
                        sayac++;
                    }
                }
                catch
                {

                    Console.WriteLine("Max 100 ders girilebilir.");
                    check = false;
                }
               

            }

            // Not hesaplama ve yazdırma bölümü
            double toplam = 0;

            for (int i=0; i<sayac; i++)
            {
                double gecmeNotu = double.Parse(ders[i].vize1)*0.2 + double.Parse(ders[i].vize2) * 0.2 + double.Parse(ders[i].final) * 0.6;
                toplam += gecmeNotu;
                string sonuc;

                if (gecmeNotu < 50)
                {
                    sonuc = "Kaldınız";
                }
                else
                {
                    sonuc = "Geçtiniz";
                }

                Console.WriteLine(ders[i].dersAdi + " "+ ders[i].vize1 +" " + ders[i].vize2 + " " + ders[i].final + " " + gecmeNotu + " " + sonuc);
                    
            }

            double donemOrtalaması = toplam / sayac;
            Console.WriteLine("\nDönem Ortalaması: " + donemOrtalaması);
  
        }
    }

}
            
            
     

            
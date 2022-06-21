using System;

namespace _53
{
    class Program
    {
        static void Main(string[] args)
        {
            // DİZİLER  

            // Dizi kavramı : Aynı türden olan nesneler kümesine dizi (Array) denir. Dizilerdeki elemanların isimleri ortaktır. Ayırt edici özellikleri bellekteki yerleridir.

            // Dizi tanımlama : 

            int[] dizi = new int[25];
            int[] dizi2;
            dizi2 = new int[25];

            //Dizi Örnek 1: Klavyeden kullanıcı tarafından girilen 20 sayıdan en büyüğünü bulan programı dizi kullanarak yazınız.
            int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı giriniz", i);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enBuyuk = sayilar[0];
            for (int i = 0; i < 20; i++)
            {
                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }
            }
            Console.WriteLine("En büyük sayı  : " + enBuyuk);

            //Klavyeden kullanıcı tarafından girilen 5 sayıyı büyükten küçüğe doğru sıralayınız

            int d;

            int[] sayilar1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}.Sayı giriniz", i + 1);
                sayilar1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (sayilar1[i] < sayilar1[j])
                    {
                        d = sayilar1[i];
                        sayilar1[i] = sayilar1[j];
                        sayilar1[j] = d;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}. en büyük sayı : {1}", i + 1, sayilar1[i]);
            }

            //Dizi Örnek 3:  Klavyeden kullanıcı tarafından girilen 5 ismi alfabetik olarak sıralayan programı dizi kullanarak yazınız.
            string[] liste = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. İsmi giriniz");
                string isim = Console.ReadLine();
                liste[i] = isim;
            }

            Console.WriteLine();

            Array.Sort(liste);

            Console.WriteLine("Girdiğiniz isimmlerin alfabetik sıralaması : ");

            foreach (string eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            // Dizi Örnek 4: Klavyeden kullanıcı tarafından girilen, beş elemanlı bir sayı dizisinde, son rakamı 0(sıfır) olan sayıların sayısını bulan programı yazınız.
            int toplamSıfır = 0;

            int[] sayilar2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz");
                int sayi5 = Convert.ToInt32(Console.ReadLine());
                sayilar2[i] = sayi5;
            }
            foreach (int sayi in sayilar2)
            {
                if (sayi %10 ==0)
                {
                    toplamSıfır++;
                }
            }
            Console.WriteLine("Son rakamı 0(sıfır) olan sayılar  " + toplamSıfır + " tanedir");



            // Dizi Örnek 5: 10 elemanlı bir dizinin elemanları 1-1000 arasında bilgisayar tarafından rastgele atanacaktır. Bu dizideki 500-600 arasındaki sayıların toplamı ile 100-500 arasındaki sayıların sayısını bulan programı yazınız.

            Random rnd = new Random();

            int toplam2 = 0, araSayi = 0;
            int[] rastgeleSayi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                rastgeleSayi[i] = rnd.Next(1, 1001);
            }

            foreach (int sayi in rastgeleSayi)
            {
                if (sayi <= 600 && sayi >= 500)
                {
                    toplam2 = toplam2 + sayi;
                }
                else if (sayi <= 500 && sayi >= 100)
                {
                    araSayi++;
                }
            }
            Console.WriteLine("Toplamları = " + toplam2);

            Console.WriteLine("arasındakilerin sayısı = " + araSayi);

            // Dizi Örnek 6: Sayısal loto programı yazınız. (Kullanıcının oynamak istediği kolon sayısına göre, otomatik rastgele sayı atama gibi düşünebilirsiniz. Sayısal Loto makinelerinin otomatik numara doldurması gibi. En az 1 en fazla 8 kolon oynanabilir.)

            Console.WriteLine();

            Random rnd2 = new Random();
            Console.WriteLine("Lütfen oynamak istediğiniz kolon sayısını giriniz(En az 1 en fazla 8 kolon oynanabilir)");
            int kolonSayisi = Convert.ToInt32(Console.ReadLine());
            int[] sayisalLoto = new int[6];

            for (int i = 0; i < kolonSayisi; i++)
            {
                sayisalLoto[0] = rnd2.Next(1, 50);
                for (int j = 1; j < 6; j++)
                {
                    sayisalLoto[j] = rnd2.Next(1, 49);
                    for (int k = 0; k < j; k++)
                    {
                        while (sayisalLoto[j] == sayisalLoto[k])
                        {
                            sayisalLoto[j] = rnd2.Next(1, 49);
                        }
                    }
                    Console.WriteLine();
                }
                Array.Sort(sayisalLoto);
                for (int s = 0; s < 6; s++)
                {
                    Console.Write(sayisalLoto[s] + " ");
                    
                }
            }
            Console.ReadLine();
        }
    }
}

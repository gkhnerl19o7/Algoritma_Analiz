
using System;

class Program
{
   static int IkiliArama(int arananSayi, int[] sayilar)
    {

        int baslangic = 0, bitis = sayilar.Length, orta;//baslangic indisi,bitis indisi ve ortanca indis belirlenir.
        int adimsayisi = 1;
        while (bitis - baslangic > 1)  //dizide tek eleman kalınca döngü biter.
        {
            orta = (baslangic + bitis) / 2;
            
            if (sayilar[orta] > arananSayi)//ortanca sayı aranan sayıdan büyük ise veri kümesini küçük tarafın sınırlarıyla daralt
            {
                bitis = orta;
                adimsayisi++;
            }
            else if (sayilar[orta] < arananSayi)//ortanca sayı aranan sayıdan küçük ise veri kümesini büyük tarafın sınırlarıyla daralt
            {
                baslangic = orta;
                adimsayisi += 1;
            }
            else
            {
                return adimsayisi;
            }
        }
        return -1;

    }

    static void Main()
    {
        int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine(IkiliArama(8, ints));
        
    }
}



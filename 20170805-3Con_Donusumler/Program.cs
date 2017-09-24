using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170805_3Con_Donusumler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tip Dönüşümleri
            /*
             * Bir tipteki değeri başka bir tipe dönüştürme işlemeidir.
             * 
             * cast (convert as type) -> benzer primitif(basit) tiplerin (int double float) birbirlerine dönüştürülmesi için ve object tipinin başka bir tipe dönüştürülmesinde kullanılır.
             * 
             * stringi sayıya çevirmede cast yetersiz kalır. bu yüzden alternatif olarak convert ve parse tip dönüşümleri vardır.
             * 
             * convert -> özellikle string bir tipi başka tiplere örn. sayı, ondalık sayı, mantıksal değer gibi değerlere dönüştürme işi yapan sınıftır. bu sınıftan birçok tip için dönüşüm metotları To ile başlayarak bulunur. ToInt32,ToDouble,ToDecimal gibi
             *  
             * parse -> string olarak gelen bir metni (içinde sayı olacak) çevirmeye yarar. parse bir metottur ve sınıflar kendi içerisinde parse metodunu barındırır.
             * 
             * parse , converte göre daha hızlı çalışır 
             * convertte null değeri geldiğinde varsayılan değer olarak 0 döndürürken, parse hata verir. 
             * convert birden fazla tip alıp dönüştürebilir. 
             * convert daha yavaş, parse daha hızlı
             * işinize geleni kullanın. 
             */

            short kucuk = 127;
            int buyuk = kucuk; // küçük bir alanı büyük bir alana sorunsuz atabilir.

            int buyuk2 = 232;
            short kucuk2 = (short)buyuk2; //agam valla short yaw. deme şeklidir.


            //eğer shortun alabileceğinden daha fazla bir değer girerse. +son değer, - , - son değer, + şeklinde loop yapar.
            int buyuk3 = 44848848;
            short kucuk3 = (short)buyuk3; //agam valla short yaw. deme şeklidir.
            Console.WriteLine(kucuk2);
            
            //gelen metni int tipinde bir sayıya dönüştürür. 
            string msayi = "1256358";
            int sayi = Convert.ToInt32(msayi);
            int sayi2 = int.Parse(msayi);

            //Console.Write("İsminiz nedir : ");
            //string isim = Console.ReadLine();

            //Console.Clear();

            //Console.WriteLine("Merhaba "+isim);
            Console.Read();
        }
    }
}

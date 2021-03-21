using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORİTMALAR_2.DERS_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "12345233231133333333123449877656544ffddhtttyyywywywuıeı";
            int[] adetler = new int[255];

            for (int i = 0; i < s.Length; i++)
            {
                adetler[(byte)s[i]]++;
            }
            int eb = adetler[0];
            for (int i = 1; i < 255; i++)
            {
                if (eb < adetler[i]) eb = adetler[i];
            }
            Console.WriteLine(eb);

            /////////////////////////////////////////////////////////////////////////

            int[] a1 = { 1, 3, 5, 7, 9, 11, 13 };
            int[] a2 = { 1, 5, 2, 4, 6, 9, 12, 15, 11, 20, 900 };
            // ortak kaç değeri vardır elemanı vardır
            int ortaklar = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j]) ortaklar++;
                }
            }
            Console.WriteLine(ortaklar);



            ////////////////////////////////////////////////////////////
            ///       int[] a1 = { 1, 3, 5, 7, 9, 11, 13 };
            int[] a2 = { 1, 5, 2, 4, 6, 9, 12, 15, 11, 20, 900, 11, 11, 11 };
            // ortak kaç değeri vardır elemanı vardır
            int[] x = new int[901];

            for (int i = 0; i < a1.Length; i++)
            {
                x[a1[i]]++;
            }
            for (int i = 0; i < a2.Length; i++)
            {
                x[a2[i]]++;
            }
            int adet = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 1) adet++;
            }
            /////

            //s="101011110100000001100111010001"
            //0 ve 1 oluşan string
            //burada 00 dan hemen sonra 11 yada 01 gelmeli
            //burada 00 dan hemen sonra 11 yada 00 gelmeli
            //1111111100101011110011 kurala aykırı
            //stringi tara gelmezse reddet (kurala uygun değildir.)
            //


            //5 e bölümünden 1 kalanları kabul edelim
            //200 bitlik bir sayı var int long


            //substring
            //nasıl çalışır
            //en hızlı substring
            //abcdefghjklmnoprst
            //ghj en hızlı 

            string[] on = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] bir = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] grup = { "yüz", "bin", "milyon", "milyar" };
            string sayi = "123451";
            string yazi = "";
            int grpcount = -1;
            while (sayi.Length > 0)
            {
                string grp = "";
                bool k = true;
                while (k)
                {
                    grp = sayi[sayi.Length - 1] + grp;
                    sayi = sayi.Remove(sayi.Length - 1);
                    if (sayi.Length == 0 || grp.Length == 3) k = false;
                }
                while (grp.Length < 3) grp = "0" + grp;
                Console.WriteLine(grp);
                grpcount++;
                string grp_ = "";
                grp_ = bir[grp[2] - (byte)'0'];
                grp_ = on[grp[1] - (byte)'0'] + grp_; ;

                if (grpcount == 0)
                {
                    if (grp[0] != '0')
                        if (grp[0] == '1')
                            grp_ = grup[grpcount] + grp_;
                        else grp_ = bir[grp[0] - (byte)'0'] + grup[grpcount] + grp_;
                }
                else
                {
                    if (grp_ != "bir") grp_ = grp_ + grup[grpcount];
                    else grp_ = grup[grpcount];
                }
                yazi = grp_ + yazi;

            }

            Console.WriteLine(yazi);









        }
    }
}

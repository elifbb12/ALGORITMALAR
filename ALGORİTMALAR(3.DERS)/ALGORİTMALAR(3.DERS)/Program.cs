using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORİTMALAR_3.DERS_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ss = { { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi" },
                { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş" }, 
                { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz" },
                { "bin", "bin", "ikibin", "üçbin", "dörtbin", "beşbin", "altıbin", "yedibin" },
                { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş" },
                { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz" } };
            string say = "12345";
            string yazi = "";
            for (int i = 0; i < say.Length; i++)
            {
                yazi += ss[say.Length - i - 1, (byte)say[i] - (byte)'0']; 
            }
            Console.WriteLine(yazi);
            Console.ReadLine();


            ////////////////////////////////////////////////////////////////////////////////////

            //  11 den sonra 00 ya da 10  gelen stringler kabul edilecekti. RED
            //    durum yaklaşım
            // başlangıç seviyesinde    0,0,1
            // 1  seviye 1   0 gelirse  başlangıç seviye  1 gelseydi kabul edilemez

            //  seviye 2 0 seviye 0 bekliyorum 1  gelirse olmaz
            string s = "1100110010101110";
            int[,] q = new int[6, 2];
            q[0, 0] = 0; q[0, 1] = 1;
            q[1, 0] = 0; q[1, 1] = 2;
            q[2, 0] = 3; q[2, 1] = 5;
            q[3, 0] = 0; q[3, 1] = 4;
            q[4, 0] = 4; q[4, 1] = 4;

            q[5, 0] = 0; q[5, 1] = 4;

            int state = 0;
            string finalstate = "01";
            // 11 den sonra 00 gelmeli
            // 11 den sonra 00 ya da 10  çözelim

            for (int i = 0; i < s.Length; i++)
            {
                state = q[state, s[i] - (byte)'0'];
            }
            if (finalstate.IndexOf(state.ToString()) == -1) Console.WriteLine("onaylanmadı");
            else Console.WriteLine("ONAY");


        }
    }
}

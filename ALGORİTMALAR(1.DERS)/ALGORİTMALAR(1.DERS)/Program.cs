using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORİTMALAR_1.DERS_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizii = { 2, 9, 26, 23, 14, 13, 16 };
            // dizinin içindeki en büyük eleman
            int eb = dizii[0];
            for (int e = 0; e < dizii.Length; e++)
            {
                if (eb < dizii[e]) eb = dizii[e];
            }
            Console.WriteLine(eb);

            // en büyük ikinci eleman
            int []a = { 3, 5, 18, 9, 21, 20, 4, 17, 8, 1 };
            int i, size, max1, max2;

            size = 10;

            max1 = a[0];
            max2 = a[1];

            for (i = 1; i < size; i++)
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                }
                else if (a[i] > max2)
                    max2 = a[i];
            Console.WriteLine(max2);

            Console.ReadLine();
            //algoritma için 3 durum söz konusudur.
            //best case en iyi durum.
            //normal case
            //worst case
            //bütün algoritmalar için n tanımlaması yapılır.
            // n imput tanımlar.
            //n e göre algoritmalarımızın durumunu söyleyebiliriz.
            //bug oluşabilir.

            // dizi sıralarsınız ve büyükten küçüğe doğru 2.eleman cevap olur.
            int[] dizi2 = { 2, 9, 26, 23, 14, 13, 16 };
            Stack<int> st = new Stack<int>();
            st.Push(dizi2[0]);
            for (int d = 0; d < dizi2.Length; d++)
            {
                if (st.Peek() < dizi2[d]) st.Push(dizi2[d]);

            }
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

            Console.ReadLine();
            //bu dizinin eb elemanını buluruz
            //çıkartırız eb elemanı tekrar ararız.
            //linked list ile çözülebilir.
            //
            int[] dizi1 = { 3,3,3,3,4,4, 9,99,123,123,123,123,4,5,123,123};
            //en çok kullanılan sayıyı bulmak
            int[] dizi = { 3, 3, 3, 4, 5, 5, 6, 7, 8, 9, 99, 121, 123, 123, 123, 2, 2, 2, 123, 4, 5, 123, 123, 123 };
            //  3  3
            //   4 2
            // 5  3
            // 123   7
            int ebadet = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                int adet = 0;
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j]) adet++;
                }
                if (ebadet < adet) ebadet = adet;
            }
            Console.WriteLine(ebadet);

            int eb1 = dizi[0];
            int eb2 = dizi[1];

            for (int i = 0; i < dizi.Length; i++)
            {
                if (eb1 < dizi[i])
                {
                    eb2 = eb1;
                    eb1 = dizi[i];
                }
                else if (eb2 < dizi[i]) eb2 = dizi[i];
            }
            Console.WriteLine(eb1);
            Console.WriteLine(eb2);

            //  dizi sıralarsınız ve büyükten küçüğe doğru 2. eleman 
            //  büyükse cpu meşgul

            Stack<int> st = new Stack<int>();
            st.Push(dizi[0]);
            for (int i = 0; i < dizi.Length; i++)
            {
                if (st.Peek() < dizi[i]) st.Push(dizi[i]);
            }
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            ////////
            ///       bu dizinin eb elemanını buluruz
            ///       çıkartırız eb elemanı tekrar ararız
            ///       linked list ilede çözebilir


        }
    }
}

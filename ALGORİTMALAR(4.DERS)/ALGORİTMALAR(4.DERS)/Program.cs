using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORİTMALAR_4.DERS_
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string s = "abcdefghjklmn";
            string st = "defgh";

            for (int i = 0; i < s.Length - st.Length; i++)
            {
                int adet = 0;
                //for (int j = 0; j < st.Length; j++)
                //{
                //    if (s[i + j] == st[j]) adet++;
                //}

                while (s[i + adet] == st[adet])
                {
                    adet++;
                    if (adet == st.Length) break;
                }
                if (adet == st.Length) Console.WriteLine("Bulundu");
            }
        }
    }
}

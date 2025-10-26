using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b1, b2; string[] n;
            b1 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            n = Console.ReadLine().ToUpper().Split('.');
            
            //b1=>10
            float r = 0;
            for (int i = 0; i < n[0].Length; i++)
            {
                char c = n[0][n[0].Length - 1 - i];
                if (c >= '0' && c <= '9')
                    r += (c - '0') * (int)Math.Pow(b1, i);
                else
                    r += (c - 'A' + 10) * (int)Math.Pow(b1, i);

            }

            for (int i = 0; i < n[1].Length; i++)
            {
                char c = n[1][i];
                if (c >= '0' && c <= '9')
                    r += (c - '0') * (float)1/(int)Math.Pow(b1, i+1);
                else
                    r += (c - 'A' + 10) * (float)1/(int)Math.Pow(b1, i+1);
            }
            
            //10=>b2
            string s = "0123456789ABCDEF";

            int parteIntreaga = (int)Math.Floor(r);
            float parteFractionara = r - parteIntreaga;
            string rezultatIntreg = "";

            if (parteIntreaga == 0)
                rezultatIntreg = "0";
            else
            {
                while (parteIntreaga > 0)
                {
                    rezultatIntreg = s[(int)(parteIntreaga % b2)] + rezultatIntreg;
                    parteIntreaga /= b2;
                }
            }

            string rezultatFractionar = "";
            
            while (parteFractionara-Math.Floor(parteFractionara)!=0)
            {   
                parteFractionara *= b2;
                int cifra = (int)Math.Floor(parteFractionara);
                rezultatFractionar += s[cifra];
                parteFractionara -= cifra;
            }

            Console.WriteLine($"{rezultatIntreg}.{rezultatFractionar}");
            }
    }
}

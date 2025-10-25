using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {   //Lab1
            //Realizati un program care converteste un numar dintr-o baza intr-alta
            int b1, b2; string n;
            b1 = Convert.ToInt32(Console.ReadLine());
            b2 = Convert.ToInt32(Console.ReadLine());
            n = Console.ReadLine().ToUpper();

            //b1=>10
            int r=0;
            for (int i=0; i<n.Length; i++)
            {
                char c = n[n.Length-1-i];
                if(c>='0' && c<='9')
                    r += (c-'0') * (int)Math.Pow(b1,i);
                else
                    r += (c-'A'+10) * (int)Math.Pow(b1,i);

            }

            //10=>b2
            string s = "0123456789ABCDEF";
            string rezultat = "";
            if(r==0)
                rezultat = "0";
            else
            {
                while(r>0)
                {
                    rezultat = s[r%b2] + rezultat;
                    r /= b2;
                }
            }

            Console.WriteLine(rezultat);
        }
    }
}

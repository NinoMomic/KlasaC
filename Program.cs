using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[5];
        
            Console.WriteLine("Upiši 5 brojeva: ");
            for (int i = 0; i < niz.Length; i++)
            { 
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }

            KlasaC klasaC = new KlasaC();
            Console.WriteLine("Zbroj upisanih brojeva je: " + klasaC.Zbroj(niz));
            Console.WriteLine("Prosjek upisanih brojeva je: " + klasaC.Prosjek(niz));

            Console.ReadKey();
        }
    }
    class KlasaC
    {
        public int Zbroj(int[] niz)
        {
            int zbroj = 0;
            zbroj = niz[0] + niz[1] + niz[2] + niz[3] + niz[4];
            return zbroj;
        }

        public double Prosjek(int[] niz)
        {
            int zbroj = Zbroj(niz);
            double prosjek = (double)zbroj / niz.Length;
            return prosjek;
        }
    }
}

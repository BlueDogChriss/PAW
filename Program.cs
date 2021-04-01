using System;

namespace democ1
{
    class Produs
    {
        int cod;
        string den;
        public Produs(int fc, string fd)
        {
            cod = fc; den = fd;
        }

        public override string ToString()
        {
            return "Cod " + cod.ToString() + "  Denumire :" + den;
        }

    }
   
    class Program
    {
        static void finc(params object[] fv )
        {
            foreach (object el in fv) Console.WriteLine("el :" + el);
        }

        static void Main(string[] args)
        {
            Produs p = new Produs(100, "Ciment");
            finc(23,"Salut", 56.34, p);
        }
    }
}

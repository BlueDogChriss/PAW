using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seminar2PAW
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal(10, "AGrivei", 7.6f);
            Animal a2 = a1.Clone();

            //a1.Nume = "Boris";

            //Console.WriteLine(a2);

            Pinguin p1 = new Pinguin(true, 7, "Flipper", 15.0f);
            Urs u1 = new Urs(false, 15, "Baloo", 66.0f);
            Pisica pa1 = new Pisica(true, 4, "Mitii", 7.0f);
            Peste pe1 = new Peste("cartilaginos", 1, "Floatty", 6.0f);

            //Console.WriteLine(p1);
            //Console.WriteLine(u1);

            Zoo z1 = new Zoo();
            z1.Denumire = "OBOR";
            z1.Adresa = "STRADA SPERANTEI";
            z1.Lista.Add(a1);
            z1.Lista.Add(a2);
            z1.Lista.Add(p1);
            z1.Lista.Add(u1);
            z1.Lista.Add(pa1);
            z1.Lista.Add(pe1);
            Zoo z2 = z1.Clone();

            z2.Lista.Sort();


            z1.Lista[0].Nume = "Boris";

            //Administratie ad = new Administratie("Gheorghe", "Berceni", "Rahova", "Obor", z1.Lista);


            //foreach (Animal a in z2.Lista)
            //    Console.WriteLine(a);

            Console.WriteLine(z1);

            //Console.WriteLine(ad);

            Console.Read();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_2__1057___ex1
{
    class Animal : ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private float greutate;
        public Animal(int v, string n, float g)
        {
            varsta = v;
            nume = n;
            greutate = g;
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value.Length > 3) nume = value; }
        }
        public float Greutate
        { get { return greutate; }
            set { if (value > 0) greutate = value; }
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
        public Animal Clone()
        {
            return (Animal)((ICloneable)this).Clone();
        }

        public override string ToString()
        {
            return "Animalul " + nume + " are varsta " + varsta + " si greutatea " + greutate;
        }

        public int CompareTo(object obj)
        {
            Animal nou = (Animal)obj;
            if (this.greutate > nou.greutate) return 1;
            else if (this.greutate < nou.greutate) return -1;
            else return string.Compare(this.nume, nou.nume);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal(10, "grivei", 7.5f);
            Animal a2 = a1.Clone();
            a2.Greutate = 4.7f;
            a2.Nume = "Agrivei";
            
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);

            Urs u1 = new Urs(true, 4, "Balloo", 3.4f);
            Pinguin p1 = new Pinguin(false, 10, "Chilly Willy", 4.7f);

            //Console.WriteLine(u1);
            //Console.WriteLine(p1);

            Zoo z1 = new Zoo();
            z1.Denumire = "Baneasa";
            z1.Adresa = "Bucuresti";

            z1.Lista.Add(a1);
            z1.Lista.Add(a2);
            z1.Lista.Add(u1);
            z1.Lista.Add(p1);



            Zoo z2 = z1.Clone();
            foreach (Animal a in z2.Lista)
                a.Nume += " copie";

            foreach (Animal a in z1.Lista)
                Console.WriteLine(a);

            Console.WriteLine();

            z2.Lista.Sort();

            foreach (Animal a in z2.Lista)
                Console.WriteLine(a);

            Console.Read();

        }
    }
}

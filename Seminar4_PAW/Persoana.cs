using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_PAW
{
    public class Persoana
    {
        public string NumePrenume;
        public DateTime DataNasterii;
        public string Cnp;
        public Persoana (string _nume, DateTime _datan, string _cnp)
        {
            NumePrenume = _nume;
            DataNasterii = _datan;
            Cnp = _cnp;
        }
    }
}

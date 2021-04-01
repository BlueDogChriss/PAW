using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_PAW
{
    public class Medic:Persoana
    {
        public int AnAbsolvire;
        public string Specializare;
        public Medic(string _nume, DateTime _datan, string _cnp, int _an, string _specializare):base(_nume, _datan, _cnp)
        {
            AnAbsolvire = _an;
            Specializare = _specializare;
        }
            }
}

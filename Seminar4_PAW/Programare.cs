using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_PAW
{
    public class Programare
    {
        public Medic medic;
        public Pacient pacient;
        public IntervalOrar oraProgramare;

        public Programare (Medic _medic,Pacient _pacient, IntervalOrar _ora)
        {
            medic = _medic;
            pacient = _pacient;
            oraProgramare = _ora;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_PAW
{
    public class IntervalOrar
    {
        public DateTime OraIncepere;
        public DateTime OraTerminare;
        public IntervalOrar(DateTime inceput, DateTime sfarsit)
        {
            OraIncepere = inceput;
            OraTerminare = sfarsit;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_PAW
{
    public class Pacient:Persoana
    {
        public string CardSanatate;
        public string Ocupatie;
        public Pacient(string _nume, DateTime _datan, string _cnp, string _card, string _ocupatie):base(_nume, _datan,_cnp)
        {
            CardSanatate = _card;
            Ocupatie = _ocupatie;
        }
            }
}

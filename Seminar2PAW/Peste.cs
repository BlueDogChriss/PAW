using System;
using System.Collections.Generic;
using System.Text;

namespace Seminar2PAW
{
    class Peste:Animal
    {

        private string tipPeste;

        public string TipPeste

        {
            get { return tipPeste; }
            set { if (value.Length > 2) tipPeste = value; }
        }
              public Peste(string pe, int v, string n, float g) : base(v, n, g)
        {
            tipPeste = pe;
        }

        public override string ToString()
        {
            return base.ToString()+ "Si e un peste "+ tipPeste;
        }
    }
    }


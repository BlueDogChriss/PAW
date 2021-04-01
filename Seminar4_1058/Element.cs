using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4_1058
{
    public class Element
    {
        public delegate void DElement(int i);
        public event DElement ElementSchimbat;
        int el;
        public int ValoareElement
        {
            get { return el; }
            set
            {
                if (el != value)
                {
                    el = value;
                    //invoc evenimentul
                    ElementSchimbat?.Invoke(el);
                }
            }
        }
    }
}

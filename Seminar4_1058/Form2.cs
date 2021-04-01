using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4_1058
{
    public partial class Form2 : Form
    {
      Element ObiectElementf2;
        public Form2(Element x)
        {

            InitializeComponent();
            ObiectElementf2 = x;
            ObiectElementf2.ElementSchimbat += new Element.DElement(ElementSchimbatV3);
        }

        void ElementSchimbatV3(int i)
        {
            textBoxMesaje3.Text += "Element modificat: " + i + Environment.NewLine;
        }
    }
}

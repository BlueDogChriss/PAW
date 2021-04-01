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
    public partial class Form1 : Form
    {
        Element ObiectElement;
        public Form1()
        {          
            InitializeComponent();
            ObiectElement = new Element();
            ObiectElement.ElementSchimbat += new Element.DElement(ElementSchimbatV1);
            ObiectElement.ElementSchimbat += new Element.DElement(ElementSchimbatV2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try { 
            ObiectElement.ValoareElement = Convert.ToInt32(textBoxInt.Text);
            }
            catch { }
            }

        void ElementSchimbatV1(int i)
        {
           textBoxMesaje1.Text += "Element modificat: " + i + Environment.NewLine;
        }
        void ElementSchimbatV2(int i)
        {
            textBoxMesaje2.Text += "Element modificat: " + i + Environment.NewLine;
        }

        private void buttonSeteaza_Click(object sender, EventArgs e)
        {
            try { 
            ObiectElement.ValoareElement = Convert.ToInt32(textBoxInt.Text);
            }
            catch { }
            }

        private void buttonCupleaza_Click(object sender, EventArgs e)
        {
            ObiectElement.ElementSchimbat += new Element.DElement(ElementSchimbatV1);
        }

        private void buttonDecupleaza_Click(object sender, EventArgs e)
        {
            ObiectElement.ElementSchimbat -= new Element.DElement(ElementSchimbatV1);
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(ObiectElement);
            f2.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public delegate int pFunctie(int a, int b);

        pFunctie operatie;
        
        int adunare (int a, int b)
        {
            return a + b;
        }
        int scadere(int a, int b)
        {
            return a - b;
        }

        public Form1()
        {
            InitializeComponent();
            operatie = new pFunctie(adunare);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butonAfiseaza_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(textNume.Text + " " + textPrenume.Text + " si are varsta " + textVarsta.Text);
            int rezultat = 0;
            try
            {
                rezultat = operatie(Convert.ToInt32(textBoxIntA.Text), Convert.ToInt32(textBoxIntB.Text));
            }
            catch
            {

            }
            MessageBox.Show("Rezultatul este: " + rezultat);
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inchideAplicatiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close(); - inchide un formular, in cazu nostru inchide toata aplicatia
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Aplicatia a fost realizata la seminar grupa 1058, miercuri ora 17 ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatie==scadere)
            {
                operatie = new pFunctie(adunare);
                labelOperatiaCurenta.Text = "Adunare";
            }
            else
            {
                operatie = new pFunctie(scadere);
                labelOperatiaCurenta.Text = "Scadere";
            }
        }
    }
}

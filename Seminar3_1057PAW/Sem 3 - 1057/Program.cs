using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_3___1057
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form formularul_meu = new Form();
            Button butonul_meu = new Button() { Text = "Afiseaza", Location = new Point(10, 10) };
            Button b2 = new Button() { Text = "Verifica", Location = new Point(50, 130) };

            butonul_meu.Click += (o, s) =>
              {
                  MessageBox.Show("Prima aplicatie Windows Forms", "Fereastra", MessageBoxButtons.YesNo);
              };

            TextBox t1 = new TextBox();
            t1.Text = "text in texbox";
            t1.Location = new Point(50, 90);

            b2.Click += (o, s) =>
              {
                  MessageBox.Show(t1.Text);
              };
            Label l1 = new Label();
            l1.Location = new Point(50, 50);
            l1.Text = "Label 1 - test";
            l1.Size = new Size(70, 30);

            formularul_meu.Controls.Add(butonul_meu);
            formularul_meu.Controls.Add(l1);
            formularul_meu.Controls.Add(t1);
            formularul_meu.Controls.Add(b2);

            Application.Run(formularul_meu);

        }
    }
}

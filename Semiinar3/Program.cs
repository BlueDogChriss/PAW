using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semiinar3
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Form formularul_meu = new Form();

            Label l1 = new Label()
            {
                Text = "Label nume",
                Location = new Point(50, 50)
            };

            TextBox t1 = new TextBox();
            t1.Location = new Point(50, 90);
            t1.Size = new Size(100, 30);

            TextBox t2 = new TextBox() { Location = new Point(165, 90), Size = new Size(100, 30) };

            Button b1 = new Button() { Text = "Afisare", Location = new Point(50, 130) };

            b1.Click += (o, s) =>
              {
                  MessageBox.Show(t1.Text, "Fereastra", MessageBoxButtons.OKCancel);
              };

            formularul_meu.Controls.Add(l1);
            formularul_meu.Controls.Add(t1);
            formularul_meu.Controls.Add(b1);
            formularul_meu.Controls.Add(t2);

            Application.Run(formularul_meu);
        }

    }
}


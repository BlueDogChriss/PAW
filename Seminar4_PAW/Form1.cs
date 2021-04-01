using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Medic m1 = new Medic("Ionescu", DateTime.Now, "5001009035268", 2010, "Cardiolog");
            Medic m2 = new Medic("Florescu", DateTime.Now, "6001009035268", 2015, "Neurolog");

            ListViewItem lvi1 = new ListViewItem(m1.NumePrenume);
            lvi1.SubItems.Add(m1.Cnp);
            lvi1.SubItems.Add(m1.Specializare);
            lvi1.SubItems.Add("Orar",Color.Orange,Color.Black,lvi1.Font);
            lvi1.UseItemStyleForSubItems = false;
            lvi1.Tag = m1;
            listView1.Items.Add(lvi1);

            ListViewItem lvi2 = new ListViewItem(m2.NumePrenume);
            lvi2.SubItems.Add(m2.Cnp);
            lvi2.SubItems.Add(m2.Specializare);
            lvi2.SubItems.Add("Orar");
            lvi2.Tag = m2;
            listView1.Items.Add(lvi2);
        }

        private void toolStripMenuItemModificaMedic_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                FormMedic fm = new FormMedic();

                listView1.SelectedIndexChanged += new EventHandler(fm.ActualizeazaControale);

                fm.Text = "Modificare medic";

                fm.ActualizeazaControale(listView1, e);
                fm.parinte = this;
                fm.ShowDialog();
            }
        }

        public void UpdateItems()
        {
            foreach(ListViewItem lvi in listView1.Items)
            {
                Medic m = (Medic)lvi.Tag;
                lvi.Text = m.NumePrenume;
                lvi.SubItems[1].Text = m.Cnp;
                lvi.SubItems[2].Text = m.Specializare;
            }
        }

        private void toolStripMenuItemAdaugaMedic_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "Link orar" });
            listView1.Items.Add(lvi);
            Medic m = new Medic("", DateTime.Now, "", 0, "");
            lvi.Tag = m;
            lvi.Selected = true;

            FormMedic fm = new FormMedic();
            fm.medic = m;
            fm.parinte = this;
            fm.Text = "Adaugare medic";
            fm.buttonActualizare.Text = "Adauga";

            fm.ShowDialog();

            if (fm.DialogResult != DialogResult.OK) lvi.Remove();


        }

        private void toolStripMenuItemStergeMedic_Click(object sender, EventArgs e)
        {
            toolStripMenuItemAdaugaMedic_Click(sender, e);
        }


        //private void contextMenuStrip1(object sender, EventArgs e)
        //{
        //    toolStripMenuItemAdaugaMedic_Click(sender, e);
        //}
    }
}

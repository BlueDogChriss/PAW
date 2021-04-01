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
    public partial class FormMedic : Form
    {
        public Medic medic;
        public Form1 parinte;
        public FormMedic()
        {
            InitializeComponent();
        }

        public void ActualizeazaControale (object sender, EventArgs e)
        {
            ListView listamea = (ListView)sender;
            if (listamea.SelectedItems.Count > 0)
                medic = (Medic)listamea.SelectedItems[0].Tag;
            if(medic!=null)
            {
                textBoxNume.Text = medic.NumePrenume;
                dateTimePickerDataNasterii.Value = medic.DataNasterii;
                textBoxCNP.Text = medic.Cnp;
                comboBoxAnAbsolvire.Text = medic.AnAbsolvire.ToString();
                comboBoxSpecializare.Text = medic.Specializare;
            }

        }

        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            if (medic!=null)
            {
                medic.NumePrenume = textBoxNume.Text;
                medic.DataNasterii = dateTimePickerDataNasterii.Value;
                medic.Cnp = textBoxCNP.Text;
                medic.AnAbsolvire = Convert.ToInt32(comboBoxAnAbsolvire.Text);
                medic.Specializare = comboBoxSpecializare.Text;
                //actualizare listview
                parinte.UpdateItems();
            }

            //private void textBoxNume_Validating(object sender, CancelEventArgs e)
            //{
            //    if(textBoxNume.Text.Length<5)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }
    }
}

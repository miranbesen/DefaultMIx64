using DefaultMIx64.Core;
using DefaultMIx64.Entities;
using DefaultMIx64.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefaultMIx64
{
    public partial class InfoSinirDuvarForm : Form
    {
        public Collective collective { get; set; } = new Collective();
        public string SelectedInfo { get; set; }


        public InfoSinirDuvarForm()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Sinir_Duvar selected = (Sinir_Duvar)listBox1.Items[listBox1.SelectedIndex];
                if (selected != null)
                {
                    SinirDuvarForm sinirDuvarForm = new SinirDuvarForm();
                    sinirDuvarForm.IsUpdate = true;
                    sinirDuvarForm.rowID = Convert.ToString(selected.Id);
                    sinirDuvarForm.sinir_duvar = selected;
                    DialogResult dialogResult = sinirDuvarForm.ShowDialog();

                    if (dialogResult != DialogResult.OK)
                    {
                        MapInfoClass.Instance.Do("rollback table Sinir_Duvar");
                        MapInfoClass.Instance.Do("rollback table OBJEYEGIT");

                    }

                    collective.ObjeSil(2);//2 tane oluşturuyor SinirDuvarOlustur içinde.
                }
            }
        }

        private void InfoSinirDuvarForm_Load(object sender, EventArgs e)
        {

        }
    }
}

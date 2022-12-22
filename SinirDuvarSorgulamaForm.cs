using DefaultMIx64.Entities;
using DefaultMIx64.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefaultMIx64
{
    public partial class SinirDuvarSorgulamaForm : Form
    {
        public SinirDuvarSorgulamaForm()
        {
            InitializeComponent();
        }

        private void SinirDuvarSorgulamaForm_Load(object sender, EventArgs e)
        {
            try
            {
                MapInfoClass.Instance.Do("select * from Sinir_Duvar where obj into selSinirDuvar noselect");
                string count = MapInfoClass.Instance.Eval("tableinfo(selSinirDuvar, 8)");
                MapInfoClass.Instance.Do("fetch first from selSinirDuvar");
                Sinir_Duvar sinir_Duvar = new Sinir_Duvar();

                for (int i = 0; i < Convert.ToInt32(count); i++)
                {
                    sinir_Duvar.Sinir_Adi = MapInfoClass.Instance.Eval("selSinirDuvar.Sinir_Adi");
                    sinir_Duvar.Sinir_Uzunluk = Convert.ToDouble(MapInfoClass.Instance.Eval("selSinirDuvar.Sınır_Uzunluk"));
                    sinir_Duvar.Il = MapInfoClass.Instance.Eval("selSinirDuvar.Il");
                    if (sinir_Duvar.Sinir_Adi != "" && sinir_Duvar.Il != "" && sinir_Duvar.Sinir_Uzunluk != 0)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = i + 1;
                        row.Cells[1].Value = sinir_Duvar.Sinir_Adi;
                        row.Cells[2].Value = sinir_Duvar.Il;
                        row.Cells[3].Value = sinir_Duvar.Sinir_Uzunluk;
                        dataGridView1.Rows.Add(row);
                    }

                    MapInfoClass.Instance.Do("fetch next from selSinirDuvar");
                }

                MapInfoClass.Instance.Do("close table selSinirDuvar");

            }
            catch (Exception)
            {
                MessageBox.Show("Sinir Duvar sorgulama esnasında sorun olustu, Tekrar Deneyiniz.");
            }
        }
    }
}

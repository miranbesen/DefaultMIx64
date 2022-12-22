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
    public partial class MadenOcagiSorgulamaForm : Form
    {


        public MadenOcagiSorgulamaForm()
        {
            InitializeComponent();
        }


        private void MadenOcagiSorgulamaForm_Load(object sender, EventArgs e)
        {
            try
            {
                MapInfoClass.Instance.Do("select * from Maden_Ocagi where obj into selMadenOcagi noselect");
                string count = MapInfoClass.Instance.Eval("tableinfo(selMadenOcagi, 8)");
                MapInfoClass.Instance.Do("fetch first from selMadenOcagi");
                Maden_Ocagi maden_Ocagi = new Maden_Ocagi();

                for (int i = 0; i < Convert.ToInt32(count); i++)
                {
                    maden_Ocagi.Sirket_Adi = MapInfoClass.Instance.Eval("selMadenOcagi.Sirket_Adi");
                    maden_Ocagi.Kapladigi_Alan = Convert.ToDouble(MapInfoClass.Instance.Eval("selMadenOcagi.Alan"));
                    maden_Ocagi.Il = MapInfoClass.Instance.Eval("selMadenOcagi.Il");
                    if (maden_Ocagi.Sirket_Adi != "" && maden_Ocagi.Il != "" && maden_Ocagi.Kapladigi_Alan != 0)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = i + 1;
                        row.Cells[1].Value = maden_Ocagi.Sirket_Adi;
                        row.Cells[2].Value = maden_Ocagi.Il;
                        row.Cells[3].Value = maden_Ocagi.Kapladigi_Alan;
                        dataGridView1.Rows.Add(row);
                    }

                    MapInfoClass.Instance.Do("fetch next from selMadenOcagi");
                }

                MapInfoClass.Instance.Do("close table selMadenOcagi");

            }
            catch (Exception)
            {
                MessageBox.Show("Maden Ocagi sorgulama esnasında sorun olustu, Tekrar Deneyiniz.");
            }


        }
    }
}

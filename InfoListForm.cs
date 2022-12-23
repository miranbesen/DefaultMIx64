using DefaultMIx64.Core;
using DefaultMIx64.Entities;
using DefaultMIx64.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefaultMIx64
{
    public partial class InfoListForm : Form
    {
        public string SelectedInfo { get; set; }

        public string pointIlBilgisi { get; set; }

        public Collective collective { get; set; } = new Collective();

        public InfoListForm()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    CustomListItem selected = (CustomListItem)listBox1.Items[listBox1.SelectedIndex];
                    if (selected != null)
                    {
                        if (selected.Text5 == "Point")
                        {
                            PointForm pointForm = new PointForm();
                            pointForm.IsUpdate = true;
                            pointForm.rowID = selected.Text4;
                            string query = "select Il_Adi from Point where rowid =" + Convert.ToInt32(selected.Text4) + " into secim";
                            MapInfoClass.Instance.Do(query);
                            pointIlBilgisi = MapInfoClass.Instance.Eval("secim.Il_Adi");
                            pointForm.ilAdi = pointIlBilgisi;
                            DialogResult dialogResult = pointForm.ShowDialog();
                            if (dialogResult != DialogResult.OK)
                            {
                                MapInfoClass.Instance.Do("rollback table point");
                            }
                        }

                        else if (selected.Text5 == "Region")
                        {
                            DrawRegion region = new DrawRegion();
                            MapInfoClass.Instance.Do("dim o as object");
                            MapInfoClass.Instance.Do("Select obj from Region where rowid=" + selected.Text4 + "into selectRegion");
                            MapInfoClass.Instance.Do("o=selectRegion.obj");
                            region = collective.Region(selected.Text4, "VeriCekme");
                            RegionForm regionForm = new RegionForm();
                            regionForm.IsUpdate = true;
                            regionForm.rowID = selected.Text4;
                            regionForm.region = region;
                            DialogResult dialogResult = regionForm.ShowDialog();

                            if (dialogResult != DialogResult.OK)
                            {
                                MapInfoClass.Instance.Do("rollback table Region");
                            }
                            MapInfoClass.Instance.Do("undim o");
                        }
                        else if (selected.Text5 == "Maden_Ocagi")
                        {
                            Maden_Ocagi maden_Ocagi = new Maden_Ocagi();
                            MapInfoClass.Instance.Do("dim o as object");
                            maden_Ocagi = collective.MadenOcagiOlustur(selected.Text4, "VeriCekme");

                            AddMadenOcagi madenOcagiForm = new AddMadenOcagi();
                            madenOcagiForm.maden_Ocagi = maden_Ocagi;
                            madenOcagiForm.rowID = selected.Text4;
                            madenOcagiForm.IsUpdate = true;
                            DialogResult dialogResult = madenOcagiForm.ShowDialog();

                            if (dialogResult != DialogResult.OK)
                            {
                                MapInfoClass.Instance.Do("rollback table Maden_Ocagi");
                            }
                            collective.ObjeSil(2);
                        }

                        else if (selected.Text5 == "Sinir_Duvar")
                        {
                            Sinir_Duvar sinir_Duvar = new Sinir_Duvar();
                            MapInfoClass.Instance.Do("dim o as object");
                            sinir_Duvar = collective.SinirDuvarOlustur(selected.Text4, "VeriCekme");
                            SinirDuvarForm sinirDuvarForm = new SinirDuvarForm();
                            sinirDuvarForm.IsUpdate = true;
                            sinirDuvarForm.rowID = selected.Text4;
                            sinirDuvarForm.sinir_duvar = sinir_Duvar;
                            DialogResult dialogResult = sinirDuvarForm.ShowDialog();

                            if (dialogResult != DialogResult.OK)
                            {
                                MapInfoClass.Instance.Do("rollback table Sinir_Duvar");
                            }

                            collective.ObjeSil(2);//2 tane oluşturuyor SinirDuvarOlustur içinde.

                        }

                        this.SelectedInfo = selected.Value.ToString();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lütfen Formu kapatıp tekrar bilgi almayı deneyiniz!", "Dikkat");
            }
        }
        private void InfoListForm_Load(object sender, EventArgs e)
        {

        }
    }
}

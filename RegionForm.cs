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
    public partial class RegionForm : Form
    {
        public bool IsUpdate { get; set; }
        public string rowID { get; set; }

        public DrawRegion region { get; set; }

        //public string[] alanArr { get; set; }
        //public string[] sehirArr { get; set; }
        //public string Alan { get; set; }
        public RegionForm()
        {
            InitializeComponent();
        }

        private void RegionForm_Load(object sender, EventArgs e)
        {
            if (!IsUpdate)
            {
                btnRegionDelete.Enabled = false;
            }
            if (region.sehirArr != null)
            {

                for (int i = 0; i < region.sehirArr.Count; i++)
                {
                    listBox1.Items.Add(region.sehirArr[i]);
                    listBox2.Items.Add(region.alanArr[i]);
                }

            }
            string query = "select Adi,Soyadi from Region where rowid =" + Convert.ToInt32(rowID) + " into secim";
            MapInfoClass.Instance.Do(query);
            string RegionAdBilgisi = MapInfoClass.Instance.Eval("secim.Adi");
            string RegionSoyadBilgisi = MapInfoClass.Instance.Eval("secim.Soyadi");
            textRegionName.Text = RegionAdBilgisi;
            textRegionType.Text = RegionSoyadBilgisi;
            label5.Text = region.Alan.ToString();


        }

        public void FillRegionForm()
        {
            if (IsUpdate)
            {
                MapInfoClass.Instance.Do("select * from Refion where rowid=" + rowID + " into selgecici noselect");

                textRegionName.Text = MapInfoClass.Instance.Eval("selgecici.Adi");
                textRegionType.Text = MapInfoClass.Instance.Eval("selgecici.Soyadi");

                MapInfoClass.Instance.Do("close table selgecici");

            }
            else
                btnRegionDelete.Enabled = false;
        }

        private void BtnRegionSave_Click(object sender, EventArgs e)
        {
            if (textRegionName.TextLength <= 0 || textRegionType.TextLength <= 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.");
            }

            try
            {

                MapInfoClass.Instance.Do("update region set Soyadi=\"" + textRegionType.Text + "\", Adi=\"" + textRegionName.Text + "\" where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table region");

                MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Problem oluştu, Tekrar Deneyiniz.");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnRegionDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyormusunuz?", "Dikkat",
                MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                MapInfoClass.Instance.Do("delete from region where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table region");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

using DefaultMIx64.Core;
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
    public partial class SinirDuvarForm : Form
    {
        public bool IsUpdate { get; set; }
        public string rowID { get; set; }
        public Collective collective { get; set; } = new Collective();
        public Sinir_Duvar sinir_duvar { get; set; }

        string windowId;

        public SinirDuvarForm()
        {
            InitializeComponent();
        }

        private void SinirDuvarForm_Load(object sender, EventArgs e)
        {
            windowId = MapInfoClass.Instance.Eval("windowID(1)"); //window ıd yi alıyoruz.
            if (!IsUpdate)
            {
                btnSinirDuvarDelete.Enabled = false;
            }
            if (sinir_duvar.Kesisim_Listesi.Count != null)
            {

                for (int i = 0; i < sinir_duvar.Kesisim_Listesi.Count; i++)
                {
                    //noktaList.Add(maden_Ocagi.Kesisim_Listesi[i].Kesisen_Merkez_Nokta);
                    listBox1.Items.Add(sinir_duvar.Kesisim_Listesi[i]);
                    //listBox2.Items.Add(maden_Ocagi.Kesisim_Listesi[i].Kesisim_Alan);
                }

            }

            string query = "select Sinir_Adi from Sinir_Duvar where rowid =" + Convert.ToInt32(rowID) + " into secim";
            MapInfoClass.Instance.Do(query);
            string MadenOcagiSirketBilgisi = MapInfoClass.Instance.Eval("secim.Sinir_Adi");
            textSinirDuvarAdi.Text = MadenOcagiSirketBilgisi;
            textilAdi.Text = sinir_duvar.Il;
            label5.Text = sinir_duvar.Sinir_Uzunluk.ToString();

        }

            

        private void btnSinirDuvarSave_Click(object sender, EventArgs e)
        {
            if (textSinirDuvarAdi.TextLength <= 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.");
            }

            try
            {
                MapInfoClass.Instance.Do("update Sinir_Duvar set Sinir_Adi=\"" + textSinirDuvarAdi.Text + "\" where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table Sinir_Duvar");
                MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Problem oluştu, Tekrar Deneyiniz.");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSinirDuvarDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyormusunuz?", "Dikkat",
                MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                MapInfoClass.Instance.Do("delete from Sinir_Duvar where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table Sinir_Duvar");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                collective.ClearShowObjectLayer();
                if (listBox1.SelectedIndex >= 0)
                {
                    KesisimUzunluk selectedListBoxItem = (KesisimUzunluk)listBox1.SelectedItem; //LİSTBOX1'DE İTEMİMİZİ SEÇTİK.
                    collective.AddPointShowObjectLayer(selectedListBoxItem.Kesisen_Merkez_Nokta);
                    collective.ZoomToShowLayer(windowId);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Point eklersen sorun oluştu, lütfen bir daha deneyiniz", "Dikkat");
            }

        }

        private void btnKesisenInfo_Click(object sender, EventArgs e)
        {
            collective.ClearShowObjectLayer();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                KesisimUzunluk selectedListBoxItem = listBox1.Items[i] as KesisimUzunluk; //LİSTBOX1'DE İTEMİMİZİ SEÇTİK.
                collective.AddPointShowObjectLayer(selectedListBoxItem.Kesisen_Merkez_Nokta);
            }
            collective.ZoomToShowLayer(windowId);
        }
    }
}

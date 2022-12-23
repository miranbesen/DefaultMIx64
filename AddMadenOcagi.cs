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
using DefaultMIx64.Core;
using System.Windows.Controls.Primitives;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace DefaultMIx64
{
    public partial class AddMadenOcagi : Form
    {

        public Collective collective { get; set; } = new Collective();
        public bool IsUpdate { get; set; }
        public Maden_Ocagi maden_Ocagi { get; set; }
        public string rowID { get; set; }



        string windowId;

        public AddMadenOcagi()
        {
            InitializeComponent();
        }

        private void AddMadenOcagi_Load(object sender, EventArgs e)
        {
            windowId = MapInfoClass.Instance.Eval("windowID(1)"); //window ıd yi alıyoruz.
            if (!IsUpdate)
            {
                btnRegionDelete.Enabled = false;
            }
            if (maden_Ocagi.Kesisim_Listesi.Count != null)
            {

                for (int i = 0; i < maden_Ocagi.Kesisim_Listesi.Count; i++)
                {
                    listBox1.Items.Add(maden_Ocagi.Kesisim_Listesi[i]);
                }

            }

            string query = "select Sirket_Adi from Maden_Ocagi where rowid =" + Convert.ToInt32(rowID) + " into secim";
            MapInfoClass.Instance.Do(query);
            string MadenOcagiSirketBilgisi = MapInfoClass.Instance.Eval("secim.Sirket_Adi");
            textSirketAdi.Text = MadenOcagiSirketBilgisi;
            textBox1.Text = maden_Ocagi.Il;
            label5.Text = maden_Ocagi.Kapladigi_Alan.ToString();

        }

        private void textRegionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRegionSave_Click(object sender, EventArgs e)
        {
            if (textSirketAdi.TextLength <= 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.");
            }

            try
            {

                MapInfoClass.Instance.Do("update Maden_Ocagi set Sirket_Adi=\"" + textSirketAdi.Text + "\" where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table Maden_Ocagi");

                MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Problem oluştu, Tekrar Deneyiniz.");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnRegionDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyormusunuz?", "Dikkat",
                MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                MapInfoClass.Instance.Do("delete from Maden_Ocagi where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table Maden_Ocagi");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        /// <summary>
        /// ListBox'ımızdan seçeceğimiz il'in merkez noktasına point atıyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                collective.ClearShowObjectLayer();
                if (listBox1.SelectedIndex >= 0)
                {
                    Kesisim selectedListBoxItem = (Kesisim)listBox1.SelectedItem; //LİSTBOX1'DE İTEMİMİZİ SEÇTİK.
                    collective.AddPointShowObjectLayer(selectedListBoxItem.Kesisen_Merkez_Nokta);
                    collective.ZoomToShowLayer(windowId);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Point eklersen sorun oluştu, lütfen bir daha deneyiniz", "Dikkat");
            }
        }



        /// <summary>
        /// Region alanıyla il alanı kesişiminin merkez noktasına point atıyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKesisenInfo_Click(object sender, EventArgs e)
        {
            collective.ClearShowObjectLayer();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Kesisim selectedListBoxItem = listBox1.Items[i] as Kesisim; //LİSTBOX1'DE İTEMİMİZİ SEÇTİK.
                collective.AddPointShowObjectLayer(selectedListBoxItem.Kesisen_Merkez_Nokta);
            }
            collective.ZoomToShowLayer(windowId);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMadenOcagi_FormClosing(object sender, FormClosingEventArgs e)
        {
            collective.ClearShowObjectLayer();
        }
    }
}


using DefaultMIx64.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace DefaultMIx64
{
    public partial class PointForm : Form
    {
        public bool IsUpdate { get; set; }
        //private int rowid = 0;

        //public string rowID { get => Convert.ToString(rowid); set => rowid = Convert.ToInt32(value); }
        public string rowID { get; set; }
        public string ilAdi { get; set; }


        public PointForm()
        {
            InitializeComponent();
        }

        private void PointForm_Load(object sender, EventArgs e)
        {
            if (!IsUpdate)
            {
                btnPointDelete.Enabled = false;
            }
            label3.Text = ilAdi;
            string query = "select Adi,Soyadi from Point where rowid =" + Convert.ToInt32(rowID) + " into secim"; //Burada amaç olarak eğer bilgi ekranından veriyi güncellemek için girersek verinin text bilgisini çekmek için yazdık.
            MapInfoClass.Instance.Do(query);
            string pointAdBilgisi = MapInfoClass.Instance.Eval("secim.Adi");
            string pointSoyadBilgisi= MapInfoClass.Instance.Eval("secim.Soyadi");
            textName.Text = pointAdBilgisi;
            textType.Text = pointSoyadBilgisi;
        }

        public void FillPointForm()
        {
            if (IsUpdate)
            {
                MapInfoClass.Instance.Do("select * from Point where Id=" + rowID + " into selgecici noselect");

                textName.Text = MapInfoClass.Instance.Eval("selgecici.Adi");
                textType.Text = MapInfoClass.Instance.Eval("selgecici.Soyadi");

                MapInfoClass.Instance.Do("close table selgecici");
            }
        }

        private void BtnPointSave_Click(object sender, EventArgs e)
        {
            if (textName.TextLength <= 0 || textType.TextLength <= 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.");
            }

            try
            {
                MapInfoClass.Instance.Do("update Point set Soyadi=\"" + textType.Text + "\", Adi=\"" + textName.Text + "\" where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table Point");
                MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Problem oluştu, Tekrar Deneyiniz.");

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnPointDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyormusunuz?", "Dikkat",
                MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                MapInfoClass.Instance.Do("delete from Point where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table point");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}

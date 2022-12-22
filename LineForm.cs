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
    public partial class LineForm : Form
    {
        public bool IsUpdate { get; set; }
        public string rowID { get; set; }

        public LineForm()
        {
            InitializeComponent();
        }

        private void LineForm_Load(object sender, EventArgs e)
        {
            if (!IsUpdate)
            {
                btnLineDelete.Enabled = false;
            }
        }

        public void FillLineForm()
        {
            if (IsUpdate)
            {
                MapInfoClass.Instance.Do("select * from line where rowid=" + rowID + " into selgecici noselect");

                textName.Text = MapInfoClass.Instance.Eval("selgecici.adi");
                textType.Text = MapInfoClass.Instance.Eval("selgecici.tip");

                MapInfoClass.Instance.Do("close table selgecici");

            }
            else
                btnLineDelete.Enabled = false;
        }

        private void BtnLineSave_Click(object sender, EventArgs e)
        {
            
            if (textName.TextLength <= 0 || textType.TextLength <= 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.");
            }

            try
            {
                MapInfoClass.Instance.Do("update line set tip=\"" + textType.Text + "\", adi=\"" + textName.Text + "\" where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table line");
                MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Problem oluştu, Tekrar Deneyiniz.");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnLineDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyormusunuz?", "Dikkat",
                MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                MapInfoClass.Instance.Do("delete from line where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table line");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

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
    public partial class BuildingForm : Form
    {
        public bool IsUpdate { get; set; }
        public string rowID { get; set; }

        public BuildingForm()
        {
            InitializeComponent();
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            AddBuildingField();
        }

        public void AddBuildingField()
        {
            if (!IsUpdate)
            {
                //string tableName, buildingRowId;

                //string x = MapInfoClass.Instance.Eval("commandinfo(1)").Replace(',', '.'); //Haritada tıklanılan yerin 'x' değerini getirir.
                //string y = MapInfoClass.Instance.Eval("commandinfo(2)").Replace(',', '.'); //Haritada tıklanılan yerin 'y' değerini getirir.

                //int dataCount = Convert.ToInt32(MapInfoClass.Instance.Eval("SearchPoint(frontwindow()," + x + "," + y + ")"));

                //MapInfoClass.Instance.Do("update bina set id=" + rowID + ", adi=\"\", kodu=\"\", il=\"\", ilce=\"\" where rowid=" + rowID);

                try
                {
                    MapInfoClass.Instance.Do("dim binaobj as object");
                    MapInfoClass.Instance.Do("select obj from bina where rowid =" + rowID + " into selbina noselect");
                    string s = MapInfoClass.Instance.Eval("tableinfo(selbina, 8)");

                    if (Convert.ToInt32(s) != 0)
                    {
                        MapInfoClass.Instance.Do("fetch first from selbina");
                        MapInfoClass.Instance.Do("binaobj = selbina.obj");
                        
                        MapInfoClass.Instance.Do("select iladi, ilceadi from ilceler where obj intersects binaobj into selgecici noselect");
                        textBuildingCity.Text = MapInfoClass.Instance.Eval("selgecici.iladi");
                        textBuildingCity.Enabled = false;

                        textBuildingTown.Text = MapInfoClass.Instance.Eval("selgecici.ilceadi");
                        textBuildingTown.Enabled = false;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    MapInfoClass.Instance.Do("undim binaobj");
                }

                MapInfoClass.Instance.Do("close table selbina");
                MapInfoClass.Instance.Do("close table selgecici");
                btnBuildingDelete.Enabled = false;
            }
        }

        public void FillBuildingForm()
        {

            if (IsUpdate)
            {
                MapInfoClass.Instance.Do("select adi, kodu, il, ilce from bina where rowid=" + rowID + " into selbina noselect");

                textBuildingName.Text = MapInfoClass.Instance.Eval("selbina.adi");
                textBuildingCode.Text = MapInfoClass.Instance.Eval("selbina.kodu");
                textBuildingCity.Text = MapInfoClass.Instance.Eval("selbina.il");
                textBuildingTown.Text = MapInfoClass.Instance.Eval("selbina.ilce");

                MapInfoClass.Instance.Do("close table selbina");
                textBuildingCity.Enabled = false;
                textBuildingTown.Enabled = false;
            }
        }

        private void BtnBuildingSave_Click(object sender, EventArgs e)
        {
            if (textBuildingName.TextLength <= 0 || textBuildingCode.TextLength <= 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz.");
            }

            try
            {
                MapInfoClass.Instance.Do("update bina set id=" + rowID + ", adi=\"" + textBuildingName.Text + "\", kodu=\"" + textBuildingCode.Text + "\", il=\"" +
                    textBuildingCity.Text + "\", ilce=\"" + textBuildingTown.Text + "\" where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table bina");
                MessageBox.Show("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleştirildi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt İşlemi Sırasında Problem oluştu, Tekrar Deneyiniz.");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnBuildingDelete_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt silinecektir, Devam Etmek istiyormusunuz?", "Dikkat",
                MessageBoxButtons.YesNoCancel);
            if (sonuc == DialogResult.Yes)
            {
                MapInfoClass.Instance.Do("delete from bina where rowid=" + rowID);
                MapInfoClass.Instance.Do("commit table bina");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

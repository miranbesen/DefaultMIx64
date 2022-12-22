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
using DefaultMIx64.Helpers;

namespace DefaultMIx64
{
    public partial class IlceGolForm : Form
    {
        public IlceGolForm()
        {
            InitializeComponent();
        }

        private void IlceGolForm_Load(object sender, EventArgs e)
        {
            string golname = null, ilcename = null, ilname = null;
            try
            {
                MapInfoClass.Instance.Do("select Goller.ADI, Ilceler.IlAdi, Ilceler.IlceAdi from Goller, Ilceler where Goller.Obj intersects Ilceler.obj into selkesisim noselect");
                string count = MapInfoClass.Instance.Eval("tableinfo(selkesisim, 8)");

                for (int i = 1; i < Convert.ToInt32(count); i++)
                {
                    MapInfoClass.Instance.Do("select adi, iladi, ilceadi from selkesisim where rowid = " + i);
                    //string golid = MapInfoClass.Instance.Eval("selkesisim.rowid");

                    golname = MapInfoClass.Instance.Eval("selkesisim.adi");
                    ilcename = MapInfoClass.Instance.Eval("selkesisim.ilceadi");
                    ilname = MapInfoClass.Instance.Eval("selkesisim.iladi");

                    string x = MapInfoClass.Instance.Eval("ObjectNodeX(selkesisim.obj,1,1)");
                    string y = MapInfoClass.Instance.Eval("ObjectNodeY(selkesisim.obj,1,1)");

                    ListViewItem item = new ListViewItem(new string[] { golname, ilcename, ilname });
                    item.Tag = x + "#" + y;
                    listIlceGolQuery.Items.Add(item);
                }
                MapInfoClass.Instance.Do("close table selkesisim");
            }
            catch (Exception )
            {

            }
        }

        private void ListIlceGolQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIlceGolQuery.SelectedItems.Count > 0)
            {
                if (listIlceGolQuery.SelectedItems[0].Text == null)
                {
                    MessageBox.Show("Lütfen göl ismi geçerli bir field seçiniz");
                }
                else
                {
                    CustomToolButtons.Instance.ZoomToObject(listIlceGolQuery.SelectedItems[0].Tag.ToString(), 100);
                }
            }
        }



        //private List<string> IlBul(string objectName)
        //{
        //    List<string> selectList = new List<string>();
        //    try
        //    {
        //        MapInfoClass.Instance.Do("select ID from ILLER where OBJ intersects "+objectName+" into selkesisim NOSELECT");
        //        string count = MapInfoClass.Instance.Eval("tableinfo(selkesisim, 8)");
        //        MapInfoClass.Instance.Do("fETCH fIRST fROM selkesisim");
        //        for (int i = 1; i < Convert.ToInt32(count); i++)
        //        {               
        //            listIlceGolQuery.Items.Add(MapInfoClass.Instance.Eval("selkesisim.ID"));
        //            MapInfoClass.Instance.Do("fETCH NEXT fROM selkesisim");
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
    }
}

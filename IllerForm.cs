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
    public partial class IllerForm : Form
    {
        public IllerForm()
        {
            InitializeComponent();
        }

        private void IllerForm_Load(object sender, EventArgs e)
        {
            string x = null, y = null; // X ve Y Koordinatları

            MapInfoClass.Instance.Do("select * from iller into seliller noselect");
            string count = MapInfoClass.Instance.Eval("tableinfo(seliller, 8)");
            MapInfoClass.Instance.Do("fetch first from seliller");
            for (int i = 0; i < Convert.ToInt32(count); i++)
            {
                
                x = MapInfoClass.Instance.Eval("ObjectNodeX(seliller.obj,1,1)"); //Objenin X koordinatını almak için kullanılıyor.
                y = MapInfoClass.Instance.Eval("ObjectNodeY(seliller.obj,1,1)"); //Objenin Y koordinatını almak için kullanılıyor.

                ListViewItem item = new ListViewItem(new string[] {
                    MapInfoClass.Instance.Eval("seliller.plaka_no"),
                    MapInfoClass.Instance.Eval("seliller.il_adi"),
                    MapInfoClass.Instance.Eval("seliller.bolge_adi"),
                    MapInfoClass.Instance.Eval("seliller.nufus_1990"),
                    MapInfoClass.Instance.Eval("seliller.nufus_1997"),
                    MapInfoClass.Instance.Eval("seliller.degisim"),
                    MapInfoClass.Instance.Eval("seliller.ort_gelir_1980")
                });
                item.Tag = x + "#" + y;
                listillerQuery.Items.Add(item);
                MapInfoClass.Instance.Do("fetch next from seliller");
            }

            MapInfoClass.Instance.Do("close table seliller");
        }

        private void ListillerQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listillerQuery.SelectedItems.Count > 0)
            {

                CustomToolButtons.Instance.ZoomToObject(listillerQuery.SelectedItems[0].Tag.ToString(), 700);

            }
        }
    }
}

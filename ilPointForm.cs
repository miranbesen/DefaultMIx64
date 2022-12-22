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
    public partial class ilPointForm : Form
    {
        public ilPointForm()
        {
            InitializeComponent();
        }

        private void ListilPointQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listilPointQuery.SelectedItems.Count > 0)
            {
                CustomToolButtons.Instance.AddPointToCity(listilPointQuery.SelectedItems[0].Tag.ToString());
            }

        }

        private void IlPointForm_Load(object sender, EventArgs e)
        {
            
            MapInfoClass.Instance.Do("select * from iller into seliller noselect");
            string count = MapInfoClass.Instance.Eval("tableinfo(seliller, 8)");
            MapInfoClass.Instance.Do("fetch first from seliller");

            for (int i = 0; i < Convert.ToInt32(count); i++)
            {

                ListViewItem item = new ListViewItem(new string[] {
                    MapInfoClass.Instance.Eval("seliller.plaka_no"),
                    MapInfoClass.Instance.Eval("seliller.il_adi"),
                    MapInfoClass.Instance.Eval("seliller.bolge_adi"),
                    MapInfoClass.Instance.Eval("seliller.nufus_1990"),
                    MapInfoClass.Instance.Eval("seliller.nufus_1997"),
                    MapInfoClass.Instance.Eval("seliller.degisim"),
                    MapInfoClass.Instance.Eval("seliller.ort_gelir_1980")

                });
                item.Tag = MapInfoClass.Instance.Eval("seliller.rowid");
                listilPointQuery.Items.Add(item);

                MapInfoClass.Instance.Do("fetch next from seliller");
            }

            MapInfoClass.Instance.Do("close table seliller");
        }
    }
}

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
    public partial class IlcelerForm : Form
    {
        public IlcelerForm()
        {
            InitializeComponent();
        }

        private void IlcelerForm_Load(object sender, EventArgs e)
        {
            string ilAdı = null, ilceAdı = null, plakaNo = null;
            string x = null, y = null;

            MapInfoClass.Instance.Do("select * from ilceler into selilceler noselect");
            string count = MapInfoClass.Instance.Eval("tableinfo(selilceler, 8)"); //8'de satır sayısını gösteren tamsayı.
            MapInfoClass.Instance.Do("fetch first from selilceler");
            for (int i = 0; i < Convert.ToInt32(count); i++)
            {
                ilceAdı = MapInfoClass.Instance.Eval("selilceler.ilceadi");
                ilAdı = MapInfoClass.Instance.Eval("selilceler.iladi");
                plakaNo = MapInfoClass.Instance.Eval("selilceler.plakano");



                x = MapInfoClass.Instance.Eval("ObjectNodeX(selilceler.obj,1,1)");
                y = MapInfoClass.Instance.Eval("ObjectNodeY(selilceler.obj,1,1)");
                MapInfoClass.Instance.Do("fetch next from selilceler");

                ListViewItem item = new ListViewItem(new string[] { ilAdı, ilceAdı, plakaNo });
                item.Tag = x + "#" + y;
                listIlcelerQuery.Items.Add(item);
            }
            MapInfoClass.Instance.Do("close table selilceler");
        }

        private void ListIlcelerQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIlcelerQuery.SelectedItems.Count > 0)
            {

                CustomToolButtons.Instance.ZoomToObject(listIlcelerQuery.SelectedItems[0].Tag.ToString(), 200);

            }
        }
    }
}

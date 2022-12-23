using DefaultMIx64.Core;
using DefaultMIx64.Entities;
using MapInfo.Types.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static MapInfo.Controls.ViewModels.YouTubeViewModel;

namespace DefaultMIx64.Helpers
{
    public class CustomToolButtons
    {
        #region Enum Definitions
        public enum DrawingModeDef
        {
            DM_CUSTOM_POINT = 34, 	//The user cannot drag while using the custom tool.
            DM_CUSTOM_LINE = 33,	//As the user drags, a line connects the cursor with the location where the user clicked.
            DM_CUSTOM_RECT = 32,	//As the user drags, a rectangular marquee appears.
            DM_CUSTOM_CIRCLE = 30,	//As the user drags, a circular marquee appears.
            DM_CUSTOM_ELLIPSE = 31,	//As the user drags, an elliptical marquee appears; if you include the ModifierKeys clause, the user can force the marquee to a circular shape by holding down the Shift key.
            DM_CUSTOM_POLYGON = 35,	//The user may draw a polygon. To retrieve the object drawn by the user, use the function call: CommandInfo( ) function (CMD_INFO_CUSTOM_OBJ).
            DM_CUSTOM_POLYLINE = 36,	//The user may draw a polyline. To retrieve the object drawn by the user, use the function call: CommandInfo( ) function (CMD_INFO_CUSTOM_OBJ).
        }

        public enum ButtonName
        {
            AddLine,
            GetInfo,
            GetSinirDuvarInfo,
            AddPolygon,
            AddPoint,
            AddBuilding,
            AddMadenOcagi,
            AddSinirDuvar
        }

        public enum IconDef
        {
            MI_CURSOR_ARROW = 0,
            MI_CURSOR_IBEAM_CROSS = 135,
            MI_CURSOR_HELP = 137,
        }
        #endregion

        public Collective collective { get; set; } = new Collective(); // Bu class'ımızdaki oluşturmuş olduğumuz fonksiyonları kullanıcaz.
        public Dictionary<string, int> _dic = new Dictionary<string, int>();
        private Form _mainForm { get; set; }
        private static CustomToolButtons instance;

        public static CustomToolButtons Instance
        {
            get
            {
                if (instance != null)
                    return instance;
                else
                {
                    instance = new CustomToolButtons();
                    return instance;
                }
            }
            set
            {
                instance = value;
            }
        }

        public int GetButton(ButtonName name)
        {
            var y = -1;
            _dic.TryGetValue(name.ToString(), out y);
            return y;
        }

        public void GetCustomTool(ButtonName buttonName)
        {
            if (!MapInfoClass.Instance.IsMapInfoInstalled) return;
            var xKey = instance.GetButton(buttonName);
            MapInfoClass.Instance.miApp.SetCurrentCustomTool(xKey);
        }

        public void LoadCustomTools(Form mainForm) // harita görüntüsünü bastığımız formun instance ını alacak.
        {
            this._mainForm = mainForm;

            LoadCustomToolButton(ButtonName.GetInfo, GetInfo, null, DrawingModeDef.DM_CUSTOM_POINT, (int)IconDef.MI_CURSOR_HELP);
            LoadCustomToolButton(ButtonName.AddPoint, AddPoint, null, DrawingModeDef.DM_CUSTOM_POINT, (int)IconDef.MI_CURSOR_ARROW);
            LoadCustomToolButton(ButtonName.AddLine, AddLine, null, DrawingModeDef.DM_CUSTOM_LINE, (int)IconDef.MI_CURSOR_ARROW);
            LoadCustomToolButton(ButtonName.AddPolygon, AddRegion, null, DrawingModeDef.DM_CUSTOM_POLYGON, (int)IconDef.MI_CURSOR_ARROW);
            LoadCustomToolButton(ButtonName.AddBuilding, AddBuilding, null, DrawingModeDef.DM_CUSTOM_POLYGON, (int)IconDef.MI_CURSOR_ARROW);
            LoadCustomToolButton(ButtonName.AddMadenOcagi, AddMadenOcagi, null, DrawingModeDef.DM_CUSTOM_POLYGON, (int)IconDef.MI_CURSOR_ARROW);
            LoadCustomToolButton(ButtonName.AddSinirDuvar, AddSinirDuvar, null, DrawingModeDef.DM_CUSTOM_POLYLINE, (int)IconDef.MI_CURSOR_ARROW);
        }

        public void LoadCustomToolButton(ButtonName buttonName, Action<object> methodName, object commandParam,
                                         DrawingModeDef drawingModeDef, int mapCursorId, bool bModifierKey = false)
        {
            _dic.Add(buttonName.ToString(), MapInfoClass.Instance.miApp.RegisterCustomTool(new System.Windows.Controls.Button(),
                                            new DelegateCommand(methodName),
                                            null,
                                            (int)drawingModeDef,
                                            mapCursorId.ToString(),
                                            bModifierKey));
        }

        //Harita üzerine tıklandığında MapInfo tarafından bu method çalıştırılıyor.
        public void GetInfo(object param)
        {
            List<CustomListItem> customListItems = new List<CustomListItem>();
            try
            {
                string tableName, rowID;
                string x = MapInfoClass.Instance.Eval("commandinfo(1)").Replace(',', '.'); //Haritada tıklanılan yerin 'x' değerini getirir.
                string y = MapInfoClass.Instance.Eval("commandinfo(2)").Replace(',', '.'); //Haritada tıklanılan yerin 'y' değerini getirir.
                MainForm anaform = new MainForm();
                int dataCount = Convert.ToInt32(MapInfoClass.Instance.Eval("SearchPoint(frontwindow()," + x + "," + y + ")"));
                if (dataCount > 0)//tıklanılan yerde tablo var ise
                {
                    string _tableName = string.Empty;
                    for (int i = 1; i <= dataCount; i++)
                    {
                        tableName = MapInfoClass.Instance.Eval("SearchInfo(" + i.ToString() + ",1)");
                        rowID = MapInfoClass.Instance.Eval("SearchInfo(" + i.ToString() + ",2)");
                        MapInfoClass.Instance.Do("Fetch rec " + rowID + " From " + tableName);
                        if ((!tableName.StartsWith("sel")))// Haritada sel ile baslayan gecici tabloları dikkate alma
                        {
                            if (string.Equals("line", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = tableName + "(" + MapInfoClass.Instance.Eval(tableName + ".adi") + ")",
                                    Value = tableName + "#" + rowID
                                });
                            }
                            else if (string.Equals("point", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = "Adi" + "(" + MapInfoClass.Instance.Eval(tableName + ".adi") + ")",
                                    Text2 = "Soyadi" + "(" + MapInfoClass.Instance.Eval(tableName + ".soyadi") + ")",
                                    Text3 = "Il_Adi" + "(" + MapInfoClass.Instance.Eval(tableName + ".Il_Adi") + ")",
                                    Text4 = MapInfoClass.Instance.Eval(tableName + ".rowid"),
                                    Text5 = tableName,
                                    Value = tableName + "#" + rowID
                                });
                            }
                            else if (string.Equals("region", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = "Adi" + "(" + MapInfoClass.Instance.Eval(tableName + ".adi") + ")",
                                    Text2 = "Soyadi" + "(" + MapInfoClass.Instance.Eval(tableName + ".soyadi") + ")",
                                    Text3 = "Alan" + "(" + MapInfoClass.Instance.Eval(tableName + ".alan") + ")",
                                    Text4 = MapInfoClass.Instance.Eval(tableName + ".rowid"),
                                    Text5 = tableName,
                                    Value = tableName + "#" + rowID
                                });
                            }

                            else if (string.Equals("Maden_Ocagi", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = "SirketAdi" + "(" + MapInfoClass.Instance.Eval(tableName + ".Sirket_Adi") + ")",
                                    Text2 = "BagliOlduguIl" + "(" + MapInfoClass.Instance.Eval(tableName + ".Il") + ")",
                                    Text3 = "Alan" + "(" + MapInfoClass.Instance.Eval(tableName + ".Alan") + ")",
                                    Text4 = MapInfoClass.Instance.Eval(tableName + ".rowid"),
                                    Text5 = tableName,
                                    Value = tableName + "#" + rowID
                                });

                            }
                            else if (string.Equals("Sinir_Duvar", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = "SinirAdi" + "(" + MapInfoClass.Instance.Eval(tableName + ".Sinir_Adi") + ")",
                                    Text2 = "BagliOlduguIl" + "(" + MapInfoClass.Instance.Eval(tableName + ".Il") + ")",
                                    Text3 = "SinirUzunluk" + "(" + MapInfoClass.Instance.Eval(tableName + ".Sınır_Uzunluk") + ")",
                                    Text4 = MapInfoClass.Instance.Eval(tableName + ".rowid"),
                                    Text5 = tableName,
                                    Value = tableName + "#" + rowID
                                });
                            }
                            else if (string.Equals("ilceler", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = tableName + "(" + MapInfoClass.Instance.Eval(tableName + ".ilceadi") + ")",
                                    Value = tableName + "#" + rowID
                                });
                            }
                            else if (string.Equals("iller", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = tableName + "(" + MapInfoClass.Instance.Eval(tableName + ".il_adi") + ")",
                                    Value = tableName + "#" + rowID
                                });
                            }

                            else if (string.Equals("bina", tableName, StringComparison.InvariantCultureIgnoreCase))
                            {
                                customListItems.Add(new CustomListItem()
                                {
                                    Text = tableName + "(" + MapInfoClass.Instance.Eval(tableName + ".adi") + ")",
                                    Value = tableName + "#" + rowID
                                });
                            }

                            else
                                _tableName = tableName;

                        }
                    }
                }
                if (customListItems.Count <= 0)
                {
                    MessageBox.Show("Tıklanılan Noktada Veri Bulunamadı.");
                }
                else if (customListItems.Count == 1)
                {
                    Program.mainForm.ShowInfo(customListItems[0].Value.ToString());
                }
                else
                {
                    InfoListForm infoListForm = new InfoListForm();
                    infoListForm.Owner = Program.mainForm;
                    infoListForm.listBox1.Items.Clear();

                    for (int i = 0; i < customListItems.Count; i++)
                    {
                        infoListForm.listBox1.Items.Add(customListItems[i]);
                    }

                    DialogResult res = infoListForm.ShowDialog();

                    if (res == DialogResult.OK)
                    {
                        Program.mainForm.ShowInfo(infoListForm.SelectedInfo);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu");
            }
        }


        public void AddPoint(object param)
        {
            string ilAdı;
            MapInfoClass.Instance.Do("dim o as object");
            MapInfoClass.Instance.Do("o = CreatePoint(commandinfo(1),commandinfo(2))");
            MapInfoClass.Instance.Do("select il_adi from iller where obj intersects o into kesisenil");
            string kesisenCount = MapInfoClass.Instance.Eval("tableinfo(kesisenil, 8)");

            if (kesisenCount != "0")
            {
                MapInfoClass.Instance.Do("insert into Point(obj) values (o) ");
                MapInfoClass.Instance.Do("fetch last from Point");
                var rowid = MapInfoClass.Instance.Eval("Point.rowid");
                ilAdı = MapInfoClass.Instance.Eval("kesisenil.IL_ADI");
                MapInfoClass.Instance.Do("update Point set Id=\"" + rowid + "\", Il_Adi=\"" + ilAdı + "\" where rowid=" + rowid);
                MapInfoClass.Instance.Do("select * from Point where rowid=" + rowid + " into secim");
                MapInfoClass.Instance.Do("o=secim.obj");
                MapInfoClass.Instance.Do("alter object o info 2, makesymbol(34, 16776960, 12)");
                MapInfoClass.Instance.Do("update secim set obj=o");
                PointForm pointForm = new PointForm();
                pointForm.IsUpdate = false;
                pointForm.rowID = rowid;
                pointForm.ilAdi = ilAdı;
                DialogResult dialogResult = pointForm.ShowDialog();

                if (dialogResult != DialogResult.OK)
                {
                    MapInfoClass.Instance.Do("rollback table point");
                }

                MapInfoClass.Instance.Do("undim o");
            }
            else
            {
                MapInfoClass.Instance.Do("undim o");
                MessageBox.Show("Tabloda kesisen eleman yoktur.");
            }

            //MapInfoClass.Instance.Do("dim o as object");
            //MapInfoClass.Instance.Do("o = CreatePoint(commandinfo(1),commandinfo(2))");
            //MapInfoClass.Instance.Do("insert into point(obj) values (o) ");
            //MapInfoClass.Instance.Do("fetch last from point");

            //var rowid = MapInfoClass.Instance.Eval("point.rowid");

            //MapInfoClass.Instance.Do("select * from point where rowid=" + rowid + " into secim");
            //MapInfoClass.Instance.Do("o=secim.obj");
            //MapInfoClass.Instance.Do("alter object o info 2, makesymbol(34, 16776960, 12)");
            //MapInfoClass.Instance.Do("update secim set obj=o");

            //PointForm pointForm = new PointForm();
            //pointForm.IsUpdate = false;
            //pointForm.rowID = rowid;
            //DialogResult dialogResult = pointForm.ShowDialog();

            //if (dialogResult != DialogResult.OK)
            //{
            //    MapInfoClass.Instance.Do("rollback table point");
            //}

            //MapInfoClass.Instance.Do("undim o");
        }


        public void AddSinirDuvar(object param)
        {
            Sinir_Duvar sinir_Duvar = new Sinir_Duvar();

            MapInfoClass.Instance.Do("dim o as object");
            MapInfoClass.Instance.Do("o = commandinfo(1)");
            string query3 = "select IL_ADI,ObjectLen(Overlap(obj, o), " + '"' + "m" + '"' + ") AS " + "\"" + "UZUNLUK" + "\" from iller where obj intersects o into kesisenIl"; //Kesisenil tablosuna oluşturmuş olduğumuz region ile kesisen illerin alanı ve adını ekliyoruz.
            MapInfoClass.Instance.Do(query3);
            int kesisenIlCount = Convert.ToInt32(MapInfoClass.Instance.Eval("tableinfo(kesisenil, 8)"));
            if (kesisenIlCount != 0)
            {
                MapInfoClass.Instance.Do("insert into Sinir_Duvar(obj) values (commandinfo(1))");
                MapInfoClass.Instance.Do("fetch last from Sinir_Duvar");
                var rowid = MapInfoClass.Instance.Eval("Sinir_Duvar.rowid");
                sinir_Duvar = collective.SinirDuvarOlustur(rowid, "Add");

                SinirDuvarForm sinirDuvarForm = new SinirDuvarForm();
                sinirDuvarForm.IsUpdate = false;
                sinirDuvarForm.rowID = rowid;
                sinirDuvarForm.sinir_duvar = sinir_Duvar;
                DialogResult dialogResult = sinirDuvarForm.ShowDialog();

                if (dialogResult != DialogResult.OK)
                {
                    MapInfoClass.Instance.Do("rollback table Sinir_Duvar");
                }

                MapInfoClass.Instance.Do("undim o");
                MapInfoClass.Instance.Do("undim o2");

            }
            else
            {
                MapInfoClass.Instance.Do("undim o");
                MessageBox.Show("HARİTADA KESİSEN ELEMAN YOKTUR.");
            }


        }

        public void AddLine(object param)
        {

        }

        public void AddMadenOcagi(object param)
        {
            Maden_Ocagi maden_Ocagi = new Maden_Ocagi();
            MapInfoClass.Instance.Do("dim o as object");
            MapInfoClass.Instance.Do("o = commandinfo(1)");

           
            string query3 = "select IL_ADI,AREA(Overlap(obj, o), " + '"' + "sq km" + '"' + ") AS " + "\"" + "ALAN" + "\" from iller where obj intersects o into kesisenIl"; //Kesisenil tablosuna oluşturmuş olduğumuz region ile kesisen illerin alanı ve adını ekliyoruz.
            MapInfoClass.Instance.Do(query3);
            string kesisenIlCount = MapInfoClass.Instance.Eval("tableinfo(kesisenIl, 8)"); //Kesisen il sayısını öğrendik.
            if (kesisenIlCount != "0")
            {
                MapInfoClass.Instance.Do("insert into Maden_Ocagi(obj) values (commandinfo(1)) "); //maden ocagi tablosuna region ekliyoruz
                MapInfoClass.Instance.Do("fetch last from Maden_Ocagi"); //rowid için yazdık.
                var rowid = MapInfoClass.Instance.Eval("Maden_Ocagi.rowid");
                maden_Ocagi = collective.MadenOcagiOlustur(rowid, "Add"); //Maden ocagi class'ının bilgilerini dolduruyoruz.

                AddMadenOcagi madenOcagiForm = new AddMadenOcagi(); //madenocagi class'ına erişiyoruz.
                madenOcagiForm.maden_Ocagi = maden_Ocagi; //maden_ocagi class'ına maden_ocagimizi yolluyoruz.
                madenOcagiForm.rowID = rowid;

                madenOcagiForm.IsUpdate = false; //Delete butonu pasifligi için false yolladık.

                DialogResult dialogResult = madenOcagiForm.ShowDialog(); //madenocagiformunu gösterdik.

                if (dialogResult != DialogResult.OK)
                {
                    MapInfoClass.Instance.Do("rollback table Maden_Ocagi");
                }
               
                MapInfoClass.Instance.Do("undim o");
                MapInfoClass.Instance.Do("undim o2");
            }
            else
            {
                MapInfoClass.Instance.Do("undim o");
                MessageBox.Show("HARİTADA KESİSEN ELEMAN YOKTUR.");
            }

        }

        public void AddRegion(object param)
        {
            DrawRegion region = new DrawRegion();
            MapInfoClass.Instance.Do("dim o as object");
            MapInfoClass.Instance.Do("o = commandinfo(1)");
            MapInfoClass.Instance.Do("select il_adi from iller where obj intersects o into kesisenil");
            string kesisenCount = MapInfoClass.Instance.Eval("tableinfo(kesisenil, 8)");
            if (kesisenCount != "0")
            {


                MapInfoClass.Instance.Do("insert into Region(obj) values (commandinfo(1)) ");
                MapInfoClass.Instance.Do("fetch last from Region");
                var rowid = MapInfoClass.Instance.Eval("region.rowid");
                region = collective.Region(rowid, "Add");

                RegionForm regionForm = new RegionForm();
                regionForm.IsUpdate = false;
                regionForm.rowID = rowid;
                regionForm.region = region;
                DialogResult dialogResult = regionForm.ShowDialog();

                if (dialogResult != DialogResult.OK)
                {
                    MapInfoClass.Instance.Do("rollback table region");
                }


            }
            else
            {
                MessageBox.Show("HARİTADA KESİSEN ELEMAN YOKTUR.");
            }
            MapInfoClass.Instance.Do("undim o");


            //-----------------------------------------
            //MapInfoClass.Instance.Do("dim o as object");
            //MapInfoClass.Instance.Do("insert into Region(obj) values (commandinfo(1)) ");
            //MapInfoClass.Instance.Do("fetch last from region");
            //var rowid = MapInfoClass.Instance.Eval("region.rowid");
            //MapInfoClass.Instance.Do("select * from region where rowid=" + rowid + " into secim noselect");
            //MapInfoClass.Instance.Do("o=secim.obj");
            //MapInfoClass.Instance.Do("alter object o info 3, makebrush(46, 11796288,-1)");// -1 arka planı transparan yapar
            //MapInfoClass.Instance.Do("update secim set obj=o");

            //RegionForm regionForm = new RegionForm();
            //regionForm.IsUpdate = false;
            //regionForm.rowID = rowid;
            //DialogResult dialogResult = regionForm.ShowDialog();

            //if (dialogResult != DialogResult.OK)
            //{
            //    MapInfoClass.Instance.Do("rollback table point");
            //}

            //MapInfoClass.Instance.Do("undim o");

        }

        public void AddBuilding(object param)
        {
            MapInfoClass.Instance.Do("dim o as object");
            MapInfoClass.Instance.Do("insert into bina(obj) values (commandinfo(1)) ");
            //MapInfoClass.Instance.Do("o= CreatePoint(commandinfo(1),commandinfo(2))");
            //MapInfoClass.Instance.Do("insert into bina(obj) values (o) ");
            MapInfoClass.Instance.Do("fetch last from bina");

            var rowid = MapInfoClass.Instance.Eval("bina.rowid");

            MapInfoClass.Instance.Do("select * from bina where rowid=" + rowid + " into secim noselect");
            MapInfoClass.Instance.Do("o=secim.obj");
            MapInfoClass.Instance.Do("alter object o info 3, makebrush(46, 11796288,-1)");// -1 arka planı transparan yapar
            MapInfoClass.Instance.Do("update secim set obj=o");

            BuildingForm building = new BuildingForm();
            building.IsUpdate = false;
            building.rowID = rowid;
            DialogResult dialogResult = building.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                MapInfoClass.Instance.Do("rollback table bina");
            }

            MapInfoClass.Instance.Do("undim o");
        }

        public void ZoomToObject(string coordinates, int units)
        {
            string x = null, y = null;
            if (coordinates.Split('#').Length == 2)
            {
                x = coordinates.Split('#')[0];
                y = coordinates.Split('#')[1];
            }

            MapInfoClass.Instance.Do("set map window FrontWindow() Center(" + x + ", " + y + ")");
            MapInfoClass.Instance.Do("set map zoom " + units + " units \"km\"");
            //MapInfoClass.Instance.Do("set map zoom entire layer 1");

        }

        public void AddPointToCity(string rowid)
        {
            try
            {
                MapInfoClass.Instance.Do("select * from iller where rowid=" + rowid + "into selil noselect");
                MapInfoClass.Instance.Do("dim o as object");
                MapInfoClass.Instance.Do("o = CreatePoint(centroidX(selil.obj), centroidY(selil.obj))");
                MapInfoClass.Instance.Do("insert into point(obj) values (o) ");
                MapInfoClass.Instance.Do("fetch last from point");

                var pointId = MapInfoClass.Instance.Eval("point.rowid");

                MapInfoClass.Instance.Do("select * from point where rowid=" + pointId + " into secim");
                MapInfoClass.Instance.Do("o=secim.obj");
                MapInfoClass.Instance.Do("alter object o info 2, makesymbol(34, 16776960, 12)");
                MapInfoClass.Instance.Do("update secim set obj=o");

                MapInfoClass.Instance.Do("update point set tipi=\"il\", adi=\"" +
                    MapInfoClass.Instance.Eval("selil.il_adi") + "\" where rowid=" + pointId);

                MapInfoClass.Instance.Do("commit table point");
                MapInfoClass.Instance.Do("close table selil");

                MapInfoClass.Instance.Do("select * from point where tipi=\"il\" into selpoint noselect");
                //string count = MapInfoClass.Instance.Eval("tableinfo(selpoint, 8)");

                MapInfoClass.Instance.Do("fetch last from selpoint");

                string id = MapInfoClass.Instance.Eval("selpoint.rowid");

                if ((Convert.ToInt32(id) - 1) != 0)
                {
                    MapInfoClass.Instance.Do("delete from point where rowid=" + (Convert.ToInt32(id) - 1));
                    MapInfoClass.Instance.Do("commit table point");
                }

                MapInfoClass.Instance.Do("close table selpoint");
                MapInfoClass.Instance.Do("undim o");

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu, Bilgiler İşlenemedi.");
                MapInfoClass.Instance.Do("rollback table point");
            }


        }
    }
}
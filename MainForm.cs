using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using DefaultMIx64.Helpers;
using MapInfo.Application;
using MapInfo.Commands;
using MapInfo.Types;

namespace DefaultMIx64
{
    public partial class MainForm : Form, IIntegratedMappingApplication
    {
        public static MapInfo.Types.IMapInfoApplication mapInfoApplication { get; set; } //MapInfo kütüphanesinin bir instancesi


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MapInfoCore.StartUp(null);
            mapInfoApplication = MapInfoCore.Initialize(Handle, this); //değer ataması yapıyoruz.
            MapInfoClass.Instance = new MapInfoClass(mapInfoApplication);

            if (MapInfoClass.Instance.miApp == null)
                throw new ApplicationException();

            CustomToolButtons.Instance.LoadCustomTools(this);

            string workSpacePath = System.Windows.Forms.Application.StartupPath + @"\DefaultData\default.wor"; // workspace’imizin dizin bilgisi
            mapInfoApplication.RunMapBasicCommand("Run application \"" + workSpacePath + "\""); //“RunMapBasicCommand” metodu ile workspace yüklememizi yapıyoruz.

        }

        public void ShowInfo(string key)
        {
            string tableName = null, rowId = null;

            if (key.Split('#').Length == 2)
            {
                tableName = key.Split('#')[0];
                rowId = key.Split('#')[1];
            }

            MapInfoClass.Instance.Do("Select * from " + tableName + " where rowid=" + rowId + " into selgecici noselect");
            MapInfoClass.Instance.Do("fetch first from " + tableName);

            switch (tableName)
            {
                case "point":
                    PointForm form = new PointForm();
                    form.IsUpdate = true;
                    form.rowID = rowId;
                    form.FillPointForm();
                    DialogResult res = form.ShowDialog();

                    if (res != DialogResult.OK)
                    {
                        MapInfoClass.Instance.Do("rollback table point");
                    }
                    break;

                case "line":
                    LineForm lineform = new LineForm();
                    lineform.IsUpdate = true;
                    lineform.rowID = rowId;
                    lineform.FillLineForm();
                    DialogResult lineres = lineform.ShowDialog();

                    if (lineres != DialogResult.OK)
                    {
                        MapInfoClass.Instance.Do("rollback table line");
                    }
                    break;

                case "region":
                    RegionForm regionForm = new RegionForm();
                    regionForm.IsUpdate = true;
                    regionForm.rowID = rowId;
                    regionForm.FillRegionForm();
                    DialogResult regionres = regionForm.ShowDialog();

                    if (regionres != DialogResult.OK)
                    {
                        MapInfoClass.Instance.Do("rollback table region");
                    }
                    break;

                case "Bina":
                    BuildingForm buildingForm = new BuildingForm();
                    buildingForm.IsUpdate = true;
                    buildingForm.rowID = rowId;
                    buildingForm.FillBuildingForm();
                    DialogResult buildingRes = buildingForm.ShowDialog();

                    if (buildingRes != DialogResult.OK)
                    {
                        MapInfoClass.Instance.Do("rollback table bina");
                    }
                    break;

                default:
                    break;
            }
        }

        public void ExecuteCommand(MapInfoCommand cmd, object sender) //MapInfo nun genel araçlarını kullanabilmek için yazdık.
        {
            if (cmd.CanExecute(sender, null))
                cmd.Execute(sender, null);
        }

        public IWindowInfo ActiveWindow
        {
            get { return _activeWindow; }
        }

        public IWindowInfo FrontDocumentWindow
        {
            get;

            set;

        }

        public bool IsApplicationClosing => throw new NotImplementedException();

        public Rect GetApplicationClientRect()
        {
            return new System.Windows.Rect();
        }

        public TReturnType GetWindowProperty<TReturnType>(IWindowInfo win, WindowProps property)
        {
            return default(TReturnType);
        }

        public void PreviewWindowClosed(IWindowInfo window)
        {
            //throw new NotImplementedException();
        }

        public void SetActiveWindow(IWindowInfo win, bool internalUse = true)
        {
            _activeWindow = win;
        }

        public void SetApplicationIcon(Uri icon)
        {
            //throw new NotImplementedException();
        }

        public void SetApplicationTitle(string title)
        {
            //throw new NotImplementedException();
        }

        public void SetNextActiveWindow()
        {
            //throw new NotImplementedException();
        }

        public void SetWindowProperty(IWindowInfo win, WindowProps property, string value)
        {
            throw new NotImplementedException();
        }

        public void ShowNotification(string message, System.Windows.Point location, int timeToShow = 2500)
        {
            //throw new NotImplementedException();
        }

        public void WindowClosed(IWindowInfo window)
        {
            //throw new NotImplementedException();
        }

        public IWindowInfo _activeWindow { get; set; }

        public void WindowCreated(IWindowInfo window, IEnumerable<KeyValuePair<string, string>> properties) //Proje başlangıcında harita görüntümüzü uygulamamızda gösterebilmek için gerekli olan kontrolleri eklememize yarayan sınıf.
        {
            var win = window as MapInfo.Types.WindowInfo;

            if (win == null)
                return;
            var ctrl = new ElementHost
            {
                Child = win.UserControl,
                Dock = DockStyle.Fill
            };
            if (win.IsDocumentWindow)
            {
                PanelMid.Tag = win.WindowId;
                PanelMid.Controls.Add(ctrl);
            }
        }

        public void WindowShowing(IWindowInfo window, bool bShow)
        {
            //throw new NotImplementedException();
        }

        #region Dosya Button İşlemleri
        private void BtnOpenWorkspace_Click(object sender, EventArgs e) //Workspace açmak için yazdık.
        {
            ExecuteCommand(ApplicationCommands.OpenWorkspace, sender); //Bu metotda yer alan “ApplicationCommands” MapInfo kütüphanesinin standart arayüzlerini açmak için kullanılmaktadır
        }

        private void BtnOpenTable_Click(object sender, EventArgs e) //yeni bir tablo açmak isteğimiz için yazdık.
        {
            ExecuteCommand(ApplicationCommands.OpenTable, sender);

        }

        private void BtnCloseAllTable_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.CloseAll, sender);

        }

        private void BtnCloseTable_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ApplicationCommands.CloseTable, sender);

        }
        #endregion

        #region Harita İşlemleri
        private void BtnSelect_Click(object sender, EventArgs e) //Harita üzerinde obje veya objeleri seçili hale getirmek için bu araç kullanılmaktadır.
        {
            ExecuteCommand(ToolCommands.Select, sender);
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ToolCommands.ZoomIn, sender);

        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            ExecuteCommand(ToolCommands.ZoomOut, sender);

        }

        private void BtnPan_Click(object sender, EventArgs e) //Harita üzerinde kaydırma işlemi için bu araç kullanılmaktadır
        {
            ExecuteCommand(ToolCommands.Recenter, sender);

        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.GetInfo);
        }
        #endregion

        #region Çizim İşlemleri
        private void PanelMid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDrawPoint_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.AddPoint);
        }

        private void BtnDrawLine_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.AddLine);

        }

        private void BtnDrawRegion_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.AddPolygon);

        }
        private void BtnDrawBuilding_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.AddBuilding);

        }
        #endregion

        private void BtnIlceGolQuery_Click(object sender, EventArgs e)
        {
            IlceGolForm form = new IlceGolForm();
            form.Show();
        }

        private void BtnShowiller_Click(object sender, EventArgs e)
        {
            IllerForm form = new IllerForm();
            form.Show();
        }

        private void BtnShowilceler_Click(object sender, EventArgs e)
        {
            IlcelerForm form = new IlcelerForm();
            form.Show();
        }

        private void BtnileNoktaAt_Click(object sender, EventArgs e)
        {
            ilPointForm form = new ilPointForm();
            form.Show();
        }

        public void ShowNotification(string message, System.Windows.Point location, int timeToShow = 2500, bool addToList = false)
        {
            // throw new NotImplementedException();
        }

        public string[] GetStatusFieldText(int field = -1)
        {
            //throw new NotImplementedException();
            return null;
        }

        public void SetWorkspaceClean()
        {
            // throw new NotImplementedException();
        }

        private void btnMadenOcakSorgula_Click(object sender, EventArgs e)
        {
            MadenOcagiSorgulamaForm form = new MadenOcagiSorgulamaForm();
            form.Show();

        }

        private void btnDrawMadenOcagi_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.AddMadenOcagi);
        }

        private void btnDrawDuvar_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.AddSinirDuvar);
        }

        private void btnSinirDuvarSorgula_Click(object sender, EventArgs e)
        {
            SinirDuvarSorgulamaForm form = new SinirDuvarSorgulamaForm();
            form.Show();
        }

        private void btnSinirDuvarInfo_Click(object sender, EventArgs e)
        {
            CustomToolButtons.Instance.GetCustomTool(CustomToolButtons.ButtonName.GetSinirDuvarInfo);
        }
    }
}

namespace DefaultMIx64
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TLPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabDocument = new System.Windows.Forms.TabPage();
            this.btnOpenWorkspace = new System.Windows.Forms.Button();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnCloseAllTable = new System.Windows.Forms.Button();
            this.btnOpenTable = new System.Windows.Forms.Button();
            this.tabMapTools = new System.Windows.Forms.TabPage();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tabDrawingTools = new System.Windows.Forms.TabPage();
            this.btnDrawDuvar = new System.Windows.Forms.Button();
            this.btnDrawMadenOcagi = new System.Windows.Forms.Button();
            this.btnDrawBuilding = new System.Windows.Forms.Button();
            this.btnDrawRegion = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawPoint = new System.Windows.Forms.Button();
            this.tabQueries = new System.Windows.Forms.TabPage();
            this.btnSinirDuvarSorgula = new System.Windows.Forms.Button();
            this.btnMadenOcakSorgula = new System.Windows.Forms.Button();
            this.btnileNoktaAt = new System.Windows.Forms.Button();
            this.btnShowilceler = new System.Windows.Forms.Button();
            this.btnShowiller = new System.Windows.Forms.Button();
            this.btnIlceGolQuery = new System.Windows.Forms.Button();
            this.PanelMid = new System.Windows.Forms.Panel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.TLPanelMain.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabDocument.SuspendLayout();
            this.tabMapTools.SuspendLayout();
            this.tabDrawingTools.SuspendLayout();
            this.tabQueries.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPanelMain
            // 
            this.TLPanelMain.AutoSize = true;
            this.TLPanelMain.ColumnCount = 1;
            this.TLPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPanelMain.Controls.Add(this.PanelTop, 0, 0);
            this.TLPanelMain.Controls.Add(this.PanelMid, 0, 1);
            this.TLPanelMain.Controls.Add(this.PanelBottom, 0, 2);
            this.TLPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TLPanelMain.Margin = new System.Windows.Forms.Padding(4);
            this.TLPanelMain.Name = "TLPanelMain";
            this.TLPanelMain.RowCount = 3;
            this.TLPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.TLPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TLPanelMain.Size = new System.Drawing.Size(1344, 890);
            this.TLPanelMain.TabIndex = 0;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.TabControl);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTop.Location = new System.Drawing.Point(4, 4);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1336, 115);
            this.PanelTop.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabDocument);
            this.TabControl.Controls.Add(this.tabMapTools);
            this.TabControl.Controls.Add(this.tabDrawingTools);
            this.TabControl.Controls.Add(this.tabQueries);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1336, 115);
            this.TabControl.TabIndex = 0;
            // 
            // tabDocument
            // 
            this.tabDocument.Controls.Add(this.btnOpenWorkspace);
            this.tabDocument.Controls.Add(this.btnCloseTable);
            this.tabDocument.Controls.Add(this.btnCloseAllTable);
            this.tabDocument.Controls.Add(this.btnOpenTable);
            this.tabDocument.Location = new System.Drawing.Point(4, 25);
            this.tabDocument.Margin = new System.Windows.Forms.Padding(4);
            this.tabDocument.Name = "tabDocument";
            this.tabDocument.Padding = new System.Windows.Forms.Padding(4);
            this.tabDocument.Size = new System.Drawing.Size(1328, 86);
            this.tabDocument.TabIndex = 0;
            this.tabDocument.Text = "Dosya";
            this.tabDocument.UseVisualStyleBackColor = true;
            // 
            // btnOpenWorkspace
            // 
            this.btnOpenWorkspace.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenWorkspace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenWorkspace.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenWorkspace.Image")));
            this.btnOpenWorkspace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenWorkspace.Location = new System.Drawing.Point(8, 7);
            this.btnOpenWorkspace.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenWorkspace.Name = "btnOpenWorkspace";
            this.btnOpenWorkspace.Size = new System.Drawing.Size(119, 69);
            this.btnOpenWorkspace.TabIndex = 0;
            this.btnOpenWorkspace.Text = "Workspace Aç";
            this.btnOpenWorkspace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenWorkspace.UseVisualStyleBackColor = false;
            this.btnOpenWorkspace.Click += new System.EventHandler(this.BtnOpenWorkspace_Click);
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseTable.Image")));
            this.btnCloseTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseTable.Location = new System.Drawing.Point(411, 7);
            this.btnCloseTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(105, 69);
            this.btnCloseTable.TabIndex = 3;
            this.btnCloseTable.Text = "Tablo Kapat";
            this.btnCloseTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseTable.UseVisualStyleBackColor = true;
            this.btnCloseTable.Click += new System.EventHandler(this.BtnCloseTable_Click);
            // 
            // btnCloseAllTable
            // 
            this.btnCloseAllTable.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseAllTable.Image")));
            this.btnCloseAllTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseAllTable.Location = new System.Drawing.Point(249, 7);
            this.btnCloseAllTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseAllTable.Name = "btnCloseAllTable";
            this.btnCloseAllTable.Size = new System.Drawing.Size(153, 69);
            this.btnCloseAllTable.TabIndex = 2;
            this.btnCloseAllTable.Text = "Tüm Tabloları Kapat";
            this.btnCloseAllTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseAllTable.UseVisualStyleBackColor = true;
            this.btnCloseAllTable.Click += new System.EventHandler(this.BtnCloseAllTable_Click);
            // 
            // btnOpenTable
            // 
            this.btnOpenTable.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenTable.Image")));
            this.btnOpenTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenTable.Location = new System.Drawing.Point(135, 7);
            this.btnOpenTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenTable.Name = "btnOpenTable";
            this.btnOpenTable.Size = new System.Drawing.Size(107, 69);
            this.btnOpenTable.TabIndex = 1;
            this.btnOpenTable.Text = "Tablo Aç";
            this.btnOpenTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenTable.UseVisualStyleBackColor = true;
            this.btnOpenTable.Click += new System.EventHandler(this.BtnOpenTable_Click);
            // 
            // tabMapTools
            // 
            this.tabMapTools.Controls.Add(this.btnInfo);
            this.tabMapTools.Controls.Add(this.btnPan);
            this.tabMapTools.Controls.Add(this.btnZoomOut);
            this.tabMapTools.Controls.Add(this.btnZoomIn);
            this.tabMapTools.Controls.Add(this.btnSelect);
            this.tabMapTools.Location = new System.Drawing.Point(4, 25);
            this.tabMapTools.Margin = new System.Windows.Forms.Padding(4);
            this.tabMapTools.Name = "tabMapTools";
            this.tabMapTools.Padding = new System.Windows.Forms.Padding(4);
            this.tabMapTools.Size = new System.Drawing.Size(1328, 86);
            this.tabMapTools.TabIndex = 1;
            this.tabMapTools.Text = "Harita Araçları";
            this.tabMapTools.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInfo.Location = new System.Drawing.Point(504, 7);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(116, 69);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "Bilgi";
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnPan
            // 
            this.btnPan.BackColor = System.Drawing.Color.Transparent;
            this.btnPan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPan.Image = ((System.Drawing.Image)(resources.GetObject("btnPan.Image")));
            this.btnPan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPan.Location = new System.Drawing.Point(380, 7);
            this.btnPan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(116, 69);
            this.btnPan.TabIndex = 4;
            this.btnPan.Text = "Pan";
            this.btnPan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPan.UseVisualStyleBackColor = false;
            this.btnPan.Click += new System.EventHandler(this.BtnPan_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZoomOut.Location = new System.Drawing.Point(256, 7);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(116, 69);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.BtnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.btnZoomIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnZoomIn.Location = new System.Drawing.Point(132, 7);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(116, 69);
            this.btnZoomIn.TabIndex = 2;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.BtnZoomIn_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelect.Location = new System.Drawing.Point(8, 7);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(116, 69);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // tabDrawingTools
            // 
            this.tabDrawingTools.Controls.Add(this.btnDrawDuvar);
            this.tabDrawingTools.Controls.Add(this.btnDrawMadenOcagi);
            this.tabDrawingTools.Controls.Add(this.btnDrawBuilding);
            this.tabDrawingTools.Controls.Add(this.btnDrawRegion);
            this.tabDrawingTools.Controls.Add(this.btnDrawLine);
            this.tabDrawingTools.Controls.Add(this.btnDrawPoint);
            this.tabDrawingTools.Location = new System.Drawing.Point(4, 25);
            this.tabDrawingTools.Margin = new System.Windows.Forms.Padding(4);
            this.tabDrawingTools.Name = "tabDrawingTools";
            this.tabDrawingTools.Padding = new System.Windows.Forms.Padding(4);
            this.tabDrawingTools.Size = new System.Drawing.Size(1328, 86);
            this.tabDrawingTools.TabIndex = 2;
            this.tabDrawingTools.Text = "Çizim Araçları";
            this.tabDrawingTools.UseVisualStyleBackColor = true;
            // 
            // btnDrawDuvar
            // 
            this.btnDrawDuvar.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawDuvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrawDuvar.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawDuvar.Image")));
            this.btnDrawDuvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrawDuvar.Location = new System.Drawing.Point(649, 8);
            this.btnDrawDuvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawDuvar.Name = "btnDrawDuvar";
            this.btnDrawDuvar.Size = new System.Drawing.Size(116, 69);
            this.btnDrawDuvar.TabIndex = 11;
            this.btnDrawDuvar.Text = "Duvar Çiz";
            this.btnDrawDuvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDrawDuvar.UseVisualStyleBackColor = false;
            this.btnDrawDuvar.Click += new System.EventHandler(this.btnDrawDuvar_Click);
            // 
            // btnDrawMadenOcagi
            // 
            this.btnDrawMadenOcagi.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawMadenOcagi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrawMadenOcagi.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawMadenOcagi.Image")));
            this.btnDrawMadenOcagi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrawMadenOcagi.Location = new System.Drawing.Point(513, 9);
            this.btnDrawMadenOcagi.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawMadenOcagi.Name = "btnDrawMadenOcagi";
            this.btnDrawMadenOcagi.Size = new System.Drawing.Size(116, 69);
            this.btnDrawMadenOcagi.TabIndex = 10;
            this.btnDrawMadenOcagi.Text = "Maden Ocagi Ciz";
            this.btnDrawMadenOcagi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDrawMadenOcagi.UseVisualStyleBackColor = false;
            this.btnDrawMadenOcagi.Click += new System.EventHandler(this.btnDrawMadenOcagi_Click);
            // 
            // btnDrawBuilding
            // 
            this.btnDrawBuilding.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawBuilding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrawBuilding.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrawBuilding.Location = new System.Drawing.Point(380, 7);
            this.btnDrawBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawBuilding.Name = "btnDrawBuilding";
            this.btnDrawBuilding.Size = new System.Drawing.Size(116, 69);
            this.btnDrawBuilding.TabIndex = 9;
            this.btnDrawBuilding.Text = "Bina Çiz";
            this.btnDrawBuilding.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDrawBuilding.UseVisualStyleBackColor = false;
            this.btnDrawBuilding.Click += new System.EventHandler(this.BtnDrawBuilding_Click);
            // 
            // btnDrawRegion
            // 
            this.btnDrawRegion.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawRegion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrawRegion.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawRegion.Image")));
            this.btnDrawRegion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrawRegion.Location = new System.Drawing.Point(256, 7);
            this.btnDrawRegion.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawRegion.Name = "btnDrawRegion";
            this.btnDrawRegion.Size = new System.Drawing.Size(116, 69);
            this.btnDrawRegion.TabIndex = 8;
            this.btnDrawRegion.Text = "Kapalı Alan Çiz";
            this.btnDrawRegion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDrawRegion.UseVisualStyleBackColor = false;
            this.btnDrawRegion.Click += new System.EventHandler(this.BtnDrawRegion_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrawLine.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawLine.Image")));
            this.btnDrawLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrawLine.Location = new System.Drawing.Point(132, 7);
            this.btnDrawLine.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(116, 69);
            this.btnDrawLine.TabIndex = 7;
            this.btnDrawLine.Text = "Çizgi Çiz";
            this.btnDrawLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDrawLine.UseVisualStyleBackColor = false;
            this.btnDrawLine.Click += new System.EventHandler(this.BtnDrawLine_Click);
            // 
            // btnDrawPoint
            // 
            this.btnDrawPoint.BackColor = System.Drawing.Color.Transparent;
            this.btnDrawPoint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrawPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnDrawPoint.Image")));
            this.btnDrawPoint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDrawPoint.Location = new System.Drawing.Point(8, 7);
            this.btnDrawPoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawPoint.Name = "btnDrawPoint";
            this.btnDrawPoint.Size = new System.Drawing.Size(116, 69);
            this.btnDrawPoint.TabIndex = 6;
            this.btnDrawPoint.Text = "Nokta Çiz";
            this.btnDrawPoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDrawPoint.UseVisualStyleBackColor = false;
            this.btnDrawPoint.Click += new System.EventHandler(this.BtnDrawPoint_Click);
            // 
            // tabQueries
            // 
            this.tabQueries.Controls.Add(this.btnSinirDuvarSorgula);
            this.tabQueries.Controls.Add(this.btnMadenOcakSorgula);
            this.tabQueries.Controls.Add(this.btnileNoktaAt);
            this.tabQueries.Controls.Add(this.btnShowilceler);
            this.tabQueries.Controls.Add(this.btnShowiller);
            this.tabQueries.Controls.Add(this.btnIlceGolQuery);
            this.tabQueries.Location = new System.Drawing.Point(4, 25);
            this.tabQueries.Margin = new System.Windows.Forms.Padding(4);
            this.tabQueries.Name = "tabQueries";
            this.tabQueries.Padding = new System.Windows.Forms.Padding(4);
            this.tabQueries.Size = new System.Drawing.Size(1328, 86);
            this.tabQueries.TabIndex = 3;
            this.tabQueries.Text = "Sorgular";
            this.tabQueries.UseVisualStyleBackColor = true;
            // 
            // btnSinirDuvarSorgula
            // 
            this.btnSinirDuvarSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinirDuvarSorgula.Location = new System.Drawing.Point(649, 8);
            this.btnSinirDuvarSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinirDuvarSorgula.Name = "btnSinirDuvarSorgula";
            this.btnSinirDuvarSorgula.Size = new System.Drawing.Size(120, 68);
            this.btnSinirDuvarSorgula.TabIndex = 5;
            this.btnSinirDuvarSorgula.Text = "Sinir Duvar Sorgula";
            this.btnSinirDuvarSorgula.UseVisualStyleBackColor = true;
            this.btnSinirDuvarSorgula.Click += new System.EventHandler(this.btnSinirDuvarSorgula_Click);
            // 
            // btnMadenOcakSorgula
            // 
            this.btnMadenOcakSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMadenOcakSorgula.Location = new System.Drawing.Point(521, 10);
            this.btnMadenOcakSorgula.Margin = new System.Windows.Forms.Padding(4);
            this.btnMadenOcakSorgula.Name = "btnMadenOcakSorgula";
            this.btnMadenOcakSorgula.Size = new System.Drawing.Size(120, 68);
            this.btnMadenOcakSorgula.TabIndex = 4;
            this.btnMadenOcakSorgula.Text = "Maden Ocağı Sorgulama";
            this.btnMadenOcakSorgula.UseVisualStyleBackColor = true;
            this.btnMadenOcakSorgula.Click += new System.EventHandler(this.btnMadenOcakSorgula_Click);
            // 
            // btnileNoktaAt
            // 
            this.btnileNoktaAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnileNoktaAt.Location = new System.Drawing.Point(393, 10);
            this.btnileNoktaAt.Margin = new System.Windows.Forms.Padding(4);
            this.btnileNoktaAt.Name = "btnileNoktaAt";
            this.btnileNoktaAt.Size = new System.Drawing.Size(120, 68);
            this.btnileNoktaAt.TabIndex = 3;
            this.btnileNoktaAt.Text = "Seçilen İle Nokta At";
            this.btnileNoktaAt.UseVisualStyleBackColor = true;
            this.btnileNoktaAt.Click += new System.EventHandler(this.BtnileNoktaAt_Click);
            // 
            // btnShowilceler
            // 
            this.btnShowilceler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowilceler.Location = new System.Drawing.Point(265, 9);
            this.btnShowilceler.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowilceler.Name = "btnShowilceler";
            this.btnShowilceler.Size = new System.Drawing.Size(120, 68);
            this.btnShowilceler.TabIndex = 2;
            this.btnShowilceler.Text = "İlçe Listesi";
            this.btnShowilceler.UseVisualStyleBackColor = true;
            this.btnShowilceler.Click += new System.EventHandler(this.BtnShowilceler_Click);
            // 
            // btnShowiller
            // 
            this.btnShowiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowiller.Location = new System.Drawing.Point(137, 9);
            this.btnShowiller.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowiller.Name = "btnShowiller";
            this.btnShowiller.Size = new System.Drawing.Size(120, 68);
            this.btnShowiller.TabIndex = 1;
            this.btnShowiller.Text = "İl Listesi";
            this.btnShowiller.UseVisualStyleBackColor = true;
            this.btnShowiller.Click += new System.EventHandler(this.BtnShowiller_Click);
            // 
            // btnIlceGolQuery
            // 
            this.btnIlceGolQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIlceGolQuery.Location = new System.Drawing.Point(9, 9);
            this.btnIlceGolQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnIlceGolQuery.Name = "btnIlceGolQuery";
            this.btnIlceGolQuery.Size = new System.Drawing.Size(120, 68);
            this.btnIlceGolQuery.TabIndex = 0;
            this.btnIlceGolQuery.Text = "İlçe ve Göl Analizi";
            this.btnIlceGolQuery.UseVisualStyleBackColor = true;
            this.btnIlceGolQuery.Click += new System.EventHandler(this.BtnIlceGolQuery_Click);
            // 
            // PanelMid
            // 
            this.PanelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMid.Location = new System.Drawing.Point(4, 127);
            this.PanelMid.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMid.Name = "PanelMid";
            this.PanelMid.Size = new System.Drawing.Size(1336, 710);
            this.PanelMid.TabIndex = 1;
            this.PanelMid.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMid_Paint);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBottom.Location = new System.Drawing.Point(4, 845);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1336, 41);
            this.PanelBottom.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 890);
            this.Controls.Add(this.TLPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TLPanelMain.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabDocument.ResumeLayout(false);
            this.tabMapTools.ResumeLayout(false);
            this.tabDrawingTools.ResumeLayout(false);
            this.tabQueries.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPanelMain;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelMid;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabDocument;
        private System.Windows.Forms.TabPage tabMapTools;
        private System.Windows.Forms.TabPage tabDrawingTools;
        private System.Windows.Forms.Button btnOpenWorkspace;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Button btnCloseAllTable;
        private System.Windows.Forms.Button btnOpenTable;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnDrawPoint;
        private System.Windows.Forms.Button btnDrawRegion;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.TabPage tabQueries;
        private System.Windows.Forms.Button btnIlceGolQuery;
        private System.Windows.Forms.Button btnDrawBuilding;
        private System.Windows.Forms.Button btnShowilceler;
        private System.Windows.Forms.Button btnShowiller;
        private System.Windows.Forms.Button btnileNoktaAt;
        private System.Windows.Forms.Button btnMadenOcakSorgula;
        private System.Windows.Forms.Button btnDrawMadenOcagi;
        private System.Windows.Forms.Button btnDrawDuvar;
        private System.Windows.Forms.Button btnSinirDuvarSorgula;
    }
}


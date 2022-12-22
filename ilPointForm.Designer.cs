namespace DefaultMIx64
{
    partial class ilPointForm
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
            this.listilPointQuery = new System.Windows.Forms.ListView();
            this.colPlakaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colilAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBolgeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNufus1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNufus2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDegisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrtGelir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listilPointQuery
            // 
            this.listilPointQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlakaNo,
            this.colilAdı,
            this.colBolgeAdi,
            this.colNufus1,
            this.colNufus2,
            this.colDegisim,
            this.colOrtGelir});
            this.listilPointQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listilPointQuery.FullRowSelect = true;
            this.listilPointQuery.GridLines = true;
            this.listilPointQuery.Location = new System.Drawing.Point(0, 0);
            this.listilPointQuery.MultiSelect = false;
            this.listilPointQuery.Name = "listilPointQuery";
            this.listilPointQuery.Size = new System.Drawing.Size(800, 450);
            this.listilPointQuery.TabIndex = 1;
            this.listilPointQuery.UseCompatibleStateImageBehavior = false;
            this.listilPointQuery.View = System.Windows.Forms.View.Details;
            this.listilPointQuery.SelectedIndexChanged += new System.EventHandler(this.ListilPointQuery_SelectedIndexChanged);
            // 
            // colPlakaNo
            // 
            this.colPlakaNo.Text = "PlakaNo";
            this.colPlakaNo.Width = 50;
            // 
            // colilAdı
            // 
            this.colilAdı.Text = "İl Adı";
            this.colilAdı.Width = 100;
            // 
            // colBolgeAdi
            // 
            this.colBolgeAdi.Text = "Bölge Adı";
            this.colBolgeAdi.Width = 100;
            // 
            // colNufus1
            // 
            this.colNufus1.Text = "Nüfus 1990";
            this.colNufus1.Width = 100;
            // 
            // colNufus2
            // 
            this.colNufus2.Text = "Nüfus 1997";
            this.colNufus2.Width = 100;
            // 
            // colDegisim
            // 
            this.colDegisim.Text = "Değişim";
            this.colDegisim.Width = 100;
            // 
            // colOrtGelir
            // 
            this.colOrtGelir.Text = "Ortalama Gelir";
            this.colOrtGelir.Width = 100;
            // 
            // ilPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listilPointQuery);
            this.Name = "ilPointForm";
            this.Text = "ilPointForm";
            this.Load += new System.EventHandler(this.IlPointForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listilPointQuery;
        private System.Windows.Forms.ColumnHeader colPlakaNo;
        private System.Windows.Forms.ColumnHeader colilAdı;
        private System.Windows.Forms.ColumnHeader colBolgeAdi;
        private System.Windows.Forms.ColumnHeader colNufus1;
        private System.Windows.Forms.ColumnHeader colNufus2;
        private System.Windows.Forms.ColumnHeader colDegisim;
        private System.Windows.Forms.ColumnHeader colOrtGelir;
    }
}
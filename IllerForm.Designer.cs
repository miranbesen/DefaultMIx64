namespace DefaultMIx64
{
    partial class IllerForm
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
            this.listillerQuery = new System.Windows.Forms.ListView();
            this.colPlakaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colilAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBolgeAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNufus1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNufus2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDegisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrtGelir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listillerQuery
            // 
            this.listillerQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlakaNo,
            this.colilAdı,
            this.colBolgeAdi,
            this.colNufus1,
            this.colNufus2,
            this.colDegisim,
            this.colOrtGelir});
            this.listillerQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listillerQuery.FullRowSelect = true;
            this.listillerQuery.GridLines = true;
            this.listillerQuery.Location = new System.Drawing.Point(0, 0);
            this.listillerQuery.MultiSelect = false;
            this.listillerQuery.Name = "listillerQuery";
            this.listillerQuery.Size = new System.Drawing.Size(751, 485);
            this.listillerQuery.TabIndex = 0;
            this.listillerQuery.UseCompatibleStateImageBehavior = false;
            this.listillerQuery.View = System.Windows.Forms.View.Details;
            this.listillerQuery.SelectedIndexChanged += new System.EventHandler(this.ListillerQuery_SelectedIndexChanged);
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
            // IllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 485);
            this.Controls.Add(this.listillerQuery);
            this.Name = "IllerForm";
            this.Text = "IllerForm";
            this.Load += new System.EventHandler(this.IllerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listillerQuery;
        private System.Windows.Forms.ColumnHeader colPlakaNo;
        private System.Windows.Forms.ColumnHeader colilAdı;
        private System.Windows.Forms.ColumnHeader colBolgeAdi;
        private System.Windows.Forms.ColumnHeader colNufus1;
        private System.Windows.Forms.ColumnHeader colNufus2;
        private System.Windows.Forms.ColumnHeader colDegisim;
        private System.Windows.Forms.ColumnHeader colOrtGelir;
    }
}
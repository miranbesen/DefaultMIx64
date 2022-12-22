namespace DefaultMIx64
{
    partial class IlceGolForm
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
            this.listIlceGolQuery = new System.Windows.Forms.ListView();
            this.colGolAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIlceAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIlAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listIlceGolQuery
            // 
            this.listIlceGolQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGolAdi,
            this.colIlceAdi,
            this.colIlAdi});
            this.listIlceGolQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIlceGolQuery.FullRowSelect = true;
            this.listIlceGolQuery.GridLines = true;
            this.listIlceGolQuery.Location = new System.Drawing.Point(0, 0);
            this.listIlceGolQuery.MultiSelect = false;
            this.listIlceGolQuery.Name = "listIlceGolQuery";
            this.listIlceGolQuery.Size = new System.Drawing.Size(482, 599);
            this.listIlceGolQuery.TabIndex = 0;
            this.listIlceGolQuery.UseCompatibleStateImageBehavior = false;
            this.listIlceGolQuery.View = System.Windows.Forms.View.Details;
            this.listIlceGolQuery.SelectedIndexChanged += new System.EventHandler(this.ListIlceGolQuery_SelectedIndexChanged);
            // 
            // colGolAdi
            // 
            this.colGolAdi.Text = "Göl Adı";
            this.colGolAdi.Width = 100;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Text = "İlçe Adı";
            this.colIlceAdi.Width = 100;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Text = "İl Adı";
            this.colIlAdi.Width = 100;
            // 
            // IlceGolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 599);
            this.Controls.Add(this.listIlceGolQuery);
            this.Name = "IlceGolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlçe ve Göl Analizi";
            this.Load += new System.EventHandler(this.IlceGolForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listIlceGolQuery;
        private System.Windows.Forms.ColumnHeader colGolAdi;
        private System.Windows.Forms.ColumnHeader colIlceAdi;
        private System.Windows.Forms.ColumnHeader colIlAdi;
    }
}
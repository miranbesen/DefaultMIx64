namespace DefaultMIx64
{
    partial class IlcelerForm
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
            this.listIlcelerQuery = new System.Windows.Forms.ListView();
            this.colilAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colilceAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlakaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listIlcelerQuery
            // 
            this.listIlcelerQuery.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colilAdi,
            this.colilceAdi,
            this.colPlakaNo});
            this.listIlcelerQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIlcelerQuery.FullRowSelect = true;
            this.listIlcelerQuery.GridLines = true;
            this.listIlcelerQuery.Location = new System.Drawing.Point(0, 0);
            this.listIlcelerQuery.MultiSelect = false;
            this.listIlcelerQuery.Name = "listIlcelerQuery";
            this.listIlcelerQuery.Size = new System.Drawing.Size(434, 489);
            this.listIlcelerQuery.TabIndex = 0;
            this.listIlcelerQuery.UseCompatibleStateImageBehavior = false;
            this.listIlcelerQuery.View = System.Windows.Forms.View.Details;
            this.listIlcelerQuery.SelectedIndexChanged += new System.EventHandler(this.ListIlcelerQuery_SelectedIndexChanged);
            // 
            // colilAdi
            // 
            this.colilAdi.Text = "İl Adı";
            this.Width = 100;
            // 
            // colilceAdi
            // 
            this.colilceAdi.Text = "İlçe Adı";
            this.Width = 100;
            // 
            // colPlakaNo
            // 
            this.colPlakaNo.Text = "Plaka No";
            this.Width = 50;
            // 
            // IlcelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 489);
            this.Controls.Add(this.listIlcelerQuery);
            this.Name = "IlcelerForm";
            this.Text = "IlcelerForm";
            this.Load += new System.EventHandler(this.IlcelerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listIlcelerQuery;
        private System.Windows.Forms.ColumnHeader colilAdi;
        private System.Windows.Forms.ColumnHeader colilceAdi;
        private System.Windows.Forms.ColumnHeader colPlakaNo;
    }
}
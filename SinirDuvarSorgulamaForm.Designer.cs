namespace DefaultMIx64
{
    partial class SinirDuvarSorgulamaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinir_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Il = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sinir_Uzunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sinir_Adi,
            this.Il,
            this.Sinir_Uzunluk});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Sinir_Adi
            // 
            this.Sinir_Adi.HeaderText = "Sınır Adi";
            this.Sinir_Adi.MinimumWidth = 6;
            this.Sinir_Adi.Name = "Sinir_Adi";
            this.Sinir_Adi.Width = 125;
            // 
            // Il
            // 
            this.Il.HeaderText = "Il";
            this.Il.MinimumWidth = 6;
            this.Il.Name = "Il";
            this.Il.Width = 125;
            // 
            // Sinir_Uzunluk
            // 
            this.Sinir_Uzunluk.HeaderText = "Sınır Uzunluk";
            this.Sinir_Uzunluk.MinimumWidth = 6;
            this.Sinir_Uzunluk.Name = "Sinir_Uzunluk";
            this.Sinir_Uzunluk.Width = 125;
            // 
            // SinirDuvarSorgulamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SinirDuvarSorgulamaForm";
            this.Text = "SinirDuvarSorgulamaForm";
            this.Load += new System.EventHandler(this.SinirDuvarSorgulamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinir_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Il;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sinir_Uzunluk;
    }
}
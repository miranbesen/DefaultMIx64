namespace DefaultMIx64
{
    partial class MadenOcagiSorgulamaForm
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
            this.Sirket_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Il = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sirket_Adi,
            this.Il,
            this.Alan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Sirket_Adi
            // 
            this.Sirket_Adi.HeaderText = "Sirket Adi";
            this.Sirket_Adi.MinimumWidth = 6;
            this.Sirket_Adi.Name = "Sirket_Adi";
            this.Sirket_Adi.Width = 125;
            // 
            // Il
            // 
            this.Il.HeaderText = "Il Adi";
            this.Il.MinimumWidth = 6;
            this.Il.Name = "Il";
            this.Il.Width = 125;
            // 
            // Alan
            // 
            this.Alan.HeaderText = "Kapladigi Alan";
            this.Alan.MinimumWidth = 6;
            this.Alan.Name = "Alan";
            this.Alan.Width = 125;
            // 
            // MadenOcagiSorgulamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MadenOcagiSorgulamaForm";
            this.Text = "MadenOcagiSorgulamaForm";
            this.Load += new System.EventHandler(this.MadenOcagiSorgulamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sirket_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Il;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alan;
    }
}
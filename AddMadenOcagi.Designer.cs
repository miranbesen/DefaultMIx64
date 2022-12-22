namespace DefaultMIx64
{
    partial class AddMadenOcagi
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSirketAdi = new System.Windows.Forms.TextBox();
            this.btnRegionSave = new System.Windows.Forms.Button();
            this.btnRegionDelete = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKesisenInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Maden Ocagi Alan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sirket Adi:";
            // 
            // textSirketAdi
            // 
            this.textSirketAdi.Location = new System.Drawing.Point(159, 26);
            this.textSirketAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textSirketAdi.Name = "textSirketAdi";
            this.textSirketAdi.Size = new System.Drawing.Size(251, 22);
            this.textSirketAdi.TabIndex = 26;
            this.textSirketAdi.TextChanged += new System.EventHandler(this.textRegionName_TextChanged);
            // 
            // btnRegionSave
            // 
            this.btnRegionSave.Location = new System.Drawing.Point(148, 220);
            this.btnRegionSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegionSave.Name = "btnRegionSave";
            this.btnRegionSave.Size = new System.Drawing.Size(119, 28);
            this.btnRegionSave.TabIndex = 28;
            this.btnRegionSave.Text = "Kaydet";
            this.btnRegionSave.UseVisualStyleBackColor = true;
            this.btnRegionSave.Click += new System.EventHandler(this.btnRegionSave_Click);
            // 
            // btnRegionDelete
            // 
            this.btnRegionDelete.Location = new System.Drawing.Point(285, 220);
            this.btnRegionDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegionDelete.Name = "btnRegionDelete";
            this.btnRegionDelete.Size = new System.Drawing.Size(125, 28);
            this.btnRegionDelete.TabIndex = 29;
            this.btnRegionDelete.Text = "Sil";
            this.btnRegionDelete.UseVisualStyleBackColor = true;
            this.btnRegionDelete.Click += new System.EventHandler(this.btnRegionDelete_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(417, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 308);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(414, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "label5";
            // 
            // btnKesisenInfo
            // 
            this.btnKesisenInfo.Location = new System.Drawing.Point(417, 340);
            this.btnKesisenInfo.Name = "btnKesisenInfo";
            this.btnKesisenInfo.Size = new System.Drawing.Size(196, 60);
            this.btnKesisenInfo.TabIndex = 36;
            this.btnKesisenInfo.Text = "Tüm Kesisenleri Goster";
            this.btnKesisenInfo.UseVisualStyleBackColor = true;
            this.btnKesisenInfo.Click += new System.EventHandler(this.btnKesisenInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Il Adi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 100);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textRegionName_TextChanged);
            // 
            // AddMadenOcagi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 416);
            this.Controls.Add(this.btnKesisenInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRegionDelete);
            this.Controls.Add(this.btnRegionSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textSirketAdi);
            this.Name = "AddMadenOcagi";
            this.Text = "AddMadenOcagi";
            this.Load += new System.EventHandler(this.AddMadenOcagi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSirketAdi;
        private System.Windows.Forms.Button btnRegionSave;
        private System.Windows.Forms.Button btnRegionDelete;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKesisenInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
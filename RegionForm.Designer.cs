namespace DefaultMIx64
{
    partial class RegionForm
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
            this.btnRegionDelete = new System.Windows.Forms.Button();
            this.btnRegionSave = new System.Windows.Forms.Button();
            this.textRegionType = new System.Windows.Forms.TextBox();
            this.textRegionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegionDelete
            // 
            this.btnRegionDelete.Location = new System.Drawing.Point(224, 100);
            this.btnRegionDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegionDelete.Name = "btnRegionDelete";
            this.btnRegionDelete.Size = new System.Drawing.Size(125, 28);
            this.btnRegionDelete.TabIndex = 17;
            this.btnRegionDelete.Text = "Sil";
            this.btnRegionDelete.UseVisualStyleBackColor = true;
            this.btnRegionDelete.Click += new System.EventHandler(this.BtnRegionDelete_Click);
            // 
            // btnRegionSave
            // 
            this.btnRegionSave.Location = new System.Drawing.Point(97, 100);
            this.btnRegionSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegionSave.Name = "btnRegionSave";
            this.btnRegionSave.Size = new System.Drawing.Size(119, 28);
            this.btnRegionSave.TabIndex = 16;
            this.btnRegionSave.Text = "Kaydet";
            this.btnRegionSave.UseVisualStyleBackColor = true;
            this.btnRegionSave.Click += new System.EventHandler(this.BtnRegionSave_Click);
            // 
            // textRegionType
            // 
            this.textRegionType.Location = new System.Drawing.Point(97, 53);
            this.textRegionType.Margin = new System.Windows.Forms.Padding(4);
            this.textRegionType.Name = "textRegionType";
            this.textRegionType.Size = new System.Drawing.Size(251, 22);
            this.textRegionType.TabIndex = 15;
            // 
            // textRegionName
            // 
            this.textRegionName.Location = new System.Drawing.Point(97, 21);
            this.textRegionName.Margin = new System.Windows.Forms.Padding(4);
            this.textRegionName.Name = "textRegionName";
            this.textRegionName.Size = new System.Drawing.Size(251, 22);
            this.textRegionName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Soyadi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adı";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(530, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 308);
            this.listBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(561, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Şehir";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(732, 75);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(134, 308);
            this.listBox2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(785, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Alan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(932, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(932, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Polygon Alan";
            // 
            // RegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 510);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRegionDelete);
            this.Controls.Add(this.btnRegionSave);
            this.Controls.Add(this.textRegionType);
            this.Controls.Add(this.textRegionName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegionForm";
            this.Load += new System.EventHandler(this.RegionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegionDelete;
        private System.Windows.Forms.Button btnRegionSave;
        private System.Windows.Forms.TextBox textRegionType;
        private System.Windows.Forms.TextBox textRegionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ListBox listBox2;
    }
}
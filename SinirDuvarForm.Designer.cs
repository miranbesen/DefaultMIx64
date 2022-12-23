namespace DefaultMIx64
{
    partial class SinirDuvarForm
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
            this.btnKesisenInfo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSinirDuvarDelete = new System.Windows.Forms.Button();
            this.btnSinirDuvarSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textilAdi = new System.Windows.Forms.TextBox();
            this.textSinirDuvarAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKesisenInfo
            // 
            this.btnKesisenInfo.Location = new System.Drawing.Point(515, 341);
            this.btnKesisenInfo.Name = "btnKesisenInfo";
            this.btnKesisenInfo.Size = new System.Drawing.Size(196, 60);
            this.btnKesisenInfo.TabIndex = 47;
            this.btnKesisenInfo.Text = "Tüm Kesisenleri Goster";
            this.btnKesisenInfo.UseVisualStyleBackColor = true;
            this.btnKesisenInfo.Click += new System.EventHandler(this.btnKesisenInfo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "Sinir Duvar Uzunluk:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(512, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Şehir";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(515, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 308);
            this.listBox1.TabIndex = 43;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnSinirDuvarDelete
            // 
            this.btnSinirDuvarDelete.Location = new System.Drawing.Point(230, 174);
            this.btnSinirDuvarDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinirDuvarDelete.Name = "btnSinirDuvarDelete";
            this.btnSinirDuvarDelete.Size = new System.Drawing.Size(125, 28);
            this.btnSinirDuvarDelete.TabIndex = 42;
            this.btnSinirDuvarDelete.Text = "Sil";
            this.btnSinirDuvarDelete.UseVisualStyleBackColor = true;
            this.btnSinirDuvarDelete.Click += new System.EventHandler(this.btnSinirDuvarDelete_Click);
            // 
            // btnSinirDuvarSave
            // 
            this.btnSinirDuvarSave.Location = new System.Drawing.Point(90, 174);
            this.btnSinirDuvarSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinirDuvarSave.Name = "btnSinirDuvarSave";
            this.btnSinirDuvarSave.Size = new System.Drawing.Size(119, 28);
            this.btnSinirDuvarSave.TabIndex = 41;
            this.btnSinirDuvarSave.Text = "Kaydet";
            this.btnSinirDuvarSave.UseVisualStyleBackColor = true;
            this.btnSinirDuvarSave.Click += new System.EventHandler(this.btnSinirDuvarSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Il Adi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sinir Duvar Adi:";
            // 
            // textilAdi
            // 
            this.textilAdi.Location = new System.Drawing.Point(230, 95);
            this.textilAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textilAdi.Name = "textilAdi";
            this.textilAdi.Size = new System.Drawing.Size(251, 22);
            this.textilAdi.TabIndex = 39;
            // 
            // textSinirDuvarAdi
            // 
            this.textSinirDuvarAdi.Location = new System.Drawing.Point(230, 24);
            this.textSinirDuvarAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textSinirDuvarAdi.Name = "textSinirDuvarAdi";
            this.textSinirDuvarAdi.Size = new System.Drawing.Size(251, 22);
            this.textSinirDuvarAdi.TabIndex = 40;
            // 
            // SinirDuvarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 412);
            this.Controls.Add(this.btnKesisenInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSinirDuvarDelete);
            this.Controls.Add(this.btnSinirDuvarSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textilAdi);
            this.Controls.Add(this.textSinirDuvarAdi);
            this.Name = "SinirDuvarForm";
            this.Text = "SinirDuvarForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinirDuvarForm_FormClosing);
            this.Load += new System.EventHandler(this.SinirDuvarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKesisenInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSinirDuvarDelete;
        private System.Windows.Forms.Button btnSinirDuvarSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textilAdi;
        private System.Windows.Forms.TextBox textSinirDuvarAdi;
    }
}
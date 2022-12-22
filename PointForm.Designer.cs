namespace DefaultMIx64
{
    partial class PointForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.btnPointSave = new System.Windows.Forms.Button();
            this.btnPointDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadi";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(93, 15);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(251, 22);
            this.textName.TabIndex = 2;
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(93, 47);
            this.textType.Margin = new System.Windows.Forms.Padding(4);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(251, 22);
            this.textType.TabIndex = 3;
            // 
            // btnPointSave
            // 
            this.btnPointSave.Location = new System.Drawing.Point(93, 94);
            this.btnPointSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnPointSave.Name = "btnPointSave";
            this.btnPointSave.Size = new System.Drawing.Size(119, 28);
            this.btnPointSave.TabIndex = 4;
            this.btnPointSave.Text = "Kaydet";
            this.btnPointSave.UseVisualStyleBackColor = true;
            this.btnPointSave.Click += new System.EventHandler(this.BtnPointSave_Click);
            // 
            // btnPointDelete
            // 
            this.btnPointDelete.Location = new System.Drawing.Point(220, 94);
            this.btnPointDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPointDelete.Name = "btnPointDelete";
            this.btnPointDelete.Size = new System.Drawing.Size(125, 28);
            this.btnPointDelete.TabIndex = 5;
            this.btnPointDelete.Text = "Sil";
            this.btnPointDelete.UseVisualStyleBackColor = true;
            this.btnPointDelete.Click += new System.EventHandler(this.BtnPointDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "KESİSTİĞİ İL";
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 137);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPointDelete);
            this.Controls.Add(this.btnPointSave);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointForm";
            this.Load += new System.EventHandler(this.PointForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.Button btnPointSave;
        private System.Windows.Forms.Button btnPointDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
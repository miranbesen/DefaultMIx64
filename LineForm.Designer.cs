namespace DefaultMIx64
{
    partial class LineForm
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
            this.btnLineDelete = new System.Windows.Forms.Button();
            this.btnLineSave = new System.Windows.Forms.Button();
            this.textType = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLineDelete
            // 
            this.btnLineDelete.Location = new System.Drawing.Point(166, 77);
            this.btnLineDelete.Name = "btnLineDelete";
            this.btnLineDelete.Size = new System.Drawing.Size(94, 23);
            this.btnLineDelete.TabIndex = 11;
            this.btnLineDelete.Text = "Sil";
            this.btnLineDelete.UseVisualStyleBackColor = true;
            this.btnLineDelete.Click += new System.EventHandler(this.BtnLineDelete_Click);
            // 
            // btnLineSave
            // 
            this.btnLineSave.Location = new System.Drawing.Point(71, 77);
            this.btnLineSave.Name = "btnLineSave";
            this.btnLineSave.Size = new System.Drawing.Size(89, 23);
            this.btnLineSave.TabIndex = 10;
            this.btnLineSave.Text = "Kaydet";
            this.btnLineSave.UseVisualStyleBackColor = true;
            this.btnLineSave.Click += new System.EventHandler(this.BtnLineSave_Click);
            // 
            // textType
            // 
            this.textType.Location = new System.Drawing.Point(71, 39);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(189, 20);
            this.textType.TabIndex = 9;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(71, 13);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(189, 20);
            this.textName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı";
            // 
            // LineForm
            // 
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 111);
            this.Controls.Add(this.btnLineDelete);
            this.Controls.Add(this.btnLineSave);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LineForm";
            this.Text = "LineForm";
            this.Load += new System.EventHandler(this.LineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLineDelete;
        private System.Windows.Forms.Button btnLineSave;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
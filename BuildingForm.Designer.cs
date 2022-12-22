namespace DefaultMIx64
{
    partial class BuildingForm
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
            this.textBuildingName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuildingSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBuildingCode = new System.Windows.Forms.TextBox();
            this.textBuildingCity = new System.Windows.Forms.TextBox();
            this.textBuildingTown = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuildingDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBuildingName
            // 
            this.textBuildingName.Location = new System.Drawing.Point(66, 15);
            this.textBuildingName.Name = "textBuildingName";
            this.textBuildingName.Size = new System.Drawing.Size(212, 20);
            this.textBuildingName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // btnBuildingSave
            // 
            this.btnBuildingSave.Location = new System.Drawing.Point(66, 119);
            this.btnBuildingSave.Name = "btnBuildingSave";
            this.btnBuildingSave.Size = new System.Drawing.Size(75, 23);
            this.btnBuildingSave.TabIndex = 2;
            this.btnBuildingSave.Text = "Kaydet";
            this.btnBuildingSave.UseVisualStyleBackColor = true;
            this.btnBuildingSave.Click += new System.EventHandler(this.BtnBuildingSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İl";
            // 
            // textBuildingCode
            // 
            this.textBuildingCode.Location = new System.Drawing.Point(66, 41);
            this.textBuildingCode.Name = "textBuildingCode";
            this.textBuildingCode.Size = new System.Drawing.Size(212, 20);
            this.textBuildingCode.TabIndex = 5;
            // 
            // textBuildingCity
            // 
            this.textBuildingCity.Location = new System.Drawing.Point(66, 67);
            this.textBuildingCity.Name = "textBuildingCity";
            this.textBuildingCity.Size = new System.Drawing.Size(212, 20);
            this.textBuildingCity.TabIndex = 6;
            // 
            // textBuildingTown
            // 
            this.textBuildingTown.Location = new System.Drawing.Point(66, 93);
            this.textBuildingTown.Name = "textBuildingTown";
            this.textBuildingTown.Size = new System.Drawing.Size(212, 20);
            this.textBuildingTown.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "İlçe";
            // 
            // btnBuildingDelete
            // 
            this.btnBuildingDelete.Location = new System.Drawing.Point(203, 121);
            this.btnBuildingDelete.Name = "btnBuildingDelete";
            this.btnBuildingDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBuildingDelete.TabIndex = 9;
            this.btnBuildingDelete.Text = "Sil";
            this.btnBuildingDelete.UseVisualStyleBackColor = true;
            this.btnBuildingDelete.Click += new System.EventHandler(this.BtnBuildingDelete_Click);
            // 
            // BuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 156);
            this.Controls.Add(this.btnBuildingDelete);
            this.Controls.Add(this.textBuildingTown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBuildingCity);
            this.Controls.Add(this.textBuildingCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuildingSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuildingName);
            this.Name = "BuildingForm";
            this.Text = "BuildingForm";
            this.Load += new System.EventHandler(this.BuildingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBuildingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuildingSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBuildingCode;
        private System.Windows.Forms.TextBox textBuildingCity;
        private System.Windows.Forms.TextBox textBuildingTown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuildingDelete;
    }
}
namespace AccessTest
{
    partial class Form_EntryADR
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
            this.txtAdrCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtKu = new System.Windows.Forms.TextBox();
            this.lblAdrCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblKu = new System.Windows.Forms.Label();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdrCode
            // 
            this.txtAdrCode.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAdrCode.Location = new System.Drawing.Point(44, 47);
            this.txtAdrCode.Name = "txtAdrCode";
            this.txtAdrCode.Size = new System.Drawing.Size(421, 26);
            this.txtAdrCode.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCity.Location = new System.Drawing.Point(44, 146);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(421, 26);
            this.txtCity.TabIndex = 1;
            // 
            // txtKu
            // 
            this.txtKu.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKu.Location = new System.Drawing.Point(44, 252);
            this.txtKu.Name = "txtKu";
            this.txtKu.Size = new System.Drawing.Size(421, 26);
            this.txtKu.TabIndex = 2;
            // 
            // lblAdrCode
            // 
            this.lblAdrCode.AutoSize = true;
            this.lblAdrCode.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblAdrCode.Location = new System.Drawing.Point(40, 22);
            this.lblAdrCode.Name = "lblAdrCode";
            this.lblAdrCode.Size = new System.Drawing.Size(95, 19);
            this.lblAdrCode.TabIndex = 3;
            this.lblAdrCode.Text = "市区コード";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCity.Location = new System.Drawing.Point(40, 121);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 19);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "市";
            // 
            // lblKu
            // 
            this.lblKu.AutoSize = true;
            this.lblKu.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKu.Location = new System.Drawing.Point(40, 225);
            this.lblKu.Name = "lblKu";
            this.lblKu.Size = new System.Drawing.Size(29, 19);
            this.lblKu.TabIndex = 5;
            this.lblKu.Text = "区";
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(323, 360);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(142, 37);
            this.btnEntry.TabIndex = 6;
            this.btnEntry.Text = "登録";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(44, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 37);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_EntryADR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 435);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.lblKu);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAdrCode);
            this.Controls.Add(this.txtKu);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAdrCode);
            this.Name = "Form_EntryADR";
            this.Text = "ENTRY ADR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdrCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtKu;
        private System.Windows.Forms.Label lblAdrCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblKu;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnClose;
    }
}
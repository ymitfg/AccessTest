namespace AccessTest
{
    partial class Form_SelectEntry
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
            this.btnADR = new System.Windows.Forms.Button();
            this.btnORG = new System.Windows.Forms.Button();
            this.btnDEP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnADR
            // 
            this.btnADR.Location = new System.Drawing.Point(74, 42);
            this.btnADR.Name = "btnADR";
            this.btnADR.Size = new System.Drawing.Size(175, 45);
            this.btnADR.TabIndex = 0;
            this.btnADR.Text = "市区マスタ";
            this.btnADR.UseVisualStyleBackColor = true;
            this.btnADR.Click += new System.EventHandler(this.btnADR_Click);
            // 
            // btnORG
            // 
            this.btnORG.Location = new System.Drawing.Point(74, 120);
            this.btnORG.Name = "btnORG";
            this.btnORG.Size = new System.Drawing.Size(175, 45);
            this.btnORG.TabIndex = 1;
            this.btnORG.Text = "会社マスタ";
            this.btnORG.UseVisualStyleBackColor = true;
            // 
            // btnDEP
            // 
            this.btnDEP.Location = new System.Drawing.Point(74, 200);
            this.btnDEP.Name = "btnDEP";
            this.btnDEP.Size = new System.Drawing.Size(175, 45);
            this.btnDEP.TabIndex = 2;
            this.btnDEP.Text = "部署マスタ";
            this.btnDEP.UseVisualStyleBackColor = true;
            // 
            // Form_SelectEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 290);
            this.Controls.Add(this.btnDEP);
            this.Controls.Add(this.btnORG);
            this.Controls.Add(this.btnADR);
            this.Name = "Form_SelectEntry";
            this.Text = "SELECT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnADR;
        private System.Windows.Forms.Button btnORG;
        private System.Windows.Forms.Button btnDEP;
    }
}
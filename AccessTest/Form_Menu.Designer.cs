namespace AccessTest
{
    partial class Form_Menu
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
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(70, 77);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(186, 43);
            this.btnEntry.TabIndex = 0;
            this.btnEntry.Text = "データ登録";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(70, 154);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(186, 43);
            this.btnSerch.TabIndex = 1;
            this.btnSerch.Text = "データ検索";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 290);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.btnEntry);
            this.Name = "Form_Menu";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnSerch;
    }
}
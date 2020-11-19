namespace AccessTest
{
    partial class Form_Serch
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDisp = new System.Windows.Forms.Button();
            this.dgvTestDB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisp
            // 
            this.btnDisp.Location = new System.Drawing.Point(29, 111);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(114, 30);
            this.btnDisp.TabIndex = 0;
            this.btnDisp.Text = "データ表示";
            this.btnDisp.UseVisualStyleBackColor = true;
            this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
            // 
            // dgvTestDB
            // 
            this.dgvTestDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestDB.Location = new System.Drawing.Point(29, 177);
            this.dgvTestDB.Name = "dgvTestDB";
            this.dgvTestDB.RowTemplate.Height = 21;
            this.dgvTestDB.Size = new System.Drawing.Size(735, 204);
            this.dgvTestDB.TabIndex = 1;
            // 
            // Form_Serch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.dgvTestDB);
            this.Controls.Add(this.btnDisp);
            this.Name = "Form_Serch";
            this.Text = "DISP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisp;
        private System.Windows.Forms.DataGridView dgvTestDB;
    }
}


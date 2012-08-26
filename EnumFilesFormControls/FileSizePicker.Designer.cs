namespace EnumFilesFormControls
{
    partial class FileSizePicker
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.FileSizeSpinner = new System.Windows.Forms.NumericUpDown();
            this.UnitCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FileSizeSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.EnableCheckBox.Location = new System.Drawing.Point(0, 0);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Size = new System.Drawing.Size(15, 19);
            this.EnableCheckBox.TabIndex = 0;
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileSizeSpinner
            // 
            this.FileSizeSpinner.AutoSize = true;
            this.FileSizeSpinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileSizeSpinner.Hexadecimal = true;
            this.FileSizeSpinner.Location = new System.Drawing.Point(15, 0);
            this.FileSizeSpinner.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.FileSizeSpinner.Name = "FileSizeSpinner";
            this.FileSizeSpinner.Size = new System.Drawing.Size(67, 19);
            this.FileSizeSpinner.TabIndex = 1;
            this.FileSizeSpinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FileSizeSpinner.ValueChanged += new System.EventHandler(this.FileSizeSpinner_ValueChanged);
            // 
            // UnitCombo
            // 
            this.UnitCombo.Dock = System.Windows.Forms.DockStyle.Right;
            this.UnitCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitCombo.FormattingEnabled = true;
            this.UnitCombo.Location = new System.Drawing.Point(82, 0);
            this.UnitCombo.Name = "UnitCombo";
            this.UnitCombo.Size = new System.Drawing.Size(85, 20);
            this.UnitCombo.TabIndex = 2;
            this.UnitCombo.SelectedValueChanged += new System.EventHandler(this.UnitCombo_SelectedValueChanged);
            // 
            // FileSizePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.FileSizeSpinner);
            this.Controls.Add(this.EnableCheckBox);
            this.Controls.Add(this.UnitCombo);
            this.Name = "FileSizePicker";
            this.Size = new System.Drawing.Size(167, 19);
            ((System.ComponentModel.ISupportInitialize)(this.FileSizeSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.NumericUpDown FileSizeSpinner;
        private System.Windows.Forms.ComboBox UnitCombo;
    }
}

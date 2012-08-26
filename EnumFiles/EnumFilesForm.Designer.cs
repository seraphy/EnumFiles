namespace EnumFiles
{
    partial class EnumFilesForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label LblDirectory;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnumFilesForm));
            System.Windows.Forms.Label LblFileName;
            System.Windows.Forms.Label LblOtherConditions;
            System.Windows.Forms.Label LblOutputFormat;
            System.Windows.Forms.GroupBox SearchConditionGroup;
            System.Windows.Forms.TableLayoutPanel PatternSelectionGroup;
            System.Windows.Forms.TableLayoutPanel SearchConditionTableLayout;
            System.Windows.Forms.Panel ButtonPanel;
            this.BtnSaveCond = new System.Windows.Forms.Button();
            this.BtnRemoveCond = new System.Windows.Forms.Button();
            this.ComboCondPattern = new System.Windows.Forms.ComboBox();
            this.ComboDirectory = new System.Windows.Forms.ComboBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.ComboFileName = new System.Windows.Forms.ComboBox();
            this.ChkRegularExpression = new System.Windows.Forms.CheckBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ComboOutputFormat = new System.Windows.Forms.ComboBox();
            this.BtnEditFormat = new System.Windows.Forms.Button();
            this.CheckShowResults = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            LblDirectory = new System.Windows.Forms.Label();
            LblFileName = new System.Windows.Forms.Label();
            LblOtherConditions = new System.Windows.Forms.Label();
            LblOutputFormat = new System.Windows.Forms.Label();
            SearchConditionGroup = new System.Windows.Forms.GroupBox();
            PatternSelectionGroup = new System.Windows.Forms.TableLayoutPanel();
            SearchConditionTableLayout = new System.Windows.Forms.TableLayoutPanel();
            ButtonPanel = new System.Windows.Forms.Panel();
            SearchConditionGroup.SuspendLayout();
            PatternSelectionGroup.SuspendLayout();
            SearchConditionTableLayout.SuspendLayout();
            ButtonPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDirectory
            // 
            resources.ApplyResources(LblDirectory, "LblDirectory");
            LblDirectory.Name = "LblDirectory";
            // 
            // LblFileName
            // 
            resources.ApplyResources(LblFileName, "LblFileName");
            LblFileName.Name = "LblFileName";
            // 
            // LblOtherConditions
            // 
            resources.ApplyResources(LblOtherConditions, "LblOtherConditions");
            LblOtherConditions.Name = "LblOtherConditions";
            // 
            // LblOutputFormat
            // 
            resources.ApplyResources(LblOutputFormat, "LblOutputFormat");
            LblOutputFormat.Name = "LblOutputFormat";
            // 
            // SearchConditionGroup
            // 
            SearchConditionGroup.Controls.Add(PatternSelectionGroup);
            SearchConditionGroup.Controls.Add(SearchConditionTableLayout);
            resources.ApplyResources(SearchConditionGroup, "SearchConditionGroup");
            SearchConditionGroup.Name = "SearchConditionGroup";
            SearchConditionGroup.TabStop = false;
            SearchConditionGroup.Enter += new System.EventHandler(this.SearchConditionGroup_Enter);
            // 
            // PatternSelectionGroup
            // 
            resources.ApplyResources(PatternSelectionGroup, "PatternSelectionGroup");
            PatternSelectionGroup.Controls.Add(this.BtnSaveCond, 1, 0);
            PatternSelectionGroup.Controls.Add(this.BtnRemoveCond, 2, 0);
            PatternSelectionGroup.Controls.Add(this.ComboCondPattern, 0, 0);
            PatternSelectionGroup.Name = "PatternSelectionGroup";
            // 
            // BtnSaveCond
            // 
            resources.ApplyResources(this.BtnSaveCond, "BtnSaveCond");
            this.BtnSaveCond.Name = "BtnSaveCond";
            this.BtnSaveCond.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveCond
            // 
            resources.ApplyResources(this.BtnRemoveCond, "BtnRemoveCond");
            this.BtnRemoveCond.Name = "BtnRemoveCond";
            this.BtnRemoveCond.UseVisualStyleBackColor = true;
            // 
            // ComboCondPattern
            // 
            resources.ApplyResources(this.ComboCondPattern, "ComboCondPattern");
            this.ComboCondPattern.FormattingEnabled = true;
            this.ComboCondPattern.Name = "ComboCondPattern";
            // 
            // SearchConditionTableLayout
            // 
            resources.ApplyResources(SearchConditionTableLayout, "SearchConditionTableLayout");
            SearchConditionTableLayout.Controls.Add(LblDirectory, 0, 0);
            SearchConditionTableLayout.Controls.Add(this.ComboDirectory, 1, 0);
            SearchConditionTableLayout.Controls.Add(this.BtnBrowse, 2, 0);
            SearchConditionTableLayout.Controls.Add(LblFileName, 0, 1);
            SearchConditionTableLayout.Controls.Add(this.ComboFileName, 1, 1);
            SearchConditionTableLayout.Controls.Add(this.ChkRegularExpression, 1, 2);
            SearchConditionTableLayout.Controls.Add(LblOtherConditions, 0, 3);
            SearchConditionTableLayout.Controls.Add(this.BtnEdit, 2, 3);
            SearchConditionTableLayout.Controls.Add(this.textBox1, 1, 3);
            SearchConditionTableLayout.Controls.Add(LblOutputFormat, 0, 4);
            SearchConditionTableLayout.Controls.Add(this.ComboOutputFormat, 1, 4);
            SearchConditionTableLayout.Controls.Add(this.BtnEditFormat, 2, 4);
            SearchConditionTableLayout.Name = "SearchConditionTableLayout";
            // 
            // ComboDirectory
            // 
            resources.ApplyResources(this.ComboDirectory, "ComboDirectory");
            this.ComboDirectory.FormattingEnabled = true;
            this.ComboDirectory.Name = "ComboDirectory";
            // 
            // BtnBrowse
            // 
            resources.ApplyResources(this.BtnBrowse, "BtnBrowse");
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            // 
            // ComboFileName
            // 
            SearchConditionTableLayout.SetColumnSpan(this.ComboFileName, 2);
            resources.ApplyResources(this.ComboFileName, "ComboFileName");
            this.ComboFileName.FormattingEnabled = true;
            this.ComboFileName.Name = "ComboFileName";
            // 
            // ChkRegularExpression
            // 
            resources.ApplyResources(this.ChkRegularExpression, "ChkRegularExpression");
            SearchConditionTableLayout.SetColumnSpan(this.ChkRegularExpression, 2);
            this.ChkRegularExpression.Name = "ChkRegularExpression";
            this.ChkRegularExpression.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            resources.ApplyResources(this.BtnEdit, "BtnEdit");
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // ComboOutputFormat
            // 
            resources.ApplyResources(this.ComboOutputFormat, "ComboOutputFormat");
            this.ComboOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOutputFormat.FormattingEnabled = true;
            this.ComboOutputFormat.Name = "ComboOutputFormat";
            // 
            // BtnEditFormat
            // 
            resources.ApplyResources(this.BtnEditFormat, "BtnEditFormat");
            this.BtnEditFormat.Name = "BtnEditFormat";
            this.BtnEditFormat.UseVisualStyleBackColor = true;
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(this.CheckShowResults);
            ButtonPanel.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(ButtonPanel, "ButtonPanel");
            ButtonPanel.Name = "ButtonPanel";
            // 
            // CheckShowResults
            // 
            resources.ApplyResources(this.CheckShowResults, "CheckShowResults");
            this.CheckShowResults.Name = "CheckShowResults";
            this.CheckShowResults.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnRun);
            this.flowLayoutPanel1.Controls.Add(this.BtnCancel);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // BtnRun
            // 
            resources.ApplyResources(this.BtnRun, "BtnRun");
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EnumFilesForm
            // 
            this.AcceptButton = this.BtnRun;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.Controls.Add(SearchConditionGroup);
            this.Controls.Add(ButtonPanel);
            this.Name = "EnumFilesForm";
            this.Load += new System.EventHandler(this.EnumFilesForm_Load);
            SearchConditionGroup.ResumeLayout(false);
            PatternSelectionGroup.ResumeLayout(false);
            SearchConditionTableLayout.ResumeLayout(false);
            SearchConditionTableLayout.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            ButtonPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboDirectory;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.ComboBox ComboFileName;
        private System.Windows.Forms.CheckBox ChkRegularExpression;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnSaveCond;
        private System.Windows.Forms.Button BtnRemoveCond;
        private System.Windows.Forms.ComboBox ComboCondPattern;
        private System.Windows.Forms.ComboBox ComboOutputFormat;
        private System.Windows.Forms.Button BtnEditFormat;
        private System.Windows.Forms.CheckBox CheckShowResults;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnCancel;
    }
}


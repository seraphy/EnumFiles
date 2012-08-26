namespace EnumFiles
{
    partial class SearchOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOptionsForm));
            System.Windows.Forms.TableLayoutPanel ContentLayout;
            System.Windows.Forms.GroupBox DatesGroup;
            System.Windows.Forms.GroupBox AttributesGroup;
            System.Windows.Forms.TableLayoutPanel DatesGrid;
            System.Windows.Forms.Label LblLastModified;
            System.Windows.Forms.Label lblCreation;
            System.Windows.Forms.Label lblLastAccess;
            System.Windows.Forms.Label lblStart;
            System.Windows.Forms.Label LblEnd;
            System.Windows.Forms.GroupBox ExcludeGroup;
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.InnerButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SizeGroup = new System.Windows.Forms.GroupBox();
            this.DtStartLastModified = new System.Windows.Forms.DateTimePicker();
            this.DtStartCreation = new System.Windows.Forms.DateTimePicker();
            this.DtStartLastAccess = new System.Windows.Forms.DateTimePicker();
            this.DtEndLastModified = new System.Windows.Forms.DateTimePicker();
            this.DtEndCreation = new System.Windows.Forms.DateTimePicker();
            this.DtEndLastAccess = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ContentLayout = new System.Windows.Forms.TableLayoutPanel();
            DatesGroup = new System.Windows.Forms.GroupBox();
            AttributesGroup = new System.Windows.Forms.GroupBox();
            DatesGrid = new System.Windows.Forms.TableLayoutPanel();
            LblLastModified = new System.Windows.Forms.Label();
            lblCreation = new System.Windows.Forms.Label();
            lblLastAccess = new System.Windows.Forms.Label();
            lblStart = new System.Windows.Forms.Label();
            LblEnd = new System.Windows.Forms.Label();
            ExcludeGroup = new System.Windows.Forms.GroupBox();
            this.ButtonPanel.SuspendLayout();
            this.InnerButtonPanel.SuspendLayout();
            ContentLayout.SuspendLayout();
            DatesGroup.SuspendLayout();
            DatesGrid.SuspendLayout();
            ExcludeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.InnerButtonPanel);
            resources.ApplyResources(this.ButtonPanel, "ButtonPanel");
            this.ButtonPanel.Name = "ButtonPanel";
            // 
            // InnerButtonPanel
            // 
            this.InnerButtonPanel.Controls.Add(this.BtnOK);
            this.InnerButtonPanel.Controls.Add(this.BtnCancel);
            resources.ApplyResources(this.InnerButtonPanel, "InnerButtonPanel");
            this.InnerButtonPanel.Name = "InnerButtonPanel";
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.BtnOK, "BtnOK");
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ContentLayout
            // 
            resources.ApplyResources(ContentLayout, "ContentLayout");
            ContentLayout.Controls.Add(DatesGroup, 0, 0);
            ContentLayout.Controls.Add(this.SizeGroup, 0, 1);
            ContentLayout.Controls.Add(AttributesGroup, 0, 2);
            ContentLayout.Controls.Add(ExcludeGroup, 0, 3);
            ContentLayout.Name = "ContentLayout";
            // 
            // DatesGroup
            // 
            DatesGroup.Controls.Add(DatesGrid);
            resources.ApplyResources(DatesGroup, "DatesGroup");
            DatesGroup.Name = "DatesGroup";
            DatesGroup.TabStop = false;
            // 
            // SizeGroup
            // 
            resources.ApplyResources(this.SizeGroup, "SizeGroup");
            this.SizeGroup.Name = "SizeGroup";
            this.SizeGroup.TabStop = false;
            // 
            // AttributesGroup
            // 
            resources.ApplyResources(AttributesGroup, "AttributesGroup");
            AttributesGroup.Name = "AttributesGroup";
            AttributesGroup.TabStop = false;
            // 
            // DatesGrid
            // 
            resources.ApplyResources(DatesGrid, "DatesGrid");
            DatesGrid.Controls.Add(LblLastModified, 1, 0);
            DatesGrid.Controls.Add(lblCreation, 2, 0);
            DatesGrid.Controls.Add(lblLastAccess, 3, 0);
            DatesGrid.Controls.Add(lblStart, 0, 1);
            DatesGrid.Controls.Add(LblEnd, 0, 2);
            DatesGrid.Controls.Add(this.DtStartLastModified, 1, 1);
            DatesGrid.Controls.Add(this.DtStartCreation, 2, 1);
            DatesGrid.Controls.Add(this.DtStartLastAccess, 3, 1);
            DatesGrid.Controls.Add(this.DtEndLastModified, 1, 2);
            DatesGrid.Controls.Add(this.DtEndCreation, 2, 2);
            DatesGrid.Controls.Add(this.DtEndLastAccess, 3, 2);
            DatesGrid.Name = "DatesGrid";
            // 
            // LblLastModified
            // 
            resources.ApplyResources(LblLastModified, "LblLastModified");
            LblLastModified.Name = "LblLastModified";
            // 
            // lblCreation
            // 
            resources.ApplyResources(lblCreation, "lblCreation");
            lblCreation.Name = "lblCreation";
            // 
            // lblLastAccess
            // 
            resources.ApplyResources(lblLastAccess, "lblLastAccess");
            lblLastAccess.Name = "lblLastAccess";
            // 
            // lblStart
            // 
            resources.ApplyResources(lblStart, "lblStart");
            lblStart.Name = "lblStart";
            // 
            // LblEnd
            // 
            resources.ApplyResources(LblEnd, "LblEnd");
            LblEnd.Name = "LblEnd";
            // 
            // DtStartLastModified
            // 
            this.DtStartLastModified.Checked = false;
            resources.ApplyResources(this.DtStartLastModified, "DtStartLastModified");
            this.DtStartLastModified.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtStartLastModified.Name = "DtStartLastModified";
            this.DtStartLastModified.ShowCheckBox = true;
            // 
            // DtStartCreation
            // 
            this.DtStartCreation.Checked = false;
            this.DtStartCreation.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.DtStartCreation, "DtStartCreation");
            this.DtStartCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtStartCreation.Name = "DtStartCreation";
            this.DtStartCreation.ShowCheckBox = true;
            // 
            // DtStartLastAccess
            // 
            this.DtStartLastAccess.Checked = false;
            resources.ApplyResources(this.DtStartLastAccess, "DtStartLastAccess");
            this.DtStartLastAccess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtStartLastAccess.Name = "DtStartLastAccess";
            this.DtStartLastAccess.ShowCheckBox = true;
            // 
            // DtEndLastModified
            // 
            this.DtEndLastModified.Checked = false;
            resources.ApplyResources(this.DtEndLastModified, "DtEndLastModified");
            this.DtEndLastModified.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtEndLastModified.Name = "DtEndLastModified";
            this.DtEndLastModified.ShowCheckBox = true;
            // 
            // DtEndCreation
            // 
            this.DtEndCreation.Checked = false;
            resources.ApplyResources(this.DtEndCreation, "DtEndCreation");
            this.DtEndCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtEndCreation.Name = "DtEndCreation";
            this.DtEndCreation.ShowCheckBox = true;
            // 
            // DtEndLastAccess
            // 
            this.DtEndLastAccess.Checked = false;
            resources.ApplyResources(this.DtEndLastAccess, "DtEndLastAccess");
            this.DtEndLastAccess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtEndLastAccess.Name = "DtEndLastAccess";
            this.DtEndLastAccess.ShowCheckBox = true;
            // 
            // ExcludeGroup
            // 
            ExcludeGroup.Controls.Add(this.textBox1);
            resources.ApplyResources(ExcludeGroup, "ExcludeGroup");
            ExcludeGroup.Name = "ExcludeGroup";
            ExcludeGroup.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // SearchOptionsForm
            // 
            this.AcceptButton = this.BtnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ControlBox = false;
            this.Controls.Add(ContentLayout);
            this.Controls.Add(this.ButtonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchOptionsForm";
            this.ShowIcon = false;
            this.ButtonPanel.ResumeLayout(false);
            this.InnerButtonPanel.ResumeLayout(false);
            ContentLayout.ResumeLayout(false);
            DatesGroup.ResumeLayout(false);
            DatesGrid.ResumeLayout(false);
            DatesGrid.PerformLayout();
            ExcludeGroup.ResumeLayout(false);
            ExcludeGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.FlowLayoutPanel InnerButtonPanel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.GroupBox SizeGroup;
        private System.Windows.Forms.DateTimePicker DtStartLastModified;
        private System.Windows.Forms.DateTimePicker DtStartCreation;
        private System.Windows.Forms.DateTimePicker DtStartLastAccess;
        private System.Windows.Forms.DateTimePicker DtEndLastModified;
        private System.Windows.Forms.DateTimePicker DtEndCreation;
        private System.Windows.Forms.DateTimePicker DtEndLastAccess;
        private System.Windows.Forms.TextBox textBox1;
    }
}
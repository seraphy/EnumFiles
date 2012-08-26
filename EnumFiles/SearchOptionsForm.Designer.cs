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
            System.Windows.Forms.TableLayoutPanel ContentLayout;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOptionsForm));
            System.Windows.Forms.GroupBox DatesGroup;
            System.Windows.Forms.TableLayoutPanel DatesGrid;
            System.Windows.Forms.Label LblLastModified;
            System.Windows.Forms.Label lblCreation;
            System.Windows.Forms.Label lblLastAccess;
            System.Windows.Forms.Label lblStart;
            System.Windows.Forms.Label LblEnd;
            System.Windows.Forms.GroupBox SizeGroup;
            System.Windows.Forms.GroupBox AttributesGroup;
            System.Windows.Forms.GroupBox ExcludeGroup;
            System.Windows.Forms.TableLayoutPanel FileSizeLayout;
            System.Windows.Forms.Label LblMinSize;
            System.Windows.Forms.Label LblMaxSize;
            this.DtStartLastModified = new System.Windows.Forms.DateTimePicker();
            this.DtStartCreation = new System.Windows.Forms.DateTimePicker();
            this.DtStartLastAccess = new System.Windows.Forms.DateTimePicker();
            this.DtEndLastModified = new System.Windows.Forms.DateTimePicker();
            this.DtEndCreation = new System.Windows.Forms.DateTimePicker();
            this.DtEndLastAccess = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.InnerButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FileMinSize = new EnumFilesFormControls.FileSizePicker();
            this.FileMaxSize = new EnumFilesFormControls.FileSizePicker();
            ContentLayout = new System.Windows.Forms.TableLayoutPanel();
            DatesGroup = new System.Windows.Forms.GroupBox();
            DatesGrid = new System.Windows.Forms.TableLayoutPanel();
            LblLastModified = new System.Windows.Forms.Label();
            lblCreation = new System.Windows.Forms.Label();
            lblLastAccess = new System.Windows.Forms.Label();
            lblStart = new System.Windows.Forms.Label();
            LblEnd = new System.Windows.Forms.Label();
            SizeGroup = new System.Windows.Forms.GroupBox();
            AttributesGroup = new System.Windows.Forms.GroupBox();
            ExcludeGroup = new System.Windows.Forms.GroupBox();
            FileSizeLayout = new System.Windows.Forms.TableLayoutPanel();
            LblMinSize = new System.Windows.Forms.Label();
            LblMaxSize = new System.Windows.Forms.Label();
            ContentLayout.SuspendLayout();
            DatesGroup.SuspendLayout();
            DatesGrid.SuspendLayout();
            SizeGroup.SuspendLayout();
            ExcludeGroup.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.InnerButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            FileSizeLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentLayout
            // 
            resources.ApplyResources(ContentLayout, "ContentLayout");
            ContentLayout.Controls.Add(DatesGroup, 0, 0);
            ContentLayout.Controls.Add(SizeGroup, 0, 1);
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
            // SizeGroup
            // 
            SizeGroup.Controls.Add(FileSizeLayout);
            resources.ApplyResources(SizeGroup, "SizeGroup");
            SizeGroup.Name = "SizeGroup";
            SizeGroup.TabStop = false;
            // 
            // AttributesGroup
            // 
            resources.ApplyResources(AttributesGroup, "AttributesGroup");
            AttributesGroup.Name = "AttributesGroup";
            AttributesGroup.TabStop = false;
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FileSizeLayout
            // 
            resources.ApplyResources(FileSizeLayout, "FileSizeLayout");
            FileSizeLayout.Controls.Add(LblMinSize, 0, 0);
            FileSizeLayout.Controls.Add(this.FileMinSize, 1, 0);
            FileSizeLayout.Controls.Add(LblMaxSize, 2, 0);
            FileSizeLayout.Controls.Add(this.FileMaxSize, 3, 0);
            FileSizeLayout.Name = "FileSizeLayout";
            // 
            // LblMinSize
            // 
            resources.ApplyResources(LblMinSize, "LblMinSize");
            LblMinSize.Name = "LblMinSize";
            // 
            // FileMinSize
            // 
            resources.ApplyResources(this.FileMinSize, "FileMinSize");
            this.FileMinSize.Checked = false;
            this.FileMinSize.Name = "FileMinSize";
            this.FileMinSize.SelectedUnitIndex = -1;
            this.FileMinSize.UnitItems = null;
            // 
            // LblMaxSize
            // 
            resources.ApplyResources(LblMaxSize, "LblMaxSize");
            LblMaxSize.Name = "LblMaxSize";
            // 
            // FileMaxSize
            // 
            resources.ApplyResources(this.FileMaxSize, "FileMaxSize");
            this.FileMaxSize.Checked = false;
            this.FileMaxSize.Name = "FileMaxSize";
            this.FileMaxSize.SelectedUnitIndex = -1;
            this.FileMaxSize.UnitItems = null;
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
            ContentLayout.ResumeLayout(false);
            DatesGroup.ResumeLayout(false);
            DatesGrid.ResumeLayout(false);
            DatesGrid.PerformLayout();
            SizeGroup.ResumeLayout(false);
            ExcludeGroup.ResumeLayout(false);
            ExcludeGroup.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.InnerButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            FileSizeLayout.ResumeLayout(false);
            FileSizeLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.FlowLayoutPanel InnerButtonPanel;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DateTimePicker DtStartLastModified;
        private System.Windows.Forms.DateTimePicker DtStartCreation;
        private System.Windows.Forms.DateTimePicker DtStartLastAccess;
        private System.Windows.Forms.DateTimePicker DtEndLastModified;
        private System.Windows.Forms.DateTimePicker DtEndCreation;
        private System.Windows.Forms.DateTimePicker DtEndLastAccess;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private EnumFilesFormControls.FileSizePicker FileMinSize;
        private EnumFilesFormControls.FileSizePicker FileMaxSize;
    }
}
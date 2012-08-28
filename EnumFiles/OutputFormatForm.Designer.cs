namespace EnumFiles
{
    partial class OutputFormatForm
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
            System.Windows.Forms.Panel FormatNamePanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputFormatForm));
            System.Windows.Forms.Panel ButtonPanel;
            System.Windows.Forms.FlowLayoutPanel OkCancelButtonPanel;
            System.Windows.Forms.TableLayoutPanel FormatLayout;
            System.Windows.Forms.GroupBox HeaderGroup;
            System.Windows.Forms.GroupBox EachItemGroup;
            System.Windows.Forms.GroupBox EachItemOddGroup;
            System.Windows.Forms.GroupBox FooterGroup;
            this.ComboFormatName = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TextHeader = new System.Windows.Forms.TextBox();
            this.TextEachItem = new System.Windows.Forms.TextBox();
            this.TextEachItemAlternate = new System.Windows.Forms.TextBox();
            this.TextFooter = new System.Windows.Forms.TextBox();
            this.ContantSplitPane = new System.Windows.Forms.SplitContainer();
            this.VariableItemList = new System.Windows.Forms.ListBox();
            FormatNamePanel = new System.Windows.Forms.Panel();
            ButtonPanel = new System.Windows.Forms.Panel();
            OkCancelButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            FormatLayout = new System.Windows.Forms.TableLayoutPanel();
            HeaderGroup = new System.Windows.Forms.GroupBox();
            EachItemGroup = new System.Windows.Forms.GroupBox();
            EachItemOddGroup = new System.Windows.Forms.GroupBox();
            FooterGroup = new System.Windows.Forms.GroupBox();
            FormatNamePanel.SuspendLayout();
            ButtonPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            OkCancelButtonPanel.SuspendLayout();
            FormatLayout.SuspendLayout();
            HeaderGroup.SuspendLayout();
            EachItemGroup.SuspendLayout();
            EachItemOddGroup.SuspendLayout();
            FooterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContantSplitPane)).BeginInit();
            this.ContantSplitPane.Panel1.SuspendLayout();
            this.ContantSplitPane.Panel2.SuspendLayout();
            this.ContantSplitPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormatNamePanel
            // 
            FormatNamePanel.Controls.Add(this.ComboFormatName);
            FormatNamePanel.Controls.Add(ButtonPanel);
            resources.ApplyResources(FormatNamePanel, "FormatNamePanel");
            FormatNamePanel.Name = "FormatNamePanel";
            // 
            // ComboFormatName
            // 
            resources.ApplyResources(this.ComboFormatName, "ComboFormatName");
            this.ComboFormatName.FormattingEnabled = true;
            this.ComboFormatName.Name = "ComboFormatName";
            // 
            // ButtonPanel
            // 
            resources.ApplyResources(ButtonPanel, "ButtonPanel");
            ButtonPanel.Controls.Add(this.BtnRemove);
            ButtonPanel.Controls.Add(this.BtnSave);
            ButtonPanel.Name = "ButtonPanel";
            // 
            // BtnSave
            // 
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnRemove, "BtnRemove");
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(OkCancelButtonPanel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // OkCancelButtonPanel
            // 
            OkCancelButtonPanel.Controls.Add(this.BtnOK);
            OkCancelButtonPanel.Controls.Add(this.BtnCancel);
            resources.ApplyResources(OkCancelButtonPanel, "OkCancelButtonPanel");
            OkCancelButtonPanel.Name = "OkCancelButtonPanel";
            // 
            // BtnOK
            // 
            resources.ApplyResources(this.BtnOK, "BtnOK");
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormatLayout
            // 
            resources.ApplyResources(FormatLayout, "FormatLayout");
            FormatLayout.Controls.Add(HeaderGroup, 0, 0);
            FormatLayout.Controls.Add(EachItemGroup, 0, 1);
            FormatLayout.Controls.Add(EachItemOddGroup, 0, 2);
            FormatLayout.Controls.Add(FooterGroup, 0, 3);
            FormatLayout.Name = "FormatLayout";
            // 
            // HeaderGroup
            // 
            HeaderGroup.Controls.Add(this.TextHeader);
            resources.ApplyResources(HeaderGroup, "HeaderGroup");
            HeaderGroup.Name = "HeaderGroup";
            HeaderGroup.TabStop = false;
            // 
            // EachItemGroup
            // 
            EachItemGroup.Controls.Add(this.TextEachItem);
            resources.ApplyResources(EachItemGroup, "EachItemGroup");
            EachItemGroup.Name = "EachItemGroup";
            EachItemGroup.TabStop = false;
            // 
            // EachItemOddGroup
            // 
            EachItemOddGroup.Controls.Add(this.TextEachItemAlternate);
            resources.ApplyResources(EachItemOddGroup, "EachItemOddGroup");
            EachItemOddGroup.Name = "EachItemOddGroup";
            EachItemOddGroup.TabStop = false;
            // 
            // FooterGroup
            // 
            FooterGroup.Controls.Add(this.TextFooter);
            resources.ApplyResources(FooterGroup, "FooterGroup");
            FooterGroup.Name = "FooterGroup";
            FooterGroup.TabStop = false;
            // 
            // TextHeader
            // 
            resources.ApplyResources(this.TextHeader, "TextHeader");
            this.TextHeader.Name = "TextHeader";
            // 
            // TextEachItem
            // 
            resources.ApplyResources(this.TextEachItem, "TextEachItem");
            this.TextEachItem.Name = "TextEachItem";
            // 
            // TextEachItemAlternate
            // 
            resources.ApplyResources(this.TextEachItemAlternate, "TextEachItemAlternate");
            this.TextEachItemAlternate.Name = "TextEachItemAlternate";
            // 
            // TextFooter
            // 
            resources.ApplyResources(this.TextFooter, "TextFooter");
            this.TextFooter.Name = "TextFooter";
            // 
            // ContantSplitPane
            // 
            resources.ApplyResources(this.ContantSplitPane, "ContantSplitPane");
            this.ContantSplitPane.Name = "ContantSplitPane";
            // 
            // ContantSplitPane.Panel1
            // 
            this.ContantSplitPane.Panel1.Controls.Add(FormatLayout);
            // 
            // ContantSplitPane.Panel2
            // 
            this.ContantSplitPane.Panel2.Controls.Add(this.VariableItemList);
            // 
            // VariableItemList
            // 
            resources.ApplyResources(this.VariableItemList, "VariableItemList");
            this.VariableItemList.FormattingEnabled = true;
            this.VariableItemList.Items.AddRange(new object[] {
            resources.GetString("VariableItemList.Items"),
            resources.GetString("VariableItemList.Items1"),
            resources.GetString("VariableItemList.Items2"),
            resources.GetString("VariableItemList.Items3"),
            resources.GetString("VariableItemList.Items4"),
            resources.GetString("VariableItemList.Items5"),
            resources.GetString("VariableItemList.Items6"),
            resources.GetString("VariableItemList.Items7"),
            resources.GetString("VariableItemList.Items8")});
            this.VariableItemList.Name = "VariableItemList";
            // 
            // OutputFormatForm
            // 
            this.AcceptButton = this.BtnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ControlBox = false;
            this.Controls.Add(this.ContantSplitPane);
            this.Controls.Add(this.panel1);
            this.Controls.Add(FormatNamePanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutputFormatForm";
            FormatNamePanel.ResumeLayout(false);
            FormatNamePanel.PerformLayout();
            ButtonPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            OkCancelButtonPanel.ResumeLayout(false);
            OkCancelButtonPanel.PerformLayout();
            FormatLayout.ResumeLayout(false);
            HeaderGroup.ResumeLayout(false);
            HeaderGroup.PerformLayout();
            EachItemGroup.ResumeLayout(false);
            EachItemGroup.PerformLayout();
            EachItemOddGroup.ResumeLayout(false);
            EachItemOddGroup.PerformLayout();
            FooterGroup.ResumeLayout(false);
            FooterGroup.PerformLayout();
            this.ContantSplitPane.Panel1.ResumeLayout(false);
            this.ContantSplitPane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContantSplitPane)).EndInit();
            this.ContantSplitPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox ComboFormatName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TextHeader;
        private System.Windows.Forms.TextBox TextEachItem;
        private System.Windows.Forms.TextBox TextEachItemAlternate;
        private System.Windows.Forms.TextBox TextFooter;
        private System.Windows.Forms.SplitContainer ContantSplitPane;
        private System.Windows.Forms.ListBox VariableItemList;
    }
}
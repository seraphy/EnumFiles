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
            this.components = new System.ComponentModel.Container();
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
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TextHeader = new System.Windows.Forms.TextBox();
            this.TextEachItem = new System.Windows.Forms.TextBox();
            this.TextEachItemAlternate = new System.Windows.Forms.TextBox();
            this.TextFooter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContantSplitPane = new System.Windows.Forms.SplitContainer();
            this.VariableItemList = new System.Windows.Forms.ListBox();
            this.BtnInsertVariable = new System.Windows.Forms.Button();
            this.outputFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            OkCancelButtonPanel.SuspendLayout();
            FormatLayout.SuspendLayout();
            HeaderGroup.SuspendLayout();
            EachItemGroup.SuspendLayout();
            EachItemOddGroup.SuspendLayout();
            FooterGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContantSplitPane)).BeginInit();
            this.ContantSplitPane.Panel1.SuspendLayout();
            this.ContantSplitPane.Panel2.SuspendLayout();
            this.ContantSplitPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputFormatBindingSource)).BeginInit();
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
            // BtnRemove
            // 
            this.BtnRemove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnRemove, "BtnRemove");
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnSave, "BtnSave");
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            // TextHeader
            // 
            this.TextHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outputFormatBindingSource, "Header", true));
            resources.ApplyResources(this.TextHeader, "TextHeader");
            this.TextHeader.Name = "TextHeader";
            // 
            // EachItemGroup
            // 
            EachItemGroup.Controls.Add(this.TextEachItem);
            resources.ApplyResources(EachItemGroup, "EachItemGroup");
            EachItemGroup.Name = "EachItemGroup";
            EachItemGroup.TabStop = false;
            // 
            // TextEachItem
            // 
            this.TextEachItem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outputFormatBindingSource, "EachItem", true));
            resources.ApplyResources(this.TextEachItem, "TextEachItem");
            this.TextEachItem.Name = "TextEachItem";
            // 
            // EachItemOddGroup
            // 
            EachItemOddGroup.Controls.Add(this.TextEachItemAlternate);
            resources.ApplyResources(EachItemOddGroup, "EachItemOddGroup");
            EachItemOddGroup.Name = "EachItemOddGroup";
            EachItemOddGroup.TabStop = false;
            // 
            // TextEachItemAlternate
            // 
            this.TextEachItemAlternate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outputFormatBindingSource, "EachItemAlternate", true));
            resources.ApplyResources(this.TextEachItemAlternate, "TextEachItemAlternate");
            this.TextEachItemAlternate.Name = "TextEachItemAlternate";
            // 
            // FooterGroup
            // 
            FooterGroup.Controls.Add(this.TextFooter);
            resources.ApplyResources(FooterGroup, "FooterGroup");
            FooterGroup.Name = "FooterGroup";
            FooterGroup.TabStop = false;
            // 
            // TextFooter
            // 
            this.TextFooter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.outputFormatBindingSource, "Footer", true));
            resources.ApplyResources(this.TextFooter, "TextFooter");
            this.TextFooter.Name = "TextFooter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(OkCancelButtonPanel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            this.ContantSplitPane.Panel2.Controls.Add(this.BtnInsertVariable);
            // 
            // VariableItemList
            // 
            resources.ApplyResources(this.VariableItemList, "VariableItemList");
            this.VariableItemList.FormattingEnabled = true;
            this.VariableItemList.Name = "VariableItemList";
            // 
            // BtnInsertVariable
            // 
            resources.ApplyResources(this.BtnInsertVariable, "BtnInsertVariable");
            this.BtnInsertVariable.Name = "BtnInsertVariable";
            this.BtnInsertVariable.UseVisualStyleBackColor = true;
            // 
            // outputFormatBindingSource
            // 
            this.outputFormatBindingSource.DataSource = typeof(EnumFiles.OutputFormat);
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
            this.panel1.ResumeLayout(false);
            this.ContantSplitPane.Panel1.ResumeLayout(false);
            this.ContantSplitPane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContantSplitPane)).EndInit();
            this.ContantSplitPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputFormatBindingSource)).EndInit();
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
        private System.Windows.Forms.Button BtnInsertVariable;
        public System.Windows.Forms.BindingSource outputFormatBindingSource;
    }
}
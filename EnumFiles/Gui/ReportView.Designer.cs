namespace EnumFiles.Gui
{
    partial class ReportView
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
            System.Windows.Forms.Panel FormatPanel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
            this.ComboOutputFormat = new System.Windows.Forms.ComboBox();
            this.BtnOutput = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.FileListView = new System.Windows.Forms.ListView();
            FormatPanel = new System.Windows.Forms.Panel();
            FormatPanel.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormatPanel
            // 
            FormatPanel.Controls.Add(this.ComboOutputFormat);
            FormatPanel.Controls.Add(this.BtnOutput);
            resources.ApplyResources(FormatPanel, "FormatPanel");
            FormatPanel.Name = "FormatPanel";
            // 
            // ComboOutputFormat
            // 
            resources.ApplyResources(this.ComboOutputFormat, "ComboOutputFormat");
            this.ComboOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOutputFormat.FormattingEnabled = true;
            this.ComboOutputFormat.Name = "ComboOutputFormat";
            // 
            // BtnOutput
            // 
            resources.ApplyResources(this.BtnOutput, "BtnOutput");
            this.BtnOutput.Name = "BtnOutput";
            this.BtnOutput.UseVisualStyleBackColor = true;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage,
            this.ProgressBar});
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            // 
            // StatusMessage
            // 
            this.StatusMessage.Name = "StatusMessage";
            resources.ApplyResources(this.StatusMessage, "StatusMessage");
            this.StatusMessage.Spring = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            // 
            // FileListView
            // 
            this.FileListView.CheckBoxes = true;
            resources.ApplyResources(this.FileListView, "FileListView");
            this.FileListView.FullRowSelect = true;
            this.FileListView.GridLines = true;
            this.FileListView.Name = "FileListView";
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.VirtualMode = true;
            // 
            // ReportView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileListView);
            this.Controls.Add(FormatPanel);
            this.Controls.Add(this.StatusBar);
            this.Name = "ReportView";
            FormatPanel.ResumeLayout(false);
            FormatPanel.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusMessage;
        private System.Windows.Forms.ComboBox ComboOutputFormat;
        private System.Windows.Forms.Button BtnOutput;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ListView FileListView;
    }
}
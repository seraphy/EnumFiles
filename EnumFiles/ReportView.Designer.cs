namespace EnumFiles
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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ComboOutputFormat = new System.Windows.Forms.ComboBox();
            this.BtnOutput = new System.Windows.Forms.Button();
            this.FileListView = new System.Windows.Forms.ListView();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            FormatPanel = new System.Windows.Forms.Panel();
            this.StatusBar.SuspendLayout();
            FormatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMessage,
            this.ProgressBar});
            this.StatusBar.Location = new System.Drawing.Point(0, 239);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(384, 22);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "statusStrip1";
            // 
            // StatusMessage
            // 
            this.StatusMessage.Name = "StatusMessage";
            this.StatusMessage.Size = new System.Drawing.Size(267, 17);
            this.StatusMessage.Spring = true;
            // 
            // FormatPanel
            // 
            FormatPanel.Controls.Add(this.ComboOutputFormat);
            FormatPanel.Controls.Add(this.BtnOutput);
            FormatPanel.Dock = System.Windows.Forms.DockStyle.Top;
            FormatPanel.Location = new System.Drawing.Point(0, 0);
            FormatPanel.Name = "FormatPanel";
            FormatPanel.Size = new System.Drawing.Size(384, 20);
            FormatPanel.TabIndex = 1;
            // 
            // ComboOutputFormat
            // 
            this.ComboOutputFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboOutputFormat.FormattingEnabled = true;
            this.ComboOutputFormat.Location = new System.Drawing.Point(0, 0);
            this.ComboOutputFormat.Name = "ComboOutputFormat";
            this.ComboOutputFormat.Size = new System.Drawing.Size(321, 20);
            this.ComboOutputFormat.TabIndex = 0;
            // 
            // BtnOutput
            // 
            this.BtnOutput.AutoSize = true;
            this.BtnOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnOutput.Location = new System.Drawing.Point(321, 0);
            this.BtnOutput.Name = "BtnOutput";
            this.BtnOutput.Size = new System.Drawing.Size(63, 20);
            this.BtnOutput.TabIndex = 1;
            this.BtnOutput.Text = "Save";
            this.BtnOutput.UseVisualStyleBackColor = true;
            // 
            // FileListView
            // 
            this.FileListView.CheckBoxes = true;
            this.FileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListView.FullRowSelect = true;
            this.FileListView.GridLines = true;
            this.FileListView.Location = new System.Drawing.Point(0, 20);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(384, 219);
            this.FileListView.TabIndex = 2;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.Details;
            this.FileListView.VirtualMode = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.FileListView);
            this.Controls.Add(FormatPanel);
            this.Controls.Add(this.StatusBar);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            FormatPanel.ResumeLayout(false);
            FormatPanel.PerformLayout();
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
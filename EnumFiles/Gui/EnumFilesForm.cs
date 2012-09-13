using EnumFiles.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumFiles.Gui
{
    public partial class EnumFilesForm : Form
    {
        public EnumFilesForm()
        {
            InitializeComponent();
        }

        private void EnumFilesForm_Load(object sender, EventArgs e)
        {
            // 出力フォーマットをロードする
            var outputFormatMgr = EnumFileApp.OutputFormatManager;
            outputFormatMgr.Load();

            // 出力フォーマットの選択コンボボックスに設定する
            var outputFormats = new List<OutputFormat>();
            outputFormats.AddRange(outputFormatMgr.AllItems);

            ComboOutputFormat.DataSource = outputFormats;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var dlg = new SearchOptionsForm();
            var ret = dlg.ShowDialog(this);
            MessageBox.Show(ret.ToString());
        }

        /// <summary>
        /// 出力フォーマットの編集ボタンのハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditFormat_Click(object sender, EventArgs e)
        {
            var outputFormat = ComboOutputFormat.SelectedItem as OutputFormat;

            var editForm = new OutputFormatForm();
            editForm.Current = outputFormat;

            var ret = editForm.ShowDialog(this);
            MessageBox.Show(ret.ToString() + "/" + editForm.Current);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (CheckShowResults.Checked)
            {
                var reportView = new ReportView();
                reportView.Show(this);
            }
        }
    }
}

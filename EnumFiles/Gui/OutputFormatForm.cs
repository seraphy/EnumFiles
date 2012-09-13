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
    public partial class OutputFormatForm : Form
    {
        private OutputFormat current_ = new OutputFormat();

        public OutputFormat Current
        {
            set
            {
                if (value == null) throw new ArgumentException();

                current_ = value;
                outputFormatBindingSource.DataSource = current_;
            }

            get
            {
                return current_;
            }
        }

        public OutputFormatForm()
        {
            InitializeComponent();
        }

        private void OutputFormatForm_Load(object sender, EventArgs e)
        {
            // 出力フォーマットの一覧を選択コンボボックスに設定する
            var outputFormatMgr = EnumFileApp.OutputFormatManager;
            var outputFormatNames = outputFormatMgr.AllItems.Select(of => of.Name).ToList();
            ComboFormatName.DataSource = outputFormatNames;

            // 現在の選択アイテム名を設定する.
            ComboFormatName.Text = current_.Name;
        }

        /// <summary>
        /// 出力フォーマット名コンボボックスのリストの選択を変更した場合のハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboFormatName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択した出力フォーマット名を取得する.
            string selName = ComboFormatName.Text;

            //　名前に該当する出力フォーマットを取得する
            var outputFormatMgr = EnumFileApp.OutputFormatManager;
            OutputFormat of = null;
            if (!string.IsNullOrWhiteSpace(selName))
            {
                of = outputFormatMgr[selName];
            }
            if (of == null)
            {
                // 該当がなければ空とする
                of = new OutputFormat();
            }
            // 選択を変更する
            Current = of;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel-Format");
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK-Format");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var of = new OutputFormat();
            of.Header = "header:" + (DateTime.Now).ToShortDateString();
            outputFormatBindingSource.DataSource = of;
            MessageBox.Show("Save");
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var of = (OutputFormat)outputFormatBindingSource.DataSource;
            of.Footer = "Foooter!!";

            MessageBox.Show("remove");
        }
    }
}

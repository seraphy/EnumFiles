using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumFiles
{
    public partial class EnumFilesForm : Form
    {
        public EnumFilesForm()
        {
            InitializeComponent();
        }

        private void EnumFilesForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchConditionGroup_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var dlg = new SearchOptionsForm();
            var ret = dlg.ShowDialog(this);
            MessageBox.Show(ret.ToString());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Run");
        }
    }
}

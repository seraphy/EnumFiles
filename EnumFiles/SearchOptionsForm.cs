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
    public partial class SearchOptionsForm : Form
    {
        public SearchOptionsForm()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok-option");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cancel-option");
        }
    }
}

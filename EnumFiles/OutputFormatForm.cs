﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumFiles
{
    public partial class OutputFormatForm : Form
    {
        public OutputFormatForm()
        {
            InitializeComponent();
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
            MessageBox.Show("Save");
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("remove");
        }
    }
}

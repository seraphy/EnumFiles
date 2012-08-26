using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumFilesFormControls
{
    public partial class FileSizePicker : UserControl
    {
        public FileSizePicker()
        {
            InitializeComponent();
        }

        public bool Checked
        {
            get
            {
                return EnableCheckBox.Checked;
            }
            set
            {
                EnableCheckBox.Checked = value;
            }
        }

        public object UnitItems
        {
            set
            {
                UnitCombo.DataSource = value;
            }
            get
            {
                return UnitCombo.DataSource;
            }
        }

        public object SelectedUnitItem
        {
            get
            {
                return UnitCombo.SelectedItem;
            }
        }

        public int SelectedUnitIndex
        {
            get
            {
                return UnitCombo.SelectedIndex;
            }
            set
            {
                UnitCombo.SelectedIndex = value;
            }
        }

        private void FileSizeSpinner_ValueChanged(object sender, EventArgs e)
        {
            EnableCheckBox.Checked = true;
        }

        private void UnitCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            EnableCheckBox.Checked = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPivotGrid.Customization;
using System.Collections;
using System.Xml.Serialization;
using System.IO;
using DevExpress.XtraPivotGrid.Data;

namespace E4592
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nwindDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.nwindDataSet.Invoices);
            CustomizationFindHelper helper = new CustomizationFindHelper(pivotGridControl1);
            pivotGridControl1.FieldsCustomization();
        }

    }
}
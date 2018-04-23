using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPivotGrid;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.Customization;
using DevExpress.XtraEditors;

namespace E4592
{
    public class CustomizationFindHelper
    {
        PivotGridControl _pivotGrid;
        TextEdit _searchTextEdit;
        public PivotGridControl PivotGrid
        {
            get { return _pivotGrid; }
    }
        public CustomizationFindHelper(PivotGridControl pivotGrid)
        {
            Attach(pivotGrid);
        }

        void Attach(PivotGridControl pivotGrid)
        {
            if (_pivotGrid != null)
                Detach();
            _pivotGrid = pivotGrid;
            _pivotGrid.ShowCustomizationForm += new EventHandler(_pivotGrid_ShowCustomizationForm);
        }

        void Detach()
        {
            _pivotGrid = null;
            _pivotGrid.ShowCustomizationForm -= new EventHandler(_pivotGrid_ShowCustomizationForm);
        }

        private void _pivotGrid_ShowCustomizationForm(object sender, EventArgs e)
        {
            AddSearchControl(_pivotGrid.CustomizationForm);
            _pivotGrid.CustomizationForm.MinimumSize = new System.Drawing.Size(250, 500);

        }
        private void AddSearchControl(CustomizationForm customizationForm)
        {
            _searchTextEdit = new TextEdit();
            _searchTextEdit.Properties.NullValuePrompt = "Enter text to filter above fields...";
            _searchTextEdit.Dock = DockStyle.Top;
            _searchTextEdit.EditValueChanged += new EventHandler(_searchTextEdit_EditValueChanged);
            customizationForm.ActiveListBox.Parent.Controls.Add(_searchTextEdit);
        }


        void _searchTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            foreach (PivotGridField field in _pivotGrid.Fields)
            {
                if (field.ToString().IndexOf(textEdit.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    field.Options.ShowInCustomizationForm = true;
                else
                    field.Options.ShowInCustomizationForm = false;

            }
        }



    }
}

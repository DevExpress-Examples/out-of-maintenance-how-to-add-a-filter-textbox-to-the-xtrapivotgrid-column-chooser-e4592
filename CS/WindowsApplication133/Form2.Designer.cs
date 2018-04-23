namespace E4592
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new nwindDataSet();
            this.fieldShipName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipAddress1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipCity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipRegion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipPostalCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShipCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomerID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomersCompanyName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAddress1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRegion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPostalCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesperson1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRequiredDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippersCompanyName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductID1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFreight1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.invoicesTableAdapter = new nwindDataSetTableAdapters.InvoicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.invoicesBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldShipName1,
            this.fieldShipAddress1,
            this.fieldShipCity1,
            this.fieldShipRegion1,
            this.fieldShipPostalCode1,
            this.fieldShipCountry1,
            this.fieldCustomerID1,
            this.fieldCustomersCompanyName1,
            this.fieldAddress1,
            this.fieldCity1,
            this.fieldRegion1,
            this.fieldPostalCode1,
            this.fieldCountry1,
            this.fieldSalesperson1,
            this.fieldOrderID1,
            this.fieldOrderDate1,
            this.fieldRequiredDate1,
            this.fieldShippedDate1,
            this.fieldShippersCompanyName1,
            this.fieldProductID1,
            this.fieldProductName1,
            this.fieldUnitPrice1,
            this.fieldQuantity1,
            this.fieldDiscount1,
            this.fieldExtendedPrice1,
            this.fieldFreight1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = true;
            this.pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = true;
            this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl1.Size = new System.Drawing.Size(606, 556);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldShipName1
            // 
            this.fieldShipName1.AreaIndex = 0;
            this.fieldShipName1.Caption = "Ship Name";
            this.fieldShipName1.FieldName = "ShipName";
            this.fieldShipName1.Name = "fieldShipName1";
            this.fieldShipName1.Visible = false;
            // 
            // fieldShipAddress1
            // 
            this.fieldShipAddress1.AreaIndex = 0;
            this.fieldShipAddress1.Caption = "Ship Address";
            this.fieldShipAddress1.FieldName = "ShipAddress";
            this.fieldShipAddress1.Name = "fieldShipAddress1";
            this.fieldShipAddress1.Visible = false;
            // 
            // fieldShipCity1
            // 
            this.fieldShipCity1.AreaIndex = 0;
            this.fieldShipCity1.Caption = "Ship City";
            this.fieldShipCity1.FieldName = "ShipCity";
            this.fieldShipCity1.Name = "fieldShipCity1";
            this.fieldShipCity1.Visible = false;
            // 
            // fieldShipRegion1
            // 
            this.fieldShipRegion1.AreaIndex = 0;
            this.fieldShipRegion1.Caption = "Ship Region";
            this.fieldShipRegion1.FieldName = "ShipRegion";
            this.fieldShipRegion1.Name = "fieldShipRegion1";
            this.fieldShipRegion1.Visible = false;
            // 
            // fieldShipPostalCode1
            // 
            this.fieldShipPostalCode1.AreaIndex = 0;
            this.fieldShipPostalCode1.Caption = "Ship Postal Code";
            this.fieldShipPostalCode1.FieldName = "ShipPostalCode";
            this.fieldShipPostalCode1.Name = "fieldShipPostalCode1";
            this.fieldShipPostalCode1.Visible = false;
            // 
            // fieldShipCountry1
            // 
            this.fieldShipCountry1.AreaIndex = 0;
            this.fieldShipCountry1.Caption = "Ship Country";
            this.fieldShipCountry1.FieldName = "ShipCountry";
            this.fieldShipCountry1.Name = "fieldShipCountry1";
            this.fieldShipCountry1.Visible = false;
            // 
            // fieldCustomerID1
            // 
            this.fieldCustomerID1.AreaIndex = 0;
            this.fieldCustomerID1.Caption = "Customer ID";
            this.fieldCustomerID1.FieldName = "CustomerID";
            this.fieldCustomerID1.Name = "fieldCustomerID1";
            this.fieldCustomerID1.Visible = false;
            // 
            // fieldCustomersCompanyName1
            // 
            this.fieldCustomersCompanyName1.AreaIndex = 0;
            this.fieldCustomersCompanyName1.Caption = "Customers_Company Name";
            this.fieldCustomersCompanyName1.FieldName = "Customers_CompanyName";
            this.fieldCustomersCompanyName1.Name = "fieldCustomersCompanyName1";
            this.fieldCustomersCompanyName1.Visible = false;
            // 
            // fieldAddress1
            // 
            this.fieldAddress1.AreaIndex = 0;
            this.fieldAddress1.Caption = "Address";
            this.fieldAddress1.FieldName = "Address";
            this.fieldAddress1.Name = "fieldAddress1";
            this.fieldAddress1.Visible = false;
            // 
            // fieldCity1
            // 
            this.fieldCity1.AreaIndex = 0;
            this.fieldCity1.Caption = "City";
            this.fieldCity1.FieldName = "City";
            this.fieldCity1.Name = "fieldCity1";
            this.fieldCity1.Visible = false;
            // 
            // fieldRegion1
            // 
            this.fieldRegion1.AreaIndex = 0;
            this.fieldRegion1.Caption = "Region";
            this.fieldRegion1.FieldName = "Region";
            this.fieldRegion1.Name = "fieldRegion1";
            this.fieldRegion1.Visible = false;
            // 
            // fieldPostalCode1
            // 
            this.fieldPostalCode1.AreaIndex = 0;
            this.fieldPostalCode1.Caption = "Postal Code";
            this.fieldPostalCode1.FieldName = "PostalCode";
            this.fieldPostalCode1.Name = "fieldPostalCode1";
            this.fieldPostalCode1.Visible = false;
            // 
            // fieldCountry1
            // 
            this.fieldCountry1.AreaIndex = 0;
            this.fieldCountry1.Caption = "Country";
            this.fieldCountry1.FieldName = "Country";
            this.fieldCountry1.Name = "fieldCountry1";
            this.fieldCountry1.Visible = false;
            // 
            // fieldSalesperson1
            // 
            this.fieldSalesperson1.AreaIndex = 0;
            this.fieldSalesperson1.Caption = "Salesperson";
            this.fieldSalesperson1.FieldName = "Salesperson";
            this.fieldSalesperson1.Name = "fieldSalesperson1";
            this.fieldSalesperson1.Visible = false;
            // 
            // fieldOrderID1
            // 
            this.fieldOrderID1.AreaIndex = 0;
            this.fieldOrderID1.Caption = "Order ID";
            this.fieldOrderID1.FieldName = "OrderID";
            this.fieldOrderID1.Name = "fieldOrderID1";
            this.fieldOrderID1.Visible = false;
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate1.AreaIndex = 0;
            this.fieldOrderDate1.Caption = "Order Date";
            this.fieldOrderDate1.FieldName = "OrderDate";
            this.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            // 
            // fieldRequiredDate1
            // 
            this.fieldRequiredDate1.AreaIndex = 0;
            this.fieldRequiredDate1.Caption = "Required Date";
            this.fieldRequiredDate1.FieldName = "RequiredDate";
            this.fieldRequiredDate1.Name = "fieldRequiredDate1";
            this.fieldRequiredDate1.Visible = false;
            // 
            // fieldShippedDate1
            // 
            this.fieldShippedDate1.AreaIndex = 0;
            this.fieldShippedDate1.Caption = "Shipped Date";
            this.fieldShippedDate1.FieldName = "ShippedDate";
            this.fieldShippedDate1.Name = "fieldShippedDate1";
            this.fieldShippedDate1.Visible = false;
            // 
            // fieldShippersCompanyName1
            // 
            this.fieldShippersCompanyName1.AreaIndex = 0;
            this.fieldShippersCompanyName1.Caption = "Shippers_Company Name";
            this.fieldShippersCompanyName1.FieldName = "Shippers_CompanyName";
            this.fieldShippersCompanyName1.Name = "fieldShippersCompanyName1";
            this.fieldShippersCompanyName1.Visible = false;
            // 
            // fieldProductID1
            // 
            this.fieldProductID1.AreaIndex = 0;
            this.fieldProductID1.Caption = "Product ID";
            this.fieldProductID1.FieldName = "ProductID";
            this.fieldProductID1.Name = "fieldProductID1";
            this.fieldProductID1.Visible = false;
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName1.AreaIndex = 0;
            this.fieldProductName1.Caption = "Product Name";
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice1.AreaIndex = 1;
            this.fieldUnitPrice1.Caption = "Unit Price";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            this.fieldUnitPrice1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // fieldQuantity1
            // 
            this.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity1.AreaIndex = 0;
            this.fieldQuantity1.Caption = "Quantity";
            this.fieldQuantity1.FieldName = "Quantity";
            this.fieldQuantity1.Name = "fieldQuantity1";
            // 
            // fieldDiscount1
            // 
            this.fieldDiscount1.AreaIndex = 0;
            this.fieldDiscount1.Caption = "Discount";
            this.fieldDiscount1.FieldName = "Discount";
            this.fieldDiscount1.Name = "fieldDiscount1";
            this.fieldDiscount1.Visible = false;
            // 
            // fieldExtendedPrice1
            // 
            this.fieldExtendedPrice1.AreaIndex = 0;
            this.fieldExtendedPrice1.Caption = "Extended Price";
            this.fieldExtendedPrice1.FieldName = "ExtendedPrice";
            this.fieldExtendedPrice1.Name = "fieldExtendedPrice1";
            this.fieldExtendedPrice1.Visible = false;
            // 
            // fieldFreight1
            // 
            this.fieldFreight1.AreaIndex = 0;
            this.fieldFreight1.Caption = "Freight";
            this.fieldFreight1.FieldName = "Freight";
            this.fieldFreight1.Name = "fieldFreight1";
            this.fieldFreight1.Visible = false;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 556);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private nwindDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipAddress1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipCity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipRegion1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipPostalCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShipCountry1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomerID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomersCompanyName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAddress1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRegion1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPostalCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSalesperson1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRequiredDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippersCompanyName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFreight1;
    }
}
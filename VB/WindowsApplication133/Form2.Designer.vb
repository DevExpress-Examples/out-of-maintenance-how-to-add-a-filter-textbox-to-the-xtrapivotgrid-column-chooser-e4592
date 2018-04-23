Imports Microsoft.VisualBasic
Imports System
Namespace E4592
	Partial Public Class Form2
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.invoicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New nwindDataSet()
			Me.fieldShipName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShipAddress1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShipCity1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShipRegion1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShipPostalCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShipCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCustomerID1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCustomersCompanyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldAddress1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCity1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldRegion1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldPostalCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesperson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderID1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldRequiredDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShippedDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldShippersCompanyName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductID1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldUnitPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDiscount1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldFreight1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.invoicesTableAdapter = New nwindDataSetTableAdapters.InvoicesTableAdapter()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.invoicesBindingSource
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldShipName1, Me.fieldShipAddress1, Me.fieldShipCity1, Me.fieldShipRegion1, Me.fieldShipPostalCode1, Me.fieldShipCountry1, Me.fieldCustomerID1, Me.fieldCustomersCompanyName1, Me.fieldAddress1, Me.fieldCity1, Me.fieldRegion1, Me.fieldPostalCode1, Me.fieldCountry1, Me.fieldSalesperson1, Me.fieldOrderID1, Me.fieldOrderDate1, Me.fieldRequiredDate1, Me.fieldShippedDate1, Me.fieldShippersCompanyName1, Me.fieldProductID1, Me.fieldProductName1, Me.fieldUnitPrice1, Me.fieldQuantity1, Me.fieldDiscount1, Me.fieldExtendedPrice1, Me.fieldFreight1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = True
			Me.pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = True
			Me.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			Me.pivotGridControl1.Size = New System.Drawing.Size(606, 556)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' invoicesBindingSource
			' 
			Me.invoicesBindingSource.DataMember = "Invoices"
			Me.invoicesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldShipName1
			' 
			Me.fieldShipName1.AreaIndex = 0
			Me.fieldShipName1.Caption = "Ship Name"
			Me.fieldShipName1.FieldName = "ShipName"
			Me.fieldShipName1.Name = "fieldShipName1"
			Me.fieldShipName1.Visible = False
			' 
			' fieldShipAddress1
			' 
			Me.fieldShipAddress1.AreaIndex = 0
			Me.fieldShipAddress1.Caption = "Ship Address"
			Me.fieldShipAddress1.FieldName = "ShipAddress"
			Me.fieldShipAddress1.Name = "fieldShipAddress1"
			Me.fieldShipAddress1.Visible = False
			' 
			' fieldShipCity1
			' 
			Me.fieldShipCity1.AreaIndex = 0
			Me.fieldShipCity1.Caption = "Ship City"
			Me.fieldShipCity1.FieldName = "ShipCity"
			Me.fieldShipCity1.Name = "fieldShipCity1"
			Me.fieldShipCity1.Visible = False
			' 
			' fieldShipRegion1
			' 
			Me.fieldShipRegion1.AreaIndex = 0
			Me.fieldShipRegion1.Caption = "Ship Region"
			Me.fieldShipRegion1.FieldName = "ShipRegion"
			Me.fieldShipRegion1.Name = "fieldShipRegion1"
			Me.fieldShipRegion1.Visible = False
			' 
			' fieldShipPostalCode1
			' 
			Me.fieldShipPostalCode1.AreaIndex = 0
			Me.fieldShipPostalCode1.Caption = "Ship Postal Code"
			Me.fieldShipPostalCode1.FieldName = "ShipPostalCode"
			Me.fieldShipPostalCode1.Name = "fieldShipPostalCode1"
			Me.fieldShipPostalCode1.Visible = False
			' 
			' fieldShipCountry1
			' 
			Me.fieldShipCountry1.AreaIndex = 0
			Me.fieldShipCountry1.Caption = "Ship Country"
			Me.fieldShipCountry1.FieldName = "ShipCountry"
			Me.fieldShipCountry1.Name = "fieldShipCountry1"
			Me.fieldShipCountry1.Visible = False
			' 
			' fieldCustomerID1
			' 
			Me.fieldCustomerID1.AreaIndex = 0
			Me.fieldCustomerID1.Caption = "Customer ID"
			Me.fieldCustomerID1.FieldName = "CustomerID"
			Me.fieldCustomerID1.Name = "fieldCustomerID1"
			Me.fieldCustomerID1.Visible = False
			' 
			' fieldCustomersCompanyName1
			' 
			Me.fieldCustomersCompanyName1.AreaIndex = 0
			Me.fieldCustomersCompanyName1.Caption = "Customers_Company Name"
			Me.fieldCustomersCompanyName1.FieldName = "Customers_CompanyName"
			Me.fieldCustomersCompanyName1.Name = "fieldCustomersCompanyName1"
			Me.fieldCustomersCompanyName1.Visible = False
			' 
			' fieldAddress1
			' 
			Me.fieldAddress1.AreaIndex = 0
			Me.fieldAddress1.Caption = "Address"
			Me.fieldAddress1.FieldName = "Address"
			Me.fieldAddress1.Name = "fieldAddress1"
			Me.fieldAddress1.Visible = False
			' 
			' fieldCity1
			' 
			Me.fieldCity1.AreaIndex = 0
			Me.fieldCity1.Caption = "City"
			Me.fieldCity1.FieldName = "City"
			Me.fieldCity1.Name = "fieldCity1"
			Me.fieldCity1.Visible = False
			' 
			' fieldRegion1
			' 
			Me.fieldRegion1.AreaIndex = 0
			Me.fieldRegion1.Caption = "Region"
			Me.fieldRegion1.FieldName = "Region"
			Me.fieldRegion1.Name = "fieldRegion1"
			Me.fieldRegion1.Visible = False
			' 
			' fieldPostalCode1
			' 
			Me.fieldPostalCode1.AreaIndex = 0
			Me.fieldPostalCode1.Caption = "Postal Code"
			Me.fieldPostalCode1.FieldName = "PostalCode"
			Me.fieldPostalCode1.Name = "fieldPostalCode1"
			Me.fieldPostalCode1.Visible = False
			' 
			' fieldCountry1
			' 
			Me.fieldCountry1.AreaIndex = 0
			Me.fieldCountry1.Caption = "Country"
			Me.fieldCountry1.FieldName = "Country"
			Me.fieldCountry1.Name = "fieldCountry1"
			Me.fieldCountry1.Visible = False
			' 
			' fieldSalesperson1
			' 
			Me.fieldSalesperson1.AreaIndex = 0
			Me.fieldSalesperson1.Caption = "Salesperson"
			Me.fieldSalesperson1.FieldName = "Salesperson"
			Me.fieldSalesperson1.Name = "fieldSalesperson1"
			Me.fieldSalesperson1.Visible = False
			' 
			' fieldOrderID1
			' 
			Me.fieldOrderID1.AreaIndex = 0
			Me.fieldOrderID1.Caption = "Order ID"
			Me.fieldOrderID1.FieldName = "OrderID"
			Me.fieldOrderID1.Name = "fieldOrderID1"
			Me.fieldOrderID1.Visible = False
			' 
			' fieldOrderDate1
			' 
			Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldOrderDate1.AreaIndex = 0
			Me.fieldOrderDate1.Caption = "Order Date"
			Me.fieldOrderDate1.FieldName = "OrderDate"
			Me.fieldOrderDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldOrderDate1.Name = "fieldOrderDate1"
			Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
			' 
			' fieldRequiredDate1
			' 
			Me.fieldRequiredDate1.AreaIndex = 0
			Me.fieldRequiredDate1.Caption = "Required Date"
			Me.fieldRequiredDate1.FieldName = "RequiredDate"
			Me.fieldRequiredDate1.Name = "fieldRequiredDate1"
			Me.fieldRequiredDate1.Visible = False
			' 
			' fieldShippedDate1
			' 
			Me.fieldShippedDate1.AreaIndex = 0
			Me.fieldShippedDate1.Caption = "Shipped Date"
			Me.fieldShippedDate1.FieldName = "ShippedDate"
			Me.fieldShippedDate1.Name = "fieldShippedDate1"
			Me.fieldShippedDate1.Visible = False
			' 
			' fieldShippersCompanyName1
			' 
			Me.fieldShippersCompanyName1.AreaIndex = 0
			Me.fieldShippersCompanyName1.Caption = "Shippers_Company Name"
			Me.fieldShippersCompanyName1.FieldName = "Shippers_CompanyName"
			Me.fieldShippersCompanyName1.Name = "fieldShippersCompanyName1"
			Me.fieldShippersCompanyName1.Visible = False
			' 
			' fieldProductID1
			' 
			Me.fieldProductID1.AreaIndex = 0
			Me.fieldProductID1.Caption = "Product ID"
			Me.fieldProductID1.FieldName = "ProductID"
			Me.fieldProductID1.Name = "fieldProductID1"
			Me.fieldProductID1.Visible = False
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 0
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldUnitPrice1
			' 
			Me.fieldUnitPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitPrice1.AreaIndex = 1
			Me.fieldUnitPrice1.Caption = "Unit Price"
			Me.fieldUnitPrice1.FieldName = "UnitPrice"
			Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
			Me.fieldUnitPrice1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
			' 
			' fieldQuantity1
			' 
			Me.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity1.AreaIndex = 0
			Me.fieldQuantity1.Caption = "Quantity"
			Me.fieldQuantity1.FieldName = "Quantity"
			Me.fieldQuantity1.Name = "fieldQuantity1"
			' 
			' fieldDiscount1
			' 
			Me.fieldDiscount1.AreaIndex = 0
			Me.fieldDiscount1.Caption = "Discount"
			Me.fieldDiscount1.FieldName = "Discount"
			Me.fieldDiscount1.Name = "fieldDiscount1"
			Me.fieldDiscount1.Visible = False
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "ExtendedPrice"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			Me.fieldExtendedPrice1.Visible = False
			' 
			' fieldFreight1
			' 
			Me.fieldFreight1.AreaIndex = 0
			Me.fieldFreight1.Caption = "Freight"
			Me.fieldFreight1.FieldName = "Freight"
			Me.fieldFreight1.Name = "fieldFreight1"
			Me.fieldFreight1.Visible = False
			' 
			' invoicesTableAdapter
			' 
			Me.invoicesTableAdapter.ClearBeforeFill = True
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(606, 556)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form2"
			Me.Text = "Form2"
'			Me.Load += New System.EventHandler(Me.Form2_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.invoicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private nwindDataSet As nwindDataSet
		Private invoicesBindingSource As System.Windows.Forms.BindingSource
		Private invoicesTableAdapter As nwindDataSetTableAdapters.InvoicesTableAdapter
		Private fieldShipName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShipAddress1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShipCity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShipRegion1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShipPostalCode1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShipCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCustomerID1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCustomersCompanyName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldAddress1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldRegion1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPostalCode1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesperson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderID1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldRequiredDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShippedDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldShippersCompanyName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductID1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldUnitPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDiscount1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldFreight1 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace
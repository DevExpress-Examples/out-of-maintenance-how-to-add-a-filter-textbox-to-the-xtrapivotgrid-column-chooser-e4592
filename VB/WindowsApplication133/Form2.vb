Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPivotGrid.Customization
Imports System.Collections
Imports System.Xml.Serialization
Imports System.IO
Imports DevExpress.XtraPivotGrid.Data

Namespace E4592
	Partial Public Class Form2
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Invoices' table. You can move, or remove it, as needed.
			Me.invoicesTableAdapter.Fill(Me.nwindDataSet.Invoices)
			Dim helper As New CustomizationFindHelper(pivotGridControl1)
			pivotGridControl1.FieldsCustomization()
		End Sub

	End Class
End Namespace
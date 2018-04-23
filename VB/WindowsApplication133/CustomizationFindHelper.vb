Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraPivotGrid
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid.Customization
Imports DevExpress.XtraEditors

Namespace E4592
	Public Class CustomizationFindHelper
		Private _pivotGrid As PivotGridControl
		Private _searchTextEdit As TextEdit
		Public ReadOnly Property PivotGrid() As PivotGridControl
			Get
				Return _pivotGrid
			End Get
		End Property
		Public Sub New(ByVal pivotGrid As PivotGridControl)
			Attach(pivotGrid)
		End Sub

		Private Sub Attach(ByVal pivotGrid As PivotGridControl)
			If _pivotGrid IsNot Nothing Then
				Detach()
			End If
			_pivotGrid = pivotGrid
			AddHandler _pivotGrid.ShowCustomizationForm, AddressOf _pivotGrid_ShowCustomizationForm
		End Sub

		Private Sub Detach()
			_pivotGrid = Nothing
			RemoveHandler _pivotGrid.ShowCustomizationForm, AddressOf _pivotGrid_ShowCustomizationForm
		End Sub

		Private Sub _pivotGrid_ShowCustomizationForm(ByVal sender As Object, ByVal e As EventArgs)
			AddSearchControl(_pivotGrid.CustomizationForm)
			_pivotGrid.CustomizationForm.MinimumSize = New System.Drawing.Size(250, 500)

		End Sub
		Private Sub AddSearchControl(ByVal customizationForm As CustomizationForm)
			_searchTextEdit = New TextEdit()
			_searchTextEdit.Properties.NullValuePrompt = "Enter text to filter above fields..."
			_searchTextEdit.Dock = DockStyle.Top
			AddHandler _searchTextEdit.EditValueChanged, AddressOf _searchTextEdit_EditValueChanged
			customizationForm.ActiveListBox.Parent.Controls.Add(_searchTextEdit)
		End Sub


		Private Sub _searchTextEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim textEdit As TextEdit = CType(sender, TextEdit)
			For Each field As PivotGridField In _pivotGrid.Fields
				If field.ToString().IndexOf(textEdit.Text, StringComparison.OrdinalIgnoreCase) >= 0 Then
					field.Options.ShowInCustomizationForm = True
				Else
					field.Options.ShowInCustomizationForm = False
				End If

			Next field
		End Sub



	End Class
End Namespace

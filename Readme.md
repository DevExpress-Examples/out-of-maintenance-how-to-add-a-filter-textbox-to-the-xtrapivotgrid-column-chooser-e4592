<!-- default file list -->
*Files to look at*:

* [CustomizationFindHelper.cs](./CS/WindowsApplication133/CustomizationFindHelper.cs) (VB: [CustomizationFindHelper.vb](./VB/WindowsApplication133/CustomizationFindHelper.vb))
* [Form2.cs](./CS/WindowsApplication133/Form2.cs) (VB: [Form2.vb](./VB/WindowsApplication133/Form2.vb))
* [Program.cs](./CS/WindowsApplication133/Program.cs) (VB: [Program.vb](./VB/WindowsApplication133/Program.vb))
<!-- default file list end -->
# How to add a filter TextBox to the XtraPivotGrid Column Chooser


<p> This example illustrates how to add a field filter text box to the PivotGridControl's Column Chooser window (<a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument11785"><u>Customization Form</u></a>).  To achieve this goal, handle the ShowCustomizationForm event. In this event handler, you can get a displayed customization form via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomizationFormtopic"><u>PivotGridControl.CustomizationForm</u></a> property. Then add a TexbBox control onto this form and handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsBaseEdit_EditValueChangedtopic"><u>TextBox.EditValueChanged</u></a><u> </u>event to hide PivotGridFields which do not meet the entered text via the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldOptions_ShowInCustomizationFormtopic"><u>field.Options.ShowInCustomizationForm</u></a> property.</p>

<br/>



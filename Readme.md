# How to add a filter TextBox to the XtraPivotGrid Column Chooser


<p> This example illustrates how to add a field filter text box to the PivotGridControl's Column Chooser window (<a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument11785"><u>Customization Form</u></a>).  To achieve this goal, handle the ShowCustomizationForm event. In this event handler, you can get a displayed customization form via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomizationFormtopic"><u>PivotGridControl.CustomizationForm</u></a> property. Then add a TexbBox control onto this form and handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsBaseEdit_EditValueChangedtopic"><u>TextBox.EditValueChanged</u></a><u> </u>event to hide PivotGridFields which do not meet the entered text via the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldOptions_ShowInCustomizationFormtopic"><u>field.Options.ShowInCustomizationForm</u></a> property.</p>

<br/>



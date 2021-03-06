# Aspose.Cells.Cloud.SDK.Model.WorkbookSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoCompressPictures** | **bool?** |  | [optional] 
**AutoRecover** | **bool?** |  | [optional] 
**BuildVersion** | **string** | Specifies the incremental public release of the application.              | [optional] 
**CalcMode** | **string** | It specifies whether to calculate formulas manually, automatically or automatically except for multiple table operations.              | [optional] 
**CalcStackSize** | **int?** | Specifies the stack size for calculating cells recursively.  The large value for this size will give better performance when there are lots of cells need to be calculated recursively.  On the other hand, larger value will raise the stakes of StackOverflowException.  If use gets StackOverflowException when calculating formulas, this value should be decreased.              | [optional] 
**CalculationId** | **string** | Specifies the version of the calculation engine used to calculate values in the workbook.              | [optional] 
**CheckComptiliblity** | **bool?** | Indicates whether check comptiliblity when saving workbook.                           Remarks:  The default value is true.               | [optional] 
**CheckExcelRestriction** | **bool?** | Whether check restriction of excel file when user modify cells related objects.  For example, excel does not allow inputting string value longer than 32K.  When you input a value longer than 32K such as by Cell.PutValue(string), if this property is true, you will get an Exception.  If this property is false, we will accept your input string value as the cell&#39;s value so that later you can output the complete string value for other file formats such as CSV.  However, if you have set such kind of value that is invalid for excel file format, you should not save the workbook as excel file format later. Otherwise there may be unexpected error for the generated excel file.              | [optional] 
**CrashSave** | **bool?** |  | [optional] 
**CreateCalcChain** | **bool?** | Indicates whether create calculated formulas chain.              | [optional] 
**DataExtractLoad** | **bool?** |  | [optional] 
**Date1904** | **bool?** | Gets or sets a value which represents if the workbook uses the 1904 date system.              | [optional] 
**DisplayDrawingObjects** | **string** | Indicates whether and how to show objects in the workbook.              | [optional] 
**EnableMacros** | **bool?** |  | [optional] 
**FirstVisibleTab** | **int?** | Gets or sets the first visible worksheet tab.              | [optional] 
**HidePivotFieldList** | **bool?** |  | [optional] 
**IsDefaultEncrypted** | **bool?** |  | [optional] 
**IsHidden** | **bool?** | Indicates whether this workbook is hidden.              | [optional] 
**IsHScrollBarVisible** | **bool?** | Gets or sets a value indicating whether the generated spreadsheet will contain a horizontal scroll bar.                           Remarks: The default value is true.               | [optional] 
**IsMinimized** | **bool?** | Represents whether the generated spreadsheet will be opened Minimized.              | [optional] 
**IsVScrollBarVisible** | **bool?** | Gets or sets a value indicating whether the generated spreadsheet will contain a vertical scroll bar.                           Remarks: The default value is true.               | [optional] 
**Iteration** | **bool?** | Indicates if Aspose.Cells will use iteration to resolve circular references.              | [optional] 
**LanguageCode** | **string** | Gets or sets the user interface language of the Workbook version based on CountryCode that has saved the file.              | [optional] 
**MaxChange** | **double?** | Returns or sets the maximum number of change that Microsoft Excel can use to resolve a circular reference.              | [optional] 
**MaxIteration** | **int?** | Returns or sets the maximum number of iterations that Aspose.Cells can use to resolve a circular reference.              | [optional] 
**MemorySetting** | **string** |  | [optional] 
**NumberDecimalSeparator** | **string** |  | [optional] 
**NumberGroupSeparator** | **string** |  | [optional] 
**ParsingFormulaOnOpen** | **bool?** | Indicates whether parsing the formula when reading the file.                           Remarks: Only applies for Excel Xlsx,Xltx, Xltm,Xlsm file because the formulas in the files are stored with a string formula.               | [optional] 
**PrecisionAsDisplayed** | **bool?** | True if calculations in this workbook will be done using only the precision of the numbers as they&#39;re displayed              | [optional] 
**RecalculateBeforeSave** | **bool?** | Indicates whether to recalculate before saving the document.              | [optional] 
**ReCalculateOnOpen** | **bool?** | Indicates whether re-calculate all formulas on opening file.              | [optional] 
**RecommendReadOnly** | **bool?** | Indicates if the Read Only Recommended option is selected.              | [optional] 
**Region** | **string** | Gets or sets the system regional settings based on CountryCode at the time the file was saved.                           Remarks: If you do not want to use the region saved in the file, please reset it after reading the file.               | [optional] 
**RemovePersonalInformation** | **bool?** |  | [optional] 
**RepairLoad** | **bool?** |  | [optional] 
**Shared** | **bool?** | Gets or sets a value that indicates whether the Workbook is shared.                           Remarks: The default value is false.               | [optional] 
**SheetTabBarWidth** | **int?** | Width of worksheet tab bar (in 1/1000 of window width).              | [optional] 
**ShowTabs** | **bool?** | Get or sets a value whether the Workbook tabs are displayed.                           Remarks: The default value is true.               | [optional] 
**UpdateAdjacentCellsBorder** | **bool?** | Indicates whether update adjacent cells&#39; border.                           Remarks: The default value is true.  For example: the bottom border of the cell A1 is update, the top border of the cell A2 should be changed too.               | [optional] 
**UpdateLinksType** | **string** |  | [optional] 
**WindowHeight** | **double?** | The height of the window, in unit of point.              | [optional] 
**WindowLeft** | **double?** | The distance from the left edge of the client area to the left edge of the window, in unit of point.              | [optional] 
**WindowTop** | **double?** | The distance from the top edge of the client area to the top edge of the window, in unit of point.              | [optional] 
**WindowWidth** | **double?** | The width of the window, in unit of point.              | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


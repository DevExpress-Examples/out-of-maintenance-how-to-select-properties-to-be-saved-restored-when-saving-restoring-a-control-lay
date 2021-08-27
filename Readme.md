<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658755/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2013)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/SelectingPropertiesToSerialize/Window1.xaml) (VB: [Window1.xaml](./VB/SelectingPropertiesToSerialize/Window1.xaml))
* [Window1.xaml.cs](./CS/SelectingPropertiesToSerialize/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/SelectingPropertiesToSerialize/Window1.xaml.vb))
<!-- default file list end -->
# How to select properties to be saved/restored when saving/restoring a control layout


<p>The following example shows how to specify which properties should be saved/restored when saving/restoring the layout of a control.</p><p>In this example, the DXSerializer.AllowPropertyEvent attached event is handled to specify which properties of the DXGrid columns should be saved when saving the grid layout. The event parameter's Allow property is set to true for three properties: GridColumn.ActualWidth, GridColumn.FieldName and GridColumn.Visible. Thus, these properties are saved for every grid column</p>

<br/>



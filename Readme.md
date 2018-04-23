# How to select properties to be saved/restored when saving/restoring a control layout


<p>The following example shows how to specify which properties should be saved/restored when saving/restoring the layout of a control.</p><p>In this example, the DXSerializer.AllowPropertyEvent attached event is handled to specify which properties of the DXGrid columns should be saved when saving the grid layout. The event parameter's Allow property is set to true for three properties: GridColumn.ActualWidth, GridColumn.FieldName and GridColumn.Visible. Thus, these properties are saved for every grid column</p>

<br/>



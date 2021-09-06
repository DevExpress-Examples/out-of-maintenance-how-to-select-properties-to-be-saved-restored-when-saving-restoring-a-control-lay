Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Core.Serialization
Imports DevExpress.Xpf.Grid

Namespace SelectingPropertiesToSerialize
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub gridControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.ItemsSource = IssueList.GetData()
			For Each column As GridColumn In gridControl1.Columns
				column.AddHandler(DXSerializer.AllowPropertyEvent, New AllowPropertyEventHandler(AddressOf column_AllowProperty))
			Next column
		End Sub
		Private Sub column_AllowProperty(ByVal sender As Object, ByVal e As AllowPropertyEventArgs)
			e.Allow = e.DependencyProperty = GridColumn.ActualWidthProperty OrElse e.DependencyProperty = GridColumn.FieldNameProperty OrElse e.DependencyProperty = GridColumn.VisibleProperty
		End Sub
		Public Class IssueList
			Public Shared Function GetData() As List(Of IssueDataObject)
				Dim data As New List(Of IssueDataObject)()
				data.Add(New IssueDataObject() With {
					.IssueName = "Transaction History",
					.IssueType = "Bug",
					.IsPrivate = True
				})
				data.Add(New IssueDataObject() With {
					.IssueName = "Ledger: Inconsistency",
					.IssueType = "Bug",
					.IsPrivate = False
				})
				data.Add(New IssueDataObject() With {
					.IssueName = "Data Import",
					.IssueType = "Request",
					.IsPrivate = False
				})
				data.Add(New IssueDataObject() With {
					.IssueName = "Data Archiving",
					.IssueType = "Request",
					.IsPrivate = True
				})
				Return data
			End Function
		End Class
		Public Class IssueDataObject
			Public Property IssueName() As String
			Public Property IssueType() As String
			Public Property IsPrivate() As Boolean
		End Class
		Private Sub btnRestoreLayout_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.RestoreLayoutFromXml("layout.xml")
		End Sub
		Private Sub btnSaveLayout_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.SaveLayoutToXml("layout.xml")
		End Sub
	End Class
End Namespace

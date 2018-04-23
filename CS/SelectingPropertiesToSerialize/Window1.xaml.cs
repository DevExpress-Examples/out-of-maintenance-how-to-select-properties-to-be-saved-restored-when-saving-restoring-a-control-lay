using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;

namespace SelectingPropertiesToSerialize {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        private void gridControl1_Loaded(object sender, RoutedEventArgs e) {
            gridControl1.ItemsSource = IssueList.GetData();
            foreach (GridColumn column in gridControl1.Columns)
                column.AddHandler(DXSerializer.AllowPropertyEvent,
                    new AllowPropertyEventHandler(column_AllowProperty));
        }
        void column_AllowProperty(object sender, AllowPropertyEventArgs e) {
            e.Allow = e.DependencyProperty == GridColumn.ActualWidthProperty ||
                      e.DependencyProperty == GridColumn.FieldNameProperty ||
                      e.DependencyProperty == GridColumn.VisibleProperty;
        }
        public class IssueList {
            static public List<IssueDataObject> GetData() {
                List<IssueDataObject> data = new List<IssueDataObject>();
                data.Add(new IssueDataObject() { IssueName = "Transaction History", IssueType = "Bug", IsPrivate = true });
                data.Add(new IssueDataObject() { IssueName = "Ledger: Inconsistency", IssueType = "Bug", IsPrivate = false });
                data.Add(new IssueDataObject() { IssueName = "Data Import", IssueType = "Request", IsPrivate = false });
                data.Add(new IssueDataObject() { IssueName = "Data Archiving", IssueType = "Request", IsPrivate = true });
                return data;
            }
        }
        public class IssueDataObject {
            public string IssueName { get; set; }
            public string IssueType { get; set; }
            public bool IsPrivate { get; set; }
        }
        private void btnRestoreLayout_Click(object sender, RoutedEventArgs e) {
            gridControl1.RestoreLayoutFromXml("layout.xml");
        }
        private void btnSaveLayout_Click(object sender, RoutedEventArgs e) {
            gridControl1.SaveLayoutToXml("layout.xml");
        }
    }
}

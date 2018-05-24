using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.XtraGrid;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CustomSorting {
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();
            grid.ItemsSource = new MonthList();
            grid.SortBy(grid.Columns[0]);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) {
            grid.Columns[0].SortMode = ColumnSortMode.Custom;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e) {
            grid.Columns[0].SortMode = ColumnSortMode.Default;
        }

        private void grid_CustomColumnSort(object sender, DevExpress.UI.Xaml.Grid.CustomColumnSortEventArgs e) {
            e.Result = Comparer<int>.Default.Compare(e.ListSourceRowIndex1, e.ListSourceRowIndex2);

            e.Handled = true;
        }
    }
    public class Month {
        public string month { get; set; }
    }
    public class MonthList : ObservableCollection<Month> {
        public MonthList()
            : base() {
            Add(new Month() { month = "January" });
            Add(new Month() { month = "February" });
            Add(new Month() { month = "March" });
            Add(new Month() { month = "April" });
            Add(new Month() { month = "May" });
            Add(new Month() { month = "June" });
            Add(new Month() { month = "July" });
            Add(new Month() { month = "August" });
            Add(new Month() { month = "September" });
            Add(new Month() { month = "October" });
            Add(new Month() { month = "November" });
            Add(new Month() { month = "December" });
        }
    }
}

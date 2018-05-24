Imports DevExpress.XtraGrid

Public NotInheritable Class MainPage
    Inherits Page
    Public Sub New()
        Me.InitializeComponent()
        grid.ItemsSource = New MonthList()
        grid.SortBy(grid.Columns(0))
    End Sub

    Private Sub CheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        grid.Columns(0).SortMode = ColumnSortMode.Custom
    End Sub

    Private Sub CheckBox_Unchecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        grid.Columns(0).SortMode = ColumnSortMode.Default
    End Sub

    Private Sub grid_CustomColumnSort(ByVal sender As Object, ByVal e As DevExpress.UI.Xaml.Grid.CustomColumnSortEventArgs)
        e.Result = Comparer(Of Integer).Default.Compare(e.ListSourceRowIndex1, e.ListSourceRowIndex2)

        e.Handled = True
    End Sub
    Public Class Month
        Private privatemonth As String
        Public Property month() As String
            Get
                Return privatemonth
            End Get
            Set(ByVal value As String)
                privatemonth = value
            End Set
        End Property
    End Class
    Public Class MonthList
        Inherits ObservableCollection(Of Month)
        Public Sub New()
            MyBase.New()
            Add(New Month() With {.month = "January"})
            Add(New Month() With {.month = "February"})
            Add(New Month() With {.month = "March"})
            Add(New Month() With {.month = "April"})
            Add(New Month() With {.month = "May"})
            Add(New Month() With {.month = "June"})
            Add(New Month() With {.month = "July"})
            Add(New Month() With {.month = "August"})
            Add(New Month() With {.month = "September"})
            Add(New Month() With {.month = "October"})
            Add(New Month() With {.month = "November"})
            Add(New Month() With {.month = "December"})
        End Sub
    End Class
End Class



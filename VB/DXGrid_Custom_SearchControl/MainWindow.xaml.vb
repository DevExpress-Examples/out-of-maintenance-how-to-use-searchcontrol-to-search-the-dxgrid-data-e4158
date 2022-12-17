Imports System.Windows
Imports System.Windows.Controls

Namespace DXGrid_Custom_SearchControl

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.gridControl1.ItemsSource = New nwindDataSetTableAdapters.CustomersTableAdapter().GetData()
        End Sub
    End Class
End Namespace

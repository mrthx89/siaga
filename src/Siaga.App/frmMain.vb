Public Class frmMain

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub navBarControl_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs)
        navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf(e.Group)
    End Sub
    Private Sub barButtonNavigation_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles employeesBarButtonItem.ItemClick, customersBarButtonItem.ItemClick
        navBarControl.ActiveGroup = If(e.Item.Caption = "Employees", employeesNavBarGroup, customersNavBarGroup)
    End Sub
End Class

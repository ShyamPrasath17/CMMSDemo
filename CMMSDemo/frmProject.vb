
Public Class frmProject

    Private Sub frmProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub fillProject(ByRef dr As DataRow, ByRef dt As DataTable)
        txtprojectID.Text = dr("ProjectID").ToString()
        txtstatus.Text = dr("status").ToString()
    End Sub

    Private Sub BtnAddWo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnViewWo_Click(sender As Object, e As EventArgs) Handles btnViewWo.Click
        'If btnViewWo.Text = "View WorkOrders" Then
        '    'FormMain.RadDockMain.DockWindow(FormMain.ToolWindowWoLst, Telerik.WinControls.UI.Docking.DockPosition.Right)
        '    '    btnViewWo.Text = "Hide WorkOrders"
        '    'Else
        '    '    FormMain.ToolWindowWoLst.Hide()
        '    '    btnViewWo.Text = "View WorkOrders"
        'End If
        FormMain.RadDockMain.DockWindow(FormMain.ToolWindowWoLst, Telerik.WinControls.UI.Docking.DockPosition.Right)
    End Sub
End Class
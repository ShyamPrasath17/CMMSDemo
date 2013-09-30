Public Class frmWorkOrderLists
    Public dtWo As DataTable
    Dim frmloaded As Boolean = False

    Private Sub frmWorkOrderLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        createtable()
        frmloaded = True
        dgvWo.AllowAddNewRow = False
        dgvWo.AllowEditRow = False
        dgvWo.AllowDeleteRow = False
    End Sub

    Private Sub createtable()
        dtWo = New DataTable()
        dtWo.Columns.Add("ProjectNo", GetType(String))
        dtWo.Columns.Add("WorkOrderNo", GetType(String))
        dtWo.Columns.Add("WorkOrderName", GetType(String))
        dtWo.Columns.Add("ServiceType", GetType(String))
        dtWo.Columns.Add("status", GetType(String))
        For i As Integer = 1 To 15
            If i < 4 Then
                dtWo.Rows.Add("Project 1", "Wo " & i.ToString(), "service " + i.ToString(), "102" + i.ToString(), "Approved")
            ElseIf i >= 4 And i < 8 Then
                dtWo.Rows.Add("Project 3", "Wo " & i.ToString(), "service " + i.ToString(), "105" + i.ToString(), "New")
            ElseIf i >= 8 And i < 12 Then
                dtWo.Rows.Add("Project 5", "Wo " & i.ToString(), "service " + i.ToString(), "107" + i.ToString(), "Approved")
            Else
                dtWo.Rows.Add("Project 8", "Wo " & i.ToString(), "service " + i.ToString(), "109" + i.ToString(), "New")
            End If
        Next
        dgvWo.DataSource = dtWo.Copy()
        dgvWo.BestFitColumns()
    End Sub

    Private Sub dgvWo_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvWo.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                FormMain.frmwo.fillworkorder(dtWo.Select("WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0), dtWo)
                Dim dt_task As DataTable = FormMain.frmTskLst.dttask
                dt_task.DefaultView.RowFilter = "WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'"
                FormMain.frmTskLst.dgvTasks.DataSource = dt_task.DefaultView
            End If
        End If
    End Sub

    Private Sub dgvWo_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvWo.CellDoubleClick
        'FormMain.RadDockMain.DockWindow(FormMain.ToolWindowWo, Telerik.WinControls.UI.Docking.DockPosition.Left)
        FormMain.ToolWindowWo.Show()
        FormMain.ToolWindowWo.Select()
    End Sub

    Private Sub dgvWo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvWo.SelectionChanged
        If (frmloaded) Then
            If (Not dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                FormMain.frmwo.fillworkorder(dtWo.Select("WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0), dtWo)
                Dim dt_task As DataTable = FormMain.frmTskLst.dttask
                dt_task.DefaultView.RowFilter = "WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'"
                FormMain.frmTskLst.dgvTasks.DataSource = dt_task.DefaultView
            End If
        End If
    End Sub
End Class
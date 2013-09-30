Public Class frmTaskLists
    Dim dt As DataTable
    Dim frmloaded As Boolean = False
    Private Sub frmTaskLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        createtable()
        frmloaded = True
        dgvTasks.AllowAddNewRow = False
        dgvTasks.AllowEditRow = False
        dgvTasks.AllowDeleteRow = False
    End Sub
    Private Sub createtable()
        dt = New DataTable()
        'dt.Columns.Add("Project", GetType(String))
        'dt.Columns.Add("WorkOrder", GetType(String))
        dt.Columns.Add("TaskNo", GetType(String))
        'dt.Columns.Add("ServiceType", GetType(String))
        dt.Columns.Add("status", GetType(String))

        For i As Integer = 1 To 10
            dt.Rows.Add("Task " & i.ToString(), "Approved")
        Next
        dgvTasks.DataSource = dt
    End Sub

    Private Sub dgvTasks_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvTasks.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvTasks.CurrentRow.Cells("TaskNo").Value Is Nothing) Then
                FormMain.frmTsk.filltask(dt.Select("TaskNo = '" & dgvTasks.CurrentRow.Cells("TaskNo").Value.ToString() & "'")(0), dt)
            End If
        End If
    End Sub

    Private Sub dgvTasks_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvTasks.CellDoubleClick
        FormMain.twTask.Show()
        FormMain.twTask.Select()
    End Sub
End Class
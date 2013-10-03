Public Class frmTaskLists
    Public dttask As DataTable
    Dim frmloaded As Boolean = False
    Private Sub frmTaskLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        createtable()
        dgvTasks.AllowAddNewRow = False
        dgvTasks.AllowEditRow = False
        dgvTasks.AllowDeleteRow = False
        frmloaded = True
    End Sub
    Private Sub createtable()
        dttask = New DataTable()
        'dttask.Columns.Add("ProjectNo", GetType(String))
        dttask.Columns.Add("WorkOrderNo", GetType(String))
        dttask.Columns.Add("TaskNo", GetType(String))
        'dt.Columns.Add("ServiceType", GetType(String))
        dttask.Columns.Add("status", GetType(String))

        For i As Integer = 1 To 20
            'dt.Rows.Add("Task " & i.ToString(), "Approved")
            If i < 4 Then
                dttask.Rows.Add("Wo 2", "Task " & i.ToString(), "Approved")
            ElseIf i >= 4 And i < 8 Then
                dttask.Rows.Add("Wo 4", "Task " & i.ToString(), "New")
            ElseIf i >= 8 And i < 12 Then
                dttask.Rows.Add("Wo 8", "Task " & i.ToString(), "Approved")
            ElseIf i >= 12 And i < 16 Then
                dttask.Rows.Add("Wo 12", "Task " & i.ToString(), "New")
            Else
                dttask.Rows.Add("Wo 18", "Task " & i.ToString(), "New")
            End If

        Next
        dgvTasks.DataSource = dttask
        dgvTasks.BestFitColumns()
        'dgvTasks.Columns("ProjectNo").IsVisible = False

    End Sub
    Public Sub ViewAllTasks()
        dgvTasks.DataSource = dttask
        dgvTasks.BestFitColumns()
        dttask.DefaultView.RowFilter = ""
    End Sub
    Private Sub dgvTasks_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvTasks.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvTasks.CurrentRow.Cells("TaskNo").Value Is Nothing) Then
                FormMain.frmTsk.filltask(dttask.Select("TaskNo = '" & dgvTasks.CurrentRow.Cells("TaskNo").Value.ToString() & "'")(0), dttask)
            End If
        End If
    End Sub

    Private Sub dgvTasks_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvTasks.CellDoubleClick
        FormMain.twTask.Show()
        FormMain.twTask.Select()
    End Sub
End Class
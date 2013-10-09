Imports Telerik.WinControls.UI

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
        dttask.Columns.Add("TaskName", GetType(String))
        dttask.Columns.Add("status", GetType(String))

        For i As Integer = 1 To 40
            'dt.Rows.Add("Task " & i.ToString(), "Approved")
            If i < 4 Then
                dttask.Rows.Add("Wo 1", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Approved")
            ElseIf i >= 4 And i < 8 Then
                dttask.Rows.Add("Wo 2", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Hold")
            ElseIf i >= 8 And i < 12 Then
                dttask.Rows.Add("Wo 3", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Approved")
            ElseIf i >= 12 And i < 16 Then
                dttask.Rows.Add("Wo 4", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "New")
            ElseIf i >= 16 And i < 22 Then
                dttask.Rows.Add("Wo 5", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Hold")
            ElseIf i >= 22 And i < 29 Then
                dttask.Rows.Add("Wo 6", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "New")
            ElseIf i >= 29 And i < 36 Then
                dttask.Rows.Add("Wo 7", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Approved")
            Else
                dttask.Rows.Add("Wo 8", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Hold")
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
                FormMain.frmTsk.filltask(dttask.Select("TaskNo = '" & dgvTasks.CurrentRow.Cells("TaskNo").Value.ToString() & "'")(0))
            End If
        End If
    End Sub

    Private Sub dgvTasks_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvTasks.CellDoubleClick
        FormMain.twTask.Show()
        FormMain.twTask.Select()
    End Sub

    Private Sub dgvTasks_ContextMenuOpening(sender As Object, e As Telerik.WinControls.UI.ContextMenuOpeningEventArgs) Handles dgvTasks.ContextMenuOpening
        Try
            If TypeOf e.ContextMenuProvider Is GridHeaderCellElement Then
                Dim BestFitAllMI As RadMenuItem = New RadMenuItem("BestFitAll")
                AddHandler BestFitAllMI.Click, AddressOf BestFitAllMI_Click
                e.ContextMenu.Items.Add(BestFitAllMI)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BestFitAllMI_Click(sender As Object, e As EventArgs)
        dgvTasks.BestFitColumns()
    End Sub

End Class
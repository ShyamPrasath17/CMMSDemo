Imports Telerik.WinControls.UI

Public Class frmTaskLists
    Public dttask_All As DataTable
    Dim frmloaded As Boolean = False
    Dim dt_tsk As DataTable
    Dim ArgArray As ArrayList
    Private Sub frmTaskLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        'createtable()
        dgvTasks.AllowAddNewRow = False
        dgvTasks.AllowEditRow = False
        dgvTasks.AllowDeleteRow = False
        frmloaded = True
    End Sub
    Public Sub SetTaskData(WoID As String)
        'If Not dt_tsk Is Nothing Then
        '    dt_tsk.Clear()
        '    dt_tsk.Dispose()
        '    GC.Collect()
        'End If
        If Not ArgArray Is Nothing Then
            ArgArray.Clear()
        End If
        ArgArray = New ArrayList
        ArgArray.Add("@WorkOrderNo") : ArgArray.Add(WoID.ToString()) : ArgArray.Add(DbType.String)
        dt_tsk = CMMSDAL.cls_EXE_STORED_PROCEDURE_PRAM(ArgArray, "CmmsTaskScmd").Tables(0)
        FormMain.frmTskLst.dgvTasks.DataSource = dt_tsk

        dt_tsk.Dispose()
        GC.Collect()
    End Sub

    Private Sub createtable()
        dttask_All = New DataTable()
        'dttask_All.Columns.Add("ProjectNo", GetType(String))
        dttask_All.Columns.Add("WorkOrderNo", GetType(String))
        dttask_All.Columns.Add("TaskNo", GetType(String))
        dttask_All.Columns.Add("TaskName", GetType(String))
        dttask_All.Columns.Add("status", GetType(String))

        For i As Integer = 1 To 40
            'dt.Rows.Add("Task " & i.ToString(), "Approved")
            If i < 4 Then
                dttask_All.Rows.Add("Wo 1", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Approved")
            ElseIf i >= 4 And i < 8 Then
                dttask_All.Rows.Add("Wo 2", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Hold")
            ElseIf i >= 8 And i < 12 Then
                dttask_All.Rows.Add("Wo 3", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Approved")
            ElseIf i >= 12 And i < 16 Then
                dttask_All.Rows.Add("Wo 4", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "New")
            ElseIf i >= 16 And i < 22 Then
                dttask_All.Rows.Add("Wo 5", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Hold")
            ElseIf i >= 22 And i < 29 Then
                dttask_All.Rows.Add("Wo 6", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "New")
            ElseIf i >= 29 And i < 36 Then
                dttask_All.Rows.Add("Wo 7", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Approved")
            Else
                dttask_All.Rows.Add("Wo 8", "Task " & i.ToString(), "Task " & i.ToString() & " Name", "Hold")
            End If

        Next
        dgvTasks.DataSource = dttask_All
        dgvTasks.BestFitColumns()
        'dgvTasks.Columns("ProjectNo").IsVisible = False

    End Sub

    Public Sub ViewAllTasks()
       
    End Sub
    Private Sub dgvTasks_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvTasks.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvTasks.CurrentRow.Cells("TaskID").Value Is Nothing) Then
                FormMain.frmTsk.filltask(dt_tsk.Select("TaskID = '" & dgvTasks.CurrentRow.Cells("TaskID").Value.ToString() & "'")(0))
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
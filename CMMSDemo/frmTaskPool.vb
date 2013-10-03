Imports Telerik.WinControls.UI

Public Class frmTaskPool
    Public dttemptask As DataTable
    Dim frmloaded As Boolean = False
    Dim PoolType_ As String = ""

    Sub New(PoolType As String)
        InitializeComponent()
        PoolType_ = PoolType
    End Sub
    Private Sub frmIndependentTaskPool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        createtable()
        dgvIndepSchedTaskList.AllowAddNewRow = False
        dgvIndepSchedTaskList.AllowEditRow = False
        dgvIndepSchedTaskList.AllowDeleteRow = False
        dgvIndepSchedTaskList.DataSource = dttemptask.DefaultView

        If dgvIndepSchedTaskList.Columns.Contains("btncol") Then
            dgvIndepSchedTaskList.Columns.Remove("btncol")
        End If
        Dim btncol As GridViewCommandColumn = New GridViewCommandColumn()
        btncol.Name = "btncol"
        btncol.HeaderText = "Attach"
        btncol.DefaultText = "Attach to work order"
        btncol.UseDefaultText = True
        btncol.AutoEllipsis = True
        dgvIndepSchedTaskList.Columns.Insert(2, btncol)
        dgvIndepSchedTaskList.BestFitColumns()

        If PoolType_ = "Independent" Then
            dttemptask.DefaultView.RowFilter = "PoolType = 'Independent'"
        ElseIf PoolType_ = "ScheduledMaintanance" Then
            dttemptask.DefaultView.RowFilter = "PoolType = 'ScheduledMaintanance'"
        Else
            dttemptask.DefaultView.RowFilter = ""
        End If
        frmloaded = True
    End Sub

    Private Sub createtable()
        dttemptask = New DataTable()
        dttemptask.Columns.Add("TaskNo", GetType(String))
        dttemptask.Columns.Add("PoolType", GetType(String))
        dttemptask.Columns.Add("status", GetType(String))
        For i As Integer = 30 To 45
            If i < 35 Then
                dttemptask.Rows.Add("Task " & i.ToString(), "ScheduledMaintanance", "Pending")
            ElseIf i >= 35 And i < 41 Then
                dttemptask.Rows.Add("Task " & i.ToString(), "Independent", "Pending")
            Else
                dttemptask.Rows.Add("Task " & i.ToString(), "ScheduledMaintanance", "Pending")
            End If
        Next

    End Sub
End Class
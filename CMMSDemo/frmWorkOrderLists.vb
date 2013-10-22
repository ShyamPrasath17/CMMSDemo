Public Class frmWorkOrderLists
    Public dtWo As DataTable
    Dim frmloaded As Boolean = False
    Dim dt_tsk As DataTable
    Dim ArgArray As ArrayList

    Private Sub frmWorkOrderLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        'createtable()
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
        dtWo.Columns.Add("Symptoms", GetType(String))
        dtWo.Columns.Add("Leader", GetType(String))
        dtWo.Columns.Add("status", GetType(String))
        For i As Integer = 1 To 15
            If i < 4 Then
                dtWo.Rows.Add("Project 1", "Wo " & i.ToString(), "service " + i.ToString(), "Perfomance issues", "Tom", "Approved")
            ElseIf i >= 4 And i < 8 Then
                dtWo.Rows.Add("Project 2", "Wo " & i.ToString(), "service " + i.ToString(), "Low Output Quality", "Raj", "New")
            ElseIf i >= 8 And i < 12 Then
                dtWo.Rows.Add("Project 3", "Wo " & i.ToString(), "service " + i.ToString(), "Damages Found", "Xyz", "Approved")
            Else
                dtWo.Rows.Add("Project 6", "Wo " & i.ToString(), "service " + i.ToString(), "Unusual Noise in machine", "Abc", "New")
            End If
        Next
        dgvWo.DataSource = dtWo.Copy()
        dgvWo.BestFitColumns()
    End Sub

    Public Sub ViewAllWorkOrders()
        dgvWo.DataSource = dtWo
        dgvWo.BestFitColumns()
    End Sub

    Private Sub dgvWo_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvWo.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                'FormMain.frmwo.fillworkorder(dtWo.Select("WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0), dtWo)
                'Dim dtTask As DataTable = FormMain.frmTskLst.dttask
                'dtTask.DefaultView.RowFilter = "WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'"
                'FormMain.frmTskLst.dgvTasks.DataSource = dtTask.DefaultView

                'If Not dt_tsk Is Nothing Then
                '    dt_tsk.Clear()
                '    dt_tsk.Dispose()
                '    GC.Collect()
                'End If

                If Not ArgArray Is Nothing Then
                    ArgArray.Clear()
                End If
                ArgArray = New ArrayList
                ArgArray.Add("@WorkOrderNo") : ArgArray.Add(Me.dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString()) : ArgArray.Add(DbType.String)
                dt_tsk = CMMSDAL.cls_EXE_STORED_PROCEDURE_PRAM(ArgArray, "CmmsTaskScmd").Tables(0)
                FormMain.frmTskLst.dgvTasks.DataSource = dt_tsk


                dt_tsk.Dispose()
                GC.Collect()
            End If
        End If
    End Sub
    Public Sub Viewall_Wo()
        dgvWo.DataSource = dtWo
        dgvWo.BestFitColumns()
    End Sub

    Private Sub dgvWo_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvWo.CellDoubleClick
        FormMain.ToolWindowWo.Show()
        FormMain.ToolWindowWo.Select()
    End Sub

    Private Sub dgvWo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvWo.SelectionChanged
        If (frmloaded) Then
            If (Not dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                'FormMain.frmwo.fillworkorder(dtWo.Select("WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0), dtWo)
                'Dim dtTask As DataTable = FormMain.frmTskLst.dttask
                'dtTask.DefaultView.RowFilter = "WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'"
                'FormMain.frmTskLst.dgvTasks.DataSource = dtTask.DefaultView

            End If
        End If
    End Sub

End Class
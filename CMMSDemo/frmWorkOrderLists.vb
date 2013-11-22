Public Class frmWorkOrderLists
    Public dtWo_All As DataTable
    Dim frmloaded As Boolean = False
    Dim dt_wo As DataTable
    Dim ArgArray As ArrayList
    Public connstring As String

    Private Sub frmWorkOrderLists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        'createtable()
        frmloaded = True
        dgvWo.AllowAddNewRow = False
        dgvWo.AllowEditRow = False
        dgvWo.AllowDeleteRow = False
    End Sub

    Private Sub createtable()
        dtWo_All = New DataTable()
        dtWo_All.Columns.Add("ProjectNo", GetType(String))
        dtWo_All.Columns.Add("WorkOrderNo", GetType(String))
        dtWo_All.Columns.Add("WorkOrderName", GetType(String))
        dtWo_All.Columns.Add("Symptoms", GetType(String))
        dtWo_All.Columns.Add("Leader", GetType(String))
        dtWo_All.Columns.Add("status", GetType(String))
        For i As Integer = 1 To 15
            If i < 4 Then
                dtWo_All.Rows.Add("Project 1", "Wo " & i.ToString(), "service " + i.ToString(), "Perfomance issues", "Tom", "Approved")
            ElseIf i >= 4 And i < 8 Then
                dtWo_All.Rows.Add("Project 2", "Wo " & i.ToString(), "service " + i.ToString(), "Low Output Quality", "Raj", "New")
            ElseIf i >= 8 And i < 12 Then
                dtWo_All.Rows.Add("Project 3", "Wo " & i.ToString(), "service " + i.ToString(), "Damages Found", "Xyz", "Approved")
            Else
                dtWo_All.Rows.Add("Project 6", "Wo " & i.ToString(), "service " + i.ToString(), "Unusual Noise in machine", "Abc", "New")
            End If
        Next
        dgvWo.DataSource = dtWo_All.Copy()
        dgvWo.BestFitColumns()
    End Sub

    Public Sub ViewAllWorkOrders()
       
    End Sub

    Public Sub SetWoData(ProjectID As String)
        'If Not dt_wo Is Nothing Then
        '    dt_wo.Clear()
        '    dt_wo.Dispose()
        '    GC.Collect()
        'End If

        If Not ArgArray Is Nothing Then
            ArgArray.Clear()
        End If

        ArgArray = New ArrayList
        ArgArray.Add("@ProjectID") : ArgArray.Add(ProjectID.ToString()) : ArgArray.Add(DbType.String)
        CMMSDAL.strConn = connstring
        dt_wo = CMMSDAL.cls_EXE_STORED_PROCEDURE_PRAM(ArgArray, "CmmsWoScmd").Tables(0)
        FormMain.frmwolst.dgvWo.DataSource = dt_wo
        dgvWo.BestFitColumns()
    End Sub

    Public Sub SetTypedWoData(Type As String)
        'If Not dt_wo Is Nothing Then
        '    dt_wo.Clear()
        '    dt_wo.Dispose()
        '    GC.Collect()
        'End If

        If Not ArgArray Is Nothing Then
            ArgArray.Clear()
        End If

        ArgArray = New ArrayList
        ArgArray.Add("@CreateType") : ArgArray.Add(Type.ToString()) : ArgArray.Add(DbType.String)
        CMMSDAL.strConn = connstring
        dt_wo = CMMSDAL.cls_EXE_STORED_PROCEDURE_PRAM(ArgArray, "CmmsSelTypedWocmd").Tables(0)
        FormMain.frmwolst.dgvWo.DataSource = dt_wo
        dgvWo.BestFitColumns()
    End Sub

    Private Sub dgvWo_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvWo.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                FormMain.frmwo.fillworkorder(dt_wo.Select("WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0))
                FormMain.frmTskLst.SetTaskData(dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString())
            End If
        End If
    End Sub
    Public Sub Viewall_Wo()
        dgvWo.DataSource = dtWo_All
        dgvWo.BestFitColumns()
    End Sub

    Private Sub dgvWo_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvWo.CellDoubleClick
        FormMain.ToolWindowWo.DefaultFloatingSize = New Size(700, 650)
        FormMain.RadDockMain.FloatWindow(FormMain.ToolWindowWo)
        'FormMain.ToolWindowWo.Show()
        FormMain.ToolWindowWo.Select()
    End Sub

    Private Sub dgvWo_SelectionChanged(sender As Object, e As EventArgs) Handles dgvWo.SelectionChanged
        'If (frmloaded) Then
        '    If (Not dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
        '        'FormMain.frmwo.fillworkorder(dtWo.Select("WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0), dtWo)
        '        'Dim dtTask As DataTable = FormMain.frmTskLst.dttask
        '        'dtTask.DefaultView.RowFilter = "WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'"
        '        'FormMain.frmTskLst.dgvTasks.DataSource = dtTask.DefaultView

        '    End If
        'End If
    End Sub

End Class
﻿Public Class frmWorkOrderLists
    Dim dt As DataTable
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
        dt = New DataTable()
        dt.Columns.Add("WorkOrderNo", GetType(String))
        dt.Columns.Add("WorkOrderName", GetType(String))
        dt.Columns.Add("ServiceType", GetType(String))
        dt.Columns.Add("status", GetType(String))

        For i As Integer = 1 To 10
            dt.Rows.Add("Wo " & i.ToString(), "service " + i.ToString(), "102" + i.ToString(), "Approved")
        Next
        dgvWo.DataSource = dt
    End Sub

    Private Sub dgvWo_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvWo.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                FormMain.frmwo.fillworkorder(dt.Select("WorkOrderNo = '" & dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0), dt)
            End If
        End If
    End Sub

    Private Sub dgvWo_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvWo.CellDoubleClick
        'FormMain.RadDockMain.DockWindow(FormMain.ToolWindowWo, Telerik.WinControls.UI.Docking.DockPosition.Left)
        FormMain.ToolWindowWo.Show()
        FormMain.ToolWindowWo.Select()
    End Sub
End Class
﻿Public Class frmProjectList
    Dim dtProject As DataTable
    Dim frmloaded As Boolean = False
    Private Sub dgvProjectList_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvProjectList.CellDoubleClick
        FormMain.twProject.Show()
        FormMain.twProject.Select()
    End Sub

    Private Sub dgvProjectList_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvProjectList.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvProjectList.CurrentRow.Cells("ProjectNo").Value Is Nothing) Then
                FormMain.frmProj.fillProject(dtProject.Select("ProjectNo = '" & dgvProjectList.CurrentRow.Cells("ProjectNo").Value.ToString() & "'")(0), dtProject)
                Dim dt_wo As DataTable = FormMain.frmwolst.dtWo.Copy()
                dt_wo.DefaultView.RowFilter = "ProjectNo = '" & dgvProjectList.CurrentRow.Cells("ProjectNo").Value.ToString() & "'"
                Dim dttask_copy As DataTable = FormMain.frmTskLst.dttask.Copy()
                dttask_copy.Clear()
                FormMain.frmTskLst.dgvTasks.DataSource = dttask_copy
                FormMain.frmwolst.dgvWo.DataSource = dt_wo.DefaultView
            End If
        End If
    End Sub

    Private Sub frmProjectList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        createtable()
        frmloaded = True
        dgvProjectList.AllowAddNewRow = False
        dgvProjectList.AllowEditRow = False
        dgvProjectList.AllowDeleteRow = False
    End Sub
    Private Sub createtable()
        dtProject = New DataTable()
        'dt.Columns.Add("Project", GetType(String))
        'dt.Columns.Add("WorkOrder", GetType(String))
        dtProject.Columns.Add("ProjectNo", GetType(String))
        'dt.Columns.Add("ServiceType", GetType(String))
        dtProject.Columns.Add("status", GetType(String))

        For i As Integer = 1 To 10
            dtProject.Rows.Add("Project " & i.ToString(), "Approved")
        Next
        dgvProjectList.DataSource = dtProject

    End Sub

End Class
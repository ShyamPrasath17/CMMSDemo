Public Class frmProjectList
    Dim dtProject As DataTable
    Dim frmloaded As Boolean = False
    Public connstring As String
   
    Private Sub dgvProjectList_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvProjectList.CellDoubleClick
        FormMain.twProject.Show()
        FormMain.twProject.Select()
    End Sub

    Private Sub dgvProjectList_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvProjectList.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvProjectList.CurrentRow.Cells("ProjectID").Value Is Nothing) Then
                FormMain.frmProj.fillProject(dtProject.Select("ProjectID = '" & dgvProjectList.CurrentRow.Cells("ProjectID").Value.ToString() & "'")(0), dtProject)
                FormMain.frmwolst.SetWoData(dgvProjectList.CurrentRow.Cells("ProjectID").Value.ToString())


                '    Dim dt_wo As DataTable = FormMain.frmwolst.dtWo.Copy()
                '    dt_wo.DefaultView.RowFilter = "ProjectNo = '" & dgvProjectList.CurrentRow.Cells("ProjectNo").Value.ToString() & "'"
                '    Dim dttask_copy As DataTable = FormMain.frmTskLst.dttask.Copy()
                '    dttask_copy.Clear()
                '    FormMain.frmTskLst.dgvTasks.DataSource = dttask_copy
                '    FormMain.frmwolst.dgvWo.DataSource = dt_wo.DefaultView
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
        CMMSDAL.strConn = connstring
        dtProject = CMMSDAL.cls_EXE_STORED_PROCEDURE("CmmsProjectScmd").Tables(0)

        dgvProjectList.DataSource = dtProject
        dgvProjectList.BestFitColumns()

    End Sub

End Class
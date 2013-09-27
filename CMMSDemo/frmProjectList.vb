Public Class frmProjectList
    Dim dt As DataTable
    Dim frmloaded As Boolean = False
    Private Sub dgvProjectList_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvProjectList.CellDoubleClick
        FormMain.twProject.Show()
        FormMain.twProject.Select()
    End Sub

    Private Sub dgvProjectList_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvProjectList.CurrentRowChanged
        If (frmloaded) Then
            If (Not dgvProjectList.CurrentRow.Cells("ProjectNo").Value Is Nothing) Then
                FormMain.frmProj.fillProject(dt.Select("ProjectNo = '" & dgvProjectList.CurrentRow.Cells("ProjectNo").Value.ToString() & "'")(0), dt)
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
        dt = New DataTable()
        'dt.Columns.Add("Project", GetType(String))
        'dt.Columns.Add("WorkOrder", GetType(String))
        dt.Columns.Add("ProjectNo", GetType(String))
        'dt.Columns.Add("ServiceType", GetType(String))
        dt.Columns.Add("status", GetType(String))

        For i As Integer = 1 To 10
            dt.Rows.Add("Project " & i.ToString(), "Approved")
        Next
        dgvProjectList.DataSource = dt
    End Sub
End Class
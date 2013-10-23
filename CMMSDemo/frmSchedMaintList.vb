Public Class frmSchedMaintList
    Public dtSml As DataTable
    Dim frmloaded As Boolean = False
    Private Sub frmSchedMaintList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        createtable()
        frmloaded = True
        dgvSchedMaint.AllowAddNewRow = False
        dgvSchedMaint.AllowEditRow = False
        dgvSchedMaint.AllowDeleteRow = False
    End Sub

    Private Sub createtable()
        dtSml = New DataTable()
        dtSml.Columns.Add("MaintananceID", GetType(String))
        dtSml.Columns.Add("Name", GetType(String))
        dtSml.Columns.Add("Asset", GetType(String))
        dtSml.Columns.Add("Description", GetType(String))
        dtSml.Columns.Add("RecurrenceType", GetType(String))
        dtSml.Columns.Add("Status", GetType(String))

        dtSml.Rows.Add("Maintanance 1", "Oil Change to car", "Car 001", "", "Meter Reading", "New")
        dtSml.Rows.Add("Maintanance 2", "Clean Mechine 2", "Mechine 002", "", "TimeBased", "Approved")
        dtSml.Rows.Add("Maintanance 3", "Name 3", "Asset A", "", "TimeBased", "Approved")
        dtSml.Rows.Add("Maintanance 4", "Name 4", "Asset B", "", "Meter Reading", "New")
        dtSml.Rows.Add("Maintanance 5", "Name 5", "Asset C", "", "Meter Reading", "Approved")

        dgvSchedMaint.DataSource = dtSml.Copy()
        dgvSchedMaint.BestFitColumns()
    End Sub

    Private Sub dgvSchedMaint_CurrentRowChanged(sender As Object, e As Telerik.WinControls.UI.CurrentRowChangedEventArgs) Handles dgvSchedMaint.CurrentRowChanged
        If (frmloaded) Then
            FormMain.frmSched.fillSched(dtSml.Select("MaintananceID = '" & dgvSchedMaint.CurrentRow.Cells("MaintananceID").Value.ToString() & "'")(0))
        End If
    End Sub

    Private Sub dgvSchedMaint_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles dgvSchedMaint.CellDoubleClick
        FormMain.TwScheduledMaint.Show()
        FormMain.TwScheduledMaint.Select()
    End Sub
End Class
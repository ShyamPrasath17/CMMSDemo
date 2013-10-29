Public Class frmAssets
    Dim dtmeter As DataTable
    Dim dtmaint As DataTable

    Private Sub txtAddReading_Click(sender As Object, e As EventArgs) Handles txtAddReading.Click
        Dim frmmeter As frmMeterReading = New frmMeterReading()
        frmmeter.ShowDialog()
    End Sub

    Private Sub frmAssets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtmeter = New DataTable()
        dtmeter.Columns.Add("UserID", GetType(String))
        dtmeter.Columns.Add("DateTime", GetType(String))
        dtmeter.Columns.Add("Meter", GetType(String))
        dtmeter.Columns.Add("Value", GetType(String))
        dgvmeter.DataSource = dtmeter
        dgvmeter.AllowAddNewRow = False
        dgvmeter.AllowDeleteRow = False
        dgvmeter.AllowEditRow = False
        dgvmeter.BestFitColumns()
    End Sub
End Class
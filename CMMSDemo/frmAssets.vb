Public Class frmAssets
    Dim dtmeter As DataTable
    Dim dtmaint As DataTable
    Private Sub txtAddMaintanance_Click(sender As Object, e As EventArgs) Handles txtAddMaintanance.Click
        Dim frmmaint As frmAssetMaintanance = New frmAssetMaintanance()
        frmmaint.ShowDialog()
    End Sub

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


        dtmaint = New DataTable()
        dtmaint.Columns.Add("Service Type", GetType(String))
        dtmaint.Columns.Add("Service", GetType(String))
        dtmaint.Columns.Add("Do Maintanance for Every", GetType(String))
        dtmaint.Columns.Add("UOM", GetType(String))
        dgvAssetmaint.DataSource = dtmaint
        dgvAssetmaint.AllowAddNewRow = False
        dgvAssetmaint.AllowDeleteRow = False
        dgvAssetmaint.AllowEditRow = False
        dgvAssetmaint.BestFitColumns()
    End Sub
End Class
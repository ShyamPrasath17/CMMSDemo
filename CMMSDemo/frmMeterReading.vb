Public Class frmMeterReading
    Dim dtType As DataTable
    Private Sub frmMeterReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createTypeTbl()
        cmbrptUom.DataSource = dtType.DefaultView
        cmbrptUom.DisplayMember = "UOM"
    End Sub
    Private Sub createTypeTbl()
        dtType = New DataTable()
        dtType.Columns.Add("UOM", GetType(String))
        dtType.Rows.Add("Productive Hours")
        dtType.Rows.Add("Productive Days")
        dtType.Rows.Add("Kms")
        dtType.Rows.Add("Meters")
        dtType.Rows.Add("Cycles")
    End Sub
End Class
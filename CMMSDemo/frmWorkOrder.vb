Public Class frmWorkOrder

    Private Sub WorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub fillworkorder(dr As DataRow)
        txtwono.Text = dr("WorkOrderNo").ToString()
        txtarea.Text = dr("areaID").ToString()
        txtsertype.Text = dr("ServiceType").ToString()
        txtstatus.Text = dr("status").ToString()
    End Sub
End Class
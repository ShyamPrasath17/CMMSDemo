Public Class frmWorkOrder

    Private Sub WorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub fillworkorder(ByRef dr As DataRow, ByRef dt As DataTable)
        txtwono.Text = dr("WorkOrderNo").ToString()
        Cmbsertype.Text = dr("ServiceType").ToString()
        txtstatus.Text = dr("status").ToString()
    End Sub

    Private Sub BtnAddWo_Click(sender As Object, e As EventArgs) Handles BtnAddWo.Click
       
    End Sub

    Private Sub chkBillable_CheckedChanged(sender As Object, e As EventArgs) Handles chkBillable.CheckedChanged
        If chkBillable.Checked Then
            lblCust.Enabled = True
            txtcust.Enabled = True
            Sercust.Enabled = True
        Else
            lblCust.Enabled = False
            txtcust.Enabled = False
            Sercust.Enabled = False
        End If
    End Sub
End Class
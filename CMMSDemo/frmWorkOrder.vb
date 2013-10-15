Public Class frmWorkOrder
    Dim dtcomment As DataTable

    Private Sub WorkOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkBillable.Checked = True

        dtcomment = New DataTable()
        dtcomment.Columns.Add("UserID", GetType(String))
        dtcomment.Columns.Add("Date", GetType(DateTime))
        dtcomment.Columns.Add("Comment", GetType(String))

        dgvComment.DataSource = dtcomment
        dgvComment.BestFitColumns()
    End Sub

    Public Sub fillworkorder(ByRef dr As DataRow, ByRef dt As DataTable)
        txtwono.Text = dr("WorkOrderNo").ToString()
        'Cmbsertype.Text = dr("ServiceType").ToString()
        txtstatus.Text = dr("status").ToString()
    End Sub

    Private Sub BtnAddWo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub chkBillable_CheckedChanged(sender As Object, e As EventArgs) Handles chkBillable.CheckedChanged
        If chkBillable.Checked Then
            grpBillable.Enabled = True
        Else
            grpBillable.Enabled = False
        End If
    End Sub

    Private Sub RadScrollablePanel1_PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles RadScrollablePanel1.PanelContainer.Paint

    End Sub
End Class
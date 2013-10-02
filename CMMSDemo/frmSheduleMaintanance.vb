Public Class frmSheduleMaintanance

    Private Sub radTimeBased_CheckedChanged(sender As Object, e As EventArgs) Handles radTimeBased.CheckedChanged
        grpSubType.Enabled = True
    End Sub

    Private Sub radMeter_CheckedChanged(sender As Object, e As EventArgs) Handles radMeter.CheckedChanged
        grpSubType.Enabled = False
    End Sub

    Private Sub frmSheduleMaintanance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radTimeBased.Checked = True
    End Sub
End Class
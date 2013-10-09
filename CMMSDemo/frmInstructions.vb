Public Class frmInstructions


    Private Sub frmInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radPredefined.Checked = True
    End Sub

    Private Sub radPredefined_CheckedChanged(sender As Object, e As EventArgs) Handles radPredefined.CheckedChanged
        If radPredefined.Checked Then
            txtInstruction.ReadOnly = True
            btnfind.Enabled = True
        End If
    End Sub

    Private Sub radNonPredefined_CheckedChanged(sender As Object, e As EventArgs) Handles radNonPredefined.CheckedChanged
        If radNonPredefined.Checked Then
            txtInstruction.ReadOnly = False
            btnfind.Enabled = False
        End If
    End Sub
End Class
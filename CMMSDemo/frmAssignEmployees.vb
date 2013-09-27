Public Class frmAssignEmployees

    Private Sub frmAssignEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radInternal.Checked = True
    End Sub

    Private Sub radInternal_CheckedChanged(sender As Object, e As EventArgs) Handles radInternal.CheckedChanged
        If radInternal.Checked Then
            grpInternalEmp.Visible = True
            grpOutSource.Visible = False
        End If
    End Sub

    Private Sub radOutsourced_CheckedChanged(sender As Object, e As EventArgs) Handles radOutsourced.CheckedChanged
        If radOutsourced.Checked Then
            grpOutSource.Visible = True
            grpInternalEmp.Visible = False
        End If
    End Sub

    Private Sub btnOutSource_Click(sender As Object, e As EventArgs) Handles btnOutSource.Click
        Dim frmou As frmOutsource = New frmOutsource()
        frmou.ShowDialog()
    End Sub
End Class
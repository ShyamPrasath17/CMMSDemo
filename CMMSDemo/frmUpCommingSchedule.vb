Public Class frmUpCommingSchedule

    Private Sub ChkFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFilter.CheckedChanged
        If ChkFilter.Checked Then
            grpfilter.Enabled = True
        Else
            grpfilter.Enabled = False
        End If

    End Sub

    Private Sub frmUpCommingSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
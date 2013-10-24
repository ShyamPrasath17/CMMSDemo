Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstUsers.SelectedIndex = 0
        LstItems.SelectedIndex = 0
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

    End Sub

    Private Sub chkNotify_CheckedChanged(sender As Object, e As EventArgs)
        'If chkNotify.Checked Then
        '    grpNotify.Enabled = True
        'Else
        '    grpNotify.Enabled = False
        'End If
    End Sub

    Private Sub ChkIsEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles ChkIsEmployee.CheckedChanged
        If ChkIsEmployee.Checked Then
            grpEmployee.Enabled = True
        Else
            grpEmployee.Enabled = False
        End If
    End Sub

End Class
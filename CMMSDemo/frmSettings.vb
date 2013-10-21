Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstUsers.SelectedIndex = 0
        LstItems.SelectedIndex = 0
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        CMMSDAL.strConn = txtConn.Text.Trim()
    End Sub
End Class
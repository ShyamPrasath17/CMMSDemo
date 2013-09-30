Public Class frmProject

    Private Sub frmProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
    End Sub
    Public Sub fillProject(ByRef dr As DataRow, ByRef dt As DataTable)
        txtprojectID.Text = dr("ProjectNo").ToString()
        txtstatus.Text = dr("status").ToString()
    End Sub

    Private Sub BtnAddWo_Click(sender As Object, e As EventArgs)

    End Sub
End Class
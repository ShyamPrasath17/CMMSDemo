Imports System.Data.SqlClient
Public Class frmLogin
    Private Shared cn As SqlConnection
    Public strConn_ As String
    Public state As String
    Public connstring As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            strConn_ = "Data Source=" + txtDataSource.Text + ";Initial Catalog=" + txtInitialCatalog.Text + ";Persist Security Info=True;User ID=" + txtUser.Text + ";Password=" + txtPass.Text
            cn = New SqlClient.SqlConnection(strConn_)
            cn.Open()
            If cn.State = ConnectionState.Open Then
                state = "Success"
                Me.Close()
            Else
                state = "failed"
            End If

        Catch ex As Exception
            MessageBox.Show("Wrong Connection")

        End Try

    End Sub
End Class
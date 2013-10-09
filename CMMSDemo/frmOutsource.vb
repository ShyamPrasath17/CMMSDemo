Public Class frmOutsource
    Dim Type_ As String

    Sub New(Type As String)
        InitializeComponent()
        Type_ = Type
    End Sub
    Private Sub frmOutsource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Type_ = "Employee" Then
            Me.Text = "Outsource Employee"
            txtQty.ReadOnly = True
            txtQty.Text = 1
            'lblQty.Visible = False
            cmbOutSourceType.SelectedIndex = 0
        ElseIf Type_ = "Equipment" Then
            Me.Text = "Outsource Equipment"
            txtQty.Visible = True
            txtQty.ReadOnly = False
            'lblQty.Visible = True
            txtQty.Text = 1
            cmbOutSourceType.SelectedIndex = 1
        Else
            Me.Text = "Outsource Task"
            txtQty.Visible = False
            'lblQty.Visible = False
            txtQty.ReadOnly = True
            txtQty.Text = 1
            cmbOutSourceType.SelectedIndex = 2
        End If
    End Sub
End Class
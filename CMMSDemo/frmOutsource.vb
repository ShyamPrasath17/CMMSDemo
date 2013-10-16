Public Class frmOutsource
    Dim Type_ As String

    Sub New(Type As String)
        InitializeComponent()
        Type_ = Type
    End Sub
    Private Sub frmOutsource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Type_ = "Employee" Then
            Me.Text = "Outsource Labour"
            chkDurationBasedCost.Checked = True
            chkDurationBasedCost.Enabled = False
            'txtQty.ReadOnly = True
            'txtQty.Text = 1
            'lblQty.Visible = False
            cmbOutSourceType.SelectedIndex = 0
        ElseIf Type_ = "Equipment" Then
            Me.Text = "Outsource Equipment"
            chkDurationBasedCost.Checked = False
            chkDurationBasedCost.Enabled = True
            'txtQty.Visible = True
            'txtQty.ReadOnly = False
            ''lblQty.Visible = True
            'txtQty.Text = 1
            grpDurationBased.Enabled = False
            cmbOutSourceType.SelectedIndex = 1
        Else
            Me.Text = "Outsource Task"
            chkDurationBasedCost.Checked = False
            chkDurationBasedCost.Enabled = True
            'txtQty.Visible = False
            ''lblQty.Visible = False
            'txtQty.ReadOnly = True
            'txtQty.Text = 1
            cmbOutSourceType.SelectedIndex = 2
        End If
    End Sub

    Private Sub chkDurationBasedCost_CheckedChanged(sender As Object, e As EventArgs) Handles chkDurationBasedCost.CheckedChanged
        If chkDurationBasedCost.Checked Then
            grpDurationBased.Enabled = True
        Else
            grpDurationBased.Enabled = False
        End If
    End Sub
End Class
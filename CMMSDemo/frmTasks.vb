Public Class frmTasks

    Private Sub BtnAddWo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub radInternal_CheckedChanged(sender As Object, e As EventArgs) Handles radInternal.CheckedChanged
        If radInternal.Checked Then
            grpSite.Visible = True
            grpItems.Visible = True
            grpOutSource.Visible = False
        End If
    End Sub

    Private Sub radOutsourced_CheckedChanged(sender As Object, e As EventArgs) Handles radOutsourced.CheckedChanged
        If radOutsourced.Checked Then
            grpOutSource.Visible = True
            grpSite.Visible = False
            grpItems.Visible = False
        End If
    End Sub

    Private Sub frmTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radInternal.Checked = True
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Dim frmemp As frmAssignEmployees = New frmAssignEmployees()
        frmemp.ShowDialog()
    End Sub

    Private Sub btnEquipments_Click(sender As Object, e As EventArgs) Handles btnEquipments.Click
        Dim frmEquipment As frmAssignEquipments = New frmAssignEquipments()
        frmEquipment.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim frmItems As frmInventoryItems = New frmInventoryItems()
        frmItems.ShowDialog()
    End Sub
    Public Sub filltask(ByRef dr As DataRow, ByRef dt As DataTable)
        txtTaskID.Text = dr("TaskNo").ToString()
        txtstatus.Text = dr("status").ToString()
    End Sub

    Private Sub btnOutSource_Click(sender As Object, e As EventArgs) Handles btnOutSource.Click
        Dim frmoutsource As frmOutsource = New frmOutsource()
        frmoutsource.ShowDialog()
    End Sub
End Class
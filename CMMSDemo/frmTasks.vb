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
    Public Sub filltask(ByRef dr As DataRow)
        txtTaskID.Text = dr("TaskID").ToString()
        txtTaskName.Text = dr("TaskName").ToString()
        'txtstatus.Text = dr("Status").ToString()
        txtwono.Text = dr("WorkOrderNo").ToString()
    End Sub

    Private Sub btnOutSource_Click(sender As Object, e As EventArgs) Handles btnOutSource.Click
        Dim frmoutsource As frmOutsource = New frmOutsource("Task")
        frmoutsource.ShowDialog()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        Dim frmins As frmInstructions = New frmInstructions()
        frmins.ShowDialog()
    End Sub
End Class
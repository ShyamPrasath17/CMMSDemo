Public Class FormMain
    Public frmwolst As frmWorkOrderLists
    Public frmwo As frmWorkOrder
    Public frmtasklst As frmTaskLists
    Public frmtask As frmTasks
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addWoLst()
        addwofrm()
        addtaskfrm()
        addtasklstfrm()
    End Sub

    Private Sub addwofrm()
        frmwo = New frmWorkOrder()
        frmwo.Dock = DockStyle.Fill
        frmwo.TopLevel = False
        frmwo.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmwo.Show()
        ToolWindowWo.Controls.Add(frmwo)
    End Sub
    Private Sub addtaskfrm()
        frmtask = New frmTasks()
        frmtask.Dock = DockStyle.Fill
        frmtask.TopLevel = False
        frmtask.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmtask.Show()
        ToolWindowTask.Controls.Add(frmtask)
    End Sub
    Private Sub addtasklstfrm()
        frmtasklst = New frmTaskLists()
        frmtasklst.Dock = DockStyle.Fill
        frmtasklst.TopLevel = False
        frmtasklst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmtasklst.Show()
        ToolWindowTaskLst.Controls.Add(frmtasklst)
    End Sub

    Private Sub addWoLst()
        frmwolst = New frmWorkOrderLists()
        frmwolst.Dock = DockStyle.Fill
        frmwolst.TopLevel = False
        frmwolst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmwolst.Show()
        ToolWindowWoLst.Controls.Add(frmwolst)
    End Sub

End Class
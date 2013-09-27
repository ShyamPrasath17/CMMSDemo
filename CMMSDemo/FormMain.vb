Public Class FormMain
    Public frmwolst As frmWorkOrderLists
    Public frmwo As frmWorkOrder
    Public frmtasklst As frmTaskLists
    Public frmtask As frmTasks
    Public frmProject As frmProject
    Public frmProjectLst As frmProjectList

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addWoLst()
        addwofrm()
        addTaskListfrm()
        addTaskfrm()
        addProjectListfrm()
        addProjectfrm()

        'ToolWindowWo.Hide()
        'ToolWindowWoLst.Hide()
        'ToolWindowProject.Hide()
        'ToolWindowProjectLst.Hide()
        'ToolWindowTask.Hide()
        'ToolWindowTaskLst.Hide()

        SplitContainer1.SplitterDistance = SplitContainer1.Height - 800
        SplitContainer1.FixedPanel = FixedPanel.Panel1


        SplitContainer2.SplitterDistance = SplitContainer2.Height - 900
        SplitContainer2.FixedPanel = FixedPanel.Panel1
    End Sub
    Private Sub addProjectListfrm()
        frmProjectLst = New frmProjectList()
        frmProjectLst.Dock = DockStyle.Fill
        frmProjectLst.TopLevel = False
        frmProjectLst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmProjectLst.Show()
        ToolWindowProjectLst.Controls.Add(frmProjectLst)
    End Sub
    Private Sub addProjectfrm()
        frmProject = New frmProject()
        frmProject.Dock = DockStyle.Fill
        frmProject.TopLevel = False
        frmProject.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmProject.Show()
        ToolWindowProject.Controls.Add(frmProject)
    End Sub
    Private Sub addTaskListfrm()
        frmtasklst = New frmTaskLists()
        frmtasklst.Dock = DockStyle.Fill
        frmtasklst.TopLevel = False
        frmtasklst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmtasklst.Show()
        ToolWindowTaskLst.Controls.Add(frmtasklst)
    End Sub
    Private Sub addTaskfrm()
        frmtask = New frmTasks()
        frmtask.Dock = DockStyle.Fill
        frmtask.TopLevel = False
        frmtask.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmtask.Show()
        ToolWindowTask.Controls.Add(frmtask)
    End Sub
    Private Sub addwofrm()
        frmwo = New frmWorkOrder()
        frmwo.Dock = DockStyle.Fill
        frmwo.TopLevel = False
        frmwo.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmwo.Show()
        ToolWindowWo.Controls.Add(frmwo)
    End Sub

    Private Sub addWoLst()
        frmwolst = New frmWorkOrderLists()
        frmwolst.Dock = DockStyle.Fill
        frmwolst.TopLevel = False
        frmwolst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmwolst.Show()
        ToolWindowWoLst.Controls.Add(frmwolst)
    End Sub

    Private Sub btnViewProject_Click(sender As Object, e As EventArgs) Handles btnViewProject.Click

    End Sub
End Class
Public Class FormMain



    Public frmwolst As frmWorkOrderLists
    Public frmwo As frmWorkOrder

    Public frmProjLst As frmProjectList
    Public frmProj As frmProject

    Public frmTskLst As frmTaskLists
    Public frmTsk As frmTasks



    Dim frmDashBoard As frmDashBoard

    Sub New()
        addDashBoardFrm()
        addWoLst()
        addwofrm()
        addfrmProj()
        addfrmProjLst()
        addfrmTsk()
        addfrmTskLst()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        twDashBoard.Controls.Add(frmDashBoard)
        twProject.Controls.Add(frmProj)
        twProjectList.Controls.Add(frmProjLst)
        twTask.Controls.Add(frmTsk)
        twTaskList.Controls.Add(frmTskLst)
        ToolWindowWo.Controls.Add(frmwo)
        ToolWindowWoLst.Controls.Add(frmwolst)

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolWindowWo.Hide()
        ToolWindowWoLst.Hide()
        twProject.Hide()
        twProjectList.Hide()
        twTask.Hide()
        twTaskList.Hide()
        AdjustSplitters()
    End Sub

    Private Sub AdjustSplitters()
        'Set Fixed size for Split Panels
        SplitContainer1.SplitterDistance = SplitContainer1.Height - 800
        SplitContainer1.FixedPanel = FixedPanel.Panel1

        SplitContainer2.SplitterDistance = SplitContainer2.Height - 1000
        SplitContainer2.FixedPanel = FixedPanel.Panel1
    End Sub

    Private Sub addDashBoardFrm()
        frmDashBoard = New frmDashBoard()
        frmDashBoard.Dock = DockStyle.Fill
        frmDashBoard.TopLevel = False
        frmDashBoard.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmDashBoard.Show()

    End Sub

    Private Sub addfrmProj()
        frmProj = New frmProject()
        frmProj.Dock = DockStyle.Fill
        frmProj.TopLevel = False
        frmProj.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmProj.Show()

    End Sub

    Private Sub addfrmProjLst()
        frmProjLst = New frmProjectList()
        frmProjLst.Dock = DockStyle.Fill
        frmProjLst.TopLevel = False
        frmProjLst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmProjLst.Show()

    End Sub

    Private Sub addfrmTsk()
        frmTsk = New frmTasks()
        frmTsk.Dock = DockStyle.Fill
        frmTsk.TopLevel = False
        frmTsk.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmTsk.Show()

    End Sub

    Private Sub addfrmTskLst()
        frmTskLst = New frmTaskLists()
        frmTskLst.Dock = DockStyle.Fill
        frmTskLst.TopLevel = False
        frmTskLst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmTskLst.Show()

    End Sub
    Private Sub addwofrm()
        frmwo = New frmWorkOrder()
        frmwo.Dock = DockStyle.Fill
        frmwo.TopLevel = False
        frmwo.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmwo.Show()

    End Sub

    Private Sub addWoLst()
        frmwolst = New frmWorkOrderLists()
        frmwolst.Dock = DockStyle.Fill
        frmwolst.TopLevel = False
        frmwolst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmwolst.Show()

    End Sub

    Private Sub rpvMain_SelectedPageChanged(sender As Object, e As EventArgs) Handles rpvMain.SelectedPageChanged
        If rpvMain.SelectedPage Is rpvpWorkOrders Then
            If Not frmProjLst.dgvProjectList.CurrentRow Is Nothing Then
                Dim dt_wo As DataTable = Me.frmwolst.dtWo.Copy()
                dt_wo.DefaultView.RowFilter = "ProjectNo = '" & Me.frmProjLst.dgvProjectList.CurrentRow.Cells("ProjectNo").Value.ToString() & "'"
                Dim dttask_copy As DataTable = Me.frmTskLst.dttask.Copy()
                dttask_copy.Clear()
                Me.frmTskLst.dgvTasks.DataSource = dttask_copy
                Me.frmwolst.dgvWo.DataSource = dt_wo.DefaultView
            End If
        ElseIf rpvMain.SelectedPage Is rpvpTasks Then
            If Not frmwolst.dgvWo.CurrentRow Is Nothing Then
                If (Not frmwolst.dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                    Me.frmwo.fillworkorder(frmwolst.dtWo.Select("WorkOrderNo = '" & frmwolst.dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'")(0), frmwolst.dtWo)
                    Dim dt_task As DataTable = Me.frmTskLst.dttask
                    dt_task.DefaultView.RowFilter = "WorkOrderNo = '" & frmwolst.dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString() & "'"
                    Me.frmTskLst.dgvTasks.DataSource = dt_task.DefaultView
                End If
            End If
        End If
    End Sub

    Private Sub rpvMain_MouseClick(sender As Object, e As MouseEventArgs) Handles rpvMain.MouseClick
        If rpvMain.SelectedPage Is rpvpWorkOrders Then
            ToolWindowWoLst.Show()
            ToolWindowWoLst.Select()
        ElseIf rpvMain.SelectedPage Is rpvpProjects Then
            twProjectList.Show()
            twProjectList.Select()

        ElseIf rpvMain.SelectedPage Is rpvpTasks Then
            twTaskList.Show()
            twTaskList.Select()
        ElseIf rpvMain.SelectedPage Is rpvpDashBoard Then
            twDashBoard.Show()
            twDashBoard.Select()
        End If
    End Sub

    Private Sub btnCreateProjects_Click(sender As Object, e As EventArgs) Handles btnCreateProjects.Click
        twProject.Show()
        twProject.Select()
    End Sub

    Private Sub btnCreateWorkOrder_Click(sender As Object, e As EventArgs) Handles btnCreateWorkOrder.Click
        ToolWindowWo.Show()
        ToolWindowWo.Select()
    End Sub

    Private Sub btnCreateTaskInternal_Click(sender As Object, e As EventArgs) Handles btnCreateTaskInternal.Click
        twTask.Show()
        twTask.Select()
        frmTsk.radInternal.Checked = True
    End Sub

    Private Sub btnCreateTaskOutsourced_Click(sender As Object, e As EventArgs) Handles btnCreateTaskOutsourced.Click
        twTask.Show()
        twTask.Select()
        frmTsk.radOutsourced.Checked = True
    End Sub

    Private Sub btnViewTasks_Click(sender As Object, e As EventArgs) Handles btnViewTasks.Click
        frmTskLst.ViewAllTasks()
    End Sub
End Class
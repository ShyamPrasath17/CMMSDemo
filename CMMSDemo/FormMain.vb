Public Class FormMain



    Dim frmwolst As frmWorkOrderLists
    Public frmwo As frmWorkOrder

    Dim frmProjLst As frmProjectList
    Public frmProj As frmProject

    Dim frmTskLst As frmTaskLists
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
        SplitContainer1.SplitterDistance = SplitContainer1.Height - 400
        SplitContainer1.FixedPanel = FixedPanel.Panel1

        SplitContainer2.SplitterDistance = SplitContainer2.Height - 700
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
        frmProj.Show()

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
End Class
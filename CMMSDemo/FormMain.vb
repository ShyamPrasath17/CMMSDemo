Public Class FormMain
    Dim frmwolst As frmWorkOrderLists
    Public frmwo As frmWorkOrder
    Dim frmDashBoard As frmDashBoard

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        addWoLst()
        addwofrm()
        addDashBoardFrm()


    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolWindowWo.Hide()
        ToolWindowWoLst.Hide()
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
        twDashBoard.Controls.Add(frmDashBoard)
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

    Private Sub rpvMain_SelectedPageChanged(sender As Object, e As EventArgs) Handles rpvMain.SelectedPageChanged
        If rpvMain.SelectedPage Is rpvpWorkOrders Then
            ToolWindowWoLst.Show()
            ToolWindowWoLst.Select()
        End If
    End Sub
End Class
Imports Telerik.WinControls.UI.Docking

Public Class FormMain



    Public frmwolst As frmWorkOrderLists
    Public frmwo As frmWorkOrder

    Public frmProjLst As frmProjectList
    Public frmProj As frmProject

    Public frmTskLst As frmTaskLists
    Public frmTsk As frmTasks

    Public frmSched As frmSheduleMaintanance

    Public frmSchedMaintList_ As frmSchedMaintList
    'Public frmIndependentTskPool As frmTaskPool
    'Public frmCommonTskPool As frmTaskPool

    Public frmWorkRequest_ As frmWorkRequest
    Public frmWorkRequestList_ As frmWorkrequestList

    Public frmschedular As frmShedular

    Public frmSettings_ As frmSettings

    Public frmImportSchedule_ As frmImportSchedule

    Public frmSearch As frmSearch
    Public frmAsset As frmAssets
    Public frmUpcomming As frmUpCommingSchedule
    Public frmrpt As frmReportList
    Dim frmDashBoard As frmDashBoard
    Dim dt_wo As DataTable
    Dim dt_tsk As DataTable

    Public connstr As String

    Sub New()

        'CMMSDAL.strConn = connstr
        Dim frm As New frmLogin()
        frm.ShowDialog()
        If frm.state = "Success" Then
            connstr = frm.strConn_
        Else
            Me.Close()
        End If
        addDashBoardFrm()
        addWoLst()
        addwofrm()
        addfrmProjLst()
        addfrmProject()
        addfrmTsk()
        addfrmTskLst()
        addfrmSchedMaintList()
        addfrmSchedmaint()
        addfrmUpcomming()
        addfrmIndeptTskPool()
        addfrmCommonTskPool()
        addfrmschedular()
        addfrmsettings()
        addfrmImportSchedule()
        addfrmSearch()
        addfrmWorkRequestList()
        addfrmUpcomming()
        addfrmAsset()
        addfrmWorkRequest()
        addfrmRpt()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        twDashBoard.Controls.Add(frmDashBoard)
        twProject.Controls.Add(frmProj)
        twProjectList.Controls.Add(frmProjLst)
        twTask.Controls.Add(frmTsk)
        twTaskList.Controls.Add(frmTskLst)
        TwSchedMaintList.Controls.Add(frmSchedMaintList_)
        TwWorkReq.Controls.Add(frmWorkRequest_)
        TwScheduledMaint.Controls.Add(frmSched)
        ToolWindowWo.Controls.Add(frmwo)
        ToolWindowWoLst.Controls.Add(frmwolst)
        twScheduler.Controls.Add(frmschedular)
        twSettings.Controls.Add(frmSettings_)
        twImportSchedule.Controls.Add(frmImportSchedule_)
        twSearch.Controls.Add(frmSearch)
        TwWorkReqList.Controls.Add(frmWorkRequestList_)
        TwUpComming.Controls.Add(frmUpcomming)
        twrptlst.Controls.Add(frmrpt)
        TwAsset.Controls.Add(frmAsset)
        DirectCast(twSearch.TabStrip, ToolTabStrip).AutoHidePosition = AutoHidePosition.Bottom


    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ToolWindowWo.Hide()
        ToolWindowWoLst.Hide()
        twProject.Hide()
        twProjectList.Hide()
        twTask.Hide()
        twTaskList.Hide()
        TwWorkReq.Hide()
        TwWorkReqList.Hide()
        TwScheduledMaint.Hide()
        TwSchedMaintList.Hide()
        twSettings.Hide()
        twImportSchedule.Hide()
        twScheduler.Hide()
        twrptlst.Hide()
        TwAsset.Hide()
        twDashBoard.Hide()


        RadDockMain.DockWindow(TwWorkReqList, TwUpComming, DockPosition.Left)
        TwWorkReqList.Show()
        TwUpComming.Show()
        twSearch.AutoHide()

    End Sub

    Private Sub addDashBoardFrm()
        frmDashBoard = New frmDashBoard()
        frmDashBoard.Dock = DockStyle.Fill
        frmDashBoard.TopLevel = False
        frmDashBoard.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmDashBoard.Show()
    End Sub

    Private Sub addfrmProject()
        frmProj = New frmProject()
        frmProj.Dock = DockStyle.Fill
        frmProj.TopLevel = False
        frmProj.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmProj.Show()

    End Sub

    Private Sub addfrmProjLst()
        frmProjLst = New frmProjectList()
        frmProjLst.connstring = connstr
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
        frmTskLst.connstring = connstr
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
        frmwolst.connstring = connstr
        frmwolst.Dock = DockStyle.Fill
        frmwolst.TopLevel = False
        frmwolst.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmwolst.Show()

    End Sub
    Private Sub addfrmSchedmaint()
        frmSched = New frmSheduleMaintanance()
        frmSched.Dock = DockStyle.Fill
        frmSched.TopLevel = False
        frmSched.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmSched.Show()
    End Sub
    Private Sub addfrmSchedMaintList()
        frmSchedMaintList_ = New frmSchedMaintList()
        frmSchedMaintList_.Dock = DockStyle.Fill
        frmSchedMaintList_.TopLevel = False
        frmSchedMaintList_.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmSchedMaintList_.Show()
    End Sub
    Private Sub addfrmIndeptTskPool()
        'frmIndependentTskPool = New frmTaskPool("Independent")
        'frmIndependentTskPool.Dock = DockStyle.Fill
        'frmIndependentTskPool.TopLevel = False
        'frmIndependentTskPool.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'frmIndependentTskPool.Show()
    End Sub
    Private Sub addfrmCommonTskPool()
        'frmCommonTskPool = New frmTaskPool("")
        'frmCommonTskPool.Dock = DockStyle.Fill
        'frmCommonTskPool.TopLevel = False
        'frmCommonTskPool.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'frmCommonTskPool.Show()
    End Sub
    Private Sub addfrmschedular()
        frmschedular = New frmShedular()
        frmschedular.Dock = DockStyle.Fill
        frmschedular.TopLevel = False
        frmschedular.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmschedular.Show()
    End Sub
    Private Sub addfrmsettings()
        frmSettings_ = New frmSettings
        frmSettings_.Dock = DockStyle.Fill
        frmSettings_.TopLevel = False
        frmSettings_.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmSettings_.Show()
    End Sub

    Private Sub addfrmImportSchedule()
        frmImportSchedule_ = New frmImportSchedule
        frmImportSchedule_.Dock = DockStyle.Fill
        frmImportSchedule_.TopLevel = False
        frmImportSchedule_.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmImportSchedule_.Show()
    End Sub

    Private Sub addfrmSearch()
        frmSearch = New frmSearch
        frmSearch.Dock = DockStyle.Fill
        frmSearch.TopLevel = False
        frmSearch.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmSearch.Show()
    End Sub

    Private Sub addfrmWorkRequest()
        frmWorkRequest_ = New frmWorkRequest()
        frmWorkRequest_.Dock = DockStyle.Fill
        frmWorkRequest_.TopLevel = False
        frmWorkRequest_.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmWorkRequest_.Show()
    End Sub
    Private Sub addfrmAsset()
        frmAsset = New frmAssets()
        frmAsset.Dock = DockStyle.Fill
        frmAsset.TopLevel = False
        frmAsset.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmAsset.Show()
    End Sub
    Private Sub addfrmRpt()
        frmrpt = New frmReportList()
        frmrpt.Dock = DockStyle.Fill
        frmrpt.TopLevel = False
        frmrpt.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmrpt.Show()
    End Sub
    Private Sub addfrmUpcomming()
        frmUpcomming = New frmUpCommingSchedule()
        frmUpcomming.Dock = DockStyle.Fill
        frmUpcomming.TopLevel = False
        frmUpcomming.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmUpcomming.Show()
    End Sub

    Private Sub addfrmWorkRequestList()
        frmWorkRequestList_ = New frmWorkrequestList()
        frmWorkRequestList_.Dock = DockStyle.Fill
        frmWorkRequestList_.TopLevel = False
        frmWorkRequestList_.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmWorkRequestList_.Show()
    End Sub

    Private Sub rpvMain_SelectedPageChanged(sender As Object, e As EventArgs) Handles rpvMain.SelectedPageChanged
        If rpvMain.SelectedPage Is rpvpWorkOrders Then
            If Not frmProjLst.dgvProjectList.CurrentRow Is Nothing Then
                If frmwolst.dgvWo.Rows.Count = 0 Then
                    Me.frmwolst.SetWoData(Me.frmProjLst.dgvProjectList.CurrentRow.Cells("ProjectID").Value.ToString())
                End If
            Else
                MessageBox.Show("Please Select a Project!")
            End If
        ElseIf rpvMain.SelectedPage Is rpvpTasks Then
            If Not frmwolst.dgvWo.CurrentRow Is Nothing Then
                If (Not frmwolst.dgvWo.CurrentRow.Cells("WorkOrderNo") Is Nothing AndAlso Not frmwolst.dgvWo.CurrentRow.Cells("WorkOrderNo").Value Is Nothing) Then
                    If frmTskLst.dgvTasks.Rows.Count = 0 Then
                        Me.frmTskLst.SetTaskData(Me.frmwolst.dgvWo.CurrentRow.Cells("WorkOrderNo").Value.ToString())
                    End If

                Else
                    MessageBox.Show("Please Select a Work Order!")
                End If
            End If
        End If
    End Sub

    Private Sub rpvMain_MouseClick(sender As Object, e As MouseEventArgs) Handles rpvMain.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            TwWorkReqList.Hide()
            If rpvMain.SelectedPage Is rpvpWorkOrders Then
                ToolWindowWoLst.Show()
                ToolWindowWoLst.Select()
            ElseIf rpvMain.SelectedPage Is rpvpProjects Then
                twProjectList.Show()
                twProjectList.Select()
            ElseIf rpvMain.SelectedPage Is rpvpWoRequest Then
                TwWorkReqList.Show()
                TwWorkReqList.Select()
            ElseIf rpvMain.SelectedPage Is rpvpTasks Then
                twTaskList.Show()
                twTaskList.Select()
            ElseIf rpvMain.SelectedPage Is rpvpDashBoard Then
                twDashBoard.Show()
                twDashBoard.Select()
            ElseIf rpvMain.SelectedPage Is rpvpScheduledMaintenance Then
                TwSchedMaintList.Show()
                TwSchedMaintList.Select()
            ElseIf rpvMain.SelectedPage Is rpvpScheduler Then
                frmschedular.RadTask.Checked = True
                twScheduler.Show()
                twScheduler.Select()
            ElseIf rpvMain.SelectedPage Is rpvpSettings Then
                twSettings.Show()
                twSettings.Select()
            ElseIf rpvMain.SelectedPage Is rpvpReportsCharts Then
                twrptlst.Show()
                twrptlst.Select()
            End If
        End If
    End Sub

    Private Sub btnCreateProjects_Click(sender As Object, e As EventArgs) Handles btnCreateProjects.Click
        twProject.Show()
        twProject.Select()
        frmProj.txtprojectID.Text = ""
        'frmProj.txtstatus.Text = ""
    End Sub

    Private Sub btnCreateWorkOrder_Click(sender As Object, e As EventArgs) Handles btnCreateWorkOrder.Click
        ToolWindowWo.Show()
        ToolWindowWo.Select()
        frmwo.txtwono.Text = ""
        'frmwo.txtstatus.Text = ""
        frmwo.txtProject.Text = ""
        frmwo.txtReq.Text = ""
    End Sub

    Private Sub btnCreateTaskInternal_Click(sender As Object, e As EventArgs) Handles btnCreateTaskInternal.Click
        twTask.Show()
        twTask.Select()
        frmTsk.radInternal.Checked = True
        frmTsk.txtTaskID.Text = ""
        frmTsk.txtTaskName.Text = ""
        'frmTsk.txtstatus.Text = ""
        frmTsk.txtwono.Text = ""
    End Sub

    Private Sub btnCreateTaskOutsourced_Click(sender As Object, e As EventArgs) Handles btnCreateTaskOutsourced.Click
        twTask.Show()
        twTask.Select()
        frmTsk.radOutsourced.Checked = True
        frmTsk.txtTaskID.Text = ""
        frmTsk.txtTaskName.Text = ""
        'frmTsk.txtstatus.Text = ""
        frmTsk.txtwono.Text = ""
    End Sub

    Private Sub btnViewTasks_Click(sender As Object, e As EventArgs) Handles btnViewTasks.Click
        frmTskLst.ViewAllTasks()
    End Sub

    Private Sub btnScheduledMaintainance_Click(sender As Object, e As EventArgs) Handles btnScheduledMaintainance.Click
        TwScheduledMaint.Show()
        TwScheduledMaint.Select()
    End Sub

    Private Sub btnCreateTaskIndependent_Click(sender As Object, e As EventArgs) Handles btnCreateWorkReq.Click
        TwWorkReq.Show()
        TwWorkReq.Select()
    End Sub

    Private Sub btnViewIndeptTasks_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnViewWorkOrders_Click(sender As Object, e As EventArgs) Handles btnViewWorkOrders.Click
        frmwolst.ViewAllWorkOrders()
    End Sub

    Private Sub btnImportSchedule_Click(sender As Object, e As EventArgs) Handles btnImportEvents.Click
        twImportSchedule.Show()
        twImportSchedule.Select()
    End Sub

    Private Sub twTaskList_Enter(sender As Object, e As EventArgs) Handles twTaskList.Enter
        frmSearch.AdvanceFilterControl1.GridView = frmTskLst.dgvTasks
    End Sub

    Private Sub twProjectList_Enter(sender As Object, e As EventArgs) Handles twProjectList.Enter
        frmSearch.AdvanceFilterControl1.GridView = frmProjLst.dgvProjectList

    End Sub

    Private Sub ToolWindowWoLst_Enter(sender As Object, e As EventArgs) Handles ToolWindowWoLst.Enter
        frmSearch.AdvanceFilterControl1.GridView = frmwolst.dgvWo
    End Sub

    Private Sub BtnViewUpcomming_Click(sender As Object, e As EventArgs) Handles BtnViewUpcomming.Click
        TwUpComming.Show()
        TwUpComming.Select()
        RadDockMain.DockWindow(TwWorkReqList, TwUpComming, DockPosition.Right)
        'TwWorkReqList.TabStrip.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute
        'TwWorkReqList.TabStrip.SizeInfo.AbsoluteSize = New System.Drawing.Size(700, 0)
    End Sub

    Private Sub btmAssetReading_Click(sender As Object, e As EventArgs) Handles btmAssetReading.Click
        TwAsset.DefaultFloatingSize = New Size(600, 500)
        RadDockMain.FloatWindow(TwAsset)
    End Sub
End Class
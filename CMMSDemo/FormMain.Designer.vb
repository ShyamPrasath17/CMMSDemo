<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.RadDockMain = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindowProjectLst = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindowProject = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolWindowWoLst = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolWindowWo = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolWindowTaskLst = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolWindowTask = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.rpvMain = New Telerik.WinControls.UI.RadPageView()
        Me.rpvpProjects = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnCreateProjects = New System.Windows.Forms.Button()
        Me.btnViewProject = New System.Windows.Forms.Button()
        Me.rpvpWorkOrders = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnCreateWorkOrder = New System.Windows.Forms.Button()
        Me.btnViewWorkOrders = New System.Windows.Forms.Button()
        Me.rpvpTasks = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnCreateTaskInternal = New System.Windows.Forms.Button()
        Me.btnCreateTaskOutsourced = New System.Windows.Forms.Button()
        Me.btnViewTasks = New System.Windows.Forms.Button()
        Me.rpvpScheduler = New Telerik.WinControls.UI.RadPageViewPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.rpvpReportsCharts = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rpvpSettings = New Telerik.WinControls.UI.RadPageViewPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolTabStrip8 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip5 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip6 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        CType(Me.RadDockMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDockMain.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rpvMain.SuspendLayout()
        Me.rpvpProjects.SuspendLayout()
        Me.rpvpWorkOrders.SuspendLayout()
        Me.rpvpTasks.SuspendLayout()
        Me.rpvpScheduler.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ToolTabStrip8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDockMain
        '
        Me.RadDockMain.ActiveWindow = Me.ToolWindowProjectLst
        Me.RadDockMain.Controls.Add(Me.ToolTabStrip1)
        Me.RadDockMain.Controls.Add(Me.DocumentContainer1)
        Me.RadDockMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDockMain.IsCleanUpTarget = True
        Me.RadDockMain.Location = New System.Drawing.Point(0, 0)
        Me.RadDockMain.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDockMain.MainDocumentContainerVisible = False
        Me.RadDockMain.Name = "RadDockMain"
        '
        '
        '
        Me.RadDockMain.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDockMain.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDockMain.Size = New System.Drawing.Size(1112, 781)
        Me.RadDockMain.TabIndex = 0
        Me.RadDockMain.TabStop = False
        Me.RadDockMain.Text = "RadDock1"
        '
        'ToolWindowProjectLst
        '
        Me.ToolWindowProjectLst.Caption = Nothing
        Me.ToolWindowProjectLst.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowProjectLst.Name = "ToolWindowProjectLst"
        Me.ToolWindowProjectLst.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowProjectLst.Size = New System.Drawing.Size(1100, 721)
        Me.ToolWindowProjectLst.Text = "Project List"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowProjectLst)
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowProject)
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowWoLst)
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowWo)
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowTaskLst)
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowTask)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(1102, 771)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(509, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(309, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindowProject
        '
        Me.ToolWindowProject.Caption = Nothing
        Me.ToolWindowProject.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowProject.Name = "ToolWindowProject"
        Me.ToolWindowProject.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowProject.Size = New System.Drawing.Size(762, 481)
        Me.ToolWindowProject.Text = "Project"
        '
        'ToolWindowWoLst
        '
        Me.ToolWindowWoLst.Caption = Nothing
        Me.ToolWindowWoLst.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowWoLst.Name = "ToolWindowWoLst"
        Me.ToolWindowWoLst.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowWoLst.Size = New System.Drawing.Size(762, 481)
        Me.ToolWindowWoLst.Text = "Work Order List"
        '
        'ToolWindowWo
        '
        Me.ToolWindowWo.Caption = Nothing
        Me.ToolWindowWo.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowWo.Name = "ToolWindowWo"
        Me.ToolWindowWo.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowWo.Size = New System.Drawing.Size(762, 481)
        Me.ToolWindowWo.Text = "WorkOrder"
        '
        'ToolWindowTaskLst
        '
        Me.ToolWindowTaskLst.Caption = Nothing
        Me.ToolWindowTaskLst.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowTaskLst.Name = "ToolWindowTaskLst"
        Me.ToolWindowTaskLst.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowTaskLst.Size = New System.Drawing.Size(762, 481)
        Me.ToolWindowTaskLst.Text = "Task List"
        '
        'ToolWindowTask
        '
        Me.ToolWindowTask.Caption = Nothing
        Me.ToolWindowTask.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowTask.Name = "ToolWindowTask"
        Me.ToolWindowTask.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowTask.Size = New System.Drawing.Size(762, 481)
        Me.ToolWindowTask.Text = "Task"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Collapsed = True
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(25, 200)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-472, 0)
        Me.DocumentContainer1.TabIndex = 2
        '
        'ToolTabStrip4
        '
        Me.ToolTabStrip4.CanUpdateChildIndex = True
        Me.ToolTabStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip4.Name = "ToolTabStrip4"
        '
        '
        '
        Me.ToolTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip4.SelectedIndex = 0
        Me.ToolTabStrip4.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip4.SizeInfo.AbsoluteSize = New System.Drawing.Size(363, 200)
        Me.ToolTabStrip4.SizeInfo.SplitterCorrection = New System.Drawing.Size(163, 0)
        Me.ToolTabStrip4.TabIndex = 0
        Me.ToolTabStrip4.TabStop = False
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.CanUpdateChildIndex = True
        Me.ToolTabStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 115)
        Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -85)
        Me.ToolTabStrip2.TabIndex = 0
        Me.ToolTabStrip2.TabStop = False
        '
        'rpvMain
        '
        Me.rpvMain.Controls.Add(Me.rpvpProjects)
        Me.rpvMain.Controls.Add(Me.rpvpWorkOrders)
        Me.rpvMain.Controls.Add(Me.rpvpTasks)
        Me.rpvMain.Controls.Add(Me.rpvpScheduler)
        Me.rpvMain.Controls.Add(Me.rpvpReportsCharts)
        Me.rpvMain.Controls.Add(Me.rpvpSettings)
        Me.rpvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpvMain.Location = New System.Drawing.Point(0, 0)
        Me.rpvMain.Name = "rpvMain"
        Me.rpvMain.PageBackColor = System.Drawing.Color.White
        Me.rpvMain.SelectedPage = Me.rpvpProjects
        Me.rpvMain.Size = New System.Drawing.Size(187, 885)
        Me.rpvMain.TabIndex = 1
        Me.rpvMain.Text = "RadPageView1"
        Me.rpvMain.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
        '
        'rpvpProjects
        '
        Me.rpvpProjects.BackColor = System.Drawing.Color.White
        Me.rpvpProjects.Controls.Add(Me.btnCreateProjects)
        Me.rpvpProjects.Controls.Add(Me.btnViewProject)
        Me.rpvpProjects.Image = CType(resources.GetObject("rpvpProjects.Image"), System.Drawing.Image)
        Me.rpvpProjects.Location = New System.Drawing.Point(5, 29)
        Me.rpvpProjects.Name = "rpvpProjects"
        Me.rpvpProjects.Size = New System.Drawing.Size(177, 462)
        Me.rpvpProjects.Text = "Projects"
        '
        'btnCreateProjects
        '
        Me.btnCreateProjects.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateProjects.BackgroundImage = CType(resources.GetObject("btnCreateProjects.BackgroundImage"), System.Drawing.Image)
        Me.btnCreateProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateProjects.FlatAppearance.BorderSize = 0
        Me.btnCreateProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateProjects.Location = New System.Drawing.Point(5, 70)
        Me.btnCreateProjects.Name = "btnCreateProjects"
        Me.btnCreateProjects.Size = New System.Drawing.Size(175, 50)
        Me.btnCreateProjects.TabIndex = 1
        Me.btnCreateProjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateProjects.UseVisualStyleBackColor = False
        '
        'btnViewProject
        '
        Me.btnViewProject.BackgroundImage = CType(resources.GetObject("btnViewProject.BackgroundImage"), System.Drawing.Image)
        Me.btnViewProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewProject.FlatAppearance.BorderSize = 0
        Me.btnViewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewProject.Location = New System.Drawing.Point(5, 14)
        Me.btnViewProject.Name = "btnViewProject"
        Me.btnViewProject.Size = New System.Drawing.Size(175, 50)
        Me.btnViewProject.TabIndex = 0
        Me.btnViewProject.UseVisualStyleBackColor = True
        '
        'rpvpWorkOrders
        '
        Me.rpvpWorkOrders.Controls.Add(Me.btnCreateWorkOrder)
        Me.rpvpWorkOrders.Controls.Add(Me.btnViewWorkOrders)
        Me.rpvpWorkOrders.Image = CType(resources.GetObject("rpvpWorkOrders.Image"), System.Drawing.Image)
        Me.rpvpWorkOrders.Location = New System.Drawing.Point(5, 29)
        Me.rpvpWorkOrders.Name = "rpvpWorkOrders"
        Me.rpvpWorkOrders.Size = New System.Drawing.Size(183, 192)
        Me.rpvpWorkOrders.Text = "Work Orders"
        '
        'btnCreateWorkOrder
        '
        Me.btnCreateWorkOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateWorkOrder.BackgroundImage = CType(resources.GetObject("btnCreateWorkOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnCreateWorkOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateWorkOrder.FlatAppearance.BorderSize = 0
        Me.btnCreateWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateWorkOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateWorkOrder.Location = New System.Drawing.Point(5, 70)
        Me.btnCreateWorkOrder.Name = "btnCreateWorkOrder"
        Me.btnCreateWorkOrder.Size = New System.Drawing.Size(175, 50)
        Me.btnCreateWorkOrder.TabIndex = 5
        Me.btnCreateWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateWorkOrder.UseVisualStyleBackColor = False
        '
        'btnViewWorkOrders
        '
        Me.btnViewWorkOrders.BackgroundImage = CType(resources.GetObject("btnViewWorkOrders.BackgroundImage"), System.Drawing.Image)
        Me.btnViewWorkOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewWorkOrders.FlatAppearance.BorderSize = 0
        Me.btnViewWorkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewWorkOrders.Location = New System.Drawing.Point(5, 14)
        Me.btnViewWorkOrders.Name = "btnViewWorkOrders"
        Me.btnViewWorkOrders.Size = New System.Drawing.Size(175, 50)
        Me.btnViewWorkOrders.TabIndex = 4
        Me.btnViewWorkOrders.UseVisualStyleBackColor = True
        '
        'rpvpTasks
        '
        Me.rpvpTasks.Controls.Add(Me.btnCreateTaskInternal)
        Me.rpvpTasks.Controls.Add(Me.btnCreateTaskOutsourced)
        Me.rpvpTasks.Controls.Add(Me.btnViewTasks)
        Me.rpvpTasks.Image = CType(resources.GetObject("rpvpTasks.Image"), System.Drawing.Image)
        Me.rpvpTasks.Location = New System.Drawing.Point(5, 29)
        Me.rpvpTasks.Name = "rpvpTasks"
        Me.rpvpTasks.Size = New System.Drawing.Size(183, 192)
        Me.rpvpTasks.Text = "Tasks"
        '
        'btnCreateTaskInternal
        '
        Me.btnCreateTaskInternal.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateTaskInternal.BackgroundImage = CType(resources.GetObject("btnCreateTaskInternal.BackgroundImage"), System.Drawing.Image)
        Me.btnCreateTaskInternal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateTaskInternal.FlatAppearance.BorderSize = 0
        Me.btnCreateTaskInternal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateTaskInternal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateTaskInternal.Location = New System.Drawing.Point(5, 70)
        Me.btnCreateTaskInternal.Name = "btnCreateTaskInternal"
        Me.btnCreateTaskInternal.Size = New System.Drawing.Size(175, 50)
        Me.btnCreateTaskInternal.TabIndex = 4
        Me.btnCreateTaskInternal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateTaskInternal.UseVisualStyleBackColor = False
        '
        'btnCreateTaskOutsourced
        '
        Me.btnCreateTaskOutsourced.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateTaskOutsourced.BackgroundImage = CType(resources.GetObject("btnCreateTaskOutsourced.BackgroundImage"), System.Drawing.Image)
        Me.btnCreateTaskOutsourced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateTaskOutsourced.FlatAppearance.BorderSize = 0
        Me.btnCreateTaskOutsourced.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateTaskOutsourced.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateTaskOutsourced.Location = New System.Drawing.Point(5, 126)
        Me.btnCreateTaskOutsourced.Name = "btnCreateTaskOutsourced"
        Me.btnCreateTaskOutsourced.Size = New System.Drawing.Size(175, 50)
        Me.btnCreateTaskOutsourced.TabIndex = 3
        Me.btnCreateTaskOutsourced.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateTaskOutsourced.UseVisualStyleBackColor = False
        '
        'btnViewTasks
        '
        Me.btnViewTasks.BackgroundImage = CType(resources.GetObject("btnViewTasks.BackgroundImage"), System.Drawing.Image)
        Me.btnViewTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewTasks.FlatAppearance.BorderSize = 0
        Me.btnViewTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTasks.Location = New System.Drawing.Point(5, 14)
        Me.btnViewTasks.Name = "btnViewTasks"
        Me.btnViewTasks.Size = New System.Drawing.Size(175, 50)
        Me.btnViewTasks.TabIndex = 2
        Me.btnViewTasks.UseVisualStyleBackColor = True
        '
        'rpvpScheduler
        '
        Me.rpvpScheduler.Controls.Add(Me.Button3)
        Me.rpvpScheduler.Image = CType(resources.GetObject("rpvpScheduler.Image"), System.Drawing.Image)
        Me.rpvpScheduler.Location = New System.Drawing.Point(5, 29)
        Me.rpvpScheduler.Name = "rpvpScheduler"
        Me.rpvpScheduler.Size = New System.Drawing.Size(183, 217)
        Me.rpvpScheduler.Text = "Scheduler"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(7, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 76)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'rpvpReportsCharts
        '
        Me.rpvpReportsCharts.Image = CType(resources.GetObject("rpvpReportsCharts.Image"), System.Drawing.Image)
        Me.rpvpReportsCharts.Location = New System.Drawing.Point(5, 29)
        Me.rpvpReportsCharts.Name = "rpvpReportsCharts"
        Me.rpvpReportsCharts.Size = New System.Drawing.Size(183, 217)
        Me.rpvpReportsCharts.Text = "Reports & Charts"
        '
        'rpvpSettings
        '
        Me.rpvpSettings.Image = CType(resources.GetObject("rpvpSettings.Image"), System.Drawing.Image)
        Me.rpvpSettings.Location = New System.Drawing.Point(5, 29)
        Me.rpvpSettings.Name = "rpvpSettings"
        Me.rpvpSettings.Size = New System.Drawing.Size(183, 217)
        Me.rpvpSettings.Text = "Settings"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.rpvMain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1303, 885)
        Me.SplitContainer1.SplitterDistance = 187
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.RadDockMain)
        Me.SplitContainer2.Size = New System.Drawing.Size(1112, 885)
        Me.SplitContainer2.SplitterDistance = 100
        Me.SplitContainer2.TabIndex = 1
        '
        'ToolTabStrip8
        '
        Me.ToolTabStrip8.CanUpdateChildIndex = True
        Me.ToolTabStrip8.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip8.Name = "ToolTabStrip8"
        '
        '
        '
        Me.ToolTabStrip8.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip8.SelectedIndex = 0
        Me.ToolTabStrip8.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip8.TabIndex = 0
        Me.ToolTabStrip8.TabStop = False
        '
        'ToolTabStrip3
        '
        Me.ToolTabStrip3.CanUpdateChildIndex = True
        Me.ToolTabStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip3.Name = "ToolTabStrip3"
        '
        '
        '
        Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip3.SelectedIndex = 0
        Me.ToolTabStrip3.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip3.TabIndex = 0
        Me.ToolTabStrip3.TabStop = False
        '
        'ToolTabStrip5
        '
        Me.ToolTabStrip5.CanUpdateChildIndex = True
        Me.ToolTabStrip5.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip5.Name = "ToolTabStrip5"
        '
        '
        '
        Me.ToolTabStrip5.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip5.SelectedIndex = 0
        Me.ToolTabStrip5.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip5.TabIndex = 0
        Me.ToolTabStrip5.TabStop = False
        '
        'ToolTabStrip6
        '
        Me.ToolTabStrip6.CanUpdateChildIndex = True
        Me.ToolTabStrip6.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip6.Name = "ToolTabStrip6"
        '
        '
        '
        Me.ToolTabStrip6.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip6.SelectedIndex = 0
        Me.ToolTabStrip6.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip6.TabIndex = 0
        Me.ToolTabStrip6.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 885)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadDockMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDockMain.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rpvMain.ResumeLayout(False)
        Me.rpvpProjects.ResumeLayout(False)
        Me.rpvpWorkOrders.ResumeLayout(False)
        Me.rpvpTasks.ResumeLayout(False)
        Me.rpvpScheduler.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ToolTabStrip8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadDockMain As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents ToolWindowWoLst As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindowWo As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents rpvMain As Telerik.WinControls.UI.RadPageView
    Friend WithEvents rpvpProjects As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rpvpWorkOrders As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rpvpTasks As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rpvpScheduler As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents btnViewProject As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnCreateProjects As System.Windows.Forms.Button
    Friend WithEvents rpvpReportsCharts As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rpvpSettings As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents btnCreateWorkOrder As System.Windows.Forms.Button
    Friend WithEvents btnViewWorkOrders As System.Windows.Forms.Button
    Friend WithEvents btnCreateTaskOutsourced As System.Windows.Forms.Button
    Friend WithEvents btnViewTasks As System.Windows.Forms.Button
    Friend WithEvents btnCreateTaskInternal As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolWindowProjectLst As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolWindowProject As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolWindowTaskLst As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolWindowTask As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip8 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip5 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip6 As Telerik.WinControls.UI.Docking.ToolTabStrip
End Class

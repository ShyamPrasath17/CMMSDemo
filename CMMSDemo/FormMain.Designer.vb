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
        Me.RadDockMain = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindowWoLst = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindowWo = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.rpvMain = New Telerik.WinControls.UI.RadPageView()
        Me.rpvpProjects = New Telerik.WinControls.UI.RadPageViewPage()
        Me.btnAddProject = New System.Windows.Forms.Button()
        Me.rpvpWorkOrders = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rpvpTasks = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rpvpScheduler = New Telerik.WinControls.UI.RadPageViewPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnViewProjects = New System.Windows.Forms.Button()
        Me.btnViewWorkOrders = New System.Windows.Forms.Button()
        Me.btnAddWorkOrder = New System.Windows.Forms.Button()
        Me.btnViewTasks = New System.Windows.Forms.Button()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.rpvpReports = New Telerik.WinControls.UI.RadPageViewPage()
        Me.rpvpSettings = New Telerik.WinControls.UI.RadPageViewPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.btnSave = New System.Windows.Forms.Button()
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
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadDockMain
        '
        Me.RadDockMain.ActiveWindow = Me.ToolWindowWoLst
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
        Me.RadDockMain.Size = New System.Drawing.Size(644, 550)
        Me.RadDockMain.TabIndex = 0
        Me.RadDockMain.TabStop = False
        Me.RadDockMain.Text = "RadDock1"
        '
        'ToolWindowWoLst
        '
        Me.ToolWindowWoLst.Caption = Nothing
        Me.ToolWindowWoLst.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowWoLst.Name = "ToolWindowWoLst"
        Me.ToolWindowWoLst.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowWoLst.Size = New System.Drawing.Size(632, 490)
        Me.ToolWindowWoLst.Text = "Work Order List"
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowWoLst)
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindowWo)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(634, 540)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(509, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(309, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindowWo
        '
        Me.ToolWindowWo.Caption = Nothing
        Me.ToolWindowWo.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowWo.Name = "ToolWindowWo"
        Me.ToolWindowWo.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowWo.Size = New System.Drawing.Size(632, 334)
        Me.ToolWindowWo.Text = "WorkOrder"
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
        Me.rpvMain.Controls.Add(Me.rpvpReports)
        Me.rpvMain.Controls.Add(Me.rpvpSettings)
        Me.rpvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpvMain.Location = New System.Drawing.Point(0, 0)
        Me.rpvMain.Name = "rpvMain"
        Me.rpvMain.PageBackColor = System.Drawing.Color.White
        Me.rpvMain.SelectedPage = Me.rpvpProjects
        Me.rpvMain.Size = New System.Drawing.Size(323, 607)
        Me.rpvMain.TabIndex = 1
        Me.rpvMain.Text = "RadPageView1"
        Me.rpvMain.ViewMode = Telerik.WinControls.UI.PageViewMode.Stack
        '
        'rpvpProjects
        '
        Me.rpvpProjects.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.rpvpProjects.Controls.Add(Me.btnViewProjects)
        Me.rpvpProjects.Controls.Add(Me.btnAddProject)
        Me.rpvpProjects.Location = New System.Drawing.Point(5, 29)
        Me.rpvpProjects.Name = "rpvpProjects"
        Me.rpvpProjects.Size = New System.Drawing.Size(313, 388)
        Me.rpvpProjects.Text = "Projects"
        '
        'btnAddProject
        '
        Me.btnAddProject.Location = New System.Drawing.Point(93, 30)
        Me.btnAddProject.Name = "btnAddProject"
        Me.btnAddProject.Size = New System.Drawing.Size(80, 80)
        Me.btnAddProject.TabIndex = 0
        Me.btnAddProject.Text = "Add Project"
        Me.btnAddProject.UseVisualStyleBackColor = True
        '
        'rpvpWorkOrders
        '
        Me.rpvpWorkOrders.Controls.Add(Me.btnViewWorkOrders)
        Me.rpvpWorkOrders.Controls.Add(Me.btnAddWorkOrder)
        Me.rpvpWorkOrders.Location = New System.Drawing.Point(5, 29)
        Me.rpvpWorkOrders.Name = "rpvpWorkOrders"
        Me.rpvpWorkOrders.Size = New System.Drawing.Size(313, 388)
        Me.rpvpWorkOrders.Text = "Work Orders"
        '
        'rpvpTasks
        '
        Me.rpvpTasks.Controls.Add(Me.btnViewTasks)
        Me.rpvpTasks.Controls.Add(Me.btnAddTask)
        Me.rpvpTasks.Location = New System.Drawing.Point(5, 29)
        Me.rpvpTasks.Name = "rpvpTasks"
        Me.rpvpTasks.Size = New System.Drawing.Size(313, 388)
        Me.rpvpTasks.Text = "Tasks"
        '
        'rpvpScheduler
        '
        Me.rpvpScheduler.Controls.Add(Me.Button3)
        Me.rpvpScheduler.Location = New System.Drawing.Point(5, 29)
        Me.rpvpScheduler.Name = "rpvpScheduler"
        Me.rpvpScheduler.Size = New System.Drawing.Size(313, 388)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(971, 607)
        Me.SplitContainer1.SplitterDistance = 323
        Me.SplitContainer1.TabIndex = 2
        '
        'btnViewProjects
        '
        Me.btnViewProjects.Location = New System.Drawing.Point(7, 3)
        Me.btnViewProjects.Name = "btnViewProjects"
        Me.btnViewProjects.Size = New System.Drawing.Size(80, 80)
        Me.btnViewProjects.TabIndex = 1
        Me.btnViewProjects.Text = "View Projects"
        Me.btnViewProjects.UseVisualStyleBackColor = True
        '
        'btnViewWorkOrders
        '
        Me.btnViewWorkOrders.Location = New System.Drawing.Point(3, 3)
        Me.btnViewWorkOrders.Name = "btnViewWorkOrders"
        Me.btnViewWorkOrders.Size = New System.Drawing.Size(80, 80)
        Me.btnViewWorkOrders.TabIndex = 3
        Me.btnViewWorkOrders.Text = "View Work Orders"
        Me.btnViewWorkOrders.UseVisualStyleBackColor = True
        '
        'btnAddWorkOrder
        '
        Me.btnAddWorkOrder.Location = New System.Drawing.Point(89, 42)
        Me.btnAddWorkOrder.Name = "btnAddWorkOrder"
        Me.btnAddWorkOrder.Size = New System.Drawing.Size(80, 80)
        Me.btnAddWorkOrder.TabIndex = 2
        Me.btnAddWorkOrder.Text = "Add Work Order"
        Me.btnAddWorkOrder.UseVisualStyleBackColor = True
        '
        'btnViewTasks
        '
        Me.btnViewTasks.Location = New System.Drawing.Point(7, 3)
        Me.btnViewTasks.Name = "btnViewTasks"
        Me.btnViewTasks.Size = New System.Drawing.Size(80, 80)
        Me.btnViewTasks.TabIndex = 5
        Me.btnViewTasks.Text = "View Tasks"
        Me.btnViewTasks.UseVisualStyleBackColor = True
        '
        'btnAddTask
        '
        Me.btnAddTask.Location = New System.Drawing.Point(93, 34)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(80, 80)
        Me.btnAddTask.TabIndex = 4
        Me.btnAddTask.Text = "Add Tasks"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'rpvpReports
        '
        Me.rpvpReports.Location = New System.Drawing.Point(5, 29)
        Me.rpvpReports.Name = "rpvpReports"
        Me.rpvpReports.Size = New System.Drawing.Size(313, 388)
        Me.rpvpReports.Text = "Reports"
        '
        'rpvpSettings
        '
        Me.rpvpSettings.Location = New System.Drawing.Point(5, 29)
        Me.rpvpSettings.Name = "rpvpSettings"
        Me.rpvpSettings.Size = New System.Drawing.Size(313, 388)
        Me.rpvpSettings.Text = "Settings"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.RadDockMain)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer2.Size = New System.Drawing.Size(644, 607)
        Me.SplitContainer2.SplitterDistance = 550
        Me.SplitContainer2.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(522, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 29)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 607)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
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
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
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
    Friend WithEvents btnAddProject As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnViewProjects As System.Windows.Forms.Button
    Friend WithEvents btnViewWorkOrders As System.Windows.Forms.Button
    Friend WithEvents btnAddWorkOrder As System.Windows.Forms.Button
    Friend WithEvents btnViewTasks As System.Windows.Forms.Button
    Friend WithEvents btnAddTask As System.Windows.Forms.Button
    Friend WithEvents rpvpReports As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents rpvpSettings As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class

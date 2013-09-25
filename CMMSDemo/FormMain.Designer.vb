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
        Me.ToolWindowWo = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindowWoLst = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        CType(Me.RadDockMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDockMain.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadDockMain.Size = New System.Drawing.Size(915, 386)
        Me.RadDockMain.TabIndex = 0
        Me.RadDockMain.TabStop = False
        Me.RadDockMain.Text = "RadDock1"
        '
        'ToolWindowWo
        '
        Me.ToolWindowWo.Caption = Nothing
        Me.ToolWindowWo.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowWo.Name = "ToolWindowWo"
        Me.ToolWindowWo.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowWo.Size = New System.Drawing.Size(903, 326)
        Me.ToolWindowWo.Text = "WorkOrder"
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
        Me.ToolTabStrip1.Size = New System.Drawing.Size(905, 376)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(509, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(309, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'ToolWindowWoLst
        '
        Me.ToolWindowWoLst.Caption = Nothing
        Me.ToolWindowWoLst.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowWoLst.Name = "ToolWindowWoLst"
        Me.ToolWindowWoLst.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowWoLst.Size = New System.Drawing.Size(903, 326)
        Me.ToolWindowWoLst.Text = "Work Order List"
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
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 386)
        Me.Controls.Add(Me.RadDockMain)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.RadDockMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDockMain.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadDockMain As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents ToolWindowWoLst As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindowWo As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShedular
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
        Dim DateTimeInterval1 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval()
        Dim SchedulerDailyPrintStyle1 As Telerik.WinControls.UI.SchedulerDailyPrintStyle = New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
        Me.Rshcmms = New Telerik.WinControls.UI.RadScheduler()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Rcal = New Telerik.WinControls.UI.RadCalendar()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.BtnViewNonScheduled = New System.Windows.Forms.Button()
        CType(Me.Rshcmms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rshcmms
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        DateTimeInterval1.Start = New Date(CType(0, Long))
        Me.Rshcmms.AccessibleInterval = DateTimeInterval1
        Me.Rshcmms.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Week
        Me.Rshcmms.AppointmentTitleFormat = Nothing
        Me.Rshcmms.Culture = New System.Globalization.CultureInfo("en-US")
        Me.Rshcmms.DataSource = Nothing
        Me.Rshcmms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rshcmms.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.Rshcmms.HeaderFormat = "dd dddd"
        Me.Rshcmms.Location = New System.Drawing.Point(0, 0)
        Me.Rshcmms.Name = "Rshcmms"
        SchedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchedulerDailyPrintStyle1.DateEndRange = New Date(2013, 10, 9, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        SchedulerDailyPrintStyle1.DateStartRange = New Date(2013, 10, 4, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Rshcmms.PrintStyle = SchedulerDailyPrintStyle1
        Me.Rshcmms.Size = New System.Drawing.Size(911, 613)
        Me.Rshcmms.TabIndex = 0
        Me.Rshcmms.Text = "RadScheduler1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Rcal)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1111, 671)
        Me.SplitContainer1.SplitterDistance = 196
        Me.SplitContainer1.TabIndex = 1
        '
        'Rcal
        '
        Me.Rcal.AllowMultipleView = True
        Me.Rcal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rcal.Location = New System.Drawing.Point(0, 0)
        Me.Rcal.MultiViewRows = 3
        Me.Rcal.Name = "Rcal"
        Me.Rcal.Size = New System.Drawing.Size(196, 671)
        Me.Rcal.TabIndex = 0
        Me.Rcal.Text = "RadCalendar1"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.Rshcmms)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.BtnViewNonScheduled)
        Me.SplitContainer2.Size = New System.Drawing.Size(911, 671)
        Me.SplitContainer2.SplitterDistance = 613
        Me.SplitContainer2.TabIndex = 1
        '
        'BtnViewNonScheduled
        '
        Me.BtnViewNonScheduled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnViewNonScheduled.Location = New System.Drawing.Point(654, 2)
        Me.BtnViewNonScheduled.Name = "BtnViewNonScheduled"
        Me.BtnViewNonScheduled.Size = New System.Drawing.Size(254, 48)
        Me.BtnViewNonScheduled.TabIndex = 0
        Me.BtnViewNonScheduled.Text = "View Non Scheduled Tasks"
        Me.BtnViewNonScheduled.UseVisualStyleBackColor = True
        '
        'frmShedular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 671)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmShedular"
        Me.Text = "Shedular"
        CType(Me.Rshcmms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rshcmms As Telerik.WinControls.UI.RadScheduler
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Rcal As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents BtnViewNonScheduled As System.Windows.Forms.Button
End Class

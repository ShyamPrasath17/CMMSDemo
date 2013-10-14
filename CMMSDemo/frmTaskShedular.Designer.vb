<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskShedular
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaskShedular))
        Me.Rshcmms = New Telerik.WinControls.UI.RadScheduler()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Rcal = New Telerik.WinControls.UI.RadCalendar()
        Me.BtnViewNonScheduled = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.grpSite = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DeptSearch = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.ChkAllAreas = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.Rshcmms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.grpSite.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        SchedulerDailyPrintStyle1.DateEndRange = New Date(2013, 10, 14, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        SchedulerDailyPrintStyle1.DateStartRange = New Date(2013, 10, 4, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Rshcmms.PrintStyle = SchedulerDailyPrintStyle1
        Me.Rshcmms.Size = New System.Drawing.Size(1054, 602)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Rshcmms)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Rcal)
        Me.SplitContainer1.Size = New System.Drawing.Size(1262, 602)
        Me.SplitContainer1.SplitterDistance = 1054
        Me.SplitContainer1.TabIndex = 1
        '
        'Rcal
        '
        Me.Rcal.AllowMultipleView = True
        Me.Rcal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rcal.Location = New System.Drawing.Point(0, 0)
        Me.Rcal.MultiViewRows = 2
        Me.Rcal.Name = "Rcal"
        Me.Rcal.Size = New System.Drawing.Size(204, 602)
        Me.Rcal.TabIndex = 0
        Me.Rcal.Text = "RadCalendar1"
        '
        'BtnViewNonScheduled
        '
        Me.BtnViewNonScheduled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnViewNonScheduled.Location = New System.Drawing.Point(1140, 9)
        Me.BtnViewNonScheduled.Name = "BtnViewNonScheduled"
        Me.BtnViewNonScheduled.Size = New System.Drawing.Size(119, 48)
        Me.BtnViewNonScheduled.TabIndex = 0
        Me.BtnViewNonScheduled.Text = "View Non Scheduled Tasks"
        Me.BtnViewNonScheduled.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnExport)
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpSite)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ChkAllAreas)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.BtnViewNonScheduled)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1262, 671)
        Me.SplitContainer2.SplitterDistance = 65
        Me.SplitContainer2.TabIndex = 2
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.Location = New System.Drawing.Point(1058, 9)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(79, 48)
        Me.btnExport.TabIndex = 112
        Me.btnExport.Text = "Export Schedule"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'grpSite
        '
        Me.grpSite.Controls.Add(Me.TextBox8)
        Me.grpSite.Controls.Add(Me.Label13)
        Me.grpSite.Controls.Add(Me.DeptSearch)
        Me.grpSite.Controls.Add(Me.TextBox9)
        Me.grpSite.Controls.Add(Me.Button9)
        Me.grpSite.Controls.Add(Me.Label15)
        Me.grpSite.Controls.Add(Me.Label16)
        Me.grpSite.Controls.Add(Me.Button10)
        Me.grpSite.Controls.Add(Me.TextBox10)
        Me.grpSite.Location = New System.Drawing.Point(407, 9)
        Me.grpSite.Name = "grpSite"
        Me.grpSite.Size = New System.Drawing.Size(647, 46)
        Me.grpSite.TabIndex = 110
        Me.grpSite.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(251, 19)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(111, 20)
        Me.TextBox8.TabIndex = 85
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(207, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "SubSite"
        '
        'DeptSearch
        '
        Me.DeptSearch.Image = CType(resources.GetObject("DeptSearch.Image"), System.Drawing.Image)
        Me.DeptSearch.Location = New System.Drawing.Point(368, 16)
        Me.DeptSearch.Name = "DeptSearch"
        Me.DeptSearch.Size = New System.Drawing.Size(24, 24)
        Me.DeptSearch.TabIndex = 87
        Me.DeptSearch.Tag = "DISABLE"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(451, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(111, 20)
        Me.TextBox9.TabIndex = 88
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(170, 16)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(24, 24)
        Me.Button9.TabIndex = 93
        Me.Button9.Tag = "DISABLE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(407, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Area"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Site"
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(568, 16)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(24, 24)
        Me.Button10.TabIndex = 90
        Me.Button10.Tag = "DISABLE"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(53, 16)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(111, 20)
        Me.TextBox10.TabIndex = 91
        '
        'ChkAllAreas
        '
        Me.ChkAllAreas.AutoSize = True
        Me.ChkAllAreas.Location = New System.Drawing.Point(334, 32)
        Me.ChkAllAreas.Name = "ChkAllAreas"
        Me.ChkAllAreas.Size = New System.Drawing.Size(67, 17)
        Me.ChkAllAreas.TabIndex = 7
        Me.ChkAllAreas.Text = "All Areas"
        Me.ChkAllAreas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 46)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Range"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(182, 20)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(42, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'frmTaskShedular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1262, 671)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "frmTaskShedular"
        Me.Text = "Task Shedular"
        CType(Me.Rshcmms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.grpSite.ResumeLayout(False)
        Me.grpSite.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rshcmms As Telerik.WinControls.UI.RadScheduler
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Rcal As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents BtnViewNonScheduled As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkAllAreas As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpSite As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DeptSearch As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
End Class

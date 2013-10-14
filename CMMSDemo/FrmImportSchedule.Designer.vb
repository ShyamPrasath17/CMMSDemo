<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportSchedule
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
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RshImport = New Telerik.WinControls.UI.RadScheduler()
        Me.Rcal = New Telerik.WinControls.UI.RadCalendar()
        Me.grpSelect.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.RshImport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.cmbType)
        Me.grpSelect.Controls.Add(Me.lblSelect)
        Me.grpSelect.Location = New System.Drawing.Point(320, 9)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(335, 48)
        Me.grpSelect.TabIndex = 5
        Me.grpSelect.TabStop = False
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Task", "Employee", "Equipment"})
        Me.cmbType.Location = New System.Drawing.Point(82, 21)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(237, 21)
        Me.cmbType.TabIndex = 121
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(6, 27)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(31, 13)
        Me.lblSelect.TabIndex = 3
        Me.lblSelect.Text = "Type"
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
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnImport)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpSelect)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1359, 823)
        Me.SplitContainer2.SplitterDistance = 64
        Me.SplitContainer2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(797, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 48)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(661, 12)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(130, 48)
        Me.btnImport.TabIndex = 113
        Me.btnImport.Text = "Import Schedule"
        Me.btnImport.UseVisualStyleBackColor = True
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RshImport)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Rcal)
        Me.SplitContainer1.Size = New System.Drawing.Size(1359, 755)
        Me.SplitContainer1.SplitterDistance = 1109
        Me.SplitContainer1.TabIndex = 1
        '
        'RshImport
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        DateTimeInterval1.Start = New Date(CType(0, Long))
        Me.RshImport.AccessibleInterval = DateTimeInterval1
        Me.RshImport.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Week
        Me.RshImport.AppointmentTitleFormat = Nothing
        Me.RshImport.Culture = New System.Globalization.CultureInfo("en-US")
        Me.RshImport.DataSource = Nothing
        Me.RshImport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RshImport.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.RshImport.HeaderFormat = "dd dddd"
        Me.RshImport.Location = New System.Drawing.Point(0, 0)
        Me.RshImport.Name = "RshImport"
        SchedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchedulerDailyPrintStyle1.DateEndRange = New Date(2013, 10, 19, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        SchedulerDailyPrintStyle1.DateStartRange = New Date(2013, 10, 14, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.RshImport.PrintStyle = SchedulerDailyPrintStyle1
        Me.RshImport.Size = New System.Drawing.Size(1109, 755)
        Me.RshImport.TabIndex = 0
        Me.RshImport.Text = "RadScheduler1"
        '
        'Rcal
        '
        Me.Rcal.AllowMultipleView = True
        Me.Rcal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rcal.Location = New System.Drawing.Point(0, 0)
        Me.Rcal.MultiViewRows = 2
        Me.Rcal.Name = "Rcal"
        Me.Rcal.Size = New System.Drawing.Size(246, 755)
        Me.Rcal.TabIndex = 0
        Me.Rcal.Text = "RadCalendar1"
        '
        'frmImportSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 823)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "frmImportSchedule"
        Me.Text = "ImportSchedule"
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.RshImport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSelect As System.Windows.Forms.GroupBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Rcal As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents RshImport As Telerik.WinControls.UI.RadScheduler
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

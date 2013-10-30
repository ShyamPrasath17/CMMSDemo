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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaskShedular))
        Dim DateTimeInterval1 As Telerik.WinControls.UI.DateTimeInterval = New Telerik.WinControls.UI.DateTimeInterval()
        Dim SchedulerDailyPrintStyle1 As Telerik.WinControls.UI.SchedulerDailyPrintStyle = New Telerik.WinControls.UI.SchedulerDailyPrintStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Rcal = New Telerik.WinControls.UI.RadCalendar()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.grpMultiType = New System.Windows.Forms.GroupBox()
        Me.ChkTask = New System.Windows.Forms.CheckBox()
        Me.ChkEquipment = New System.Windows.Forms.CheckBox()
        Me.ChkEmployee = New System.Windows.Forms.CheckBox()
        Me.ChkWo = New System.Windows.Forms.CheckBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.RadEmp = New System.Windows.Forms.RadioButton()
        Me.RadWoEqp = New System.Windows.Forms.RadioButton()
        Me.RadWo = New System.Windows.Forms.RadioButton()
        Me.RadTask = New System.Windows.Forms.RadioButton()
        Me.SchedulerNav = New Telerik.WinControls.UI.RadSchedulerNavigator()
        Me.grpVisibleM = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ChkAll = New System.Windows.Forms.CheckBox()
        Me.grpSelect = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.GrpView = New System.Windows.Forms.GroupBox()
        Me.cmbView = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.TPsch = New System.Windows.Forms.TableLayoutPanel()
        Me.Rshcmms = New Telerik.WinControls.UI.RadScheduler()
        Me.grpMultiview = New System.Windows.Forms.GroupBox()
        Me.radsingleView = New System.Windows.Forms.RadioButton()
        Me.radMultiView = New System.Windows.Forms.RadioButton()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.grpMultiType.SuspendLayout()
        Me.grpType.SuspendLayout()
        CType(Me.SchedulerNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchedulerNav.SuspendLayout()
        Me.grpVisibleM.SuspendLayout()
        CType(Me.MonthUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSelect.SuspendLayout()
        Me.GrpView.SuspendLayout()
        Me.grpSite.SuspendLayout()
        Me.TPsch.SuspendLayout()
        CType(Me.Rshcmms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMultiview.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TPsch)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Rcal)
        Me.SplitContainer1.Size = New System.Drawing.Size(1533, 599)
        Me.SplitContainer1.SplitterDistance = 1275
        Me.SplitContainer1.TabIndex = 1
        '
        'Rcal
        '
        Me.Rcal.AllowMultipleView = True
        Me.Rcal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rcal.Location = New System.Drawing.Point(0, 0)
        Me.Rcal.MultiViewRows = 3
        Me.Rcal.Name = "Rcal"
        Me.Rcal.Size = New System.Drawing.Size(254, 599)
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpMultiview)
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpMultiType)
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpType)
        Me.SplitContainer2.Panel1.Controls.Add(Me.SchedulerNav)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ChkAll)
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpSelect)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GrpView)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnExport)
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpSite)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ChkAllAreas)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1533, 769)
        Me.SplitContainer2.SplitterDistance = 166
        Me.SplitContainer2.TabIndex = 2
        '
        'grpMultiType
        '
        Me.grpMultiType.Controls.Add(Me.ChkEquipment)
        Me.grpMultiType.Controls.Add(Me.ChkTask)
        Me.grpMultiType.Controls.Add(Me.ChkEmployee)
        Me.grpMultiType.Controls.Add(Me.ChkWo)
        Me.grpMultiType.Location = New System.Drawing.Point(1036, 12)
        Me.grpMultiType.Name = "grpMultiType"
        Me.grpMultiType.Size = New System.Drawing.Size(387, 77)
        Me.grpMultiType.TabIndex = 115
        Me.grpMultiType.TabStop = False
        Me.grpMultiType.Text = "View Schedulars"
        '
        'ChkTask
        '
        Me.ChkTask.AutoSize = True
        Me.ChkTask.Location = New System.Drawing.Point(112, 34)
        Me.ChkTask.Name = "ChkTask"
        Me.ChkTask.Size = New System.Drawing.Size(50, 17)
        Me.ChkTask.TabIndex = 3
        Me.ChkTask.Text = "Task"
        Me.ChkTask.UseVisualStyleBackColor = True
        '
        'ChkEquipment
        '
        Me.ChkEquipment.AutoSize = True
        Me.ChkEquipment.Location = New System.Drawing.Point(278, 34)
        Me.ChkEquipment.Name = "ChkEquipment"
        Me.ChkEquipment.Size = New System.Drawing.Size(76, 17)
        Me.ChkEquipment.TabIndex = 2
        Me.ChkEquipment.Text = "Equipment"
        Me.ChkEquipment.UseVisualStyleBackColor = True
        '
        'ChkEmployee
        '
        Me.ChkEmployee.AutoSize = True
        Me.ChkEmployee.Location = New System.Drawing.Point(184, 34)
        Me.ChkEmployee.Name = "ChkEmployee"
        Me.ChkEmployee.Size = New System.Drawing.Size(72, 17)
        Me.ChkEmployee.TabIndex = 1
        Me.ChkEmployee.Text = "Employee"
        Me.ChkEmployee.UseVisualStyleBackColor = True
        '
        'ChkWo
        '
        Me.ChkWo.AutoSize = True
        Me.ChkWo.Location = New System.Drawing.Point(10, 34)
        Me.ChkWo.Name = "ChkWo"
        Me.ChkWo.Size = New System.Drawing.Size(81, 17)
        Me.ChkWo.TabIndex = 0
        Me.ChkWo.Text = "Work Order"
        Me.ChkWo.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.RadEmp)
        Me.grpType.Controls.Add(Me.RadWoEqp)
        Me.grpType.Controls.Add(Me.RadWo)
        Me.grpType.Controls.Add(Me.RadTask)
        Me.grpType.Location = New System.Drawing.Point(1036, 12)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(413, 77)
        Me.grpType.TabIndex = 114
        Me.grpType.TabStop = False
        Me.grpType.Text = "Schedular Type"
        '
        'RadEmp
        '
        Me.RadEmp.AutoSize = True
        Me.RadEmp.Location = New System.Drawing.Point(201, 32)
        Me.RadEmp.Name = "RadEmp"
        Me.RadEmp.Size = New System.Drawing.Size(71, 17)
        Me.RadEmp.TabIndex = 3
        Me.RadEmp.TabStop = True
        Me.RadEmp.Text = "Employee"
        Me.RadEmp.UseVisualStyleBackColor = True
        '
        'RadWoEqp
        '
        Me.RadWoEqp.AutoSize = True
        Me.RadWoEqp.Location = New System.Drawing.Point(302, 32)
        Me.RadWoEqp.Name = "RadWoEqp"
        Me.RadWoEqp.Size = New System.Drawing.Size(75, 17)
        Me.RadWoEqp.TabIndex = 2
        Me.RadWoEqp.TabStop = True
        Me.RadWoEqp.Text = "Equipment"
        Me.RadWoEqp.UseVisualStyleBackColor = True
        '
        'RadWo
        '
        Me.RadWo.AutoSize = True
        Me.RadWo.Location = New System.Drawing.Point(7, 32)
        Me.RadWo.Name = "RadWo"
        Me.RadWo.Size = New System.Drawing.Size(80, 17)
        Me.RadWo.TabIndex = 0
        Me.RadWo.TabStop = True
        Me.RadWo.Text = "Work Order"
        Me.RadWo.UseVisualStyleBackColor = True
        '
        'RadTask
        '
        Me.RadTask.AutoSize = True
        Me.RadTask.Location = New System.Drawing.Point(129, 32)
        Me.RadTask.Name = "RadTask"
        Me.RadTask.Size = New System.Drawing.Size(49, 17)
        Me.RadTask.TabIndex = 1
        Me.RadTask.TabStop = True
        Me.RadTask.Text = "Task"
        Me.RadTask.UseVisualStyleBackColor = True
        '
        'SchedulerNav
        '
        Me.SchedulerNav.AssociatedScheduler = Me.Rshcmms
        Me.SchedulerNav.Controls.Add(Me.grpVisibleM)
        Me.SchedulerNav.DateFormat = "yyyy/MM/dd"
        Me.SchedulerNav.Location = New System.Drawing.Point(12, 9)
        Me.SchedulerNav.Name = "SchedulerNav"
        Me.SchedulerNav.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
        '
        '
        '
        Me.SchedulerNav.RootElement.StretchVertically = False
        Me.SchedulerNav.Size = New System.Drawing.Size(683, 77)
        Me.SchedulerNav.TabIndex = 117
        Me.SchedulerNav.Text = "RadSchedulerNavigator1"
        '
        'grpVisibleM
        '
        Me.grpVisibleM.Controls.Add(Me.Label1)
        Me.grpVisibleM.Controls.Add(Me.MonthUpDown)
        Me.grpVisibleM.Location = New System.Drawing.Point(252, 34)
        Me.grpVisibleM.Name = "grpVisibleM"
        Me.grpVisibleM.Size = New System.Drawing.Size(154, 40)
        Me.grpVisibleM.TabIndex = 3
        Me.grpVisibleM.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Visible Months"
        '
        'MonthUpDown
        '
        Me.MonthUpDown.Location = New System.Drawing.Point(106, 17)
        Me.MonthUpDown.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.MonthUpDown.Name = "MonthUpDown"
        Me.MonthUpDown.Size = New System.Drawing.Size(42, 20)
        Me.MonthUpDown.TabIndex = 1
        '
        'ChkAll
        '
        Me.ChkAll.AutoSize = True
        Me.ChkAll.Location = New System.Drawing.Point(702, 115)
        Me.ChkAll.Name = "ChkAll"
        Me.ChkAll.Size = New System.Drawing.Size(91, 17)
        Me.ChkAll.TabIndex = 116
        Me.ChkAll.Text = "All Employees"
        Me.ChkAll.UseVisualStyleBackColor = True
        '
        'grpSelect
        '
        Me.grpSelect.Controls.Add(Me.Button1)
        Me.grpSelect.Controls.Add(Me.TextBox1)
        Me.grpSelect.Controls.Add(Me.lblSelect)
        Me.grpSelect.Location = New System.Drawing.Point(822, 95)
        Me.grpSelect.Name = "grpSelect"
        Me.grpSelect.Size = New System.Drawing.Size(318, 48)
        Me.grpSelect.TabIndex = 115
        Me.grpSelect.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(281, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 95
        Me.Button1.Tag = "DISABLE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(70, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 20)
        Me.TextBox1.TabIndex = 94
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(6, 22)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(58, 13)
        Me.lblSelect.TabIndex = 3
        Me.lblSelect.Text = "Employees"
        '
        'GrpView
        '
        Me.GrpView.Controls.Add(Me.cmbView)
        Me.GrpView.Controls.Add(Me.Label3)
        Me.GrpView.Location = New System.Drawing.Point(1142, 9)
        Me.GrpView.Name = "GrpView"
        Me.GrpView.Size = New System.Drawing.Size(264, 46)
        Me.GrpView.TabIndex = 113
        Me.GrpView.TabStop = False
        Me.GrpView.Text = "View"
        Me.GrpView.Visible = False
        '
        'cmbView
        '
        Me.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbView.FormattingEnabled = True
        Me.cmbView.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.cmbView.Location = New System.Drawing.Point(93, 13)
        Me.cmbView.Name = "cmbView"
        Me.cmbView.Size = New System.Drawing.Size(188, 21)
        Me.cmbView.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Schedular View"
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnExport.Location = New System.Drawing.Point(1412, 107)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(118, 48)
        Me.btnExport.TabIndex = 112
        Me.btnExport.Text = "Export Schedule"
        Me.btnExport.UseVisualStyleBackColor = False
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
        Me.grpSite.Location = New System.Drawing.Point(93, 92)
        Me.grpSite.Name = "grpSite"
        Me.grpSite.Size = New System.Drawing.Size(602, 46)
        Me.grpSite.TabIndex = 110
        Me.grpSite.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(252, 18)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(111, 20)
        Me.TextBox8.TabIndex = 85
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "SubSite"
        '
        'DeptSearch
        '
        Me.DeptSearch.Image = CType(resources.GetObject("DeptSearch.Image"), System.Drawing.Image)
        Me.DeptSearch.Location = New System.Drawing.Point(369, 15)
        Me.DeptSearch.Name = "DeptSearch"
        Me.DeptSearch.Size = New System.Drawing.Size(24, 24)
        Me.DeptSearch.TabIndex = 87
        Me.DeptSearch.Tag = "DISABLE"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(452, 18)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(111, 20)
        Me.TextBox9.TabIndex = 88
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(171, 15)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(24, 24)
        Me.Button9.TabIndex = 93
        Me.Button9.Tag = "DISABLE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(408, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Area"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Site"
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(569, 15)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(24, 24)
        Me.Button10.TabIndex = 90
        Me.Button10.Tag = "DISABLE"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(54, 15)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(111, 20)
        Me.TextBox10.TabIndex = 91
        '
        'ChkAllAreas
        '
        Me.ChkAllAreas.AutoSize = True
        Me.ChkAllAreas.Location = New System.Drawing.Point(9, 113)
        Me.ChkAllAreas.Name = "ChkAllAreas"
        Me.ChkAllAreas.Size = New System.Drawing.Size(67, 17)
        Me.ChkAllAreas.TabIndex = 7
        Me.ChkAllAreas.Text = "All Areas"
        Me.ChkAllAreas.UseVisualStyleBackColor = True
        '
        'TPsch
        '
        Me.TPsch.AutoSize = True
        Me.TPsch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TPsch.ColumnCount = 1
        Me.TPsch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TPsch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TPsch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TPsch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TPsch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TPsch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TPsch.Controls.Add(Me.Rshcmms, 0, 0)
        Me.TPsch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TPsch.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TPsch.Location = New System.Drawing.Point(0, 0)
        Me.TPsch.Name = "TPsch"
        Me.TPsch.RowCount = 1
        Me.TPsch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TPsch.Size = New System.Drawing.Size(1275, 599)
        Me.TPsch.TabIndex = 1
        '
        'Rshcmms
        '
        DateTimeInterval1.End = New Date(CType(0, Long))
        DateTimeInterval1.Start = New Date(CType(0, Long))
        Me.Rshcmms.AccessibleInterval = DateTimeInterval1
        Me.Rshcmms.ActiveViewType = Telerik.WinControls.UI.SchedulerViewType.Month
        Me.Rshcmms.AppointmentTitleFormat = Nothing
        Me.Rshcmms.Culture = New System.Globalization.CultureInfo("en-US")
        Me.Rshcmms.DataSource = Nothing
        Me.Rshcmms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rshcmms.GroupType = Telerik.WinControls.UI.GroupType.None
        Me.Rshcmms.HeaderFormat = "dd dddd"
        Me.Rshcmms.Location = New System.Drawing.Point(3, 3)
        Me.Rshcmms.Name = "Rshcmms"
        SchedulerDailyPrintStyle1.AppointmentFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SchedulerDailyPrintStyle1.DateEndRange = New Date(2013, 10, 30, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.DateHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        SchedulerDailyPrintStyle1.DateStartRange = New Date(2013, 10, 4, 0, 0, 0, 0)
        SchedulerDailyPrintStyle1.PageHeadingFont = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Rshcmms.PrintStyle = SchedulerDailyPrintStyle1
        Me.Rshcmms.Size = New System.Drawing.Size(1269, 593)
        Me.Rshcmms.TabIndex = 0
        Me.Rshcmms.Text = "RadScheduler1"
        '
        'grpMultiview
        '
        Me.grpMultiview.Controls.Add(Me.radMultiView)
        Me.grpMultiview.Controls.Add(Me.radsingleView)
        Me.grpMultiview.Location = New System.Drawing.Point(702, 9)
        Me.grpMultiview.Name = "grpMultiview"
        Me.grpMultiview.Size = New System.Drawing.Size(302, 77)
        Me.grpMultiview.TabIndex = 118
        Me.grpMultiview.TabStop = False
        '
        'radsingleView
        '
        Me.radsingleView.AutoSize = True
        Me.radsingleView.Location = New System.Drawing.Point(17, 29)
        Me.radsingleView.Name = "radsingleView"
        Me.radsingleView.Size = New System.Drawing.Size(131, 17)
        Me.radsingleView.TabIndex = 0
        Me.radsingleView.TabStop = True
        Me.radsingleView.Text = "Single Schedular View"
        Me.radsingleView.UseVisualStyleBackColor = True
        '
        'radMultiView
        '
        Me.radMultiView.AutoSize = True
        Me.radMultiView.Location = New System.Drawing.Point(163, 29)
        Me.radMultiView.Name = "radMultiView"
        Me.radMultiView.Size = New System.Drawing.Size(124, 17)
        Me.radMultiView.TabIndex = 1
        Me.radMultiView.TabStop = True
        Me.radMultiView.Text = "Multi Schedular View"
        Me.radMultiView.UseVisualStyleBackColor = True
        '
        'frmTaskShedular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1533, 769)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "frmTaskShedular"
        Me.Text = "Task Shedular"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Rcal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.grpMultiType.ResumeLayout(False)
        Me.grpMultiType.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        CType(Me.SchedulerNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchedulerNav.ResumeLayout(False)
        Me.SchedulerNav.PerformLayout()
        Me.grpVisibleM.ResumeLayout(False)
        Me.grpVisibleM.PerformLayout()
        CType(Me.MonthUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSelect.ResumeLayout(False)
        Me.grpSelect.PerformLayout()
        Me.GrpView.ResumeLayout(False)
        Me.GrpView.PerformLayout()
        Me.grpSite.ResumeLayout(False)
        Me.grpSite.PerformLayout()
        Me.TPsch.ResumeLayout(False)
        CType(Me.Rshcmms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMultiview.ResumeLayout(False)
        Me.grpMultiview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Rcal As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ChkAllAreas As System.Windows.Forms.CheckBox
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
    Friend WithEvents GrpView As System.Windows.Forms.GroupBox
    Friend WithEvents cmbView As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents RadEmp As System.Windows.Forms.RadioButton
    Friend WithEvents RadWoEqp As System.Windows.Forms.RadioButton
    Friend WithEvents RadTask As System.Windows.Forms.RadioButton
    Friend WithEvents RadWo As System.Windows.Forms.RadioButton
    Friend WithEvents ChkAll As System.Windows.Forms.CheckBox
    Friend WithEvents grpSelect As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSelect As System.Windows.Forms.Label
    Friend WithEvents SchedulerNav As Telerik.WinControls.UI.RadSchedulerNavigator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MonthUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpVisibleM As System.Windows.Forms.GroupBox
    Friend WithEvents grpMultiType As System.Windows.Forms.GroupBox
    Friend WithEvents ChkTask As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEquipment As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEmployee As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWo As System.Windows.Forms.CheckBox
    Friend WithEvents TPsch As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Rshcmms As Telerik.WinControls.UI.RadScheduler
    Friend WithEvents grpMultiview As System.Windows.Forms.GroupBox
    Friend WithEvents radMultiView As System.Windows.Forms.RadioButton
    Friend WithEvents radsingleView As System.Windows.Forms.RadioButton
End Class

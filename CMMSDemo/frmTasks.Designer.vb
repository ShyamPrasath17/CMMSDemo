<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTasks))
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
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
        Me.grpItems = New System.Windows.Forms.GroupBox()
        Me.btnEquipments = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.grpOutSource = New System.Windows.Forms.GroupBox()
        Me.btnOutSource = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radOutsourced = New System.Windows.Forms.RadioButton()
        Me.radInternal = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.txtTaskID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtwono = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
        Me.grpDurationBased = New System.Windows.Forms.GroupBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.dtpEndTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.grpSite.SuspendLayout()
        Me.grpItems.SuspendLayout()
        Me.grpOutSource.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadScrollablePanel1.PanelContainer.SuspendLayout()
        Me.RadScrollablePanel1.SuspendLayout()
        Me.grpDurationBased.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(131, 184)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox2.TabIndex = 114
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 187)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 13)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "Task Service Type"
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
        Me.grpSite.Location = New System.Drawing.Point(371, 307)
        Me.grpSite.Name = "grpSite"
        Me.grpSite.Size = New System.Drawing.Size(300, 111)
        Me.grpSite.TabIndex = 109
        Me.grpSite.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(53, 45)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(205, 20)
        Me.TextBox8.TabIndex = 85
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "SubSite"
        '
        'DeptSearch
        '
        Me.DeptSearch.Image = CType(resources.GetObject("DeptSearch.Image"), System.Drawing.Image)
        Me.DeptSearch.Location = New System.Drawing.Point(264, 42)
        Me.DeptSearch.Name = "DeptSearch"
        Me.DeptSearch.Size = New System.Drawing.Size(24, 24)
        Me.DeptSearch.TabIndex = 87
        Me.DeptSearch.Tag = "DISABLE"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(53, 71)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(205, 20)
        Me.TextBox9.TabIndex = 88
        '
        'Button9
        '
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(264, 16)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(24, 24)
        Me.Button9.TabIndex = 93
        Me.Button9.Tag = "DISABLE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Area"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "Site"
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(264, 68)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(24, 24)
        Me.Button10.TabIndex = 90
        Me.Button10.Tag = "DISABLE"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(53, 16)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(205, 20)
        Me.TextBox10.TabIndex = 91
        '
        'grpItems
        '
        Me.grpItems.Controls.Add(Me.btnEquipments)
        Me.grpItems.Controls.Add(Me.btnInventory)
        Me.grpItems.Controls.Add(Me.btnEmployees)
        Me.grpItems.Location = New System.Drawing.Point(413, 113)
        Me.grpItems.Name = "grpItems"
        Me.grpItems.Size = New System.Drawing.Size(258, 188)
        Me.grpItems.TabIndex = 108
        Me.grpItems.TabStop = False
        Me.grpItems.Text = "Resource Allocation"
        '
        'btnEquipments
        '
        Me.btnEquipments.Location = New System.Drawing.Point(6, 138)
        Me.btnEquipments.Name = "btnEquipments"
        Me.btnEquipments.Size = New System.Drawing.Size(245, 43)
        Me.btnEquipments.TabIndex = 2
        Me.btnEquipments.Text = "Equipments >>"
        Me.btnEquipments.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(6, 81)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(245, 43)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory >>"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(6, 26)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(245, 43)
        Me.btnEmployees.TabIndex = 0
        Me.btnEmployees.Text = "Employees >>"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'grpOutSource
        '
        Me.grpOutSource.Controls.Add(Me.btnOutSource)
        Me.grpOutSource.Location = New System.Drawing.Point(414, 35)
        Me.grpOutSource.Name = "grpOutSource"
        Me.grpOutSource.Size = New System.Drawing.Size(257, 62)
        Me.grpOutSource.TabIndex = 107
        Me.grpOutSource.TabStop = False
        '
        'btnOutSource
        '
        Me.btnOutSource.Location = New System.Drawing.Point(6, 13)
        Me.btnOutSource.Name = "btnOutSource"
        Me.btnOutSource.Size = New System.Drawing.Size(245, 43)
        Me.btnOutSource.TabIndex = 0
        Me.btnOutSource.Text = "Outsource Task >>"
        Me.btnOutSource.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radOutsourced)
        Me.GroupBox2.Controls.Add(Me.radInternal)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 62)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'radOutsourced
        '
        Me.radOutsourced.AutoSize = True
        Me.radOutsourced.Enabled = False
        Me.radOutsourced.Location = New System.Drawing.Point(140, 30)
        Me.radOutsourced.Name = "radOutsourced"
        Me.radOutsourced.Size = New System.Drawing.Size(86, 17)
        Me.radOutsourced.TabIndex = 1
        Me.radOutsourced.TabStop = True
        Me.radOutsourced.Text = "Outsourced"
        Me.radOutsourced.UseVisualStyleBackColor = True
        '
        'radInternal
        '
        Me.radInternal.AutoSize = True
        Me.radInternal.Enabled = False
        Me.radInternal.Location = New System.Drawing.Point(11, 30)
        Me.radInternal.Name = "radInternal"
        Me.radInternal.Size = New System.Drawing.Size(65, 17)
        Me.radInternal.TabIndex = 0
        Me.radInternal.TabStop = True
        Me.radInternal.Text = "Internal"
        Me.radInternal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Task ID"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(16, 627)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 23)
        Me.Button7.TabIndex = 78
        Me.Button7.Text = "File Attachments >>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtTaskName
        '
        Me.txtTaskName.Location = New System.Drawing.Point(131, 123)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(216, 20)
        Me.txtTaskName.TabIndex = 102
        '
        'txtTaskID
        '
        Me.txtTaskID.Location = New System.Drawing.Point(131, 97)
        Me.txtTaskID.Name = "txtTaskID"
        Me.txtTaskID.ReadOnly = True
        Me.txtTaskID.Size = New System.Drawing.Size(216, 20)
        Me.txtTaskID.TabIndex = 104
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Task Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(371, 427)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 184)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Cost"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(13, 70)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(278, 77)
        Me.TextBox5.TabIndex = 99
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(87, 25)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 20)
        Me.TextBox4.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Amount"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 100
        Me.Button3.Text = "Add additional Cost"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Cost Description"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(135, 471)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(185, 20)
        Me.TextBox2.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 478)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Total Task Cost"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 657)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Description"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(15, 679)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(656, 81)
        Me.TextBox3.TabIndex = 88
        '
        'txtwono
        '
        Me.txtwono.Location = New System.Drawing.Point(131, 149)
        Me.txtwono.Name = "txtwono"
        Me.txtwono.Size = New System.Drawing.Size(216, 20)
        Me.txtwono.TabIndex = 18
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(131, 73)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(216, 20)
        Me.txtstatus.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "WorkOrder"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Start Date Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Estimated Duration"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(135, 426)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpEndDate.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "End Date Time"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(135, 401)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(120, 20)
        Me.dtpStartDate.TabIndex = 79
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(434, 766)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 110
        Me.Button5.Text = "Complete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(515, 766)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Hold"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(596, 766)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Suspend"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadScrollablePanel1
        '
        Me.RadScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadScrollablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadScrollablePanel1.Name = "RadScrollablePanel1"
        '
        'RadScrollablePanel1.PanelContainer
        '
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Button6)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Button4)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.grpDurationBased)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.btnInstructions)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.dtpEndTime)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.dtpStartTime)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.TextBox3)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Button5)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.grpItems)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.GroupBox1)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label1)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Button7)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.dtpStartDate)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.ComboBox2)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label3)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label4)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label12)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label10)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.grpSite)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.grpOutSource)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label9)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.TextBox2)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.txtwono)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label5)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.txtTaskName)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.txtstatus)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Button1)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.dtpEndDate)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label17)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.txtTaskID)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Label2)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.Button2)
        Me.RadScrollablePanel1.PanelContainer.Controls.Add(Me.GroupBox2)
        Me.RadScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(680, 800)
        '
        '
        '
        Me.RadScrollablePanel1.RootElement.Padding = New System.Windows.Forms.Padding(1)
        Me.RadScrollablePanel1.Size = New System.Drawing.Size(682, 802)
        Me.RadScrollablePanel1.TabIndex = 115
        Me.RadScrollablePanel1.Text = "RadScrollablePanel1"
        '
        'grpDurationBased
        '
        Me.grpDurationBased.Controls.Add(Me.TextBox13)
        Me.grpDurationBased.Controls.Add(Me.Label18)
        Me.grpDurationBased.Controls.Add(Me.NumericUpDown3)
        Me.grpDurationBased.Controls.Add(Me.ComboBox3)
        Me.grpDurationBased.Controls.Add(Me.TextBox7)
        Me.grpDurationBased.Controls.Add(Me.TextBox6)
        Me.grpDurationBased.Controls.Add(Me.ComboBox1)
        Me.grpDurationBased.Controls.Add(Me.Label11)
        Me.grpDurationBased.Controls.Add(Me.TextBox11)
        Me.grpDurationBased.Controls.Add(Me.Label19)
        Me.grpDurationBased.Controls.Add(Me.Label20)
        Me.grpDurationBased.Controls.Add(Me.Label21)
        Me.grpDurationBased.Controls.Add(Me.TextBox12)
        Me.grpDurationBased.Controls.Add(Me.Label7)
        Me.grpDurationBased.Location = New System.Drawing.Point(16, 211)
        Me.grpDurationBased.Name = "grpDurationBased"
        Me.grpDurationBased.Size = New System.Drawing.Size(331, 184)
        Me.grpDurationBased.TabIndex = 152
        Me.grpDurationBased.TabStop = False
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(124, 16)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(95, 20)
        Me.TextBox13.TabIndex = 167
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 108)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 164
        Me.Label18.Text = "Hours per day"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(124, 106)
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(94, 20)
        Me.NumericUpDown3.TabIndex = 165
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Hours", "Days"})
        Me.ComboBox3.Location = New System.Drawing.Point(227, 16)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox3.TabIndex = 166
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(124, 80)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(95, 20)
        Me.TextBox7.TabIndex = 157
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(124, 48)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(95, 20)
        Me.TextBox6.TabIndex = 156
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Hours", "Days"})
        Me.ComboBox1.Location = New System.Drawing.Point(227, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox1.TabIndex = 151
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Rate"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(124, 130)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(95, 20)
        Me.TextBox11.TabIndex = 130
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 137)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 129
        Me.Label19.Text = "Total Hours"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 125
        Me.Label20.Text = "Duration"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 165)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 127
        Me.Label21.Text = "Hourly Rate"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(124, 158)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(94, 20)
        Me.TextBox12.TabIndex = 128
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(140, 627)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(176, 23)
        Me.btnInstructions.TabIndex = 117
        Me.btnInstructions.Text = "Instructions >>"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'dtpEndTime
        '
        Me.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEndTime.Location = New System.Drawing.Point(261, 426)
        Me.dtpEndTime.Name = "dtpEndTime"
        Me.dtpEndTime.Size = New System.Drawing.Size(90, 20)
        Me.dtpEndTime.TabIndex = 116
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpStartTime.Location = New System.Drawing.Point(261, 401)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.Size = New System.Drawing.Size(90, 20)
        Me.dtpStartTime.TabIndex = 115
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(353, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 24)
        Me.Button4.TabIndex = 153
        Me.Button4.Tag = "DISABLE"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(351, 766)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 175
        Me.Button6.Text = "Save"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'frmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(682, 802)
        Me.Controls.Add(Me.RadScrollablePanel1)
        Me.Name = "frmTasks"
        Me.Text = "Task"
        Me.grpSite.ResumeLayout(False)
        Me.grpSite.PerformLayout()
        Me.grpItems.ResumeLayout(False)
        Me.grpOutSource.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.RadScrollablePanel1.PanelContainer.ResumeLayout(False)
        Me.RadScrollablePanel1.PanelContainer.PerformLayout()
        CType(Me.RadScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadScrollablePanel1.ResumeLayout(False)
        Me.grpDurationBased.ResumeLayout(False)
        Me.grpDurationBased.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtwono As System.Windows.Forms.TextBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTaskName As System.Windows.Forms.TextBox
    Friend WithEvents txtTaskID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radOutsourced As System.Windows.Forms.RadioButton
    Friend WithEvents radInternal As System.Windows.Forms.RadioButton
    Friend WithEvents grpItems As System.Windows.Forms.GroupBox
    Friend WithEvents btnEquipments As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents grpOutSource As System.Windows.Forms.GroupBox
    Friend WithEvents btnOutSource As System.Windows.Forms.Button
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
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents RadScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
    Friend WithEvents dtpEndTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents grpDurationBased As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class

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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
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
        Me.TextBox6 = New System.Windows.Forms.TextBox()
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtwono = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpSite.SuspendLayout()
        Me.grpItems.SuspendLayout()
        Me.grpOutSource.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpSite)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpItems)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpOutSource)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtTaskID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtwono)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtstatus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NumericUpDown2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePicker1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Size = New System.Drawing.Size(730, 778)
        Me.SplitContainer1.SplitterDistance = 730
        Me.SplitContainer1.TabIndex = 95
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
        Me.grpSite.Location = New System.Drawing.Point(428, 332)
        Me.grpSite.Name = "grpSite"
        Me.grpSite.Size = New System.Drawing.Size(290, 111)
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
        Me.Label13.Size = New System.Drawing.Size(44, 13)
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
        Me.grpItems.Location = New System.Drawing.Point(428, 136)
        Me.grpItems.Name = "grpItems"
        Me.grpItems.Size = New System.Drawing.Size(257, 179)
        Me.grpItems.TabIndex = 108
        Me.grpItems.TabStop = False
        Me.grpItems.Text = "Assign"
        '
        'btnEquipments
        '
        Me.btnEquipments.Location = New System.Drawing.Point(6, 125)
        Me.btnEquipments.Name = "btnEquipments"
        Me.btnEquipments.Size = New System.Drawing.Size(245, 43)
        Me.btnEquipments.TabIndex = 2
        Me.btnEquipments.Text = "Equipments >>"
        Me.btnEquipments.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(6, 68)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(245, 43)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory >>"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(6, 13)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(245, 43)
        Me.btnEmployees.TabIndex = 0
        Me.btnEmployees.Text = "Employees >>"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'grpOutSource
        '
        Me.grpOutSource.Controls.Add(Me.btnOutSource)
        Me.grpOutSource.Location = New System.Drawing.Point(428, 49)
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
        Me.GroupBox2.Location = New System.Drawing.Point(24, 49)
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
        Me.radOutsourced.Size = New System.Drawing.Size(80, 17)
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
        Me.radInternal.Size = New System.Drawing.Size(60, 17)
        Me.radInternal.TabIndex = 0
        Me.radInternal.TabStop = True
        Me.radInternal.Text = "Internal"
        Me.radInternal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Task ID"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(116, 179)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(185, 20)
        Me.TextBox6.TabIndex = 102
        '
        'txtTaskID
        '
        Me.txtTaskID.Location = New System.Drawing.Point(116, 153)
        Me.txtTaskID.Name = "txtTaskID"
        Me.txtTaskID.ReadOnly = True
        Me.txtTaskID.Size = New System.Drawing.Size(185, 20)
        Me.txtTaskID.TabIndex = 104
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
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
        Me.GroupBox1.Location = New System.Drawing.Point(29, 352)
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
        Me.Label6.Size = New System.Drawing.Size(43, 13)
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
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Cost Description"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 314)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(185, 20)
        Me.TextBox2.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Task Cost"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "Project"
        '
        'txtwono
        '
        Me.txtwono.Location = New System.Drawing.Point(500, 9)
        Me.txtwono.Name = "txtwono"
        Me.txtwono.ReadOnly = True
        Me.txtwono.Size = New System.Drawing.Size(185, 20)
        Me.txtwono.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(185, 20)
        Me.TextBox1.TabIndex = 92
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(116, 129)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.ReadOnly = True
        Me.txtstatus.Size = New System.Drawing.Size(185, 20)
        Me.txtstatus.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "WorkOrder"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Start Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Estimated Hours"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(116, 237)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown2.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Actual Hours"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(116, 211)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 85
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(116, 288)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker2.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "End Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 263)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 79
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(643, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 109
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(481, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Hold"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(562, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Drop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(400, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 110
        Me.Button5.Text = "Finish"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(29, 595)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(641, 117)
        Me.TextBox3.TabIndex = 88
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 579)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Description"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(29, 542)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 23)
        Me.Button7.TabIndex = 78
        Me.Button7.Text = "File Attachments >>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 778)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MinimumSize = New System.Drawing.Size(746, 816)
        Me.Name = "frmTasks"
        Me.Text = "Task"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpSite.ResumeLayout(False)
        Me.grpSite.PerformLayout()
        Me.grpItems.ResumeLayout(False)
        Me.grpOutSource.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtwono As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
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
    Friend WithEvents Button4 As System.Windows.Forms.Button
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
End Class

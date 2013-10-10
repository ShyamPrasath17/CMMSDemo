<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignEmployees))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvEmployees = New Telerik.WinControls.UI.RadGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnViewSchedular = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grpOutSource = New System.Windows.Forms.GroupBox()
        Me.btnOutSource = New System.Windows.Forms.Button()
        Me.grpInternalEmp = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAddemp = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radOutsourced = New System.Windows.Forms.RadioButton()
        Me.radInternal = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadDockEmp = New Telerik.WinControls.UI.Docking.RadDock()
        Me.twEmp = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbrptUom = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmployees.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOutSource.SuspendLayout()
        Me.grpInternalEmp.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RadDockEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDockEmp.SuspendLayout()
        Me.twEmp.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvEmployees)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnViewSchedular)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpOutSource)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpInternalEmp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(547, 693)
        Me.SplitContainer1.SplitterDistance = 237
        Me.SplitContainer1.TabIndex = 0
        '
        'dgvEmployees
        '
        Me.dgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmployees.Location = New System.Drawing.Point(0, 0)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(547, 237)
        Me.dgvEmployees.TabIndex = 0
        Me.dgvEmployees.Text = "RadGridView1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "End Time"
        '
        'btnViewSchedular
        '
        Me.btnViewSchedular.Location = New System.Drawing.Point(12, 113)
        Me.btnViewSchedular.Name = "btnViewSchedular"
        Me.btnViewSchedular.Size = New System.Drawing.Size(173, 23)
        Me.btnViewSchedular.TabIndex = 124
        Me.btnViewSchedular.Text = "View Employee Schedular >>"
        Me.btnViewSchedular.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(122, 213)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker3.TabIndex = 121
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(459, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 122
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(378, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 121
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'grpOutSource
        '
        Me.grpOutSource.Controls.Add(Me.btnOutSource)
        Me.grpOutSource.Location = New System.Drawing.Point(283, 16)
        Me.grpOutSource.Name = "grpOutSource"
        Me.grpOutSource.Size = New System.Drawing.Size(257, 62)
        Me.grpOutSource.TabIndex = 118
        Me.grpOutSource.TabStop = False
        '
        'btnOutSource
        '
        Me.btnOutSource.Location = New System.Drawing.Point(6, 13)
        Me.btnOutSource.Name = "btnOutSource"
        Me.btnOutSource.Size = New System.Drawing.Size(245, 43)
        Me.btnOutSource.TabIndex = 0
        Me.btnOutSource.Text = "Out Source New Employee >>"
        Me.btnOutSource.UseVisualStyleBackColor = True
        '
        'grpInternalEmp
        '
        Me.grpInternalEmp.Controls.Add(Me.cmbrptUom)
        Me.grpInternalEmp.Controls.Add(Me.Label7)
        Me.grpInternalEmp.Controls.Add(Me.Label6)
        Me.grpInternalEmp.Controls.Add(Me.BtnAddemp)
        Me.grpInternalEmp.Controls.Add(Me.TextBox3)
        Me.grpInternalEmp.Controls.Add(Me.txtEmpName)
        Me.grpInternalEmp.Controls.Add(Me.Label2)
        Me.grpInternalEmp.Controls.Add(Me.Button6)
        Me.grpInternalEmp.Controls.Add(Me.NumericUpDown1)
        Me.grpInternalEmp.Controls.Add(Me.txtEmpID)
        Me.grpInternalEmp.Controls.Add(Me.Label1)
        Me.grpInternalEmp.Location = New System.Drawing.Point(12, 239)
        Me.grpInternalEmp.Name = "grpInternalEmp"
        Me.grpInternalEmp.Size = New System.Drawing.Size(455, 179)
        Me.grpInternalEmp.TabIndex = 117
        Me.grpInternalEmp.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Employee"
        '
        'BtnAddemp
        '
        Me.BtnAddemp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddemp.Location = New System.Drawing.Point(21, 150)
        Me.BtnAddemp.Name = "BtnAddemp"
        Me.BtnAddemp.Size = New System.Drawing.Size(105, 23)
        Me.BtnAddemp.TabIndex = 119
        Me.BtnAddemp.Text = "Add New"
        Me.BtnAddemp.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(110, 110)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 20)
        Me.TextBox3.TabIndex = 116
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(172, 13)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.ReadOnly = True
        Me.txtEmpName.Size = New System.Drawing.Size(185, 20)
        Me.txtEmpName.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Hourly Rate"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(363, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 87
        Me.Button6.Tag = "DISABLE"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(111, 48)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(55, 20)
        Me.NumericUpDown1.TabIndex = 114
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(111, 13)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(55, 20)
        Me.txtEmpID.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Allocated Hours"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radOutsourced)
        Me.GroupBox2.Controls.Add(Me.radInternal)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 62)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type"
        '
        'radOutsourced
        '
        Me.radOutsourced.AutoSize = True
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
        Me.radInternal.Location = New System.Drawing.Point(11, 30)
        Me.radInternal.Name = "radInternal"
        Me.radInternal.Size = New System.Drawing.Size(65, 17)
        Me.radInternal.TabIndex = 0
        Me.radInternal.TabStop = True
        Me.radInternal.Text = "Internal"
        Me.radInternal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Work assigned Date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(122, 152)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker2.TabIndex = 111
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 184)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Start Time"
        '
        'RadDockEmp
        '
        Me.RadDockEmp.ActiveWindow = Me.twEmp
        Me.RadDockEmp.Controls.Add(Me.DocumentContainer1)
        Me.RadDockEmp.Controls.Add(Me.ToolTabStrip1)
        Me.RadDockEmp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDockEmp.IsCleanUpTarget = True
        Me.RadDockEmp.Location = New System.Drawing.Point(0, 0)
        Me.RadDockEmp.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDockEmp.MainDocumentContainerVisible = False
        Me.RadDockEmp.Name = "RadDockEmp"
        Me.RadDockEmp.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadDockEmp.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDockEmp.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDockEmp.Size = New System.Drawing.Size(559, 729)
        Me.RadDockEmp.TabIndex = 1
        Me.RadDockEmp.TabStop = False
        Me.RadDockEmp.Text = "RadDock1"
        '
        'twEmp
        '
        Me.twEmp.Caption = Nothing
        Me.twEmp.Controls.Add(Me.SplitContainer1)
        Me.twEmp.Location = New System.Drawing.Point(1, 24)
        Me.twEmp.Name = "twEmp"
        Me.twEmp.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.twEmp.Size = New System.Drawing.Size(547, 693)
        Me.twEmp.Text = "twEmp"
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
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Controls.Add(Me.twEmp)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(549, 719)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Rate Type"
        '
        'cmbrptUom
        '
        Me.cmbrptUom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrptUom.FormattingEnabled = True
        Me.cmbrptUom.Location = New System.Drawing.Point(111, 82)
        Me.cmbrptUom.Name = "cmbrptUom"
        Me.cmbrptUom.Size = New System.Drawing.Size(112, 21)
        Me.cmbrptUom.TabIndex = 132
        '
        'frmAssignEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(559, 729)
        Me.Controls.Add(Me.RadDockEmp)
        Me.MinimumSize = New System.Drawing.Size(575, 730)
        Me.Name = "frmAssignEmployees"
        Me.Text = "Assign Employees"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvEmployees.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOutSource.ResumeLayout(False)
        Me.grpInternalEmp.ResumeLayout(False)
        Me.grpInternalEmp.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.RadDockEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDockEmp.ResumeLayout(False)
        Me.twEmp.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvEmployees As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radOutsourced As System.Windows.Forms.RadioButton
    Friend WithEvents radInternal As System.Windows.Forms.RadioButton
    Friend WithEvents grpInternalEmp As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpOutSource As System.Windows.Forms.GroupBox
    Friend WithEvents btnOutSource As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnAddemp As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnViewSchedular As System.Windows.Forms.Button
    Friend WithEvents RadDockEmp As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents twEmp As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbrptUom As System.Windows.Forms.ComboBox
End Class

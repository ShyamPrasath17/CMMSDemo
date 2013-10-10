<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignEquipments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignEquipments))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.btnOutSource = New System.Windows.Forms.Button()
        Me.grpOutSource = New System.Windows.Forms.GroupBox()
        Me.grpInternalEmp = New System.Windows.Forms.GroupBox()
        Me.BtnAddemp = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radOutsourced = New System.Windows.Forms.RadioButton()
        Me.radInternal = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvEquipment = New Telerik.WinControls.UI.RadGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnViewSchedular = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.RadDockequip = New Telerik.WinControls.UI.Docking.RadDock()
        Me.twEquipment = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.cmbrptUom = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpOutSource.SuspendLayout()
        Me.grpInternalEmp.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquipment.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.RadDockequip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDockequip.SuspendLayout()
        Me.twEquipment.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(535, 406)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 122
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(454, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 121
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Equipment"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(209, 22)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.ReadOnly = True
        Me.txtEmpName.Size = New System.Drawing.Size(185, 20)
        Me.txtEmpName.TabIndex = 85
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(400, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 87
        Me.Button6.Tag = "DISABLE"
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(125, 22)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(78, 20)
        Me.txtEmpID.TabIndex = 88
        '
        'btnOutSource
        '
        Me.btnOutSource.Location = New System.Drawing.Point(0, 13)
        Me.btnOutSource.Name = "btnOutSource"
        Me.btnOutSource.Size = New System.Drawing.Size(245, 43)
        Me.btnOutSource.TabIndex = 0
        Me.btnOutSource.Text = "Out Source New Equipment >>"
        Me.btnOutSource.UseVisualStyleBackColor = True
        '
        'grpOutSource
        '
        Me.grpOutSource.Controls.Add(Me.btnOutSource)
        Me.grpOutSource.Location = New System.Drawing.Point(351, 16)
        Me.grpOutSource.Name = "grpOutSource"
        Me.grpOutSource.Size = New System.Drawing.Size(257, 62)
        Me.grpOutSource.TabIndex = 118
        Me.grpOutSource.TabStop = False
        '
        'grpInternalEmp
        '
        Me.grpInternalEmp.Controls.Add(Me.cmbrptUom)
        Me.grpInternalEmp.Controls.Add(Me.Label7)
        Me.grpInternalEmp.Controls.Add(Me.Label6)
        Me.grpInternalEmp.Controls.Add(Me.BtnAddemp)
        Me.grpInternalEmp.Controls.Add(Me.txtEmpName)
        Me.grpInternalEmp.Controls.Add(Me.Button6)
        Me.grpInternalEmp.Controls.Add(Me.NumericUpDown1)
        Me.grpInternalEmp.Controls.Add(Me.txtEmpID)
        Me.grpInternalEmp.Controls.Add(Me.Label1)
        Me.grpInternalEmp.Location = New System.Drawing.Point(15, 243)
        Me.grpInternalEmp.Name = "grpInternalEmp"
        Me.grpInternalEmp.Size = New System.Drawing.Size(429, 155)
        Me.grpInternalEmp.TabIndex = 117
        Me.grpInternalEmp.TabStop = False
        '
        'BtnAddemp
        '
        Me.BtnAddemp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAddemp.Location = New System.Drawing.Point(18, 126)
        Me.BtnAddemp.Name = "BtnAddemp"
        Me.BtnAddemp.Size = New System.Drawing.Size(105, 23)
        Me.BtnAddemp.TabIndex = 119
        Me.BtnAddemp.Text = "Add New"
        Me.BtnAddemp.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(125, 54)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(78, 20)
        Me.NumericUpDown1.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Allocated Hours"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(136, 140)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker2.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Work assigned Date"
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
        'dgvEquipment
        '
        Me.dgvEquipment.Location = New System.Drawing.Point(0, 0)
        Me.dgvEquipment.Name = "dgvEquipment"
        Me.dgvEquipment.Size = New System.Drawing.Size(620, 213)
        Me.dgvEquipment.TabIndex = 0
        Me.dgvEquipment.Text = "RadGridView1"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvEquipment)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnViewSchedular)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpOutSource)
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpInternalEmp)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DateTimePicker4)
        Me.SplitContainer1.Size = New System.Drawing.Size(625, 675)
        Me.SplitContainer1.SplitterDistance = 230
        Me.SplitContainer1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "End Time"
        '
        'btnViewSchedular
        '
        Me.btnViewSchedular.Location = New System.Drawing.Point(15, 104)
        Me.btnViewSchedular.Name = "btnViewSchedular"
        Me.btnViewSchedular.Size = New System.Drawing.Size(173, 23)
        Me.btnViewSchedular.TabIndex = 123
        Me.btnViewSchedular.Text = "View Equipment Schedular >>"
        Me.btnViewSchedular.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker3.Location = New System.Drawing.Point(136, 199)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker3.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Start Time"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker4.Location = New System.Drawing.Point(136, 170)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker4.TabIndex = 123
        '
        'RadDockequip
        '
        Me.RadDockequip.ActiveWindow = Me.twEquipment
        Me.RadDockequip.Controls.Add(Me.DocumentContainer1)
        Me.RadDockequip.Controls.Add(Me.ToolTabStrip1)
        Me.RadDockequip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDockequip.IsCleanUpTarget = True
        Me.RadDockequip.Location = New System.Drawing.Point(0, 0)
        Me.RadDockequip.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDockequip.MainDocumentContainerVisible = False
        Me.RadDockequip.Name = "RadDockequip"
        Me.RadDockequip.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadDockequip.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDockequip.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.RadDockequip.Size = New System.Drawing.Size(637, 711)
        Me.RadDockequip.TabIndex = 2
        Me.RadDockequip.TabStop = False
        Me.RadDockequip.Text = "RadDock1"
        '
        'twEquipment
        '
        Me.twEquipment.Caption = Nothing
        Me.twEquipment.Controls.Add(Me.SplitContainer1)
        Me.twEquipment.Location = New System.Drawing.Point(1, 24)
        Me.twEquipment.Name = "twEquipment"
        Me.twEquipment.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.twEquipment.Size = New System.Drawing.Size(625, 675)
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
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 25)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -473)
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Controls.Add(Me.twEquipment)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(627, 701)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 672)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 473)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'cmbrptUom
        '
        Me.cmbrptUom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrptUom.FormattingEnabled = True
        Me.cmbrptUom.Location = New System.Drawing.Point(125, 89)
        Me.cmbrptUom.Name = "cmbrptUom"
        Me.cmbrptUom.Size = New System.Drawing.Size(112, 21)
        Me.cmbrptUom.TabIndex = 134
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Rate Type"
        '
        'frmAssignEquipments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(637, 711)
        Me.Controls.Add(Me.RadDockequip)
        Me.MinimumSize = New System.Drawing.Size(653, 749)
        Me.Name = "frmAssignEquipments"
        Me.Text = "Equipments"
        Me.grpOutSource.ResumeLayout(False)
        Me.grpInternalEmp.ResumeLayout(False)
        Me.grpInternalEmp.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvEquipment.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.RadDockequip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDockequip.ResumeLayout(False)
        Me.twEquipment.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents btnOutSource As System.Windows.Forms.Button
    Friend WithEvents grpOutSource As System.Windows.Forms.GroupBox
    Friend WithEvents grpInternalEmp As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAddemp As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents radOutsourced As System.Windows.Forms.RadioButton
    Friend WithEvents radInternal As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEquipment As Telerik.WinControls.UI.RadGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnViewSchedular As System.Windows.Forms.Button
    Friend WithEvents RadDockequip As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents twEquipment As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents cmbrptUom As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class

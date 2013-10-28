<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkRequest))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMaintID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvPredefined = New Telerik.WinControls.UI.RadGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dgvEmp = New Telerik.WinControls.UI.RadGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPredefined, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPredefined.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(127, 6)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(271, 20)
        Me.txtStatus.TabIndex = 155
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(21, 652)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 23)
        Me.Button7.TabIndex = 150
        Me.Button7.Text = "File Attachments >>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 689)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "Description"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(23, 705)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(553, 89)
        Me.TextBox3.TabIndex = 151
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Request ID"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 58)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(271, 20)
        Me.txtName.TabIndex = 146
        '
        'txtMaintID
        '
        Me.txtMaintID.Location = New System.Drawing.Point(127, 32)
        Me.txtMaintID.Name = "txtMaintID"
        Me.txtMaintID.ReadOnly = True
        Me.txtMaintID.Size = New System.Drawing.Size(271, 20)
        Me.txtMaintID.TabIndex = 148
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Name"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(404, 81)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 145
        Me.Button6.Tag = "DISABLE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Requester"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 20)
        Me.TextBox2.TabIndex = 143
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 140)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Assigned Date"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(639, 816)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 162
        Me.Button3.Text = "Approve"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(720, 816)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 161
        Me.Button2.Text = "Suspend"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(127, 166)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(185, 21)
        Me.ComboBox2.TabIndex = 166
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 165
        Me.Label13.Text = "Priority"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Estimated Duration"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(127, 196)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(86, 20)
        Me.NumericUpDown1.TabIndex = 164
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(404, 107)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 24)
        Me.Button5.TabIndex = 169
        Me.Button5.Tag = "DISABLE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Asset"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 20)
        Me.TextBox1.TabIndex = 167
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(138, 652)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(176, 23)
        Me.btnInstructions.TabIndex = 170
        Me.btnInstructions.Text = "Instructions >>"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvPredefined)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 196)
        Me.GroupBox2.TabIndex = 172
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Predefined Tasks"
        '
        'dgvPredefined
        '
        Me.dgvPredefined.Location = New System.Drawing.Point(6, 28)
        Me.dgvPredefined.Name = "dgvPredefined"
        Me.dgvPredefined.Size = New System.Drawing.Size(514, 135)
        Me.dgvPredefined.TabIndex = 149
        Me.dgvPredefined.Text = "RadGridView1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 154
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 153
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dgvEmp)
        Me.GroupBox7.Controls.Add(Me.Button8)
        Me.GroupBox7.Controls.Add(Me.Button9)
        Me.GroupBox7.Location = New System.Drawing.Point(15, 438)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(355, 196)
        Me.GroupBox7.TabIndex = 171
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Employees"
        '
        'dgvEmp
        '
        Me.dgvEmp.Location = New System.Drawing.Point(16, 28)
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.Size = New System.Drawing.Size(329, 135)
        Me.dgvEmp.TabIndex = 149
        Me.dgvEmp.Text = "RadGridView2"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(98, 169)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 154
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(16, 169)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 153
        Me.Button9.Text = "Add"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(558, 816)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 173
        Me.Button10.Text = "Save"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'frmWorkRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 851)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtMaintID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "frmWorkRequest"
        Me.Text = "Work Request"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvPredefined.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPredefined, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.dgvEmp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMaintID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPredefined As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvEmp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
End Class

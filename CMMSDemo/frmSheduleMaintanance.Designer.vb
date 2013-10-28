<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSheduleMaintanance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSheduleMaintanance))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtMaintID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvTriggers = New Telerik.WinControls.UI.RadGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.dgvEmp = New Telerik.WinControls.UI.RadGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnViewUpComming = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvPredefined = New Telerik.WinControls.UI.RadGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.dgvTriggers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTriggers.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmp.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvPredefined, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPredefined.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(401, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 87
        Me.Button6.Tag = "DISABLE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Asset"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(124, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 20)
        Me.TextBox2.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Maintanance ID"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(124, 73)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(271, 20)
        Me.txtName.TabIndex = 106
        '
        'txtMaintID
        '
        Me.txtMaintID.Location = New System.Drawing.Point(124, 47)
        Me.txtMaintID.Name = "txtMaintID"
        Me.txtMaintID.ReadOnly = True
        Me.txtMaintID.Size = New System.Drawing.Size(271, 20)
        Me.txtMaintID.TabIndex = 108
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = "Name"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(30, 677)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(111, 23)
        Me.Button7.TabIndex = 111
        Me.Button7.Text = "File Attachments >>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 711)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Description"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(30, 727)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(553, 89)
        Me.TextBox3.TabIndex = 112
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(841, 816)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 124
        Me.Button2.Text = "Suspend"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(124, 125)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(271, 21)
        Me.ComboBox3.TabIndex = 135
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 13)
        Me.Label17.TabIndex = 134
        Me.Label17.Text = "Task Service Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(124, 18)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(271, 20)
        Me.txtStatus.TabIndex = 141
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(760, 816)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 143
        Me.Button3.Text = "Approve"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvTriggers
        '
        Me.dgvTriggers.Location = New System.Drawing.Point(6, 75)
        Me.dgvTriggers.Name = "dgvTriggers"
        Me.dgvTriggers.Size = New System.Drawing.Size(514, 175)
        Me.dgvTriggers.TabIndex = 144
        Me.dgvTriggers.Text = "RadGridView1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 256)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 146
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(166, 256)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 147
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.dgvTriggers)
        Me.GroupBox1.Controls.Add(Me.btnDel)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 287)
        Me.GroupBox1.TabIndex = 148
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Triggers"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(85, 256)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 150
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton1)
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(514, 50)
        Me.GroupBox5.TabIndex = 148
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Work Order Creation"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(279, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(167, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "After  any of the Triggers Fired"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(13, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(128, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "After All Triggers Fired"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'dgvEmp
        '
        Me.dgvEmp.Location = New System.Drawing.Point(16, 28)
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.Size = New System.Drawing.Size(329, 135)
        Me.dgvEmp.TabIndex = 149
        Me.dgvEmp.Text = "RadGridView2"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(98, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 154
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
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
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dgvEmp)
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.Button9)
        Me.GroupBox7.Location = New System.Drawing.Point(564, 457)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(355, 196)
        Me.GroupBox7.TabIndex = 155
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Employees"
        '
        'btnViewUpComming
        '
        Me.btnViewUpComming.Location = New System.Drawing.Point(580, 18)
        Me.btnViewUpComming.Name = "btnViewUpComming"
        Me.btnViewUpComming.Size = New System.Drawing.Size(157, 52)
        Me.btnViewUpComming.TabIndex = 157
        Me.btnViewUpComming.Text = "View UpComming >>"
        Me.btnViewUpComming.UseVisualStyleBackColor = True
        '
        'btnInstructions
        '
        Me.btnInstructions.Location = New System.Drawing.Point(147, 677)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(176, 23)
        Me.btnInstructions.TabIndex = 118
        Me.btnInstructions.Text = "Instructions >>"
        Me.btnInstructions.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvPredefined)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 457)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 196)
        Me.GroupBox2.TabIndex = 158
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
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 169)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 153
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Location = New System.Drawing.Point(679, 816)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 176
        Me.Button8.Text = "Save"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'frmSheduleMaintanance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(929, 841)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnViewUpComming)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button2)
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
        Me.Name = "frmSheduleMaintanance"
        Me.Text = "Shedule Maintanance"
        CType(Me.dgvTriggers.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTriggers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvEmp.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvPredefined.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPredefined, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtMaintID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgvTriggers As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents dgvEmp As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewUpComming As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPredefined As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class

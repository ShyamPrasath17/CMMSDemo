<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrigger
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOccurence = New System.Windows.Forms.TextBox()
        Me.radEndAfter = New System.Windows.Forms.RadioButton()
        Me.radNoEnd = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radMeter = New System.Windows.Forms.RadioButton()
        Me.radTimeBased = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbrptUom = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbThreshold = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.txtOccurence)
        Me.GroupBox6.Controls.Add(Me.radEndAfter)
        Me.GroupBox6.Controls.Add(Me.radNoEnd)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(547, 53)
        Me.GroupBox6.TabIndex = 155
        Me.GroupBox6.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Occurence"
        '
        'txtOccurence
        '
        Me.txtOccurence.Enabled = False
        Me.txtOccurence.Location = New System.Drawing.Point(215, 16)
        Me.txtOccurence.Name = "txtOccurence"
        Me.txtOccurence.Size = New System.Drawing.Size(74, 20)
        Me.txtOccurence.TabIndex = 130
        '
        'radEndAfter
        '
        Me.radEndAfter.AutoSize = True
        Me.radEndAfter.Location = New System.Drawing.Point(140, 19)
        Me.radEndAfter.Name = "radEndAfter"
        Me.radEndAfter.Size = New System.Drawing.Size(69, 17)
        Me.radEndAfter.TabIndex = 1
        Me.radEndAfter.TabStop = True
        Me.radEndAfter.Text = "End After"
        Me.radEndAfter.UseVisualStyleBackColor = True
        '
        'radNoEnd
        '
        Me.radNoEnd.AutoSize = True
        Me.radNoEnd.Location = New System.Drawing.Point(10, 19)
        Me.radNoEnd.Name = "radNoEnd"
        Me.radNoEnd.Size = New System.Drawing.Size(61, 17)
        Me.radNoEnd.TabIndex = 0
        Me.radNoEnd.TabStop = True
        Me.radNoEnd.Text = "No End"
        Me.radNoEnd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radMeter)
        Me.GroupBox2.Controls.Add(Me.radTimeBased)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 49)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recurrence Type"
        '
        'radMeter
        '
        Me.radMeter.AutoSize = True
        Me.radMeter.Location = New System.Drawing.Point(140, 19)
        Me.radMeter.Name = "radMeter"
        Me.radMeter.Size = New System.Drawing.Size(95, 17)
        Me.radMeter.TabIndex = 1
        Me.radMeter.TabStop = True
        Me.radMeter.Text = "Meter Reading"
        Me.radMeter.UseVisualStyleBackColor = True
        '
        'radTimeBased
        '
        Me.radTimeBased.AutoSize = True
        Me.radTimeBased.Location = New System.Drawing.Point(6, 19)
        Me.radTimeBased.Name = "radTimeBased"
        Me.radTimeBased.Size = New System.Drawing.Size(80, 17)
        Me.radTimeBased.TabIndex = 0
        Me.radTimeBased.TabStop = True
        Me.radTimeBased.Text = "Time based"
        Me.radTimeBased.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 56)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(169, 20)
        Me.DateTimePicker1.TabIndex = 152
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Recurrence Start Date"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbrptUom)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 94)
        Me.GroupBox3.TabIndex = 153
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Recurrence Period Value"
        '
        'cmbrptUom
        '
        Me.cmbrptUom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrptUom.FormattingEnabled = True
        Me.cmbrptUom.Location = New System.Drawing.Point(224, 22)
        Me.cmbrptUom.Name = "cmbrptUom"
        Me.cmbrptUom.Size = New System.Drawing.Size(72, 21)
        Me.cmbrptUom.TabIndex = 131
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Repeat for every"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(127, 23)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(74, 20)
        Me.TextBox4.TabIndex = 129
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbThreshold)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextBox7)
        Me.GroupBox4.Location = New System.Drawing.Point(320, 69)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(239, 50)
        Me.GroupBox4.TabIndex = 154
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Threshold Period"
        '
        'cmbThreshold
        '
        Me.cmbThreshold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThreshold.FormattingEnabled = True
        Me.cmbThreshold.Items.AddRange(New Object() {"Days", "Months"})
        Me.cmbThreshold.Location = New System.Drawing.Point(154, 18)
        Me.cmbThreshold.Name = "cmbThreshold"
        Me.cmbThreshold.Size = New System.Drawing.Size(72, 21)
        Me.cmbThreshold.TabIndex = 131
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Before"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(64, 19)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(74, 20)
        Me.TextBox7.TabIndex = 129
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(403, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 157
        Me.Button3.Text = "Ok"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(484, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 156
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmTrigger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(562, 298)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmTrigger"
        Me.Text = "Triggers"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOccurence As System.Windows.Forms.TextBox
    Friend WithEvents radEndAfter As System.Windows.Forms.RadioButton
    Friend WithEvents radNoEnd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radMeter As System.Windows.Forms.RadioButton
    Friend WithEvents radTimeBased As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbrptUom As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbThreshold As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

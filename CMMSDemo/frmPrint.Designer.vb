<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Dim RadPrintWatermark3 As Telerik.WinControls.UI.RadPrintWatermark = New Telerik.WinControls.UI.RadPrintWatermark()
        Me.btnPrintSettings = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.RadEmp = New System.Windows.Forms.RadioButton()
        Me.RadEqp = New System.Windows.Forms.RadioButton()
        Me.RadWo = New System.Windows.Forms.RadioButton()
        Me.RadTask = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SchPrintDocument = New Telerik.WinControls.UI.RadPrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrintSettings
        '
        Me.btnPrintSettings.Location = New System.Drawing.Point(6, 77)
        Me.btnPrintSettings.Name = "btnPrintSettings"
        Me.btnPrintSettings.Size = New System.Drawing.Size(122, 23)
        Me.btnPrintSettings.TabIndex = 0
        Me.btnPrintSettings.Text = "Print Settings"
        Me.btnPrintSettings.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(6, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(122, 23)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(6, 48)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(122, 23)
        Me.btnPreview.TabIndex = 2
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnPreview)
        Me.GroupBox1.Controls.Add(Me.btnPrintSettings)
        Me.GroupBox1.Location = New System.Drawing.Point(141, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 106)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.RadEmp)
        Me.grpType.Controls.Add(Me.RadEqp)
        Me.grpType.Controls.Add(Me.RadWo)
        Me.grpType.Controls.Add(Me.RadTask)
        Me.grpType.Location = New System.Drawing.Point(12, 12)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(110, 138)
        Me.grpType.TabIndex = 115
        Me.grpType.TabStop = False
        Me.grpType.Text = "Schedular Type"
        '
        'RadEmp
        '
        Me.RadEmp.AutoSize = True
        Me.RadEmp.Location = New System.Drawing.Point(7, 78)
        Me.RadEmp.Name = "RadEmp"
        Me.RadEmp.Size = New System.Drawing.Size(71, 17)
        Me.RadEmp.TabIndex = 3
        Me.RadEmp.Text = "Employee"
        Me.RadEmp.UseVisualStyleBackColor = True
        '
        'RadEqp
        '
        Me.RadEqp.AutoSize = True
        Me.RadEqp.Location = New System.Drawing.Point(7, 101)
        Me.RadEqp.Name = "RadEqp"
        Me.RadEqp.Size = New System.Drawing.Size(75, 17)
        Me.RadEqp.TabIndex = 2
        Me.RadEqp.Text = "Equipment"
        Me.RadEqp.UseVisualStyleBackColor = True
        '
        'RadWo
        '
        Me.RadWo.AutoSize = True
        Me.RadWo.Checked = True
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
        Me.RadTask.Location = New System.Drawing.Point(7, 55)
        Me.RadTask.Name = "RadTask"
        Me.RadTask.Size = New System.Drawing.Size(49, 17)
        Me.RadTask.TabIndex = 1
        Me.RadTask.Text = "Task"
        Me.RadTask.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(209, 183)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(69, 23)
        Me.btnClose.TabIndex = 117
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SchPrintDocument
        '
        Me.SchPrintDocument.FooterFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchPrintDocument.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchPrintDocument.Watermark = RadPrintWatermark3
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 215)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 253)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 253)
        Me.Name = "frmPrint"
        Me.Text = "Print"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrintSettings As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents RadEmp As System.Windows.Forms.RadioButton
    Friend WithEvents RadEqp As System.Windows.Forms.RadioButton
    Friend WithEvents RadWo As System.Windows.Forms.RadioButton
    Friend WithEvents RadTask As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SchPrintDocument As Telerik.WinControls.UI.RadPrintDocument
End Class

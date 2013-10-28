<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssets))
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvmeter = New Telerik.WinControls.UI.RadGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAddReading = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dgvAssetmaint = New Telerik.WinControls.UI.RadGridView()
        Me.txtAddMaintanance = New System.Windows.Forms.Button()
        CType(Me.dgvmeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvmeter.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAssetmaint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAssetmaint.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(180, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(242, 20)
        Me.TextBox2.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Asset"
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(428, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 24)
        Me.Button6.TabIndex = 87
        Me.Button6.Tag = "DISABLE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 20)
        Me.TextBox1.TabIndex = 88
        '
        'dgvmeter
        '
        Me.dgvmeter.Location = New System.Drawing.Point(0, 30)
        Me.dgvmeter.Name = "dgvmeter"
        Me.dgvmeter.Size = New System.Drawing.Size(567, 187)
        Me.dgvmeter.TabIndex = 89
        Me.dgvmeter.Text = "RadGridView1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dgvmeter)
        Me.GroupBox1.Controls.Add(Me.txtAddReading)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 265)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asset Meter Reading History"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 23)
        Me.Button2.TabIndex = 140
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 23)
        Me.Button1.TabIndex = 139
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAddReading
        '
        Me.txtAddReading.Location = New System.Drawing.Point(6, 236)
        Me.txtAddReading.Name = "txtAddReading"
        Me.txtAddReading.Size = New System.Drawing.Size(76, 23)
        Me.txtAddReading.TabIndex = 138
        Me.txtAddReading.Text = "Add"
        Me.txtAddReading.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.dgvAssetmaint)
        Me.GroupBox2.Controls.Add(Me.txtAddMaintanance)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 265)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asset Maintanance"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(88, 236)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 23)
        Me.Button3.TabIndex = 140
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(170, 236)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 23)
        Me.Button4.TabIndex = 139
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dgvAssetmaint
        '
        Me.dgvAssetmaint.Location = New System.Drawing.Point(0, 30)
        Me.dgvAssetmaint.Name = "dgvAssetmaint"
        Me.dgvAssetmaint.Size = New System.Drawing.Size(567, 187)
        Me.dgvAssetmaint.TabIndex = 89
        Me.dgvAssetmaint.Text = "RadGridView2"
        '
        'txtAddMaintanance
        '
        Me.txtAddMaintanance.Location = New System.Drawing.Point(6, 236)
        Me.txtAddMaintanance.Name = "txtAddMaintanance"
        Me.txtAddMaintanance.Size = New System.Drawing.Size(76, 23)
        Me.txtAddMaintanance.TabIndex = 138
        Me.txtAddMaintanance.Text = "Add"
        Me.txtAddMaintanance.UseVisualStyleBackColor = True
        '
        'frmAssets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 690)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Name = "frmAssets"
        Me.Text = "Assets"
        CType(Me.dgvmeter.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvmeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvAssetmaint.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAssetmaint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvmeter As Telerik.WinControls.UI.RadGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAddReading As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dgvAssetmaint As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtAddMaintanance As System.Windows.Forms.Button
End Class

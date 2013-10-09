<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvInstructions = New Telerik.WinControls.UI.RadGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnfind = New System.Windows.Forms.Button()
        Me.txtInstruction = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radPredefined = New System.Windows.Forms.RadioButton()
        Me.radNonPredefined = New System.Windows.Forms.RadioButton()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvInstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInstructions.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvInstructions)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Size = New System.Drawing.Size(677, 541)
        Me.SplitContainer1.SplitterDistance = 309
        Me.SplitContainer1.TabIndex = 0
        '
        'dgvInstructions
        '
        Me.dgvInstructions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInstructions.Location = New System.Drawing.Point(0, 0)
        Me.dgvInstructions.Name = "dgvInstructions"
        Me.dgvInstructions.Size = New System.Drawing.Size(677, 309)
        Me.dgvInstructions.TabIndex = 0
        Me.dgvInstructions.Text = "RadGridView1"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(590, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 112
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(428, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(509, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 111
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnfind
        '
        Me.btnfind.Image = CType(resources.GetObject("btnfind.Image"), System.Drawing.Image)
        Me.btnfind.Location = New System.Drawing.Point(622, 127)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(24, 24)
        Me.btnfind.TabIndex = 94
        Me.btnfind.Tag = "DISABLE"
        '
        'txtInstruction
        '
        Me.txtInstruction.Location = New System.Drawing.Point(35, 71)
        Me.txtInstruction.Multiline = True
        Me.txtInstruction.Name = "txtInstruction"
        Me.txtInstruction.ReadOnly = True
        Me.txtInstruction.Size = New System.Drawing.Size(557, 80)
        Me.txtInstruction.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radNonPredefined)
        Me.GroupBox1.Controls.Add(Me.radPredefined)
        Me.GroupBox1.Controls.Add(Me.txtInstruction)
        Me.GroupBox1.Controls.Add(Me.btnfind)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 168)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instruction"
        '
        'radPredefined
        '
        Me.radPredefined.AutoSize = True
        Me.radPredefined.Location = New System.Drawing.Point(35, 32)
        Me.radPredefined.Name = "radPredefined"
        Me.radPredefined.Size = New System.Drawing.Size(72, 17)
        Me.radPredefined.TabIndex = 95
        Me.radPredefined.TabStop = True
        Me.radPredefined.Text = "Predifined"
        Me.radPredefined.UseVisualStyleBackColor = True
        '
        'radNonPredefined
        '
        Me.radNonPredefined.AutoSize = True
        Me.radNonPredefined.Location = New System.Drawing.Point(160, 32)
        Me.radNonPredefined.Name = "radNonPredefined"
        Me.radNonPredefined.Size = New System.Drawing.Size(99, 17)
        Me.radNonPredefined.TabIndex = 96
        Me.radNonPredefined.TabStop = True
        Me.radNonPredefined.Text = "Non Predefined"
        Me.radNonPredefined.UseVisualStyleBackColor = True
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 541)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmInstructions"
        Me.Text = "Instructions"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvInstructions.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInstructions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvInstructions As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtInstruction As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radNonPredefined As System.Windows.Forms.RadioButton
    Friend WithEvents radPredefined As System.Windows.Forms.RadioButton
End Class

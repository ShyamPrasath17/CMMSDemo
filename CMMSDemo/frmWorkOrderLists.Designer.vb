<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkOrderLists
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
        Me.dgvWo = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dgvWo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWo.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWo
        '
        Me.dgvWo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWo.EnableCustomFiltering = True
        Me.dgvWo.Location = New System.Drawing.Point(0, 0)
        '
        'dgvWo
        '
        Me.dgvWo.MasterTemplate.EnableCustomFiltering = True
        Me.dgvWo.MasterTemplate.EnableFiltering = True
        Me.dgvWo.Name = "dgvWo"
        Me.dgvWo.Size = New System.Drawing.Size(752, 365)
        Me.dgvWo.TabIndex = 0
        Me.dgvWo.Text = "RadGridView1"
        '
        'frmWorkOrderLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 365)
        Me.Controls.Add(Me.dgvWo)
        Me.Name = "frmWorkOrderLists"
        Me.Text = "WorkOrderList"
        CType(Me.dgvWo.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvWo As Telerik.WinControls.UI.RadGridView
End Class

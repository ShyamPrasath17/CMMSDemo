<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedMaintList
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
        Me.dgvSchedMaint = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dgvSchedMaint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSchedMaint.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSchedMaint
        '
        Me.dgvSchedMaint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSchedMaint.Location = New System.Drawing.Point(0, 0)
        Me.dgvSchedMaint.Name = "dgvSchedMaint"
        Me.dgvSchedMaint.Size = New System.Drawing.Size(718, 373)
        Me.dgvSchedMaint.TabIndex = 0
        Me.dgvSchedMaint.Text = "RadGridView1"
        '
        'frmSchedMaintList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 373)
        Me.Controls.Add(Me.dgvSchedMaint)
        Me.Name = "frmSchedMaintList"
        Me.Text = "Scheduled Maintanance List"
        CType(Me.dgvSchedMaint.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSchedMaint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvSchedMaint As Telerik.WinControls.UI.RadGridView
End Class

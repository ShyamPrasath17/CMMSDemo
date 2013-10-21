<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkrequestList
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
        Me.dgvWorkReq = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dgvWorkReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWorkReq.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWorkReq
        '
        Me.dgvWorkReq.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWorkReq.Location = New System.Drawing.Point(0, 0)
        Me.dgvWorkReq.Name = "dgvWorkReq"
        Me.dgvWorkReq.Size = New System.Drawing.Size(802, 326)
        Me.dgvWorkReq.TabIndex = 0
        Me.dgvWorkReq.Text = "RadGridView1"
        '
        'frmWorkrequestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 326)
        Me.Controls.Add(Me.dgvWorkReq)
        Me.Name = "frmWorkrequestList"
        Me.Text = "Work Request List"
        CType(Me.dgvWorkReq.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWorkReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvWorkReq As Telerik.WinControls.UI.RadGridView
End Class

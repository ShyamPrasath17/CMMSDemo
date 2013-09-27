<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskLists
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
        Me.dgvTasks = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTasks.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTasks
        '
        Me.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTasks.Location = New System.Drawing.Point(0, 0)
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.Size = New System.Drawing.Size(551, 403)
        Me.dgvTasks.TabIndex = 1
        Me.dgvTasks.Text = "RadGridView1"
        '
        'frmTaskLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 403)
        Me.Controls.Add(Me.dgvTasks)
        Me.Name = "frmTaskLists"
        Me.Text = "Task List"
        CType(Me.dgvTasks.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvTasks As Telerik.WinControls.UI.RadGridView
End Class

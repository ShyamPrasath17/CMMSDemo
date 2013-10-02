<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskPool
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
        Me.dgvIndepSchedTaskList = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dgvIndepSchedTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIndepSchedTaskList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIndepSchedTaskList
        '
        Me.dgvIndepSchedTaskList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIndepSchedTaskList.Location = New System.Drawing.Point(0, 0)
        Me.dgvIndepSchedTaskList.Name = "dgvIndepSchedTaskList"
        Me.dgvIndepSchedTaskList.Size = New System.Drawing.Size(802, 326)
        Me.dgvIndepSchedTaskList.TabIndex = 0
        Me.dgvIndepSchedTaskList.Text = "RadGridView1"
        '
        'frmIndependentTaskPool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 326)
        Me.Controls.Add(Me.dgvIndepSchedTaskList)
        Me.Name = "frmIndependentTaskPool"
        Me.Text = "Task Pool"
        CType(Me.dgvIndepSchedTaskList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIndepSchedTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvIndepSchedTaskList As Telerik.WinControls.UI.RadGridView
End Class

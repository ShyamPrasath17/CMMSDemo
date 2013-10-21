<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectList
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
        Me.dgvProjectList = New Telerik.WinControls.UI.RadGridView()
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProjectList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProjectList
        '
        Me.dgvProjectList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProjectList.EnableCustomFiltering = True
        Me.dgvProjectList.Location = New System.Drawing.Point(0, 0)
        '
        'dgvProjectList
        '
        Me.dgvProjectList.MasterTemplate.EnableCustomFiltering = True
        Me.dgvProjectList.MasterTemplate.EnableFiltering = True
        Me.dgvProjectList.Name = "dgvProjectList"
        Me.dgvProjectList.Size = New System.Drawing.Size(620, 394)
        Me.dgvProjectList.TabIndex = 0
        Me.dgvProjectList.Text = "RadGridView1"
        '
        'frmProjectList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 394)
        Me.Controls.Add(Me.dgvProjectList)
        Me.Name = "frmProjectList"
        Me.Text = "Project List"
        CType(Me.dgvProjectList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvProjectList As Telerik.WinControls.UI.RadGridView
End Class

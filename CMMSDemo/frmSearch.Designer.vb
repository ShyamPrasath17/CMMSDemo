<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.AdvanceFilterControl1 = New CMMSDemo.AdvanceFilterControl()
        Me.SuspendLayout()
        '
        'AdvanceFilterControl1
        '
        Me.AdvanceFilterControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvanceFilterControl1.GridView = Nothing
        Me.AdvanceFilterControl1.Location = New System.Drawing.Point(0, 0)
        Me.AdvanceFilterControl1.Name = "AdvanceFilterControl1"
        Me.AdvanceFilterControl1.SelectedColName = ""
        Me.AdvanceFilterControl1.Size = New System.Drawing.Size(574, 102)
        Me.AdvanceFilterControl1.TabIndex = 0
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 102)
        Me.Controls.Add(Me.AdvanceFilterControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmSearch"
        Me.Text = "frmSearch"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents AdvanceFilterControl1 As CMMSDemo.AdvanceFilterControl
End Class

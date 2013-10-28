<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.txtInitialCatalog = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(548, 148)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtDataSource
        '
        Me.txtDataSource.Location = New System.Drawing.Point(162, 34)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(173, 20)
        Me.txtDataSource.TabIndex = 5
        Me.txtDataSource.Text = "THARIK-PC\TOWNSUITE"
        '
        'txtInitialCatalog
        '
        Me.txtInitialCatalog.Location = New System.Drawing.Point(162, 60)
        Me.txtInitialCatalog.Name = "txtInitialCatalog"
        Me.txtInitialCatalog.Size = New System.Drawing.Size(173, 20)
        Me.txtInitialCatalog.TabIndex = 6
        Me.txtInitialCatalog.Text = "DBCMMS"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(162, 86)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(173, 20)
        Me.txtUser.TabIndex = 7
        Me.txtUser.Text = "sa"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(162, 109)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(173, 20)
        Me.txtPass.TabIndex = 8
        Me.txtPass.Text = "Wheymu1"
        Me.txtPass.UseSystemPasswordChar = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 198)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtInitialCatalog)
        Me.Controls.Add(Me.txtDataSource)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtDataSource As System.Windows.Forms.TextBox
    Friend WithEvents txtInitialCatalog As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
End Class

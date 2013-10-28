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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(192, 113)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtDataSource
        '
        Me.txtDataSource.Location = New System.Drawing.Point(94, 12)
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(173, 20)
        Me.txtDataSource.TabIndex = 5
        Me.txtDataSource.Text = "THARIK-PC\TOWNSUITE"
        '
        'txtInitialCatalog
        '
        Me.txtInitialCatalog.Location = New System.Drawing.Point(94, 38)
        Me.txtInitialCatalog.Name = "txtInitialCatalog"
        Me.txtInitialCatalog.Size = New System.Drawing.Size(173, 20)
        Me.txtInitialCatalog.TabIndex = 6
        Me.txtInitialCatalog.Text = "DBCMMS"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(94, 64)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(173, 20)
        Me.txtUser.TabIndex = 7
        Me.txtUser.Text = "sa"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(94, 87)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(173, 20)
        Me.txtPass.TabIndex = 8
        Me.txtPass.Text = "Wheymu1"
        Me.txtPass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Data Source :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Initial Catalog :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password :"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(280, 144)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

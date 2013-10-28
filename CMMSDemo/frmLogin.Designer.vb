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
        Me.txtConn = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtConn
        '
        Me.txtConn.Location = New System.Drawing.Point(100, 49)
        Me.txtConn.Name = "txtConn"
        Me.txtConn.Size = New System.Drawing.Size(523, 20)
        Me.txtConn.TabIndex = 3
        Me.txtConn.Text = "Data Source=SHYAM-PC\TOWNSUITE;Initial Catalog=DBCMMS;Persist Security Info=True;" & _
    "User ID=sa;Password=Wheymu1"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(3, 52)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(91, 13)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "Connection String"
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
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 198)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtConn)
        Me.Controls.Add(Me.Label40)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConn As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
End Class

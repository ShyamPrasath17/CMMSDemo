<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectListNG2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectListNG2))
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGO = New System.Windows.Forms.Button()
        Me.btnReSet = New System.Windows.Forms.Button()
        Me.chkActive = New System.Windows.Forms.RadioButton()
        Me.chkInActive = New System.Windows.Forms.RadioButton()
        Me.chkBoth = New System.Windows.Forms.RadioButton()
        Me.TrackBarZoomer = New System.Windows.Forms.TrackBar()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.rdkSelect = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindowSelect = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.dgvSelectList = New Telerik.WinControls.UI.RadGridView()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip3 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.chkWithinSearch = New System.Windows.Forms.CheckBox()
        Me.BtnLoadLayout = New System.Windows.Forms.Button()
        Me.BtnSaveLayout = New System.Windows.Forms.Button()
        Me.BtnDefLayout = New System.Windows.Forms.Button()
        Me.GroupBoxSplit = New System.Windows.Forms.GroupBox()
        Me.rdoVerticle = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.CtlRadGridAdvanceFilterControl1 = New CMMSDemo.CtlRadGridAdvanceFilterControl()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarZoomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdkSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rdkSelect.SuspendLayout()
        Me.ToolWindowSelect.SuspendLayout()
        CType(Me.dgvSelectList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelectList.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSplit.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcess.BackColor = System.Drawing.SystemColors.Control
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnProcess.Location = New System.Drawing.Point(545, 411)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(80, 23)
        Me.btnProcess.TabIndex = 28
        Me.btnProcess.Text = "Empty"
        Me.btnProcess.UseVisualStyleBackColor = False
        Me.btnProcess.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Location = New System.Drawing.Point(557, 500)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 23)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOK.Location = New System.Drawing.Point(559, 529)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(63, 23)
        Me.btnOK.TabIndex = 32
        Me.btnOK.Text = "S&elect >>"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 602)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(634, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(634, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnGO
        '
        Me.btnGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGO.BackColor = System.Drawing.SystemColors.Control
        Me.btnGO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGO.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGO.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGO.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnGO.Location = New System.Drawing.Point(548, 438)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(80, 23)
        Me.btnGO.TabIndex = 37
        Me.btnGO.Text = "&SEARCH"
        Me.btnGO.UseVisualStyleBackColor = False
        '
        'btnReSet
        '
        Me.btnReSet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReSet.BackColor = System.Drawing.SystemColors.Control
        Me.btnReSet.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReSet.Location = New System.Drawing.Point(558, 468)
        Me.btnReSet.Name = "btnReSet"
        Me.btnReSet.Size = New System.Drawing.Size(63, 23)
        Me.btnReSet.TabIndex = 38
        Me.btnReSet.Text = "&Reset"
        Me.btnReSet.UseVisualStyleBackColor = False
        '
        'chkActive
        '
        Me.chkActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkActive.BackColor = System.Drawing.Color.Transparent
        Me.chkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkActive.Location = New System.Drawing.Point(15, 408)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(71, 24)
        Me.chkActive.TabIndex = 39
        Me.chkActive.Text = "&Active"
        Me.chkActive.UseVisualStyleBackColor = False
        '
        'chkInActive
        '
        Me.chkInActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkInActive.BackColor = System.Drawing.Color.Transparent
        Me.chkInActive.Location = New System.Drawing.Point(86, 407)
        Me.chkInActive.Name = "chkInActive"
        Me.chkInActive.Size = New System.Drawing.Size(64, 24)
        Me.chkInActive.TabIndex = 40
        Me.chkInActive.Text = "&InActive"
        Me.chkInActive.UseVisualStyleBackColor = False
        '
        'chkBoth
        '
        Me.chkBoth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkBoth.BackColor = System.Drawing.Color.Transparent
        Me.chkBoth.Location = New System.Drawing.Point(156, 407)
        Me.chkBoth.Name = "chkBoth"
        Me.chkBoth.Size = New System.Drawing.Size(51, 24)
        Me.chkBoth.TabIndex = 41
        Me.chkBoth.Text = "&Both"
        Me.chkBoth.UseVisualStyleBackColor = False
        Me.chkBoth.Visible = False
        '
        'TrackBarZoomer
        '
        Me.TrackBarZoomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBarZoomer.Location = New System.Drawing.Point(241, 411)
        Me.TrackBarZoomer.Maximum = 36
        Me.TrackBarZoomer.Minimum = 8
        Me.TrackBarZoomer.Name = "TrackBarZoomer"
        Me.TrackBarZoomer.Size = New System.Drawing.Size(170, 45)
        Me.TrackBarZoomer.TabIndex = 47
        Me.TrackBarZoomer.Value = 8
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.CanUpdateChildIndex = True
        Me.DocumentTabStrip1.CausesValidation = False
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(765, 344)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'rdkSelect
        '
        Me.rdkSelect.ActiveWindow = Me.ToolWindowSelect
        Me.rdkSelect.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdkSelect.CausesValidation = False
        Me.rdkSelect.Controls.Add(Me.ToolTabStrip2)
        Me.rdkSelect.Controls.Add(Me.DocumentContainer1)
        Me.rdkSelect.IsCleanUpTarget = True
        Me.rdkSelect.Location = New System.Drawing.Point(0, 27)
        Me.rdkSelect.MainDocumentContainer = Me.DocumentContainer1
        Me.rdkSelect.Name = "rdkSelect"
        Me.rdkSelect.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.rdkSelect.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.rdkSelect.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.rdkSelect.Size = New System.Drawing.Size(634, 377)
        Me.rdkSelect.TabIndex = 49
        Me.rdkSelect.TabStop = False
        Me.rdkSelect.Text = "RadDock1"
        '
        'ToolWindowSelect
        '
        Me.ToolWindowSelect.Caption = Nothing
        Me.ToolWindowSelect.Controls.Add(Me.dgvSelectList)
        Me.ToolWindowSelect.Location = New System.Drawing.Point(1, 24)
        Me.ToolWindowSelect.Name = "ToolWindowSelect"
        Me.ToolWindowSelect.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindowSelect.Size = New System.Drawing.Size(622, 312)
        Me.ToolWindowSelect.Text = "TableName - RowCount"
        '
        'dgvSelectList
        '
        Me.dgvSelectList.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvSelectList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSelectList.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dgvSelectList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvSelectList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvSelectList.Location = New System.Drawing.Point(0, 0)
        '
        'dgvSelectList
        '
        Me.dgvSelectList.MasterTemplate.AllowAddNewRow = False
        Me.dgvSelectList.MasterTemplate.EnableFiltering = True
        Me.dgvSelectList.Name = "dgvSelectList"
        Me.dgvSelectList.ReadOnly = True
        Me.dgvSelectList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvSelectList.Size = New System.Drawing.Size(622, 312)
        Me.dgvSelectList.TabIndex = 0
        Me.dgvSelectList.Text = "RadGridView1"
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.CanUpdateChildIndex = True
        Me.ToolTabStrip2.CausesValidation = False
        Me.ToolTabStrip2.Controls.Add(Me.ToolWindowSelect)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(624, 338)
        Me.ToolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 372)
        Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 172)
        Me.ToolTabStrip2.TabIndex = 0
        Me.ToolTabStrip2.TabStop = False
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.CausesValidation = False
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.RootElement.Padding = New System.Windows.Forms.Padding(5)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-536, -760)
        Me.DocumentContainer1.TabIndex = 2
        '
        'DocumentTabStrip3
        '
        Me.DocumentTabStrip3.CanUpdateChildIndex = True
        Me.DocumentTabStrip3.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip3.Name = "DocumentTabStrip3"
        '
        '
        '
        Me.DocumentTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip3.Size = New System.Drawing.Size(278, 336)
        Me.DocumentTabStrip3.TabIndex = 1
        Me.DocumentTabStrip3.TabStop = False
        '
        'chkWithinSearch
        '
        Me.chkWithinSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkWithinSearch.AutoSize = True
        Me.chkWithinSearch.Location = New System.Drawing.Point(417, 414)
        Me.chkWithinSearch.Name = "chkWithinSearch"
        Me.chkWithinSearch.Size = New System.Drawing.Size(125, 17)
        Me.chkWithinSearch.TabIndex = 51
        Me.chkWithinSearch.Text = "Search within search"
        Me.chkWithinSearch.UseVisualStyleBackColor = True
        '
        'BtnLoadLayout
        '
        Me.BtnLoadLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoadLayout.Location = New System.Drawing.Point(367, 572)
        Me.BtnLoadLayout.Name = "BtnLoadLayout"
        Me.BtnLoadLayout.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoadLayout.TabIndex = 52
        Me.BtnLoadLayout.Text = "Load Layout"
        Me.BtnLoadLayout.UseVisualStyleBackColor = True
        '
        'BtnSaveLayout
        '
        Me.BtnSaveLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveLayout.Location = New System.Drawing.Point(286, 572)
        Me.BtnSaveLayout.Name = "BtnSaveLayout"
        Me.BtnSaveLayout.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveLayout.TabIndex = 53
        Me.BtnSaveLayout.Text = "Save Layout"
        Me.BtnSaveLayout.UseVisualStyleBackColor = True
        '
        'BtnDefLayout
        '
        Me.BtnDefLayout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDefLayout.Location = New System.Drawing.Point(448, 572)
        Me.BtnDefLayout.Name = "BtnDefLayout"
        Me.BtnDefLayout.Size = New System.Drawing.Size(81, 23)
        Me.BtnDefLayout.TabIndex = 54
        Me.BtnDefLayout.Text = "Load Default Layout"
        Me.BtnDefLayout.UseVisualStyleBackColor = True
        '
        'GroupBoxSplit
        '
        Me.GroupBoxSplit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxSplit.Controls.Add(Me.rdoVerticle)
        Me.GroupBoxSplit.Controls.Add(Me.rdoNone)
        Me.GroupBoxSplit.Controls.Add(Me.rdoHorizontal)
        Me.GroupBoxSplit.Location = New System.Drawing.Point(15, 561)
        Me.GroupBoxSplit.Name = "GroupBoxSplit"
        Me.GroupBoxSplit.Size = New System.Drawing.Size(235, 35)
        Me.GroupBoxSplit.TabIndex = 55
        Me.GroupBoxSplit.TabStop = False
        Me.GroupBoxSplit.Text = "Split Mode"
        '
        'rdoVerticle
        '
        Me.rdoVerticle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rdoVerticle.BackColor = System.Drawing.Color.Transparent
        Me.rdoVerticle.Location = New System.Drawing.Point(152, 10)
        Me.rdoVerticle.Name = "rdoVerticle"
        Me.rdoVerticle.Size = New System.Drawing.Size(83, 24)
        Me.rdoVerticle.TabIndex = 58
        Me.rdoVerticle.Text = "Verticle"
        Me.rdoVerticle.UseVisualStyleBackColor = False
        '
        'rdoNone
        '
        Me.rdoNone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdoNone.BackColor = System.Drawing.Color.Transparent
        Me.rdoNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoNone.Location = New System.Drawing.Point(7, 10)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(54, 24)
        Me.rdoNone.TabIndex = 56
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = False
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdoHorizontal.BackColor = System.Drawing.Color.Transparent
        Me.rdoHorizontal.Location = New System.Drawing.Point(67, 10)
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Size = New System.Drawing.Size(79, 24)
        Me.rdoHorizontal.TabIndex = 57
        Me.rdoHorizontal.Text = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = False
        '
        'CtlRadGridAdvanceFilterControl1
        '
        Me.CtlRadGridAdvanceFilterControl1.GridView = Nothing
        Me.CtlRadGridAdvanceFilterControl1.Location = New System.Drawing.Point(12, 440)
        Me.CtlRadGridAdvanceFilterControl1.Name = "CtlRadGridAdvanceFilterControl1"
        Me.CtlRadGridAdvanceFilterControl1.SelectedColName = ""
        Me.CtlRadGridAdvanceFilterControl1.Size = New System.Drawing.Size(485, 112)
        Me.CtlRadGridAdvanceFilterControl1.TabIndex = 56
        '
        'frmSelectListNG2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 622)
        Me.Controls.Add(Me.CtlRadGridAdvanceFilterControl1)
        Me.Controls.Add(Me.GroupBoxSplit)
        Me.Controls.Add(Me.BtnDefLayout)
        Me.Controls.Add(Me.BtnSaveLayout)
        Me.Controls.Add(Me.BtnLoadLayout)
        Me.Controls.Add(Me.chkWithinSearch)
        Me.Controls.Add(Me.rdkSelect)
        Me.Controls.Add(Me.TrackBarZoomer)
        Me.Controls.Add(Me.chkBoth)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.chkInActive)
        Me.Controls.Add(Me.btnReSet)
        Me.Controls.Add(Me.btnGO)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimumSize = New System.Drawing.Size(650, 660)
        Me.Name = "frmSelectListNG2"
        Me.Text = "TownSuite - Search Engine"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarZoomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdkSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rdkSelect.ResumeLayout(False)
        Me.ToolWindowSelect.ResumeLayout(False)
        CType(Me.dgvSelectList.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelectList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSplit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents btnReSet As System.Windows.Forms.Button
    Friend WithEvents chkActive As System.Windows.Forms.RadioButton
    Friend WithEvents chkInActive As System.Windows.Forms.RadioButton
    Friend WithEvents chkBoth As System.Windows.Forms.RadioButton
    Friend WithEvents TrackBarZoomer As System.Windows.Forms.TrackBar
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents rdkSelect As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents dgvSelectList As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ToolWindowSelect As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentTabStrip3 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents chkWithinSearch As System.Windows.Forms.CheckBox
    Friend WithEvents BtnLoadLayout As System.Windows.Forms.Button
    Friend WithEvents BtnSaveLayout As System.Windows.Forms.Button
    Friend WithEvents BtnDefLayout As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSplit As System.Windows.Forms.GroupBox
    Friend WithEvents rdoNone As System.Windows.Forms.RadioButton
    Friend WithEvents rdoVerticle As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHorizontal As System.Windows.Forms.RadioButton
    Friend WithEvents CtlRadGridAdvanceFilterControl1 As CMMSDemo.CtlRadGridAdvanceFilterControl
End Class

Imports Microsoft.VisualBasic
Imports System

Partial Public Class CtlRadGridAdvanceFilterControl
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' 
    ''' 
    ''' 
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.chkAllCols = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkCaseSensitive = New Telerik.WinControls.UI.RadCheckBox()
        Me.radLabelSearch = New Telerik.WinControls.UI.RadLabel()
        Me.radTextBoxSearch = New Telerik.WinControls.UI.RadTextBox()
        Me.txtAdvanceSearch = New Telerik.WinControls.UI.RadTextBox()
        Me.cboColumns = New System.Windows.Forms.ComboBox()
        Me.cboOperator = New System.Windows.Forms.ComboBox()
        Me.rtbValue1 = New Telerik.WinControls.UI.RadTextBox()
        Me.radDdlColumns = New Telerik.WinControls.UI.RadDropDownList()
        Me.radDropDownButtonOperator = New Telerik.WinControls.UI.RadDropDownButton()
        Me.radLabelFilter = New Telerik.WinControls.UI.RadLabel()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.radSearchPage = New Telerik.WinControls.UI.RadPageViewPage()
        Me.lblColName = New Telerik.WinControls.UI.RadLabel()
        Me.radAdvancedPage = New Telerik.WinControls.UI.RadPageViewPage()
        CType(Me.chkAllCols, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCaseSensitive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTextBoxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdvanceSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtbValue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDdlColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDropDownButtonOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.radSearchPage.SuspendLayout()
        CType(Me.lblColName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radAdvancedPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkAllCols
        '
        Me.chkAllCols.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAllCols.Location = New System.Drawing.Point(196, 3)
        Me.chkAllCols.Name = "chkAllCols"
        Me.chkAllCols.Size = New System.Drawing.Size(80, 18)
        Me.chkAllCols.TabIndex = 3
        Me.chkAllCols.Text = "All Columns"
        Me.chkAllCols.Visible = False
        '
        'chkCaseSensitive
        '
        Me.chkCaseSensitive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCaseSensitive.Location = New System.Drawing.Point(282, 3)
        Me.chkCaseSensitive.Name = "chkCaseSensitive"
        Me.chkCaseSensitive.Size = New System.Drawing.Size(91, 18)
        Me.chkCaseSensitive.TabIndex = 2
        Me.chkCaseSensitive.Text = "Case Sensitive"
        Me.chkCaseSensitive.Visible = False
        '
        'radLabelSearch
        '
        Me.radLabelSearch.Location = New System.Drawing.Point(15, 3)
        Me.radLabelSearch.Name = "radLabelSearch"
        Me.radLabelSearch.Size = New System.Drawing.Size(128, 18)
        Me.radLabelSearch.TabIndex = 1
        Me.radLabelSearch.Text = "Type your search criteria"
        '
        'radTextBoxSearch
        '
        Me.radTextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radTextBoxSearch.Location = New System.Drawing.Point(3, 27)
        Me.radTextBoxSearch.Name = "radTextBoxSearch"
        Me.radTextBoxSearch.Size = New System.Drawing.Size(458, 20)
        Me.radTextBoxSearch.TabIndex = 0
        Me.radTextBoxSearch.TabStop = False
        '
        'txtAdvanceSearch
        '
        Me.txtAdvanceSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAdvanceSearch.Location = New System.Drawing.Point(310, 23)
        Me.txtAdvanceSearch.Name = "txtAdvanceSearch"
        Me.txtAdvanceSearch.Size = New System.Drawing.Size(151, 20)
        Me.txtAdvanceSearch.TabIndex = 13
        Me.txtAdvanceSearch.TabStop = False
        '
        'cboColumns
        '
        Me.cboColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColumns.FormattingEnabled = True
        Me.cboColumns.Location = New System.Drawing.Point(3, 23)
        Me.cboColumns.Name = "cboColumns"
        Me.cboColumns.Size = New System.Drawing.Size(149, 21)
        Me.cboColumns.TabIndex = 12
        '
        'cboOperator
        '
        Me.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperator.FormattingEnabled = True
        Me.cboOperator.Location = New System.Drawing.Point(158, 23)
        Me.cboOperator.Name = "cboOperator"
        Me.cboOperator.Size = New System.Drawing.Size(146, 21)
        Me.cboOperator.TabIndex = 11
        '
        'rtbValue1
        '
        Me.rtbValue1.Location = New System.Drawing.Point(261, 24)
        Me.rtbValue1.Name = "rtbValue1"
        '
        '
        '
        Me.rtbValue1.RootElement.Enabled = False
        Me.rtbValue1.Size = New System.Drawing.Size(10, 20)
        Me.rtbValue1.TabIndex = 8
        Me.rtbValue1.TabStop = False
        Me.rtbValue1.Visible = False
        '
        'radDdlColumns
        '
        Me.radDdlColumns.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.radDdlColumns.Location = New System.Drawing.Point(35, 24)
        Me.radDdlColumns.Name = "radDdlColumns"
        Me.radDdlColumns.Size = New System.Drawing.Size(10, 20)
        Me.radDdlColumns.TabIndex = 6
        Me.radDdlColumns.Visible = False
        '
        'radDropDownButtonOperator
        '
        Me.radDropDownButtonOperator.Location = New System.Drawing.Point(190, 28)
        Me.radDropDownButtonOperator.Name = "radDropDownButtonOperator"
        Me.radDropDownButtonOperator.Size = New System.Drawing.Size(10, 15)
        Me.radDropDownButtonOperator.TabIndex = 4
        Me.radDropDownButtonOperator.Text = "Equals"
        Me.radDropDownButtonOperator.Visible = False
        '
        'radLabelFilter
        '
        Me.radLabelFilter.Location = New System.Drawing.Point(3, 3)
        Me.radLabelFilter.Name = "radLabelFilter"
        Me.radLabelFilter.Size = New System.Drawing.Size(75, 18)
        Me.radLabelFilter.TabIndex = 1
        Me.radLabelFilter.Text = "Filter rows by:"
        '
        'RadPageView1
        '
        Me.RadPageView1.Controls.Add(Me.radSearchPage)
        Me.RadPageView1.Controls.Add(Me.radAdvancedPage)
        Me.RadPageView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPageView1.Location = New System.Drawing.Point(0, 0)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.radSearchPage
        Me.RadPageView1.Size = New System.Drawing.Size(485, 112)
        Me.RadPageView1.TabIndex = 1
        Me.RadPageView1.Text = "RadPageView1"
        CType(Me.RadPageView1.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'radSearchPage
        '
        Me.radSearchPage.Controls.Add(Me.lblColName)
        Me.radSearchPage.Controls.Add(Me.chkAllCols)
        Me.radSearchPage.Controls.Add(Me.radLabelSearch)
        Me.radSearchPage.Controls.Add(Me.radTextBoxSearch)
        Me.radSearchPage.Controls.Add(Me.chkCaseSensitive)
        Me.radSearchPage.Location = New System.Drawing.Point(10, 37)
        Me.radSearchPage.Name = "radSearchPage"
        Me.radSearchPage.Size = New System.Drawing.Size(464, 64)
        Me.radSearchPage.Text = "Search"
        '
        'lblColName
        '
        Me.lblColName.Location = New System.Drawing.Point(162, 3)
        Me.lblColName.Name = "lblColName"
        Me.lblColName.Size = New System.Drawing.Size(2, 2)
        Me.lblColName.TabIndex = 2
        '
        'radAdvancedPage
        '
        Me.radAdvancedPage.Controls.Add(Me.txtAdvanceSearch)
        Me.radAdvancedPage.Controls.Add(Me.cboOperator)
        Me.radAdvancedPage.Controls.Add(Me.cboColumns)
        Me.radAdvancedPage.Controls.Add(Me.radDdlColumns)
        Me.radAdvancedPage.Controls.Add(Me.radLabelFilter)
        Me.radAdvancedPage.Controls.Add(Me.radDropDownButtonOperator)
        Me.radAdvancedPage.Controls.Add(Me.rtbValue1)
        Me.radAdvancedPage.Location = New System.Drawing.Point(10, 37)
        Me.radAdvancedPage.Name = "radAdvancedPage"
        Me.radAdvancedPage.Size = New System.Drawing.Size(464, 64)
        Me.radAdvancedPage.Text = "Advance Search"
        '
        'CtlRadGridAdvanceFilterControl
        '
        Me.Controls.Add(Me.RadPageView1)
        Me.Name = "CtlRadGridAdvanceFilterControl"
        Me.Size = New System.Drawing.Size(485, 112)
        CType(Me.chkAllCols, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCaseSensitive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTextBoxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdvanceSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtbValue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDdlColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDropDownButtonOperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.radSearchPage.ResumeLayout(False)
        Me.radSearchPage.PerformLayout()
        CType(Me.lblColName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radAdvancedPage.ResumeLayout(False)
        Me.radAdvancedPage.PerformLayout()
        Me.ResumeLayout(False)

End Sub

#End Region

    Private WithEvents radTextBoxSearch As Telerik.WinControls.UI.RadTextBox
    Private WithEvents rtbValue1 As Telerik.WinControls.UI.RadTextBox
    Private radDdlColumns As Telerik.WinControls.UI.RadDropDownList
    Private radDropDownButtonOperator As Telerik.WinControls.UI.RadDropDownButton
    Private radLabelFilter As Telerik.WinControls.UI.RadLabel
    Private radLabelSearch As Telerik.WinControls.UI.RadLabel
    Friend WithEvents chkCaseSensitive As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkAllCols As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents cboOperator As System.Windows.Forms.ComboBox
    Friend WithEvents cboColumns As System.Windows.Forms.ComboBox
    Private WithEvents txtAdvanceSearch As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents radSearchPage As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents radAdvancedPage As Telerik.WinControls.UI.RadPageViewPage
    Private WithEvents lblColName As Telerik.WinControls.UI.RadLabel
End Class


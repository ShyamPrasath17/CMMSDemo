Imports Microsoft.VisualBasic
Imports System
	Partial Public Class AdvanceFilterControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
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
        Me.radPageView = New Telerik.WinControls.UI.RadPageView()
        Me.radSearchPage = New Telerik.WinControls.UI.RadPageViewPage()
        Me.lblColName = New Telerik.WinControls.UI.RadLabel()
        Me.chkCaseSensitive = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkAllCols = New Telerik.WinControls.UI.RadCheckBox()
        Me.radLabelSearch = New Telerik.WinControls.UI.RadLabel()
        Me.radTextBoxSearch = New Telerik.WinControls.UI.RadTextBox()
        Me.radAdvancedPage = New Telerik.WinControls.UI.RadPageViewPage()
        Me.radBtnAdvanceApply = New Telerik.WinControls.UI.RadButton()
        Me.rtbValue1 = New Telerik.WinControls.UI.RadTextBox()
        Me.radDdlColumns = New Telerik.WinControls.UI.RadDropDownList()
        Me.radDropDownButtonOperator = New Telerik.WinControls.UI.RadDropDownButton()
        Me.radLabelFilter = New Telerik.WinControls.UI.RadLabel()
        CType(Me.radPageView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radPageView.SuspendLayout()
        Me.radSearchPage.SuspendLayout()
        CType(Me.lblColName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCaseSensitive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAllCols, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTextBoxSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radAdvancedPage.SuspendLayout()
        CType(Me.radBtnAdvanceApply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rtbValue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDdlColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radDropDownButtonOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radPageView
        '
        Me.radPageView.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.radPageView.Controls.Add(Me.radSearchPage)
        Me.radPageView.Controls.Add(Me.radAdvancedPage)
        Me.radPageView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radPageView.Location = New System.Drawing.Point(0, 0)
        Me.radPageView.Name = "radPageView"
        Me.radPageView.SelectedPage = Me.radSearchPage
        Me.radPageView.Size = New System.Drawing.Size(496, 103)
        Me.radPageView.TabIndex = 0
        Me.radPageView.Text = "PageView"
        CType(Me.radPageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        '
        'radSearchPage
        '
        Me.radSearchPage.Controls.Add(Me.lblColName)
        Me.radSearchPage.Controls.Add(Me.chkCaseSensitive)
        Me.radSearchPage.Controls.Add(Me.chkAllCols)
        Me.radSearchPage.Controls.Add(Me.radLabelSearch)
        Me.radSearchPage.Controls.Add(Me.radTextBoxSearch)
        Me.radSearchPage.Location = New System.Drawing.Point(10, 37)
        Me.radSearchPage.Name = "radSearchPage"
        Me.radSearchPage.Size = New System.Drawing.Size(475, 55)
        Me.radSearchPage.Text = "Search"
        '
        'lblColName
        '
        Me.lblColName.Location = New System.Drawing.Point(137, 3)
        Me.lblColName.Name = "lblColName"
        Me.lblColName.Size = New System.Drawing.Size(2, 2)
        Me.lblColName.TabIndex = 2
        '
        'chkCaseSensitive
        '
        Me.chkCaseSensitive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCaseSensitive.Location = New System.Drawing.Point(381, 4)
        Me.chkCaseSensitive.Name = "chkCaseSensitive"
        Me.chkCaseSensitive.Size = New System.Drawing.Size(91, 18)
        Me.chkCaseSensitive.TabIndex = 3
        Me.chkCaseSensitive.Text = "Case Sensitive"
        '
        'chkAllCols
        '
        Me.chkAllCols.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAllCols.Location = New System.Drawing.Point(295, 4)
        Me.chkAllCols.Name = "chkAllCols"
        Me.chkAllCols.Size = New System.Drawing.Size(80, 18)
        Me.chkAllCols.TabIndex = 2
        Me.chkAllCols.Text = "All Columns"
        '
        'radLabelSearch
        '
        Me.radLabelSearch.Location = New System.Drawing.Point(3, 3)
        Me.radLabelSearch.Name = "radLabelSearch"
        Me.radLabelSearch.Size = New System.Drawing.Size(128, 18)
        Me.radLabelSearch.TabIndex = 1
        Me.radLabelSearch.Text = "Type your search criteria"
        '
        'radTextBoxSearch
        '
        Me.radTextBoxSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radTextBoxSearch.Location = New System.Drawing.Point(3, 28)
        Me.radTextBoxSearch.Name = "radTextBoxSearch"
        Me.radTextBoxSearch.Size = New System.Drawing.Size(469, 20)
        Me.radTextBoxSearch.TabIndex = 0
        Me.radTextBoxSearch.TabStop = False
        '
        'radAdvancedPage
        '
        Me.radAdvancedPage.Controls.Add(Me.radBtnAdvanceApply)
        Me.radAdvancedPage.Controls.Add(Me.rtbValue1)
        Me.radAdvancedPage.Controls.Add(Me.radDdlColumns)
        Me.radAdvancedPage.Controls.Add(Me.radDropDownButtonOperator)
        Me.radAdvancedPage.Controls.Add(Me.radLabelFilter)
        Me.radAdvancedPage.Location = New System.Drawing.Point(10, 37)
        Me.radAdvancedPage.Name = "radAdvancedPage"
        Me.radAdvancedPage.Size = New System.Drawing.Size(475, 55)
        Me.radAdvancedPage.Text = "Advanced"
        '
        'radBtnAdvanceApply
        '
        Me.radBtnAdvanceApply.Location = New System.Drawing.Point(390, 28)
        Me.radBtnAdvanceApply.Name = "radBtnAdvanceApply"
        Me.radBtnAdvanceApply.Size = New System.Drawing.Size(78, 21)
        Me.radBtnAdvanceApply.TabIndex = 10
        Me.radBtnAdvanceApply.Text = "Apply"
        '
        'rtbValue1
        '
        Me.rtbValue1.Enabled = False
        Me.rtbValue1.Location = New System.Drawing.Point(246, 28)
        Me.rtbValue1.Name = "rtbValue1"
        '
        '
        '
        Me.rtbValue1.RootElement.Enabled = False
        Me.rtbValue1.Size = New System.Drawing.Size(135, 20)
        Me.rtbValue1.TabIndex = 8
        Me.rtbValue1.TabStop = False
        '
        'radDdlColumns
        '
        Me.radDdlColumns.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.radDdlColumns.Location = New System.Drawing.Point(3, 28)
        Me.radDdlColumns.Name = "radDdlColumns"
        Me.radDdlColumns.Size = New System.Drawing.Size(123, 20)
        Me.radDdlColumns.TabIndex = 6
        '
        'radDropDownButtonOperator
        '
        Me.radDropDownButtonOperator.Location = New System.Drawing.Point(132, 28)
        Me.radDropDownButtonOperator.Name = "radDropDownButtonOperator"
        Me.radDropDownButtonOperator.Size = New System.Drawing.Size(106, 21)
        Me.radDropDownButtonOperator.TabIndex = 4
        Me.radDropDownButtonOperator.Text = "Equals"
        '
        'radLabelFilter
        '
        Me.radLabelFilter.Location = New System.Drawing.Point(3, 3)
        Me.radLabelFilter.Name = "radLabelFilter"
        Me.radLabelFilter.Size = New System.Drawing.Size(75, 18)
        Me.radLabelFilter.TabIndex = 1
        Me.radLabelFilter.Text = "Filter rows by:"
        '
        'AdvanceFilterControl
        '
        Me.Controls.Add(Me.radPageView)
        Me.Name = "AdvanceFilterControl"
        Me.Size = New System.Drawing.Size(496, 103)
        CType(Me.radPageView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radPageView.ResumeLayout(False)
        Me.radSearchPage.ResumeLayout(False)
        Me.radSearchPage.PerformLayout()
        CType(Me.lblColName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCaseSensitive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAllCols, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTextBoxSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radAdvancedPage.ResumeLayout(False)
        Me.radAdvancedPage.PerformLayout()
        CType(Me.radBtnAdvanceApply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rtbValue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDdlColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radDropDownButtonOperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelFilter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

		#End Region

		Private radPageView As Telerik.WinControls.UI.RadPageView
		Private radSearchPage As Telerik.WinControls.UI.RadPageViewPage
		Private WithEvents radTextBoxSearch As Telerik.WinControls.UI.RadTextBox
		Private radAdvancedPage As Telerik.WinControls.UI.RadPageViewPage
		Private WithEvents radBtnAdvanceApply As Telerik.WinControls.UI.RadButton
		Private WithEvents rtbValue1 As Telerik.WinControls.UI.RadTextBox
		Private radDdlColumns As Telerik.WinControls.UI.RadDropDownList
		Private radDropDownButtonOperator As Telerik.WinControls.UI.RadDropDownButton
		Private radLabelFilter As Telerik.WinControls.UI.RadLabel
    Private radLabelSearch As Telerik.WinControls.UI.RadLabel
    Friend WithEvents chkCaseSensitive As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkAllCols As Telerik.WinControls.UI.RadCheckBox
    Private WithEvents lblColName As Telerik.WinControls.UI.RadLabel
	End Class


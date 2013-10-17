Imports System.Collections.Generic
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls.UI.GridHeaderCellElement
Imports System.Windows.Forms
Imports System.Threading
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Imports Telerik.WinControls
Imports System.Data.SqlClient

Public Class frmSelectListNG2

    ''' <summary>
    ''' This will be an object of the type of list you passed in.
    ''' 
    ''' If you pass in a List(Of LibTsFincDto.PO.Lookups.PoLookupInfo) the ReturnRow
    ''' will be LibTsFincDto.PO.Lookups.PoLookupInfo
    ''' and can be accessed with DirectCast(frm.ReturnRow, LibTsFincDto.PO.Lookups.PoLookupInfo)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ReturnRow As Telerik.WinControls.UI.GridViewRowInfo

    Private _originalDataActive As Object
    Private _originalData As Object
    'Private p_MyProcessSub As libUtilities.GlobalVariables.MyProcessSub
    Private p_CloseAfterProcess As Boolean
    Private specialSearchType As SpecialSearch = SpecialSearch.NONE

    Private includeCustomerPropertyMeterBalance As Boolean = False

    Private DataSPName As String
    Private SPParameters As ArrayList
    Private CurrentColumn As String
    Private ActiveColName As String
    Private DefaultSearchVal As String

    Private CurrentActType As ActiveType

    Private ModName As String

    Public Delegate Sub MyProcessSub()

    Private p_MyProcessSub As MyProcessSub

    Private ReadOnly Property OriginalData As Object
        Get
            Return _originalData
        End Get
    End Property

    Public Enum SpecialSearch
        NONE = 0
        ARCUSTOMER = 1
        ARMETER = 2
        ARPROPERTY = 3
    End Enum
    Public Shared strConn As String

    Private LayoutTag As String
    Private RgvTitle As String
    Private dtSelectItems As DataTable
    Private Initialized As Boolean
    Private colmnByParameter As Boolean
    Dim dtFilteredList As New DataTable

    'RadsGridMenu Items
    Private menuGrid As New RadContextMenu
    Private itemLayoutSettings As RadMenuItem
    Private itemSaveLayout As RadMenuItem
    Private itemLoadLayout As RadMenuItem
    Private itemLoadDefLayout As RadMenuItem
    Private itemSplit As RadMenuItem
    Private itemSplitNone As RadMenuItem
    Private itemSplitVerticle As RadMenuItem
    Private itemSplitHorizontal As RadMenuItem

        
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Tag">This tag value will be saved in datgrid layout settings table </param>
    ''' <param name="gridTitle">This will be shown the title of the tool window with row count.</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal tag As String, ByVal moduleName As String, ByVal gridTitle As String, ByVal activeColumnName As String)

        Me.New(Nothing, False, "", tag, moduleName, gridTitle, activeColumnName)
    End Sub


    Public Sub New(ByVal specialSearchType As SpecialSearch, _
                   ByVal includeBalance As Boolean, tag As String, ByVal moduleName As String, gridTitle As String, ByVal activeColumnName As String)



        ' This call is required by the designer.
        InitializeComponent()
        LayoutTag = tag
        RgvTitle = gridTitle
        ActiveColName = activeColumnName
        dgvSelectList.AutoSizeRows = True ' Row height will be adjusted
        dgvSelectList.BestFitColumns() ' Column width will be adjusted according to text length after zoom
        ModName = moduleName

        ' Add any initialization after the InitializeComponent() call.
        Me.DataSPName = String.Empty
        Me.specialSearchType = specialSearchType

        If activeColumnName = String.Empty Then
            chkActive.Visible = False
            chkBoth.Visible = False
            chkInActive.Visible = False
        Else
            chkActive.Visible = True
            chkBoth.Visible = True
        End If



        includeCustomerPropertyMeterBalance = includeBalance

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pMyProcessSub">A delegate that will be run if the Empty button is clicked.  
    ''' If this is not nothing the Empty button will be made visible. </param>
    ''' <param name="pCloseAfterProcess">If true the search will be closed after the Empty button is clicked.</param>
    ''' <param name="emptyButtonText">The text value that should be displayed on the Empty button.</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef pMyProcessSub As MyProcessSub, _
    ByVal pCloseAfterProcess As Boolean, ByVal emptyButtonText As String, Tag As String, ByVal moduleName As String, ByVal gridTitle As String, ByVal activeColumnName As String)


        ' This call is required by the designer.
        InitializeComponent()
        LayoutTag = Tag
        RgvTitle = gridTitle
        ActiveColName = activeColumnName
        dgvSelectList.AutoSizeRows = True ' Row height will be adjusted
        dgvSelectList.BestFitColumns() ' Column width will be adjusted according to text length after zoom
        ModName = moduleName

        ' Add any initialization after the InitializeComponent() call.
        Me.DataSPName = String.Empty
        p_MyProcessSub = pMyProcessSub
        p_CloseAfterProcess = pCloseAfterProcess
        If p_MyProcessSub IsNot Nothing Then
            btnProcess.Visible = True
            btnProcess.Text = ""
        End If

        If activeColumnName = String.Empty Then
            chkActive.Visible = False
            chkBoth.Visible = False
            chkInActive.Visible = False
        Else
            chkActive.Visible = True
            chkBoth.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' The data in the DataGrid is set by calling this function
    ''' </summary>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub SetData(ByVal data As DataTable)

        ' DataGridView1.DataContext = data

        SetData(data, "", "")

    End Sub

    ''' <summary>
    ''' The data in the DataGrid is set by calling this function
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="data"></param>
    ''' <remarks></remarks>
    Public Sub SetData(Of T)(ByVal data As List(Of T))

        ' DataGridView1.DataContext = data

        SetData(data, "", "")

    End Sub

    Private _searchColumnName As String = ""

    ''' <summary>
    ''' The data returned by spName will be set to DataGrid
    ''' </summary>
    ''' <param name="spName">Stored procedure name which provides data.</param>
    ''' <remarks></remarks>
    Public Sub SetData(ByVal spName As String)
        SetData(spName, Nothing, "", "")
    End Sub

    ''' <summary>
    ''' The data returned by spName will be set to DataGrid
    ''' </summary>
    ''' <param name="spName">Stored procedure name which provides data.</param>
    ''' <param name="argArray">Parameter list for store procedure, If there are no parameters pass Nothing/Null</param>
    ''' <remarks></remarks>
    Public Sub SetData(ByVal spName As String, ByVal argArray As ArrayList, ByVal searchVal As String)
        SetData(spName, argArray, "", searchVal)
    End Sub

    ''' <summary>
    ''' The data returned by spName will be set to DataGrid
    ''' </summary>
    ''' <param name="spName">Stored procedure name which provides data.</param>
    ''' <param name="searchColumn">A column to auto search</param>
    ''' <param name="searchValue">The value that will be auto searched when searchColumn has a value</param>
    ''' <remarks></remarks>
    Public Sub SetData(ByVal spName As String, ByVal searchColumn As String, ByVal searchValue As String)
        SetData(spName, Nothing, searchColumn, searchValue)
    End Sub

    ''' <summary>
    ''' The data returned by spName will be set to DataGrid
    ''' </summary>
    ''' <param name="spName">Stored procedure name which provides data.</param>
    ''' <param name="searchColumn">A column to auto search</param>
    ''' <param name="searchValue">The value that will be auto searched when searchColumn has a value</param>
    ''' <param name="argArray">Parameter list for store procedure, If there are no parameters pass Nothing/Null</param>
    ''' <remarks></remarks>
    Public Sub SetData(ByVal spName As String, ByVal argArray As ArrayList, ByVal searchColumn As String, ByVal searchValue As String)
        DataSPName = spName
        SPParameters = argArray

        If argArray Is Nothing Then
            SetData(cls_EXE_STORED_PROCEDURE_DATATABLE(spName), searchColumn, searchValue)
        ElseIf argArray.Count = 0 Then
            SetData(cls_EXE_STORED_PROCEDURE_DATATABLE(spName), searchColumn, searchValue)
        Else
            SetData(cls_EXE_STORED_PROCEDURE_DATATABLE_PRAM(argArray, spName), searchColumn, searchValue)
        End If

    End Sub


    ''' <summary>
    ''' The data in the DataGrid is set by calling this function
    ''' </summary>
    ''' <param name="data">Generic list that will be displayed in the search grid.</param>
    ''' <param name="searchColumn">A column to auto search</param>
    ''' <param name="searchValue">The value that will be auto searched when searchColumn has a value</param>
    ''' <remarks></remarks>
    Public Sub SetData(ByVal data As DataTable, ByVal searchColumn As String, ByVal searchValue As String)
        dgvSelectList.DataSource = Nothing ' Telerik temporary work around for bug 714971

        DefaultSearchVal = searchValue
        TrackBarZoomer.Value = Convert.ToInt32(dgvSelectList.Font.Size)
        dgvSelectList.AutoSizeRows = True ' Row height will be adjusted
        dgvSelectList.DataSource = data.Copy
        dgvSelectList.BestFitColumns()
        If Not Initialized Then
            _originalData = data
            _searchColumnName = searchColumn
        End If

        If ActiveColName <> String.Empty Then
            _originalDataActive = data.Copy()
        End If

        'Do a search if search column is defined
        If searchColumn <> String.Empty Then

            If MultiRows(dgvSelectList, searchColumn, searchValue) Then
                Dim CurrentColumnTemp As String = ""
                CurrentColumn = searchColumn

                'Temporary set Control Text box  as searchValue parameter
                CtlRadGridAdvanceFilterControl1.TextBoxValue = searchValue

                'Invoke search button
                btnGO_Click(Nothing, Nothing)

                'Clear Control Text box
                CtlRadGridAdvanceFilterControl1.TextBoxValue = String.Empty
            End If
        End If
    End Sub


    Private Function MultiRows(ByRef dataGrid As Telerik.WinControls.UI.RadGridView, ByVal colName As String, ByVal value As String) As Boolean
        Dim count As Integer = 0

        For i As Integer = 0 To dataGrid.Rows.Count - 1
            If dataGrid.Rows(i).Cells(colName).Value.ToString.Trim = value.Trim Then
                dataGrid.Rows(i).IsSelected = True
                dataGrid.Rows(i).IsCurrent = True
                Return False
            End If
        Next
        Return True
    End Function


    ''' <summary>
    ''' The data in the DataGrid is set by calling this function
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="data">Generic list that will be displayed in the search grid.</param>
    ''' <param name="searchColumn">A column to auto search</param>
    ''' <param name="searchValue">The value that will be auto searched when searchColumn has a value</param>
    ''' <remarks></remarks>
    Public Sub SetData(Of T)(ByVal data As List(Of T), ByVal searchColumn As String, ByVal searchValue As String)
        dgvSelectList.DataSource = Nothing ' Telerik temporary work around for bug 714971

        dgvSelectList.DataSource = data
        If dgvSelectList.Columns(0).Name.ToLower = "include" Then
            dgvSelectList.Columns(0).IsVisible = False
        End If

        If Not Initialized Then
            _originalData = data
            _searchColumnName = searchColumn
        End If
    End Sub



    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            If dgvSelectList.SelectedRows.Count > 0 Then
                ReturnRow = dgvSelectList.SelectedRows(0)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            Me.Close()
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        Finally

        End Try
    End Sub

    Private Sub btnProcess_Click(sender As System.Object, e As System.EventArgs) Handles btnProcess.Click
        Try

            If p_MyProcessSub IsNot Nothing Then
                p_MyProcessSub.Invoke()
                If Me.p_CloseAfterProcess = True Then
                    Me.Close()
                End If

            End If

        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    ''' <summary>
    ''' On double click on a row auto click the selection button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RadGridView1_DoubleClick(sender As System.Object, e As System.EventArgs)
        Try
            btnOK_Click(sender, e)
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try

    End Sub

    Private Sub frmSelectListNG2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' serch column has been set in code so auto do a search on the data using the values that
        ' where set in SetData
        'If _searchColumnName.Trim <> "" And txtFilter.Text.Trim <> "" Then
        '    If TypeOf OriginalData Is IList And OriginalData.GetType.IsGenericType Then

        '        Dim count As Integer = 0
        '        For Each col As Telerik.WinControls.UI.GridViewColumn In dgvSelectList.Columns
        '            If col.Name.ToLower.Trim = _searchColumnName.ToLower.Trim Then
        '                _searchColumn = count
        '                If TypeOf OriginalData Is IList And OriginalData.GetType.IsGenericType Then

        '                    For Each row As Telerik.WinControls.UI.GridViewRowInfo In dgvSelectList.Rows

        '                        If row.Cells(Me._searchColumn).Value.ToString.StartsWith(txtFilter.Text) = True Then
        '                            row.IsSelected = True

        '                            Dim tableElement As Telerik.WinControls.UI.GridTableElement = TryCast(Me.dgvSelectList.CurrentView, Telerik.WinControls.UI.GridTableElement)
        '                            tableElement.ScrollToRow(row)

        '                            Exit For
        '                        End If

        '                    Next
        '                End If

        '                Exit For
        '            End If

        '            count = count + 1
        '        Next
        '    End If
        'End If ' Removed controls 


        LoadGridMenu()


        dgvSelectList.EnableFiltering = True
        LoadRadSettings(False)

        'Tool window properties, disable close tool window and change its dock state
        ToolWindowSelect.ToolCaptionButtons = ToolStripCaptionButtons.None
        rdkSelect.MainDocumentContainerVisible = False

        Dim behavior As BaseGridBehavior = DirectCast(dgvSelectList.GridBehavior, BaseGridBehavior)
        behavior.UnregisterBehavior(GetType(GridViewTableHeaderRowInfo))
        behavior.RegisterBehavior(GetType(GridViewTableHeaderRowInfo), New CustomGridHeaderRowBehavior())

        AddHandler Me.dgvSelectList.Click, AddressOf dgvSelect_Click
        AddHandler Me.dgvSelectList.GroupDescriptors.CollectionChanged, AddressOf GroupDescriptors_CollectionChanged

        chkActive.Checked = True

        Initialized = True

        'Check inactive if there are no records for active
        If dgvSelectList.RowCount = 0 Then
            chkInActive.Checked = True
            If dgvSelectList.RowCount = 0 Then
                chkActive.Checked = True
            End If
        End If



        'Set Me as object for callbacks from the controller
        CtlRadGridAdvanceFilterControl1.formObj = Me
    End Sub

    Private Sub GroupDescriptors_CollectionChanged(sender As Object, e As NotifyCollectionChangedEventArgs)

        RemoveHandler Me.dgvSelectList.GroupDescriptors.CollectionChanged, AddressOf GroupDescriptors_CollectionChanged

        If e.Action = NotifyCollectionChangedAction.ItemChanged Then
            For Each group As GroupDescriptor In e.NewItems
                group.GroupNames(0).Direction = ListSortDirection.Ascending
            Next
        End If

        AddHandler Me.dgvSelectList.GroupDescriptors.CollectionChanged, AddressOf GroupDescriptors_CollectionChanged
    End Sub

    Private Sub dgvSelect_Click(sender As Object, e As EventArgs)
        Dim grid As RadGridView = TryCast(sender, RadGridView)
        Dim mouseEvent As MouseEventArgs = TryCast(e, MouseEventArgs)
        If grid IsNot Nothing AndAlso mouseEvent IsNot Nothing Then
            Dim element As RadElement = grid.ElementTree.GetElementAtPoint(mouseEvent.Location)
            Dim headerCell As GridHeaderCellElement = TryCast(element, GridHeaderCellElement)
            If headerCell IsNot Nothing Then
                CtlRadGridAdvanceFilterControl1.SelectedColName = headerCell.Text
            Else
                Dim groupFieldEl As GroupFieldElement = TryCast(element, GroupFieldElement)
                If groupFieldEl IsNot Nothing Then
                    CtlRadGridAdvanceFilterControl1.SelectedColName = groupFieldEl.Text
                End If
            End If
        End If
    End Sub

    Public Sub btnGO_Click(sender As System.Object, e As System.EventArgs) Handles btnGO.Click
        Dim textVal As String
        Dim idxWhere As Integer
        Dim idxVal As Integer

        Try
            If CurrentColumn.Trim = String.Empty Then
                MsgBox("Please select a column for searching", MsgBoxStyle.Information, "Information")
                Exit Sub
            End If

            Dim actClause As String = ""

            If Not LayoutTag.Trim = String.Empty Then

                If SPParameters Is Nothing Then
                    idxWhere = -1
                    idxVal = -1
                Else
                    idxWhere = SPParameters.IndexOf("@pWhereClause")
                    idxVal = SPParameters.IndexOf("@pSearchValue")
                End If

                If (idxWhere = -1 And idxVal = -1) Or chkWithinSearch.Checked Then
                    'SPs without where clause or search within search

                    If ActiveColName IsNot Nothing AndAlso ActiveColName <> String.Empty Then
                        If CurrentActType = ActiveType.ACTIVE Then
                            actClause = " AND " + ActiveColName + " = 'True'"
                        ElseIf CurrentActType = ActiveType.INACTIVE Then
                            actClause = " AND " + ActiveColName + " = 'False'"
                        ElseIf CurrentActType = ActiveType.BOTH Then
                            actClause = ""
                        End If
                    End If


                    If CtlRadGridAdvanceFilterControl1.AdvanceTab Then
                        'Check Advance filter control selected tab
                        textVal = CtlRadGridAdvanceFilterControl1.AdvanceTextBoxValue

                        If DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter <> String.Empty Then
                            DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter += " AND " + CreateAdvanceWhereClause(CtlRadGridAdvanceFilterControl1.AdvanceColName, textVal, CtlRadGridAdvanceFilterControl1.AdvanceSearchCriteria) + actClause
                        Else
                            DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = CreateAdvanceWhereClause(CtlRadGridAdvanceFilterControl1.AdvanceColName, textVal, CtlRadGridAdvanceFilterControl1.AdvanceSearchCriteria) + actClause
                        End If

                    Else
                        'Normal search
                        If dgvSelectList.Columns(CurrentColumn).DataType Is System.Type.GetType("System.Boolean") Then
                            Dim val As String = CtlRadGridAdvanceFilterControl1.TextBoxValue

                            If val = "1" Then
                                val = "=  'True'"
                            ElseIf val = "0" Then
                                val = "=  'False'"
                            ElseIf val.ToUpper = "FALSE" Or val.ToUpper = "TRUE" Then
                                val = "= '" + val + "'"
                            Else
                                val = " Is null"
                            End If

                            DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = CurrentColumn + val + actClause

                        ElseIf dgvSelectList.Columns(CurrentColumn).DataType Is System.Type.GetType("System.Decimal") _
                                Or dgvSelectList.Columns(CurrentColumn).DataType Is System.Type.GetType("System.Integer") Then

                            'LIKE does not work for Integer Decimal types in row filtering
                            DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = "Convert([" + CurrentColumn + "], 'System.String') " + " LIKE '%" + CtlRadGridAdvanceFilterControl1.TextBoxValue + "%'" + actClause


                        Else

                            If chkWithinSearch.Checked Then
                                If DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter <> String.Empty Then
                                    DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter += " AND " + CurrentColumn + " LIKE '%" + CtlRadGridAdvanceFilterControl1.TextBoxValue + "%'" + actClause
                                Else
                                    DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = CurrentColumn + " LIKE '%" + CtlRadGridAdvanceFilterControl1.TextBoxValue + "%'" + actClause
                                End If
                            Else
                                DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = CurrentColumn + " LIKE '%" + CtlRadGridAdvanceFilterControl1.TextBoxValue + "%'" + actClause
                            End If



                        End If

                    End If
                Else
                    'DATABASE SEARCH 


                    If ActiveColName IsNot Nothing AndAlso ActiveColName <> String.Empty Then
                        If CurrentActType = ActiveType.ACTIVE Then
                            actClause = " AND " + ActiveColName + " = 1"
                        ElseIf CurrentActType = ActiveType.INACTIVE Then
                            actClause = " AND " + ActiveColName + " = 0"
                        ElseIf CurrentActType = ActiveType.BOTH Then
                            actClause = ""
                        End If
                    End If

                    If CtlRadGridAdvanceFilterControl1.AdvanceTab Then
                        'Check Advance filter control selected tab
                        textVal = CtlRadGridAdvanceFilterControl1.AdvanceTextBoxValue
                        SPParameters.Item(idxWhere + 1) = CreateSearchOperatorSQL(CtlRadGridAdvanceFilterControl1.AdvanceColName, CtlRadGridAdvanceFilterControl1.AdvanceSearchCriteria, textVal) + actClause
                        SPParameters.Item(idxVal + 1) = textVal
                    Else
                        'Normal search
                        textVal = CtlRadGridAdvanceFilterControl1.TextBoxValue
                        If dgvSelectList.Columns(CurrentColumn).DataType Is System.Type.GetType("System.Boolean") Then

                            If textVal.ToUpper = "FALSE" Then
                                textVal = "0"
                            ElseIf textVal.ToUpper = "TRUE" Then
                                textVal = "1"
                            End If
                        End If

                        SPParameters.Item(idxWhere + 1) = CurrentColumn + " LIKE @mpVal" + actClause
                        SPParameters.Item(idxVal + 1) = "%" + textVal + "%"
                    End If
                    SetData(DataSPName, SPParameters, "", "")

                End If
                'Telerik temporary work around for bug 714971
                'LayoutConfigs.LoadSettings()
                'LayoutConfigs.Load(ModName, Me.Name, LayoutTag, dgvSelectList)
                'LayoutConfigs.Load(ModName, Me.Name, rdkSelect)
                SetToolWindowRowCount()
            End If



        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try

    End Sub

    ''' <summary>
    ''' Construct search operator based on selected criteria
    ''' </summary>
    ''' <param name="selectedCriteria">user selected criteria</param>
    ''' <param name="selectedValue">value which should be added to construct the operator</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CreateSearchOperatorSQL(ByRef ColumnName As String, selectedCriteria As String, ByRef selectedValue As String) As String
        Dim SearchOperator As String = ""

        If selectedValue Is Nothing Then
            selectedValue = String.Empty
        End If

        If selectedCriteria = "No Filter" Then
            SearchOperator = "LIKE '%'"
        ElseIf selectedCriteria = "Contains" Then
            SearchOperator = "LIKE @mpVal"
            selectedValue = "%" + selectedValue + "%"
        ElseIf selectedCriteria = "Does not contain" Then
            SearchOperator = "NOT LIKE @mpVal"
            selectedValue = "%" + selectedValue + "%"
        ElseIf selectedCriteria = "Starts with" Then
            SearchOperator = "LIKE @mpVal"
            selectedValue = selectedValue + "%"
        ElseIf selectedCriteria = "Ends with" Then
            SearchOperator = "LIKE @mpVal"
            selectedValue = "%" + selectedValue
        ElseIf selectedCriteria = "Equals" Then
            SearchOperator = "=  @mpVal"
            selectedValue = selectedValue
        ElseIf selectedCriteria = "Not equal to" Then
            SearchOperator = "<> @mpVal"
            selectedValue = selectedValue
        ElseIf selectedCriteria = "Is null" Then
            SearchOperator = " is null"
            selectedValue = ""
        ElseIf selectedCriteria = "Is not null" Then
            SearchOperator = " is not null"
            selectedValue = ""

        ElseIf selectedCriteria = "Is empty" Then
            SearchOperator = " = ''"
            selectedValue = ""
        ElseIf selectedCriteria = "Is not empty" Then
            SearchOperator = " <> ''"
            selectedValue = ""

            'For Boolean values
        ElseIf selectedCriteria = "Is True" Then
            SearchOperator = " = @mpVal"
            selectedValue = "TRUE"
        ElseIf selectedCriteria = "Is False" Then
            SearchOperator = " = @mpVal"
            selectedValue = "FALSE"
            'For Numerical values
        ElseIf selectedCriteria = "Greater than" Then
            SearchOperator = "> @mpVal "
        ElseIf selectedCriteria = "Less than" Then
            SearchOperator = "< @mpVal "
        ElseIf selectedCriteria = "Greater than or equal to" Then
            SearchOperator = ">= @mpVal "
        ElseIf selectedCriteria = "Less than or equal to" Then
            SearchOperator = "<= @mpVal "
        End If
        Return ColumnName + " " + SearchOperator

    End Function

    Private Function CreateSearchOperator(selectedCriteria As String, selectedValue As String) As String
        Dim SearchOperator As String = ""

        If selectedValue Is Nothing Then
            selectedValue = String.Empty
        End If

        If selectedCriteria = "No Filter" Then
            SearchOperator = "LIKE '%'"
        ElseIf selectedCriteria = "Contains" Then
            SearchOperator = "LIKE '%" + selectedValue + "%'"
        ElseIf selectedCriteria = "Does not contain" Then
            SearchOperator = "NOT LIKE '%" + selectedValue + "%'"
        ElseIf selectedCriteria = "Starts with" Then
            SearchOperator = "LIKE '" + selectedValue + "%'"
        ElseIf selectedCriteria = "Ends with" Then
            SearchOperator = "LIKE '%" + selectedValue + "'"

        ElseIf selectedCriteria = "Is null" Then
            SearchOperator = " is null"
        ElseIf selectedCriteria = "Is not null" Or selectedValue.Trim = String.Empty Then
            SearchOperator = " is not null"

        ElseIf selectedCriteria = "Is empty" Then
            SearchOperator = " = ''"
        ElseIf selectedCriteria = "<> ''" Or selectedValue.Trim = String.Empty Then
            SearchOperator = " is not null"

        ElseIf selectedCriteria = "Equals" Then
            SearchOperator = "= '" + selectedValue + "'"
        ElseIf selectedCriteria = "Not equal to" Then
            SearchOperator = "<> '" + selectedValue + "'"


            'For Boolean values
        ElseIf selectedCriteria = "Is True" Then
            SearchOperator = " = True"
        ElseIf selectedCriteria = "Is False" Then
            SearchOperator = " = False"

            'For Numerical values
        ElseIf selectedCriteria = "Greater than" Then
            SearchOperator = "> " + selectedValue
        ElseIf selectedCriteria = "Less than" Then
            SearchOperator = "< " + selectedValue
        ElseIf selectedCriteria = "Greater than or equal to" Then
            SearchOperator = ">= " + selectedValue
        ElseIf selectedCriteria = "Less than or equal to" Then
            SearchOperator = "<= " + selectedValue
        End If

        Return SearchOperator

    End Function

    Private Function CreateAdvanceWhereClause(columnName As String, selectedValue As String, selectedCriteria As String) As String
        Dim SearchOperator As String = CreateSearchOperator(selectedCriteria, selectedValue)
        Return columnName + " " + SearchOperator
    End Function

    Private Sub NoneSpecialSearch()

        If TypeOf OriginalData Is IList And OriginalData.GetType.IsGenericType Then

            For Each row As Telerik.WinControls.UI.GridViewRowInfo In dgvSelectList.Rows

                'If CommonSearch(row.Cells(Me._searchColumn).Value.ToString, txtFilter.Text) = True Then
                '    row.IsVisible = False
                'End If ' Removed controls 

            Next
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="value">The value that is being searched</param>
    ''' <param name="searchTerm">The term that we are looking for</param>
    ''' <remarks></remarks>
    ''' <returns>True if found False if not found</returns>
    Private Function CommonSearch(ByVal value As String, searchTerm As String) As Boolean

        '  =     Equal To
        ' <>  NOT Equal To
        ' >    Greater Then
        ' <     Less Then
        ' >=  Greater/Equal To
        ' <=  Less Then Equal To
        ' *=   Found To Left
        ' =*   Found To Right
        ' *=* Found In
        'If cboOperation.Text = "=" Then
        '    Return value.ToLower = searchTerm.ToLower
        'ElseIf cboOperation.Text = "<>" Then
        '    Return value.ToLower <> searchTerm.ToLower
        'ElseIf cboOperation.Text = ">" Then
        '    Return value.ToLower > searchTerm.ToLower
        'ElseIf cboOperation.Text = "<" Then
        '    Return value.ToLower < searchTerm.ToLower
        'ElseIf cboOperation.Text = ">=" Then
        '    Return value.ToLower >= searchTerm.ToLower
        'ElseIf cboOperation.Text = "<=" Then
        '    Return value.ToLower <= searchTerm.ToLower
        'ElseIf cboOperation.Text = "*=" Then
        '    Return value.ToLower.StartsWith(searchTerm.ToLower)
        'ElseIf cboOperation.Text = "=*" Then
        '    Return value.ToLower.EndsWith(searchTerm.ToLower)
        'ElseIf cboOperation.Text = "*=*" Then
        '    Return value.ToLower.Contains(searchTerm.ToLower)
        'Else
        '    Return value.ToLower.Contains(searchTerm.ToLower)
        'End If ' Removed controls 

        Return False
    End Function


    Private _searchColumn As Integer = 0
    Private Sub RadGridView1_CellClick(sender As System.Object, e As Telerik.WinControls.UI.GridViewCellEventArgs)
        Try
            If dgvSelectList.CurrentCell Is Nothing Then
                Exit Sub
            End If

            If dgvSelectList.CurrentCell.ColumnInfo Is Nothing Then
                Exit Sub
            End If

            _searchColumn = dgvSelectList.CurrentCell.ColumnInfo.Index

            ' GroupBox1.Text = "Search For Column: [" & dgvSelectList.CurrentCell.ColumnInfo.Name & "]" ' Removed controls 
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub btnReSet_Click(sender As System.Object, e As System.EventArgs) Handles btnReSet.Click
        Try
            'For Each row As Telerik.WinControls.UI.GridViewRowInfo In dgvSelectList.Rows
            '    row.IsVisible = True
            'Next
            'dgvSelectList.DataSource = _originalData
            DirectCast(Me.dgvSelectList.DataSource, DataTable).Clear()
            DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = ""
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Function SaveRadSettings() As Boolean
        Dim GridSaved As Boolean
        Dim DockSaved As Boolean

        'LayoutConfigs.LoadSettings()
        'GridSaved = LayoutConfigs.Save(ModName, Me.Name, LayoutTag, dgvSelectList)
        'DockSaved = LayoutConfigs.Save(ModName, Me.Name, rdkSelect)

        Return GridSaved And DockSaved
    End Function

    Private Function LoadRadSettings(defualt As Boolean) As Boolean
        Dim GridLoaded As Boolean
        Dim DockLoaded As Boolean

        'If defualt Then
        '    LayoutConfigs.LoadSettings()
        '    GridLoaded = LayoutConfigs.LoadDef(ModName, Me.Name, LayoutTag, dgvSelectList)
        '    DockLoaded = LayoutConfigs.LoadDef(ModName, Me.Name, rdkSelect)
        'Else
        '    LayoutConfigs.LoadSettings()
        '    GridLoaded = LayoutConfigs.Load(ModName, Me.Name, LayoutTag, dgvSelectList)
        '    DockLoaded = LayoutConfigs.Load(ModName, Me.Name, rdkSelect)
        'End If

        TrackBarZoomer.Value = Convert.ToInt32(dgvSelectList.Font.Size)
        setSelectedSplitOption()


        CtlRadGridAdvanceFilterControl1.GridView = dgvSelectList
        If Not colmnByParameter Then
            'Set First Visible column as search Column
            For i As Integer = 0 To dgvSelectList.Columns.Count - 1
                If dgvSelectList.Columns(i).IsVisible Then
                    CtlRadGridAdvanceFilterControl1.SelectedColName = dgvSelectList.Columns(i).HeaderText
                    CurrentColumn = dgvSelectList.Columns(i).Name

                    If dgvSelectList.CurrentRow IsNot Nothing Then
                        dgvSelectList.CurrentRow.Cells(i).IsSelected = True
                    End If

                    Exit For
                End If
            Next

        End If

        'Set filtering based on the search within 
        chkWithinSearch_CheckedChanged(Nothing, Nothing)

        Return GridLoaded And DockLoaded

    End Function

    Private Sub TrackBarZoomer_Scroll(sender As Object, e As EventArgs) Handles TrackBarZoomer.Scroll
        dgvSelectList.Font = New Font(dgvSelectList.Font.FontFamily, TrackBarZoomer.Value, dgvSelectList.Font.Style) ' Font size increase according to TrackBar value
        dgvSelectList.BestFitColumns() ' Column width will be adjusted according to text length after zoom
    End Sub

    Private Sub LoadGridMenu()
        itemLayoutSettings = New RadMenuItem()
        itemLayoutSettings.Text = "LayoutSettings"

        itemSaveLayout = New RadMenuItem()
        itemSaveLayout.Text = "SaveLayout"

        itemLoadLayout = New RadMenuItem()
        itemLoadLayout.Text = "Load Layout"

        itemLoadDefLayout = New RadMenuItem()
        itemLoadDefLayout.Text = "Load Defualt"


        itemLayoutSettings.Items.Add(itemSaveLayout)
        itemLayoutSettings.Items.Add(itemLoadLayout)
        itemLayoutSettings.Items.Add(itemLoadDefLayout)

        itemSplit = New RadMenuItem()
        itemSplit.Text = "Split"

        itemSplitNone = New RadMenuItem()
        itemSplitNone.Text = "None"

        itemSplitVerticle = New RadMenuItem()
        itemSplitVerticle.Text = "Verticle"

        itemSplitHorizontal = New RadMenuItem()
        itemSplitHorizontal.Text = "Horizontal"

        itemSplitNone.CheckOnClick = True
        itemSplitVerticle.CheckOnClick = True
        itemSplitHorizontal.CheckOnClick = True

        itemSplit.Items.Add(itemSplitNone)
        itemSplit.Items.Add(itemSplitVerticle)
        itemSplit.Items.Add(itemSplitHorizontal)


        AddHandler itemSplitNone.Click, AddressOf itemSplitNone_click
        AddHandler itemSplitVerticle.Click, AddressOf itemSplitVerticle_click
        AddHandler itemSplitHorizontal.Click, AddressOf itemSplitHorizontal_click

        AddHandler itemSaveLayout.Click, AddressOf itemSaveLayout_click
        AddHandler itemLoadLayout.Click, AddressOf itemLoadLayout_click
        AddHandler itemLoadDefLayout.Click, AddressOf itemLoadDefLayout_click


        menuGrid.Items.Add(itemLayoutSettings)
        menuGrid.Items.Add(itemSplit)
    End Sub

    Private Sub itemSaveLayout_click(sender As Object, e As EventArgs)
        Try
            If SaveRadSettings() Then
                MsgBox("Settings Saved Successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Settings Saving Failed!", MsgBoxStyle.Exclamation, "Information")
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub itemLoadLayout_click(sender As Object, e As EventArgs)
        Try
            If LoadRadSettings(False) Then
                MsgBox("Settings Loaded Successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Settings Loading Failed!", MsgBoxStyle.Exclamation, "Information")
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub itemLoadDefLayout_click(sender As Object, e As EventArgs)
        Try
            If LoadRadSettings(True) Then
                MsgBox("Settings Loaded Successfully!", MsgBoxStyle.Information, "Information")
            Else
                MsgBox("Settings Loading Failed!", MsgBoxStyle.Exclamation, "Information")
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub itemSplitNone_click(sender As Object, e As EventArgs)
        Try
            dgvSelectList.SplitMode = RadGridViewSplitMode.None
            dgvSelectList.VerticalScrollState = ScrollState.AutoHide

            itemSplitNone.IsChecked = True
            itemSplitHorizontal.IsChecked = False
            itemSplitVerticle.IsChecked = False

            rdoNone.Checked = True
            rdoVerticle.Checked = False
            rdoHorizontal.Checked = False
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub itemSplitVerticle_click(sender As Object, e As EventArgs)
        Try
            dgvSelectList.SplitMode = RadGridViewSplitMode.Vertical
            dgvSelectList.VerticalScrollState = ScrollState.AlwaysShow

            itemSplitNone.IsChecked = False
            itemSplitHorizontal.IsChecked = False
            itemSplitVerticle.IsChecked = True

            rdoNone.Checked = False
            rdoVerticle.Checked = True
            rdoHorizontal.Checked = False
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub itemSplitHorizontal_click(sender As Object, e As EventArgs)
        Try
            dgvSelectList.SplitMode = RadGridViewSplitMode.Horizontal
            dgvSelectList.VerticalScrollState = ScrollState.AutoHide

            itemSplitNone.IsChecked = False
            itemSplitVerticle.IsChecked = False
            itemSplitHorizontal.IsChecked = True

            rdoNone.Checked = False
            rdoVerticle.Checked = False
            rdoHorizontal.Checked = True
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub dgvSelectList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles dgvSelectList.CellClick
        Try
            If e.Column Is Nothing Then
                Return
            End If

            CtlRadGridAdvanceFilterControl1.SelectedColName = e.Column.HeaderText
            CurrentColumn = e.Column.Name

        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub setSelectedSplitOption()
        Try
            If dgvSelectList.SplitMode = RadGridViewSplitMode.None Then
                itemSplitNone.IsChecked = True
                itemSplitVerticle.IsChecked = False
                itemSplitHorizontal.IsChecked = False

                rdoNone.Checked = True
                rdoHorizontal.Checked = False
                rdoVerticle.Checked = False

            ElseIf dgvSelectList.SplitMode = RadGridViewSplitMode.Vertical Then
                itemSplitNone.IsChecked = False
                itemSplitVerticle.IsChecked = True
                itemSplitHorizontal.IsChecked = False

                rdoNone.Checked = False
                rdoHorizontal.Checked = False
                rdoVerticle.Checked = True

            ElseIf dgvSelectList.SplitMode = RadGridViewSplitMode.Horizontal Then
                itemSplitNone.IsChecked = False
                itemSplitVerticle.IsChecked = False
                itemSplitHorizontal.IsChecked = True

                rdoNone.Checked = False
                rdoHorizontal.Checked = True
                rdoVerticle.Checked = False
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub chkActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkActive.CheckedChanged
        Try
            If chkActive.Checked Then

                If Initialized And SPParameters IsNot Nothing Then
                    DirectCast(Me.dgvSelectList.DataSource, DataTable).Clear()
                End If

                CurrentActType = ActiveType.ACTIVE
                If ActiveColName IsNot Nothing AndAlso ActiveColName <> String.Empty Then
                    DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = ActiveColName + " = TRUE"
                End If
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub chkInActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkInActive.CheckedChanged
        Try
            If chkInActive.Checked Then

                If Initialized And SPParameters IsNot Nothing Then
                    DirectCast(Me.dgvSelectList.DataSource, DataTable).Clear()
                End If

                CurrentActType = ActiveType.INACTIVE
                If ActiveColName IsNot Nothing AndAlso ActiveColName <> String.Empty Then
                    DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = ActiveColName + " = FALSE"
                End If
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub chkBoth_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoth.CheckedChanged
        Try
            If chkBoth.Checked Then

                If Initialized And SPParameters IsNot Nothing Then
                    DirectCast(Me.dgvSelectList.DataSource, DataTable).Clear()
                End If

                CurrentActType = ActiveType.BOTH
                DirectCast(dgvSelectList.DataSource, DataTable).DefaultView.RowFilter = ""
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub dgvSelectList_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles dgvSelectList.RowsChanged
        Try
            SetToolWindowRowCount()
            btnGO.Select()
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub SetToolWindowRowCount()
        If dgvSelectList.Rows.Count = 1 Then
            ToolWindowSelect.Text = RgvTitle + " - " + dgvSelectList.Rows.Count.ToString + " Row"
        Else
            ToolWindowSelect.Text = RgvTitle + " - " + dgvSelectList.Rows.Count.ToString + " Rows"
        End If
    End Sub



    Private Sub dgvSelectList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvSelectList.CellDoubleClick
        Try
            If dgvSelectList.SelectedRows.Count > 0 Then
                ReturnRow = dgvSelectList.SelectedRows(0)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

            Me.Close()
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        Finally

        End Try
    End Sub

    Private Sub dgvSelectList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvSelectList.MouseClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim point As Point = Me.dgvSelectList.PointToClient(Control.MousePosition)
                Dim element As Telerik.WinControls.RadElement = Me.dgvSelectList.ElementTree.GetElementAtPoint(point)
                If TypeOf (element) Is GridHeaderCellElement Or TypeOf (element) Is GridFilterCellElement Or TypeOf (element) Is GridFilterButtonElement Then
                    Return
                End If

                menuGrid.DropDown.Show(dgvSelectList, e.Location)
            End If
        Catch ex As Exception
            'libUtilities.Functions.TrapErrors(ex, True)
        End Try
    End Sub

    Private Sub BtnSaveLayout_Click(sender As Object, e As EventArgs) Handles BtnSaveLayout.Click
        itemSaveLayout_click(sender, e)
    End Sub

    Private Sub BtnLoadLayout_Click(sender As Object, e As EventArgs) Handles BtnLoadLayout.Click
        itemLoadLayout_click(sender, e)
    End Sub

    Private Sub BtnDefLayout_Click(sender As Object, e As EventArgs) Handles BtnDefLayout.Click
        itemLoadDefLayout_click(sender, e)
    End Sub

    Private Sub rdoNone_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNone.CheckedChanged
        If rdoNone.Checked Then
            itemSplitNone_click(sender, e)
        End If
    End Sub

    Private Sub rdoHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHorizontal.CheckedChanged
        If rdoHorizontal.Checked Then
            itemSplitHorizontal_click(sender, e)
        End If
    End Sub

    Private Sub rdoVerticle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoVerticle.CheckedChanged
        If rdoVerticle.Checked Then
            itemSplitVerticle_click(sender, e)
        End If
    End Sub

    ''' <summary>
    ''' After a search Filter records according to selected rdo button
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetRdoButtons()
        If CurrentActType = ActiveType.ACTIVE Then
            chkActive.Checked = False
            chkActive.Checked = True
        ElseIf CurrentActType = ActiveType.INACTIVE Then
            chkInActive.Checked = False
            chkInActive.Checked = True
        ElseIf CurrentActType = ActiveType.BOTH Then
            chkBoth.Checked = False
            chkBoth.Checked = True
        End If
    End Sub

    Private Sub chkWithinSearch_CheckedChanged(sender As Object, e As EventArgs) Handles chkWithinSearch.CheckedChanged
        If chkWithinSearch.Checked Then
            dgvSelectList.EnableFiltering = True
        Else
            dgvSelectList.EnableFiltering = False
        End If
    End Sub

    Public Enum ActiveType
        BOTH
        ACTIVE
        INACTIVE
    End Enum

    Public Shared Function cls_EXE_STORED_PROCEDURE_DATATABLE(ByVal storedProcedureName As String) As DataTable
        Dim MainDatatable As DataTable
        Dim mySQLCommand As SqlClient.SqlCommand
        Dim cn As SqlConnection = New SqlClient.SqlConnection(strConn)
        Dim drSqlDataReader As SqlDataReader

        mySQLCommand = New SqlClient.SqlCommand
        'mySQLCommand.CommandTimeout = p_TimesOut

        MainDatatable = New DataTable

        mySQLCommand.Connection = cn
        mySQLCommand.CommandText = storedProcedureName
        mySQLCommand.CommandType = CommandType.StoredProcedure

        cn.Open()

        drSqlDataReader = mySQLCommand.ExecuteReader(CommandBehavior.CloseConnection)
        MainDatatable.Load(drSqlDataReader)

        cn.Close()
        cn.Dispose()

        drSqlDataReader.Close()
        drSqlDataReader = Nothing

        Return MainDatatable

    End Function

    Public Shared Function cls_EXE_STORED_PROCEDURE_DATATABLE_PRAM(ByRef argArray As ArrayList, ByVal storedProcedureName As String) As DataTable
        Dim MainDatatable As DataTable
        Dim mySQLCommand As SqlClient.SqlCommand
        Dim mySQLParameter As SqlClient.SqlParameter
        Dim cn As SqlConnection = New SqlClient.SqlConnection(strConn)

        Dim myEnumerator As System.Collections.IEnumerator = _
                argArray.GetEnumerator

        Dim drSqlDataReader As SqlDataReader


        mySQLCommand = New SqlClient.SqlCommand
        'mySQLCommand.CommandTimeout = p_TimesOut

        While myEnumerator.MoveNext()
            mySQLParameter = New SqlClient.SqlParameter
            mySQLParameter.ParameterName = myEnumerator.Current.ToString
            myEnumerator.MoveNext()
            mySQLParameter.Value = myEnumerator.Current
            myEnumerator.MoveNext()
            mySQLParameter.Direction = ParameterDirection.Input
            mySQLParameter.DbType = CType(myEnumerator.Current, System.Data.DbType)
            mySQLCommand.Parameters.Add(mySQLParameter)
        End While

        MainDatatable = New DataTable

        mySQLCommand.Connection = cn
        mySQLCommand.CommandText = storedProcedureName
        mySQLCommand.CommandType = CommandType.StoredProcedure

        cn.Open()

        drSqlDataReader = mySQLCommand.ExecuteReader(CommandBehavior.CloseConnection)
        MainDatatable.Load(drSqlDataReader)

        cn.Close()
        cn.Dispose()

        drSqlDataReader.Close()
        drSqlDataReader = Nothing

        Return MainDatatable
    End Function

End Class

''' <summary>
''' This Behavior is used to get rid sorting happens mouse left click on Column headers
''' </summary>
''' <remarks></remarks>
Public Class CustomGridHeaderRowBehavior
    Inherits GridHeaderRowBehavior
    Public Overrides Function OnMouseUp(e As MouseEventArgs) As Boolean
        If e.Button = MouseButtons.Left Then
            Dim result As Boolean = MyBase.OnMouseUp(e)

            Me.GridControl.SortDescriptors.Clear()
            Return result
        End If

        Return MyBase.OnMouseUp(e)
    End Function
End Class
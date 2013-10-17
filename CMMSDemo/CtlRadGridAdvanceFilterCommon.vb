Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls


Partial Public Class AdvanceFilterControl
    Inherits UserControl
#Region "Fields"

    Private gridView_Renamed As RadGridView
    Private advancedFilterDescriptor As New FilterDescriptor(String.Empty, FilterOperator.None, Nothing)

#End Region

#Region "Constructors"

    Public Sub New()
        InitializeComponent()
        AddHandler radDdlColumns.SelectedIndexChanged, AddressOf radDdlColumns_SelectedIndexChanged

    End Sub

    Public Sub New(ByVal template As RadGridView)
        Me.New()
        Me.gridView_Renamed = template
    End Sub

#End Region

#Region "Properties"
    ''' <summary>
    ''' When using Controller in Winforms, please assign form RadGridView object to this property. All the filterings are carried out by through this object
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GridView() As RadGridView
        Get
            Return Me.gridView_Renamed
        End Get
        Set(ByVal value As RadGridView)
            If Me.gridView_Renamed IsNot value Then
                If Me.gridView_Renamed IsNot Nothing Then
                    RemoveHandler gridView_Renamed.CustomFiltering, AddressOf GridView_CustomFiltering
                End If

                Me.gridView_Renamed = value

                If Me.gridView_Renamed IsNot Nothing Then
                    AddHandler gridView_Renamed.CustomFiltering, AddressOf GridView_CustomFiltering
                    Me.UpdateTheme(Me.Controls)
                End If

                Me.InitializeAdvanceView()
            End If
        End Set
    End Property

    ''' <summary>
    ''' For specific column search please assign ColumnName of RadGridView to this property, you can assign this property at radgridview CellClick event
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SelectedColName() As String
        Get
            Return lblColName.Text
        End Get
        Set(value As String)
            lblColName.Text = value
        End Set
    End Property

    Private Sub UpdateTheme(ByVal controls As ControlCollection)
        For Each currentControl As Control In controls
            Dim current As RadControl = TryCast(currentControl, RadControl)
            If current IsNot Nothing Then
                current.ThemeName = Me.gridView_Renamed.ThemeName
                Dim pageView As Telerik.WinControls.UI.RadPageView = TryCast(current, Telerik.WinControls.UI.RadPageView)
                If pageView IsNot Nothing Then
                    For Each page As RadPageViewPage In pageView.Pages
                        Me.UpdateTheme(page.Controls)
                    Next page
                End If
            End If
        Next currentControl
    End Sub

#End Region

#Region "Methods"

    Private Sub InitializeAdvanceView()
        Me.radDdlColumns.DataSource = Me.gridView_Renamed.Columns
        Me.radDdlColumns.ValueMember = "Name"
        Me.radDdlColumns.DisplayMember = "Name"
    End Sub

#End Region

#Region "Event Handlers"

    Private Sub radDdlColumns_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs)
        Me.radDropDownButtonOperator.Items.Clear()
        Me.rtbValue1.Text = String.Empty
        Me.rtbValue1.Enabled = False

        If Me.radDdlColumns.SelectedItem IsNot Nothing Then
            Dim dataColumn As GridViewDataColumn = TryCast(Me.radDdlColumns.SelectedItem.DataBoundItem, GridViewDataColumn)

            Me.radDropDownButtonOperator.Enabled = True
            Me.radDropDownButtonOperator.Text = "No Filter"

            Me.advancedFilterDescriptor.Operator = FilterOperator.None
            Me.advancedFilterDescriptor.PropertyName = dataColumn.Name

            Dim listContext As List(Of FilterOperationContext) = FilterOperationContext.GetFilterOperations(dataColumn.DataType)
            For Each context As FilterOperationContext In listContext
                Dim menuItem As New RadMenuItem(context.Name, context.Operator)
                AddHandler menuItem.Click, AddressOf menuItem_Click
                Me.radDropDownButtonOperator.Items.Add(menuItem)
            Next context
        Else
            Me.radDropDownButtonOperator.Enabled = False
            Me.radDropDownButtonOperator.Text = String.Empty
        End If
    End Sub

    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim menuItem As RadMenuItem = TryCast(sender, RadMenuItem)
        Me.radDropDownButtonOperator.Text = menuItem.Text

        Dim filterOperator As FilterOperator = CType(menuItem.Tag, FilterOperator)
        Me.advancedFilterDescriptor.Operator = filterOperator

        Me.rtbValue1.Enabled = filterOperator <> filterOperator.None AndAlso filterOperator <> filterOperator.IsNull AndAlso filterOperator <> filterOperator.IsNotNull
    End Sub

    Private Sub rtbValue1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rtbValue1.TextChanged
        If Me.radDdlColumns.SelectedItem IsNot Nothing Then
            Dim value As Object = Nothing

            If (Not String.IsNullOrEmpty(Me.rtbValue1.Text)) Then
                Dim dataColumn As GridViewDataColumn = TryCast(Me.radDdlColumns.SelectedItem.DataBoundItem, GridViewDataColumn)
                value = RadDataConverter.Instance.Parse(dataColumn, rtbValue1.Text)
            End If

            Me.advancedFilterDescriptor.Value = value
        End If
    End Sub

    Private Sub radBtnAdvanceApply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles radBtnAdvanceApply.Click
        Dim tableElement As GridTableElement = Me.GridView.TableElement
        Dim masterTemplate As MasterGridViewTemplate = Me.GridView.MasterTemplate
        tableElement.BeginUpdate()
        Me.GridView.EnableCustomFiltering = False
        masterTemplate.DataView.Refresh()
        tableElement.EndUpdate(False)

        For Each row As GridViewRowInfo In Me.GridView.Rows
            For Each cell As GridViewCellInfo In row.Cells
                cell.Style.Reset()
            Next
        Next

        Me.GridView.FilterDescriptors.BeginUpdate()
        Me.GridView.FilterDescriptors.Clear()
        Dim descriptor As FilterDescriptor = TryCast(Me.advancedFilterDescriptor.Clone(), FilterDescriptor)
        Me.GridView.FilterDescriptors.Add(descriptor)
        Me.GridView.FilterDescriptors.EndUpdate()
    End Sub

    Private Sub radTextBoxSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radTextBoxSearch.TextChanged
        Dim tableElement As GridTableElement = Me.gridView_Renamed.TableElement
        Dim masterTemplate As MasterGridViewTemplate = Me.gridView_Renamed.MasterTemplate

        tableElement.BeginUpdate()
        Me.gridView_Renamed.EnableCustomFiltering = True
        masterTemplate.DataView.Refresh()
        tableElement.EndUpdate(False)

        Dim viewChangedEventInfo As New GridViewEventInfo(KnownEvents.ViewChanged, GridEventType.UI, GridEventDispatchMode.Send)
        Dim args As New DataViewChangedEventArgs(ViewChangedAction.FilteringChanged)
        Dim viewChangedEvent As New GridViewEvent(masterTemplate, masterTemplate.DataView, New Object() {args}, viewChangedEventInfo)
        Me.gridView_Renamed.MasterTemplate.SynchronizationService.DispatchEvent(viewChangedEvent)

        Me.gridView_Renamed.TableElement.Update(GridUINotifyAction.StateChanged)
    End Sub

    Private Sub GridView_CustomFiltering(ByVal sender As Object, ByVal e As GridViewCustomFilteringEventArgs)
        Dim searchPattern As String = Me.radTextBoxSearch.Text

        Dim isEmptyPattern As Boolean = String.IsNullOrEmpty(searchPattern)
        e.Visible = isEmptyPattern


        For Each cell As GridViewCellInfo In e.Row.Cells
            cell.Style.Reset()
            'Skip if cell does not belong to user selected column when All columns checkbox is false
            If (Not chkAllCols.Checked) And (Not cell.ColumnInfo.HeaderText = SelectedColName) Then
                Continue For
            End If

            Dim value As String = String.Empty
            Dim cellValue As Object = cell.Value
            Dim decValue As Decimal

            If cellValue IsNot Nothing AndAlso (Not Convert.IsDBNull(cellValue)) Then
                value = Convert.ToString(cellValue)
            End If

            Dim contains As Boolean = False


            If (Not isEmptyPattern) Then
                'Do equal seach for decimal type columns
                If cellValue.GetType() Is Type.GetType("System.Decimal") OrElse cellValue.GetType() Is Type.GetType("System.Int32") OrElse cellValue.GetType() Is Type.GetType("System.Float") Then
                    If Decimal.TryParse(Convert.ToString(cellValue), decValue) Then
                        Dim searchDec As Decimal = 0
                        If Decimal.TryParse(Convert.ToString(searchPattern), searchDec) Then
                            If searchDec = decValue Then
                                contains = True
                            Else
                                contains = False
                            End If
                        Else
                            contains = False
                        End If


                    End If
                    'Convert search pattern 1/0 to True/False and do string contains 
                ElseIf cellValue.GetType() Is Type.GetType("System.Boolean") Then
                    If searchPattern = "1" Then
                        searchPattern = "True"
                    ElseIf searchPattern = "0" Then
                        searchPattern = "False"
                    End If
                    contains = value.ToUpper.Contains(searchPattern.ToUpper)

                    'Do contains for strings
                ElseIf cellValue.GetType() Is Type.GetType("System.String") Then

                    'Check case sensivity 
                    If Not chkCaseSensitive.Checked Then
                        contains = value.ToUpper.Contains(searchPattern.ToUpper)
                    Else
                        contains = value.Contains(searchPattern)
                    End If
                End If

                e.Visible = e.Visible Or contains

                If contains Then
                    cell.Style.CustomizeFill = True
                    cell.Style.BackColor = Color.FromArgb(201, 252, 254)
                Else
                    cell.Style.Reset()
                End If

            End If

        Next cell
    End Sub



#End Region
End Class


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls


Partial Public Class CtlRadGridAdvanceFilterControl
    Inherits UserControl
#Region "Fields"

    Private gridView_Renamed As RadGridView
    Private advancedFilterDescriptor As New FilterDescriptor(String.Empty, FilterOperator.None, Nothing)
    Private advanceOnlyNumbers As Boolean
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

    Public AdvanceColName As String
    Public AdvanceSearchCriteria As String
    Public AdvanceTextBoxValue As String
    Public AdvanceTab As Boolean

    Public TextBoxValue As String

    Public formObj As frmSelectListNG2


    Public Property GridView() As RadGridView
        Get
            Return Me.gridView_Renamed
        End Get
        Set(ByVal value As RadGridView)

 
            If value IsNot Nothing AndAlso value.Columns.Count > 0 Then
                Dim dt As New DataTable
                dt.Columns.Add("HeaderText")
                dt.Columns.Add("Name")
                cboColumns.ValueMember = "Name"
                cboColumns.DisplayMember = "HeaderText"
                For Each col As GridViewColumn In value.Columns
                    dt.Rows.Add(col.HeaderText, col.Name)
                Next
                cboColumns.DataSource = dt
                cboColumns.SelectedIndex = 0
            End If

            If Me.gridView_Renamed IsNot value Then
                If Me.gridView_Renamed IsNot Nothing Then
                    RemoveHandler gridView_Renamed.CustomFiltering, AddressOf GridView_CustomFiltering
                End If

                Me.gridView_Renamed = value
                Me.LoadOperatorCombo()

                If Me.gridView_Renamed IsNot Nothing Then
                    AddHandler gridView_Renamed.CustomFiltering, AddressOf GridView_CustomFiltering
                    Me.UpdateTheme(Me.Controls)
                End If
            End If
            Me.InitializeAdvanceView()

        End Set
    End Property

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
        If GridView IsNot Nothing Then
            Me.radDdlColumns.DataSource = Nothing
            Me.radDdlColumns.DataSource = Me.gridView_Renamed.Columns
            Me.radDdlColumns.ValueMember = "Name"
            Me.radDdlColumns.DisplayMember = "Name"
        End If
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

    Private Sub radBtnAdvanceApply_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ApplySearch()
    End Sub

    Private Sub ApplySearch()
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
        'InvokeCustomFilter()  'Commented since Textbox text changed event removed
        TextBoxValue = radTextBoxSearch.Text.Trim
    End Sub

    Private Sub InvokeCustomFilter()
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
        'CustomFiltering(sender, e) 'Commented since Textbox text changed event removed
    End Sub

    Private Sub CustomFiltering(ByVal sender As Object, ByVal e As GridViewCustomFilteringEventArgs)
        Dim searchPattern As String = Me.radTextBoxSearch.Text


        Dim isEmptyPattern As Boolean = String.IsNullOrEmpty(searchPattern)
        e.Visible = isEmptyPattern


        For Each cell As GridViewCellInfo In e.Row.Cells

            If (Not chkAllCols.Checked) And (Not cell.ColumnInfo.Name = SelectedColName) Then
                Continue For
            End If

            Dim value As String = String.Empty
            Dim cellValue As Object = cell.Value

            If cellValue IsNot Nothing AndAlso (Not Convert.IsDBNull(cellValue)) Then
                value = Convert.ToString(cellValue)
            End If

            Dim contains As Boolean = False

            If (Not isEmptyPattern) Then

                If Not chkCaseSensitive.Checked Then
                    contains = value.ToUpper.Contains(searchPattern.ToUpper)
                Else
                    contains = value.Contains(searchPattern)
                End If

                e.Visible = e.Visible Or contains
            End If

            If contains Then
                cell.Style.CustomizeFill = True
                cell.Style.BackColor = Color.FromArgb(201, 252, 254)
            Else
                cell.Style.Reset()
            End If
        Next cell
    End Sub

#End Region

    Private Sub LoadOperatorCombo()
        cboOperator.Items.Clear()
        txtAdvanceSearch.Enabled = True
        advanceOnlyNumbers = False
        If AdvanceColName IsNot Nothing AndAlso GridView IsNot Nothing AndAlso (Not AdvanceColName <> String.Empty Or
            GridView.Columns(AdvanceColName).DataType Is System.Type.GetType("System.Int32") Or
            GridView.Columns(AdvanceColName).DataType Is System.Type.GetType("System.Decimal") Or
            GridView.Columns(AdvanceColName).DataType Is System.Type.GetType("System.DateTime") Or
            GridView.Columns(AdvanceColName).DataType Is System.Type.GetType("System.TimeSpan")) Then

            cboOperator.Items.Add("Equals")
            cboOperator.Items.Add("Not equal to")
            cboOperator.Items.Add("Is null")
            cboOperator.Items.Add("Is not null")
            cboOperator.Items.Add("Greater than")
            cboOperator.Items.Add("Less than")
            cboOperator.Items.Add("Greater than or equal to")
            cboOperator.Items.Add("Less than or equal to")
            advanceOnlyNumbers = True
        ElseIf AdvanceColName IsNot Nothing AndAlso GridView IsNot Nothing AndAlso (Not AdvanceColName <> String.Empty Or
       GridView.Columns(AdvanceColName).DataType Is System.Type.GetType("System.Boolean")) Then

            cboOperator.Items.Add("Is True")
            cboOperator.Items.Add("Is False")
            txtAdvanceSearch.Enabled = False

        Else
            cboOperator.Items.Add("Contains")
            cboOperator.Items.Add("Does not contain")
            cboOperator.Items.Add("Starts with")
            cboOperator.Items.Add("Ends with")
            cboOperator.Items.Add("Equals")
            cboOperator.Items.Add("Not equal to")
            cboOperator.Items.Add("Is null")
            cboOperator.Items.Add("Is not null")
            cboOperator.Items.Add("Is empty")
            cboOperator.Items.Add("Is not empty")

        End If
        cboOperator.SelectedIndex = 0
    End Sub

    Private Sub chkAllCols_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkAllCols.ToggleStateChanged
        If chkAllCols.Checked Then
            lblColName.Visible = False
        Else
            lblColName.Visible = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdoBoth_CheckedChanged(sender As Object, e As EventArgs)
        radSearchPage.Focus()
    End Sub

    Private Sub rdoActive_CheckedChanged(sender As Object, e As EventArgs)
        GridView.Rows(0).Cells("ACTIVE").IsSelected = True
        radTextBoxSearch.Text = "T"
        radSearchPage.Focus()
    End Sub

    Private Sub rdoInactive_CheckedChanged(sender As Object, e As EventArgs)
        GridView.Rows(0).Cells("ACTIVE").IsSelected = True
        radTextBoxSearch.Text = "F"
        radSearchPage.Focus()
    End Sub

    Private Sub cmbOperator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOperator.SelectedIndexChanged
        AdvanceSearchCriteria = cboOperator.SelectedItem.ToString.Trim
    End Sub


    Private Sub cboColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColumns.SelectedIndexChanged
        AdvanceColName = cboColumns.SelectedValue.ToString.Trim
        LoadOperatorCombo()
    End Sub

    Private Sub txtAdvanceSearch_TextChanged(sender As Object, e As EventArgs) Handles txtAdvanceSearch.TextChanged
        If advanceOnlyNumbers Then
            Dim num As Decimal = 0
            If Decimal.TryParse(txtAdvanceSearch.Text.Trim, num) Then
                AdvanceTextBoxValue = num.ToString
            Else
                MsgBox("Please enter valide number", MsgBoxStyle.Exclamation, "Validation Error")
                Exit Sub
            End If
        Else
            AdvanceTextBoxValue = txtAdvanceSearch.Text.Trim
        End If
    End Sub

    Private Sub RadPageView1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RadPageView1.SelectedPageChanged
        If RadPageView1.SelectedPage Is radAdvancedPage Then
            AdvanceTab = True
        Else
            AdvanceTab = False
        End If
    End Sub


    Private Sub txtAdvanceSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdvanceSearch.KeyPress
        If advanceOnlyNumbers AndAlso (Not IsNumeric(e.KeyChar) And e.KeyChar.ToString <> ChrW(Keys.Back) And e.KeyChar.ToString <> ChrW(Keys.Enter) And e.KeyChar <> "."c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub radTextBoxSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles radTextBoxSearch.KeyDown
        'Call back search form when User press enter 
        If formObj IsNot Nothing AndAlso e.KeyCode = Keys.Enter Then
            formObj.btnGO_Click(sender, e)
        End If
    End Sub

    Private Sub txtAdvanceSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAdvanceSearch.KeyDown
        'Call back search form when User press enter 
        If formObj IsNot Nothing AndAlso e.KeyCode = Keys.Enter Then
            formObj.btnGO_Click(sender, e)
        End If
    End Sub
End Class


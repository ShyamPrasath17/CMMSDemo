Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class frmTaskPool
    Public dttemptask As DataTable
    Dim frmloaded As Boolean = False
    Dim PoolType_ As String = ""
    Private Enum AppointmentFields
        Row
        Summary
        Location
        Description
        Start
        [End]
        Background
        Status
    End Enum
    Sub New(PoolType As String)
        InitializeComponent()
        PoolType_ = PoolType
    End Sub
    Private Sub frmIndependentTaskPool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmloaded = False
        createtable()
        dgvIndepSchedTaskList.AllowAddNewRow = False
        dgvIndepSchedTaskList.AllowEditRow = False
        dgvIndepSchedTaskList.AllowDeleteRow = False
        dgvIndepSchedTaskList.DataSource = dttemptask.DefaultView

        If dgvIndepSchedTaskList.Columns.Contains("btncol") Then
            dgvIndepSchedTaskList.Columns.Remove("btncol")
        End If
        Dim btncol As GridViewCommandColumn = New GridViewCommandColumn()
        btncol.Name = "btncol"
        btncol.HeaderText = "Attach"
        btncol.DefaultText = "Attach to work order"
        btncol.UseDefaultText = True
        btncol.AutoEllipsis = True
        dgvIndepSchedTaskList.Columns.Insert(2, btncol)
        dgvIndepSchedTaskList.BestFitColumns()

        If PoolType_ = "Independent" Then
            dttemptask.DefaultView.RowFilter = "PoolType = 'Independent'"
        ElseIf PoolType_ = "ScheduledMaintanance" Then
            dttemptask.DefaultView.RowFilter = "PoolType = 'ScheduledMaintanance'"
        Else
            dttemptask.DefaultView.RowFilter = ""
        End If
        'dgvIndepSchedTaskList.dra
        frmloaded = True
    End Sub

    Private Sub createtable()
        dttemptask = New DataTable()
        dttemptask.Columns.Add("TaskNo", GetType(String))
        dttemptask.Columns.Add("PoolType", GetType(String))
        dttemptask.Columns.Add("status", GetType(String))
        For i As Integer = 30 To 45
            If i < 35 Then
                dttemptask.Rows.Add("Task " & i.ToString(), "ScheduledMaintanance", "Pending")
            ElseIf i >= 35 And i < 41 Then
                dttemptask.Rows.Add("Task " & i.ToString(), "Independent", "Pending")
            Else
                dttemptask.Rows.Add("Task " & i.ToString(), "ScheduledMaintanance", "Pending")
            End If
        Next

    End Sub

    Private Sub dgvIndepSchedTaskList_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles dgvIndepSchedTaskList.CurrentRowChanged

    End Sub

    Private Sub dgvIndepSchedTaskList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles dgvIndepSchedTaskList.CellDoubleClick

    End Sub

    Private Sub dgvIndepSchedTaskList_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles dgvIndepSchedTaskList.RowFormatting
        e.RowElement.AllowDrag = True
    End Sub

#Region "private classes"
    Private Class DragObject
        Private status_Renamed As AppointmentFields
        Private values_Renamed As Dictionary(Of AppointmentFields, Object) = New Dictionary(Of AppointmentFields, Object)()

        Public Property Status() As AppointmentFields
            Get
                Return Me.status_Renamed
            End Get
            Set(ByVal value As AppointmentFields)
                Me.status_Renamed = value
            End Set
        End Property

        Public ReadOnly Property Values() As Dictionary(Of AppointmentFields, Object)
            Get
                Return Me.values_Renamed
            End Get
        End Property
    End Class

    Private Class MyGridBehavior
        Inherits BaseGridBehavior
        Private mouseDownPoint As Point = Point.Empty

        Public Overrides Function OnMouseDown(ByVal e As MouseEventArgs) As Boolean
            If e.Button = MouseButtons.Left Then
                mouseDownPoint = e.Location
            End If

            Return MyBase.OnMouseDown(e)
        End Function

        Public Overrides Function OnMouseMove(ByVal e As MouseEventArgs) As Boolean
            If e.Button <> MouseButtons.Left Then
                Me.mouseDownPoint = Point.Empty
                Return MyBase.OnMouseMove(e)
            End If

            If (Not Me.GridViewElement.IsInEditMode) AndAlso Me.ShouldBeginDrag(Me.mouseDownPoint, e.Location) Then
                Dim element As RadElement = Me.GridControl.ElementTree.GetElementAtPoint(e.Location)

                Dim cell As GridCellElement = TryCast(element, GridCellElement)

                If cell IsNot Nothing AndAlso cell Is Me.GridViewElement.CurrentCell Then
                    Dim dragObject As New DragObject()

                    dragObject.Values.Add(AppointmentFields.Summary, cell.RowInfo.Cells("Summary").Value)
                    dragObject.Values.Add(AppointmentFields.Start, cell.RowInfo.Cells("Start").Value)
                    dragObject.Values.Add(AppointmentFields.End, cell.RowInfo.Cells("End").Value)
                    dragObject.Values.Add(AppointmentFields.Description, "")
                    'dragObject.Values.Add(AppointmentFields.Background, cell.RowInfo.Cells("BackgroundID").Value)
                    'dragObject.Values.Add(AppointmentFields.Status, cell.RowInfo.Cells("StatusID").Value)
                    'dragObject.Values.Add(AppointmentFields.Location, cell.RowInfo.Cells("Location").Value)

                    dragObject.Status = AppointmentFields.Row

                    Me.GridViewElement.ElementTree.Control.DoDragDrop(dragObject, DragDropEffects.Copy)
                    Return True
                End If
            End If

            Return MyBase.OnMouseMove(e)
        End Function


        Private Function ShouldBeginDrag(ByVal current As Point, ByVal capture As Point) As Boolean
            Dim dragSize As Size = SystemInformation.DragSize
            Dim dragRect As New Rectangle(capture.X - dragSize.Width / 2, capture.Y - dragSize.Height / 2, dragSize.Width, dragSize.Height)
            Return Not dragRect.Contains(current)
        End Function
    End Class
#End Region

End Class